using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment11_PavelGolovan_Practice2_
{
    public partial class Form1 : Form
    {
        private Car car = new Car();

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(yearTextBox.Text) &&
                !String.IsNullOrWhiteSpace(makeTextBox.Text))
            {
                try
                {
                    car.Year = int.Parse(yearTextBox.Text);
                    car.Make = makeTextBox.Text;
                    carLabel.Text = car.Make + ": " + car.Year.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter full details.");
            }
        }

        private void gasPictureBox_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(car.Make) &&
                car.Year >= 0)
            {
                speedLabel.Text = car.Accelerate().ToString();
            }
        }

        private void brakePictureBox_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(car.Make) &&
                car.Year >= 0)
            {
                speedLabel.Text = car.Brake().ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}