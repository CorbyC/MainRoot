using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoStuff
{
    public partial class NumbersGame : Form
    {
        public bool[] numberUsed;
        public Button[] numberButtons;

        public NumbersGame()
        {
            InitializeComponent();
            numberUsed = new bool[7]; //TODO: not using base 0, do this better
            numberButtons = new Button[7];
            numberButtons[1] = buttonFirstNumber;
            numberButtons[2] = buttonSecondNumber;
            numberButtons[3] = buttonThirdNumber;
            numberButtons[4] = buttonFourthNumber;
            numberButtons[5] = buttonFifthNumber;
            numberButtons[6] = buttonSixthNumber;
        }

        private void buttonNumber_Paint(object sender, PaintEventArgs e)
        {
            if (!String.IsNullOrEmpty(((Button)sender).Tag.ToString()))
            {
                int buttonIndex = int.Parse(((Button)sender).Tag.ToString());
                if (!numberUsed[buttonIndex])
                {
                    numberButtons[buttonIndex].BackColor = Color.White;
                }
                else
                {
                    numberButtons[buttonIndex].BackColor = Color.DeepPink;
                }
            }
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            int buttonIndex = int.Parse(((Button)sender).Tag.ToString());
            numberUsed[buttonIndex] = !numberUsed[buttonIndex];
        }
    }
}
