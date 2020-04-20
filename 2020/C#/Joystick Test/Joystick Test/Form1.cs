using System;
using System.Data;
using System.Linq;
using System.Text;
using OpenJigWare;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Collections.Generic;


namespace Joystick_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // To trace the two axis per thumbstick
        float x1 = 115;
        float y1 = 115;
        float x2 = 115;
        float y2 = 115;

        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(txtMessage);
            panel1.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton3);

            timer1.Enabled = true;
            radioButton1.Location = new Point((int)x1, (int)y1);
            radioButton2.Location = new Point((int)x2, (int)y2);
        }

        private float[] Angulo = new float[20];

        private Ojw.CJoystick HMController = new Ojw.CJoystick(Ojw.CJoystick._ID_0); // Joystick declaration
        private Ojw.CTimer HMC_Timer = new Ojw.CTimer(); // Timer to check the joystick connection periodically

        private void Joystick_Check_Connection()
        {
            #region Joystick Check

            Color Connected_Color = Color.LightGreen; // Color when connected
            Color Disconnected_Color = Color.Yellow; // Color when disconnected
            if (HMController.IsValid == false)
            {
                #region Joystick is not connected
                if (lbJoystick.ForeColor != Disconnected_Color)
                {
                    lbJoystick.Text = "Joystick (No Connected)";
                    lbJoystick.ForeColor = Disconnected_Color;
                }
                #endregion Joystick is not connected

                #region Try to reconnect every 3 seconds
                if (HMC_Timer.Get() > 3000) // Check if Joystic is disconnected (every 3 seconds)
                {
                    Ojw.CMessage.Write("Joystick Check again");
                    HMController = new Ojw.CJoystick(Ojw.CJoystick._ID_0);

                    if (HMController.IsValid == false)
                    {
                        Ojw.CMessage.Write("We can't find a joystick device in your PC. Check your Joystick");
                        HMC_Timer.Set(); // Reset the timer counter again.
                    }
                    else Ojw.CMessage.Write("Joystick is Connected");
                }
                #endregion Try to reconnect every 3 seconds
            }
            else
            {
                #region Connected
                if (lbJoystick.ForeColor != Connected_Color)
                {
                    lbJoystick.Text = "Joystick (Connected)";
                    lbJoystick.ForeColor = Connected_Color;
                }
                #endregion Connected
            }
            #endregion Joystick Check
        }

        string DpadSpanish = "";
        string DpadEnglish = "";

        private void Joystick_Check_Data()
        {
            if (HMController.IsDown(Ojw.CJoystick.PadKey.POVLeft) == true)
            {
                DpadSpanish = "Izquierda ";
                DpadEnglish = "Left ";
            }
            else if (HMController.IsDown(Ojw.CJoystick.PadKey.POVRight) == true)
            {
                DpadSpanish = "Derecha ";
                DpadEnglish = "Right ";
            }
            else
            {
                DpadSpanish = "";
                DpadEnglish = "";
            }
            if (HMController.IsDown(Ojw.CJoystick.PadKey.POVUp) == true)
            {
                DpadSpanish += "Arriba";
                DpadEnglish += "Up";
            }
            else if (HMController.IsDown(Ojw.CJoystick.PadKey.POVDown) == true)
            {
                DpadSpanish += "Abajo";
                DpadEnglish += "Down";
            }
            if (DpadSpanish == "")
            {
                DpadSpanish = "Sin presionar";
                DpadEnglish = "Not pressed";
            }

            if (HMController.IsDown(Ojw.CJoystick.PadKey.Button4) == true)
            {
                lblY.ForeColor = Color.Red;
            }
            else
            {
                lblY.ForeColor = Color.Black;
            }
            if (HMController.IsDown(Ojw.CJoystick.PadKey.Button3) == true)
            {
                lblX.ForeColor = Color.Red;
            }
            else
            {
                lblX.ForeColor = Color.Black;
            }
            if (HMController.IsDown(Ojw.CJoystick.PadKey.Button2) == true)
            {
                lblB.ForeColor = Color.Red;
            }
            else
            {
                lblB.ForeColor = Color.Black;
            }
            if (HMController.IsDown(Ojw.CJoystick.PadKey.Button1) == true)
            {
                lblA.ForeColor = Color.Red;
            }
            else
            {
                lblA.ForeColor = Color.Black;
            }

            if (HMController.IsDown(Ojw.CJoystick.PadKey.Button5) == true)
            {
                lblLeft.ForeColor = Color.Red;
            }
            else
            {
                lblLeft.ForeColor = Color.Black;
            }
            if (HMController.IsDown(Ojw.CJoystick.PadKey.Button6) == true)
            {
                lblRight.ForeColor = Color.Red;
            }
            else
            {
                lblRight.ForeColor = Color.Black;
            }
            //Formula para mapear 0 -> 1 a -1 -> +1
            //  Y= 2x - 1
            double Vx1 = (2 * HMController.dX0 - (1)),
                   Vx2 = (2 * HMController.dX1 - (1)),
                   Vy1 = (2 * HMController.dY0 - (1)),
                   Vy2 = (2 * HMController.dY1 - (1));
            label1.Text = DpadSpanish + "\r\n" + DpadEnglish;
            radioButton1.Location = new Point((int)(x1 * 1.8 * HMController.dX0), (int)(y1 * 1.8 * HMController.dY0));
            radioButton2.Location = new Point((int)(x2 * 1.8 * HMController.dX1), (int)(y2 * 1.8 * HMController.dY1));
            textBox1.Text = Convert.ToString("X = " + Vx1 + "\r\nY = " + Vy1);
            textBox2.Text = Convert.ToString("X = " + Vx2 + "\r\nY = " + Vy2);
            radioButton3.Location = new Point((int)(168 - HMController.Slide * 168), 10);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Method to update joystick information (i. ex. the joystick's status)
            HMController.Update();
            // Method to check if the joystick is connected
            Joystick_Check_Connection();
            // Method to check Joystick's data entries
            Joystick_Check_Data();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}