using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week05_2
{
    public partial class Form1 : Form
    {
        Status gameStatus = Status.Won;
        int myPoint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            /* My Codes
            Random random = new Random((int)DateTime.Now.Ticks);
            int firstNum = random.Next(1,6+1);
            int secondNum = random.Next(1,6+1);
            labelFirstNum.Text = String.Format("{0}", firstNum);
            labelSecNum.Text = String.Format("{0}", secondNum);
            int sum = 0;
            sum = firstNum + secondNum;
            if (sum == 7 || sum == 11)
            {
                labelResult.Text = String.Format("Sum of Dices is {0} \nYou won", sum);
            }
            else if (sum == 2 || sum == 3 || sum == 12)
            {
                labelResult.Text = String.Format("Sum of Dices is {0} \nYou Lose", sum);
            }
            else
            {
                labelResult.Text = String.Format("Sum of Dices is {0} \nYour point is {1} Roll Again", sum, sum);
            }
            */

            /* Lecturer Codes */
            int sumOfDice = RollDice();
            if (gameStatus == Status.Continue)
            {
                if (sumOfDice == myPoint)
                {
                    gameStatus = Status.Won;
                }
                else if (sumOfDice == (int)DiceNames.Seven)
                {
                    gameStatus = Status.Lost;
                }
                labelResult.Text += "\nSum of Dices is " + sumOfDice;
                if (gameStatus == Status.Won)
                {
                    labelResult.Text += "\nYou Won ";
                }
                else if (gameStatus == Status.Lost)
                {
                    labelResult.Text += "\nYou Lost ";
                }
                else
                {
                    labelResult.Text += "\nGame Continue, Roll Again ";
                }
            }
            else
            {
                switch ((DiceNames)sumOfDice)
                {
                    case DiceNames.Seven:
                    case DiceNames.YoLeven:
                        gameStatus = Status.Won;
                        break;
                    case DiceNames.SnakeEyes:
                    case DiceNames.Trey:
                    case DiceNames.BoxCars:
                        gameStatus = Status.Lost;
                        break;
                    default:
                        gameStatus = Status.Continue;
                        myPoint = sumOfDice;
                        break;
                }
                labelResult.Text += "\nSum of Dices is " + sumOfDice;
                if (gameStatus == Status.Won)
                {
                    labelResult.Text += "\nYou Won ";
                }
                else if (gameStatus == Status.Lost)
                {
                    labelResult.Text += "\nYou Lost ";
                }
                else
                {
                    labelResult.Text += "\nYour point is " + sumOfDice + ", Roll Again ";
                }
            }
        }

        private int RollDice()
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            labelFirstNum.Text = "" + dice1;
            labelSecNum.Text = "" + dice2;
            return dice1 + dice2;
        }
        
    }
    public enum Status { Continue, Won, Lost }
    public enum DiceNames
    {
        SnakeEyes = 2,
        Trey = 3,
        Seven = 7,
        YoLeven = 11,
        BoxCars = 12
    }
}
