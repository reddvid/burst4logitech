using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Ini.Net;
using System.Windows.Forms;
using System.Diagnostics;
using LedCSharp;
using System.Security.Principal;
using System.IO;
using System.Drawing.Imaging;
using Essy.Tools.InputBox;

namespace BurstForms
{
    public partial class Form1 : Form
    {
        private KeyboardHook hook = new KeyboardHook();
        private static IntPtr procHandle = IntPtr.Zero;
        internal static Color m_startColour = Color.Green;
        internal static Color m_endColour = Color.Red;

        public static string spellText = "";
        internal static bool useKeysaver = true;
        internal static int keySaverTime = 30;
        internal static bool useLogitechColours = false;
        internal static int m_fadespeed = 7;
        internal static int m_gradientspeed = 7;
        internal static bool m_Wave = true;
        internal static int m_AnimationSpeed = 100;
        internal static double m_WaveSpeed = 2.0;
        internal static double m_distanceFalloff = 1.0;
        internal static double m_KeysaveNewRippleInterval = 1500;
        private static string currentProfile = "default";
        public static bool randomColours = true;
        public static bool StartMinimized;
        public static bool keysaveBreathe = false;

        public Form1()
        {
            InitializeComponent();

            if (StartMinimized)
            {
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
            }

            notifyIcon1.BalloonTipClosed += (sender, e) => { var thisIcon = (NotifyIcon)sender; thisIcon.Visible = false; thisIcon.Dispose(); };
            WindowsPrincipal myPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (myPrincipal.IsInRole(WindowsBuiltInRole.Administrator) == false)
            {
                //show messagebox - displaying a messange to the user that rights are missing
                //MessageBox .Show("You need to run the application using the 'run as administrator' option" , "administrator right required" , MessageBoxButtons .OK, MessageBoxIcon .Exclamation); 
            }

            //read settings
            currentProfile = Properties.Settings.Default.ProfileDefault;
            LoadSettings(currentProfile);

            LogitechGSDK.LogiLedInit();
            LogitechGSDK.LogiLedSaveCurrentLighting();

            if (!useLogitechColours) LogitechGSDK.LogiLedSetLighting(0, 0, 0);
        }

        private void LoadSettings(string p)
        {
            if (!File.Exists(Application.StartupPath + "\\Profiles\\" + p + ".prf"))
            {
                MessageBox.Show("Invalid profile file specified, reverting to defaults");
                return;
            }

            var pFile = new IniFile(Application.StartupPath + "\\Profiles\\" + p + ".prf");
            useLogitechColours = pFile.ReadBoolean("LED", "KeepLogitechColours");
            m_startColour = ColorTranslator.FromHtml(pFile.ReadString("LED", "StartColour"));
            m_endColour = ColorTranslator.FromHtml(pFile.ReadString("LED", "EndColour"));
            randomColours = pFile.ReadBoolean("LED", "RandomColours");
            m_AnimationSpeed = pFile.ReadInteger("Animation", "AnimationDelay");
            m_gradientspeed = pFile.ReadInteger("Animation", "GradientSpeed");
            m_fadespeed = pFile.ReadInteger("Animation", "FadeSpeed");
            m_distanceFalloff = pFile.ReadDouble("Animation", "EffectDistance");
            m_Wave = pFile.ReadBoolean("Animation", "Wave");
            try
            {
                m_KeysaveNewRippleInterval = pFile.ReadDouble("KeySave", "m_KeysaveNewRippleInterval");
            }
            catch { }
            m_WaveSpeed = pFile.ReadDouble("Animation", "WaveFalloff");
            useKeysaver = pFile.ReadBoolean("LED", "UseKeysaver");
            keySaverTime = pFile.ReadInteger("LED", "KeySaverTime");

            chkRandomColor.Checked = randomColours;
            chkUseKeySaver.Checked = useKeysaver;
            numWaitTime.Value = keySaverTime;
            pboxColor1.BackColor = m_startColour;
            pboxColor2.BackColor = m_endColour;
            numFadeSpd.Value = m_fadespeed;
            numGradSpd.Value = m_gradientspeed;
            numAnimDelay.Value = m_AnimationSpeed;
            numRippleInterval.Value = (decimal)m_KeysaveNewRippleInterval;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)//this code gets fired on every resize
            {                                                                                      //so we check if the form was minimized
                Hide();//hides the program on the taskbar
                notifyIcon1.Visible = true;//shows our tray icon
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();//shows the program on taskbar
            this.WindowState = FormWindowState.Normal;//undoes the minimized state of the form
            notifyIcon1.Visible = false;//hides tray icon again
        }

