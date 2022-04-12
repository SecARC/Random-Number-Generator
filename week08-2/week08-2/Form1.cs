using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week08_2
{
    public partial class Form1 : Form
    {
        public Dog boncuk { get; set; }
        public Dog karabas { get; set; }
        public Dog medium { get; set; }
        public Competition<Dog> competition { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boncuk = new Dog();
            boncuk.id = 1;
            boncuk.fullName = "Boncuk";
            boncuk.species = "Shepherd";
            boncuk.score = 0;

            karabas = new Dog(2, "Karabaş", "Kangal");

            medium = new Dog(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boncuk.Run100meters();
            karabas.Run100meters();
            medium.Run100meters();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = "Training Results";
            txtResult.Text += Environment.NewLine + boncuk.score;
            txtResult.Text += Environment.NewLine + karabas.score;
            txtResult.Text += Environment.NewLine + medium.score;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            competition = new Competition<Dog>();
            competition.Add(new Dog(1001, "Suzy", "Hound"));
            competition.Add(new Dog(1255, "Flash", "Hound"));
            competition.Add(new Dog(1177, "Grafit", "Hound"));
            competition.Add(new Dog(1534, "Sammy", "Hound"));
            competition.Add(new Dog(1851, "Mogyi", "Hound"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            competition.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text = competition.ToString();
        }
    }
}
