using Newtonsoft.Json;

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CertifCalculator
{
    public partial class TestScore : Form
    {
        public TestScore()
        {
            InitializeComponent();

            SaveFile = Path.Combine(Path.GetTempPath(), "stateScore.txt");
            Reset();
        }

        public string SaveFile { get; set; }

        void SaveState()
        {
            DisplayScore displayScore = new DisplayScore();

            displayScore.Notes = textBox1.Text;
            displayScore.ScoreState.Points = Convert.ToInt32(Score.Text);
            displayScore.ScoreState.Questions = Convert.ToInt32(QuestionScore.Text);
            displayScore.TestState.Points = Convert.ToInt32(MaxScore.Text);
            displayScore.TestState.Questions = Convert.ToInt32(Questions.Text);

            string msg = JsonConvert.SerializeObject(displayScore);
            File.WriteAllText(SaveFile, msg);
        }

        void LoadState()
        {
            if (!File.Exists(SaveFile))
            {
                return;
            }
            string msg = File.ReadAllText(SaveFile);
            DisplayScore displayScore = JsonConvert.DeserializeObject<DisplayScore>(msg);

            textBox1.Text = displayScore.Notes;
            Score.Text = displayScore.ScoreState.Points.ToString();
            QuestionScore.Text = displayScore.ScoreState.Questions.ToString();
            MaxScore.Text = displayScore.TestState.Points.ToString();
            Questions.Text = displayScore.TestState.Questions.ToString();
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
            Total.Text = Resource1.TestTitle;
            ScoreBox.Text = Resource1.ScoreTitle;
            textBox1.Text = "";
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

        public int Point { get; set; }

        void AddPointToQuestions(int total)
        {
            Point = total;
            MaxScore.Value += total;
            Total.Text = $"{Resource1.TestTitle} ({total})";
            ScoreBox.Text = Resource1.ScoreTitle;
            Questions.Value++;
        }

        void AddPointToScore(int total)
        {
            Score.Value += total;
            ScoreBox.Text = $"{Resource1.ScoreTitle} ({total})";
            QuestionScore.Value++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPointToQuestions(1);
            Compute();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPointToQuestions(2);
            Compute();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddPointToQuestions(3);
            Compute();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            AddPointToQuestions(4);
            Compute();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddPointToScore(1);
            Compute();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddPointToScore(2);
            Compute();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddPointToScore(3);
            Compute();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddPointToScore(4);
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
            AddPointToQuestions(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPointToScore(0);
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

        private void TestScore_Load(object sender, EventArgs e)
        {
            Reset();
            LoadState();
        }

        private void TestScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveState();
        }

        private void TestScore_Shown(object sender, EventArgs e)
        {
            var reponse = MessageBox.Show("Voulez-vous réinitialiser le formulaire?", "Réinitialiser", MessageBoxButtons.YesNo);
            if (reponse == DialogResult.Yes)
            {
                Reset();
            }
        }
    }
}
