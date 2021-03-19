﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertifCalculator
{
    public partial class TestScore : Form
    {
        public TestScore()
        {
            InitializeComponent();
            Reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            this.MaxScore.Value = 0;
            this.Score.Value = 0;
            Percent.Text = String.Format("{0:0.0}%", 0);
            Questions.Value = 0;
            QuestionScore.Value = 0;
            Alerte.Visible = false;
        }

        void Compute()
        {
            if (MaxScore.Value == 0)
            {
                return;
            }
            var percentage = 100 * Score.Value / MaxScore.Value;
            Percent.Text = String.Format("{0:0.0}%", percentage);

            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            Score.Enabled = true;

            if (QuestionScore.Value == Questions.Value)
            {
                Percent.BackColor = Color.GreenYellow;
                Alerte.Visible = false;
            }
            else
            {
                Percent.BackColor = Color.OrangeRed;
                Alerte.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.MaxScore.Value++;
            Questions.Value++;
            Compute();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.MaxScore.Value++;
            this.MaxScore.Value++;
            Questions.Value++;
            Compute();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.MaxScore.Value++;
            this.MaxScore.Value++;
            this.MaxScore.Value++;
            Questions.Value++;
            Compute();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            this.MaxScore.Value++;
            this.MaxScore.Value++;
            this.MaxScore.Value++;
            this.MaxScore.Value++;
            Questions.Value++;
            Compute();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Score.Value++;
            QuestionScore.Value++;
            Compute();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Score.Value++;
            this.Score.Value++;
            QuestionScore.Value++;
            Compute();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Score.Value++;
            this.Score.Value++;
            this.Score.Value++;
            QuestionScore.Value++;
            Compute();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Score.Value++;
            this.Score.Value++;
            this.Score.Value++;
            this.Score.Value++;
            QuestionScore.Value++;
            Compute();
        }

        private void Score_ValueChanged(object sender, EventArgs e)
        {
            Compute();
        }

        private void MaxScore_ValueChanged(object sender, EventArgs e)
        {
            Compute();
        }

        private void Questions_ValueChanged(object sender, EventArgs e)
        {
            AdjustColor();
        }

        private void QuestionScore_ValueChanged(object sender, EventArgs e)
        {
            AdjustColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Questions.Value++;
            QuestionScore.Value++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuestionScore.Value++;
        }

        void AdjustColor()
        {
            if (QuestionScore.Value == Questions.Value)
            {
                Percent.BackColor = Color.GreenYellow;
            }
            else
            {
                Percent.BackColor = Color.OrangeRed;
            }
        }
    }
}