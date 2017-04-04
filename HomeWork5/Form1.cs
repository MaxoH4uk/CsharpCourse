using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HomeWork5
{
    public partial class Form1 : Form
    {
        public static string buttonIsPressed = "";
        public static List<bool> isOpenedDoor = new List<bool>();
        public static bool isFirstOpen = true;

        public Form1()
        {
            InitializeComponent();
            main = this;
        }
        internal static Form1 main;
        internal string Status
        {
            get { return richTextBox1.Text.ToString(); }
            set { richTextBox1.Text += value + "\n"; }
        }

        private void doorsCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(carName.Text))
            {
                if(doorNumber.Value <= doorsCount.Value)
                {
                    buttonIsPressed = "Move";
                    Car car = new Car(Convert.ToUInt32(doorsCount.Value), Convert.ToUInt32(wheelsCount.Value), Convert.ToUInt32(doorNumber.Value), carName.Text);
                }
                else
                {
                    MessageBox.Show("Номер двери не может быть больше, чем их количество!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введите название машины!");
                return;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(carName.Text))
            {
                if (doorNumber.Value <= doorsCount.Value)
                {
                    if(isFirstOpen)
                    {
                        isOpenedDoor = Enumerable.Repeat(false, (int)(doorsCount.Value)).ToList();
                        isFirstOpen = false;
                    }
                    if(isOpenedDoor.Count == doorsCount.Value)
                    {
                        buttonIsPressed = "Open";
                        Car car = new Car(Convert.ToUInt32(doorsCount.Value), Convert.ToUInt32(wheelsCount.Value), Convert.ToUInt32(doorNumber.Value), carName.Text);
                    }
                    else
                    {
                        isOpenedDoor = Enumerable.Repeat(false, (int)(doorsCount.Value)).ToList();
                        isFirstOpen = false;
                        buttonIsPressed = "Open";
                        Car car = new Car(Convert.ToUInt32(doorsCount.Value), Convert.ToUInt32(wheelsCount.Value), Convert.ToUInt32(doorNumber.Value), carName.Text);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Номер двери не может быть больше, чем их количество!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введите название машины!");
                return;
            }
        }

        private void doorNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        public void TextChange(string text)
        {
            richTextBox1.Text += text;
        }

        private void carNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
