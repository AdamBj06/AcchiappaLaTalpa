using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace AcchiappaLaTalpa
{
    public partial class Form1 : Form
    {
        public Stopwatch watch = new Stopwatch();
        public Random rand = new Random();
        public int n, n2, index1, index2, index3;
        public bool paused = false;
        public string sublabel10, talpaLocation;
        public Form1()
        {
            InitializeComponent();
        }

        #region button_talpe
        private void button1_Click(object sender, EventArgs e)
        {
            if(talpaLocation == "button1")
            {
                label1.Text = Convert.ToString( int.Parse(label1.Text) + 100);
                Hit_Animation(button1);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if(label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (talpaLocation == "button2")
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + 100);
                Hit_Animation(button2);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if (label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (talpaLocation == "button3")
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + 100);
                Hit_Animation(button3);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if (label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (talpaLocation == "button4")
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + 100);
                Hit_Animation(button4);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if (label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (talpaLocation == "button5")
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + 100);
                Hit_Animation(button5);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if (label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (talpaLocation == "button6")
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + 100);
                Hit_Animation(button6);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if (label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (talpaLocation == "button7")
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + 100);
                Hit_Animation(button7);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if (label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (talpaLocation == "button8")
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + 100);
                Hit_Animation(button8);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if (label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (talpaLocation == "button9")
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + 100);
                Hit_Animation(button9);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if (label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (talpaLocation == "button10")
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + 100);
                Hit_Animation(button10);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if (label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (talpaLocation == "button11")
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) + 100);
                Hit_Animation(button11);
            }
            else
            {
                label1.Text = Convert.ToString(int.Parse(label1.Text) - 250);
                if (label10.Text == "X" || label10.Text == "X  -  X")
                {
                    label10.Text += "  -  X";
                }
                else
                {
                    label10.Text += "X";
                }
            }
        }
        #endregion

        #region Difficulty
        private void button12_Click(object sender, EventArgs e) //easy
        {
            label1.Text = "0";
            label8.Text = "Facile";
            timer1.Interval = 1400;
            button17.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e) //medium
        {
            label1.Text = "0";
            label8.Text = "Medio";
            timer1.Interval = 1100;
            button17.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e) //hard
        {
            label1.Text = "0";
            label8.Text = "Difficile";
            timer1.Interval = 850;
            button17.Enabled = true;
        }
        #endregion

        #region Button_On_Off_Reset
        private void button17_Click(object sender, EventArgs e) //start/retry
        {
            watch.Start();
            timer1.Enabled = true;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button17.Visible = false;
            label8.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button18.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            button17.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e) //pause/resume
        {
            if (paused)
            {
                timer1.Enabled = true;
                watch.Start();
                button18.Text = "Pause";
                paused = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                watch.Stop();
                button18.Text = "Resume";
                paused = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e) //reset
        {
            label1.Text = "0";
            label10.Text = "";
            timer1.Enabled = false;
            watch.Stop();
            button18.Text = "Resume";
            paused = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e) //stop
        {
            timer1.Interval = 9999999;
            timer1.Enabled = false;
            watch.Stop();
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button17.Visible = true;
            label8.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button18.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label1.Text = "0";
            label8.Text = "Scegli la difficoltà";
            label10.Text = "";
            button17.Text = "Start";
            button18.Text = "Pause";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            paused = false;
        }
        #endregion

        #region MouseHover
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(149, 188, 56);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(132, 177, 54);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(132, 177, 54);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(132, 177, 54);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(169, 199, 59);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(149, 188, 56);
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(169, 199, 59);
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(149, 188, 56);
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(149, 188, 56);
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(169, 199, 59);
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(169, 199, 59);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Transparent;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Transparent;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Transparent;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Transparent;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.Transparent;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.Transparent;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.Transparent;
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e) {
            //Game Over
            if (label10.Text.Length >= 12)
            {
                sublabel10 = label10.Text.Substring(0, 13);
            }
            if (sublabel10 == "X  -  X  -  X")
            {
                timer1.Interval = 9999999;
                timer1.Enabled = false;
                watch.Stop();
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button17.Visible = true;
                label8.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button15.Visible = false;
                button16.Visible = false;
                button18.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label8.Text = "Game Over!";
                button17.Text = "Retry";
                label10.Text = "";
                sublabel10 = "";
            }
            //Score
            if (timer1.Interval == 1400) {
                if (int.Parse(label5.Text) < int.Parse(label1.Text)) {
                    label5.Text = label1.Text;
                }
            } else if (timer1.Interval == 1100) {
                if (int.Parse(label6.Text) < int.Parse(label1.Text)) {
                    label6.Text = label1.Text;
                }
            } else if (timer1.Interval == 850) {
                if (int.Parse(label7.Text) < int.Parse(label1.Text)) {
                    label7.Text = label1.Text;
                }
            }
            //
            talpaLocation = "";
            button1.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            button2.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            button3.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            button4.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            button5.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            button6.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            button7.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            button8.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            button9.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            button10.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            button11.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa0f;
            n = rand.Next(1, 12);
            n2= rand.Next(1, 4);
            if (n2 == 1|| n2 == 2){
                switch (n){
                    case 1:
                        talpaLocation = "button1";
                        Talpa_Animation(button1);
                        break;
                    case 2:
                        talpaLocation = "button2";
                        Talpa_Animation(button2);
                        break;
                    case 3:
                        talpaLocation = "button3";
                        Talpa_Animation(button3);
                        break;
                    case 4:
                        talpaLocation = "button4";
                        Talpa_Animation(button4);
                        break;
                    case 5:
                        talpaLocation = "button5";
                        Talpa_Animation(button5);
                        break;
                    case 6:
                        talpaLocation = "button6";
                        Talpa_Animation(button6);
                        break;
                    case 7:
                        talpaLocation = "button7";
                        Talpa_Animation(button7);
                        break;
                    case 8:
                        talpaLocation = "button8";
                        Talpa_Animation(button8);
                        break;
                    case 9:
                        talpaLocation = "button9";
                        Talpa_Animation(button9);
                        break;
                    case 10:
                        talpaLocation = "button10";
                        Talpa_Animation(button10);
                        break;
                    case 11:
                        talpaLocation = "button11";
                        Talpa_Animation(button11);
                        break;
                    default:
                        label1.Text = "Error1";
                        break;
                }
            } else if (n2==3){
                switch (n){
                    case 1:
                        Bomba_Animation(button1);
                        break;
                    case 2:
                        Bomba_Animation(button2);
                        break;
                    case 3:
                        Bomba_Animation(button3);
                        break;
                    case 4:
                        Bomba_Animation(button4);
                        break;
                    case 5:
                        Bomba_Animation(button5);
                        break;
                    case 6:
                        Bomba_Animation(button6);
                        break;
                    case 7:
                        Bomba_Animation(button7);
                        break;
                    case 8:
                        Bomba_Animation(button8);
                        break;
                    case 9:
                        Bomba_Animation(button9);
                        break;
                    case 10:
                        Bomba_Animation(button10);
                        break;
                    case 11:
                        Bomba_Animation(button11);
                        break;
                    default:
                        label1.Text = "Error2";
                        break;
                }
            }
        }

        #region Animations
        private async void Talpa_Animation(Button button)
        {
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa1f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa2f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa3f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpa4f;
        }
        private async void Bomba_Animation(Button button)
        {
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.bomba1f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.bomba2f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.bomba3f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.bomba4f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));//hard
            if (timer1.Interval == 1100 || timer1.Interval == 1400)
            {
                button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.bomba3f;
                await Task.Delay(TimeSpan.FromSeconds(0.2f));//medium
            }
            if (timer1.Interval == 1400)
            {
                button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.bomba4f;
                await Task.Delay(TimeSpan.FromSeconds(0.2f));
                button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.bomba3f;
                await Task.Delay(TimeSpan.FromSeconds(0.2f));//easy
            }
        }
        private async void Hit_Animation(Button button)
        {
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpahammerf;
            await Task.Delay(TimeSpan.FromSeconds(0.1f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpahit2f;
            await Task.Delay(TimeSpan.FromSeconds(0.1f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpahit1f;
            await Task.Delay(TimeSpan.FromSeconds(0.1f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpadizzy1f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button1.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpadizzy2f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpadizzy3f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpafaint1f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpafaint2f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
            button.BackgroundImage = AcchiappaLaTalpa.Properties.Resources.talpafaint3f;
            await Task.Delay(TimeSpan.FromSeconds(0.2f));
        }
        #endregion
    }
}