        private void chkUseKeySaver_CheckedChanged(object sender, EventArgs e)
        {
            useKeysaver = chkUseKeySaver.Checked;
            KeyboardHook.timerKeySaver.Enabled = useKeysaver;
            if (useKeysaver)
                KeyboardHook.timerKeySaver.Start();
            else
                KeyboardHook.timerKeySaver.Stop();
        }

        private void numWaitTime_ValueChanged(object sender, EventArgs e)
        {
            keySaverTime = (int)numWaitTime.Value;
            KeyboardHook.timerKeySaver.Enabled = useKeysaver;
            KeyboardHook.timerKeySaver.Interval = (int)numWaitTime.Value * 1000;
            KeyboardHook.timerKeySaver.Start();
        }

        private void chkRandomColor_CheckedChanged(object sender, EventArgs e)
        {
            randomColours = chkRandomColor.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyboardHook._hookID = hook.SetHook(hook._proc);

            LoadProfiles();
        }

        private void LoadProfiles()
        {
            lstProfiles.Items.Clear();
            foreach (string file in Directory.GetFiles(Application.StartupPath + "\\Profiles", "*.prf"))
            {
                string trunc = Path.GetFileName(file).Replace(".prf", "");
                lstProfiles.Items.Add(trunc);
            }
            lstProfiles.Visible = true;
        }

        private void numRippleInterval_ValueChanged(object sender, EventArgs e)
        {
            m_KeysaveNewRippleInterval = (double)numRippleInterval.Value;
        }

        private void chkUseLgsProfile_CheckedChanged(object sender, EventArgs e)
        {
            useLogitechColours = chkUseLgsProfile.Checked;
        }

        public static byte[] getLEDGridFromBitmap(Bitmap bitmap)
        {
            try
            {
                BitmapData bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
                int numbytes = bmpdata.Stride * bitmap.Height;
                byte[] bytedata = new byte[numbytes];
                IntPtr ptr = bmpdata.Scan0;

                Marshal.Copy(ptr, bytedata, 0, numbytes);

                bitmap.UnlockBits(bmpdata);
                return bytedata;
            }
            catch
            { return null; }
        }

        private void pboxColor1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.Color = m_startColour;
            DialogResult r = c.ShowDialog();
            if (r == DialogResult.OK)
            {
                pboxColor1.BackColor = c.Color;
                m_startColour = c.Color;
            }
        }

        private void pboxColor2_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.Color = m_endColour;
            DialogResult r = c.ShowDialog();
            if (r == DialogResult.OK)
            {
                pboxColor2.BackColor = c.Color;
                m_endColour = c.Color;
            }
        }

        private void lstProfiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstProfiles.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                LoadSettings(lstProfiles.Items[index].ToString());
                currentProfile = lstProfiles.Items[index].ToString();
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            string p = InputBox.ShowInputBox("Enter name of profile");

            if (p != null)
            {
                string filename = Application.StartupPath + "\\Profiles\\" + p + ".prf";
                if (File.Exists(filename))
                {
                    DialogResult check = MessageBox.Show("Overwrite existing profile file?", "Overwrite File?", MessageBoxButtons.YesNo);
                    if (check == DialogResult.No) return;
                }
                writeSettings(filename);
                LoadProfiles();
            }
        }

        private void writeSettings(string p)
        {
            var pFile = new IniFile(p);
            pFile.WriteBoolean("LED", "KeepLogitechColours", useLogitechColours);
            pFile.WriteString("LED", "StartColour", ColorTranslator.ToHtml(m_startColour));
            pFile.WriteString("LED", "EndColour", ColorTranslator.ToHtml(m_endColour));
            pFile.WriteBoolean("LED", "RandomColours", randomColours);
            pFile.WriteBoolean("LED", "UseKeysaver", useKeysaver);
            pFile.WriteInteger("LED", "KeysaverTime", keySaverTime);
            pFile.WriteBoolean("LED", "KeySaveBreathe", keysaveBreathe);
            pFile.WriteInteger("Animation", "AnimationDelay", m_AnimationSpeed);
            pFile.WriteInteger("Animation", "GradientSpeed", m_gradientspeed);
            pFile.WriteInteger("Animation", "FadeSpeed", m_fadespeed);
            pFile.WriteDouble("Animation", "EffectDistance", m_distanceFalloff);
            pFile.WriteBoolean("Animation", "Wave", m_Wave);
            pFile.WriteDouble("Animation", "WaveFalloff", m_WaveSpeed);
            pFile.WriteDouble("KeySave", "NewRippleInterval", m_KeysaveNewRippleInterval);
        }
    }
}
