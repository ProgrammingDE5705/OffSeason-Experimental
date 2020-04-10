using System;
using System.Data;
using System.Linq;
using System.Text;
using OpenJigWare;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Joystick_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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

            Color Connected_Color = Color.Green; // Color when connected
            Color Disconnected_Color = Color.Red; // Color when disconnected
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
                if (HMC_Timer.Get() > 30000) // Check if Joystic is disconnected (every 3 seconds)
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

            label1.Text = DpadSpanish + "\r\n" + DpadEnglish;
            radioButton1.Location = new Point((int)(x1 * 1.8 * HMController.dX0), (int)(y1 * 1.8 * HMController.dY0));
            radioButton2.Location = new Point((int)(x2 * 1.8 * HMController.dX1), (int)(y2 * 1.8 * HMController.dY1));
            textBox1.Text = Convert.ToString("X = " + HMController.dX0 + "\r\nY = " + HMController.dY0);
            textBox2.Text = Convert.ToString("X = " + HMController.dX1 + "\r\nY = " + HMController.dY1);
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
    }
}