
namespace CertifCalculator
{
    partial class TestScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.GroupBox();
            this.Points = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MaxScore = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.Questions = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.QuestionScore = new System.Windows.Forms.NumericUpDown();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Alerte = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Questions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, -36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.LightBlue;
            this.Total.Controls.Add(this.Points);
            this.Total.Controls.Add(this.button1);
            this.Total.Controls.Add(this.MaxScore);
            this.Total.Controls.Add(this.label2);
            this.Total.Controls.Add(this.button8);
            this.Total.Controls.Add(this.Questions);
            this.Total.Controls.Add(this.button7);
            this.Total.Controls.Add(this.button6);
            this.Total.Controls.Add(this.button5);
            this.Total.Controls.Add(this.label1);
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.Black;
            this.Total.Location = new System.Drawing.Point(180, 170);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(312, 510);
            this.Total.TabIndex = 6;
            this.Total.TabStop = false;
            this.Total.Text = "Test";
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(3, 50);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(62, 20);
            this.Points.TabIndex = 13;
            this.Points.Text = "Points";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaxScore
            // 
            this.MaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxScore.Location = new System.Drawing.Point(6, 73);
            this.MaxScore.Name = "MaxScore";
            this.MaxScore.Size = new System.Drawing.Size(299, 38);
            this.MaxScore.TabIndex = 5;
            this.MaxScore.TabStop = false;
            this.MaxScore.ValueChanged += new System.EventHandler(this.MaxScore_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Questions posées:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(176, 243);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 59);
            this.button8.TabIndex = 3;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Questions
            // 
            this.Questions.BackColor = System.Drawing.Color.NavajoWhite;
            this.Questions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Questions.Location = new System.Drawing.Point(6, 459);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(300, 45);
            this.Questions.TabIndex = 10;
            this.Questions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Questions.ValueChanged += new System.EventHandler(this.Questions_ValueChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 59);
            this.button7.TabIndex = 2;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(176, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 59);
            this.button6.TabIndex = 1;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 59);
            this.button5.TabIndex = 0;
            this.button5.Tag = "1";
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Score);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.QuestionScore);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(572, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 510);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Votre score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Points";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Score
            // 
            this.Score.Enabled = false;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(8, 71);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(299, 38);
            this.Score.TabIndex = 5;
            this.Score.TabStop = false;
            this.Score.ValueChanged += new System.EventHandler(this.Score_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Questions répondues:";
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(178, 241);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(130, 59);
            this.button13.TabIndex = 3;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(8, 241);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(130, 59);
            this.button12.TabIndex = 2;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // QuestionScore
            // 
            this.QuestionScore.BackColor = System.Drawing.Color.NavajoWhite;
            this.QuestionScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionScore.Location = new System.Drawing.Point(6, 459);
            this.QuestionScore.Name = "QuestionScore";
            this.QuestionScore.Size = new System.Drawing.Size(299, 45);
            this.QuestionScore.TabIndex = 10;
            this.QuestionScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuestionScore.ValueChanged += new System.EventHandler(this.QuestionScore_ValueChanged);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(8, 141);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 59);
            this.button10.TabIndex = 0;
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(178, 142);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(130, 59);
            this.button11.TabIndex = 1;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(15, 53);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 55);
            this.button9.TabIndex = 8;
            this.button9.TabStop = false;
            this.button9.Text = "Réinitialiser";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Percent
            // 
            this.Percent.BackColor = System.Drawing.Color.GreenYellow;
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(180, 53);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(705, 43);
            this.Percent.TabIndex = 9;
            this.Percent.Text = "0";
            this.Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Score (%):";
            // 
            // Alerte
            // 
            this.Alerte.AutoSize = true;
            this.Alerte.Location = new System.Drawing.Point(186, 114);
            this.Alerte.Name = "Alerte";
            this.Alerte.Size = new System.Drawing.Size(325, 17);
            this.Alerte.TabIndex = 13;
            this.Alerte.Text = "Différence questions posées/questions répondues";
            this.Alerte.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 713);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(691, 64);
            this.textBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 713);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "NOTES:";
            // 
            // TestScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(902, 808);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Alerte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Total);
            this.Name = "TestScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestScore";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TestScore_Load);
            this.Total.ResumeLayout(false);
            this.Total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Questions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Total;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown MaxScore;
        private System.Windows.Forms.NumericUpDown Score;
        private System.Windows.Forms.Label Percent;
        private System.Windows.Forms.NumericUpDown Questions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown QuestionScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Alerte;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

