using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timed_Math_Quiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1, addend2;
        int sub1,sub2;
        int mul1,mul2;
        int div1,div2;
        int timeLeft;
        public void StartTheQuiz()
        {
            
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            mul1 = randomizer.Next(51);
            mul2 = randomizer.Next(51);
            sub1 = randomizer.Next(51);
            sub2 = randomizer.Next(51);
            div1 = randomizer.Next(51);
            div2 = randomizer.Next(51);
            addLeft.Text = addend1.ToString();
            addright.Text = addend2.ToString();
            sumRess.Value = 0;
            minusLeft.Text = sub1.ToString();
            minusRight.Text = sub2.ToString();
            minusRes.Value = 0;
            mulLeft.Text = mul1.ToString();
            mulRight.Text = mul2.ToString();
            mulRes.Value = 0;
            divRight.Text = div2.ToString();
            divLeft.Text = div1.ToString();
            divRes.Value = 0;



            timeLeft = 60;
            timer.Text = "60 seconds";
            timer1.Start();
        }
        



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {

                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                start.Enabled = true;
            }
            else
            {
                if (timeLeft > 0)
                {

                    timeLeft = timeLeft - 1;
                    if (timeLeft == 5) timer.BackColor = Color.Red;
                    timer.Text = timeLeft + " seconds";
                }
                else
                {

                    timer1.Stop();
                    timer.BackColor = Color.White;
                    timer.Text = "Time's up!";
                    MessageBox.Show("You didn't finish in time.", "Sorry!");
                    sumRess.Value = addend1 + addend2;
                    divRes.Value = div1 / div2;
                    mulRes.Value = mul1 * mul2;
                    minusRes.Value = sub1 - sub2;
                    start.Enabled = true;
                }
            }
        }
        private bool CheckTheAnswer()
        {
            if (addend1 + addend2 != sumRess.Value) return false;
            if (mul1 * mul2 != mulRes.Value) return false;
            if (sub1 - sub2 != minusRes.Value) return false;
            if (div1 / div2 != divRes.Value) return false;
            return true;

        }

        private void sumRess_Enter(object sender, EventArgs e)
        {
            
        }
        private void Answer(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            start.Enabled = false;
        }
    }
}
