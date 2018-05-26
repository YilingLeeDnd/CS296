using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_20180504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BmiButton_Click(object sender, EventArgs e)
        {
            float height = 0.0f;
            float weight = 0.0f;
            float bmi = 0.0f;

            try
            {
                height = float.Parse(HeightTextBox.Text);
            }
            catch
            {
                BmiStatusLabel.Text = "請輸入身高!";
                BmiStatusLabel.ForeColor = Color.Blue;
                HeightTextBox.Text = ""; //TextBox清空
                HeightTextBox.Focus(); //游標位置
                return;
            }
            try
            {
                weight = float.Parse(WeightTextBox.Text);
            }
            catch
            {
                BmiStatusLabel.Text = "請輸入體重!";
                BmiStatusLabel.ForeColor = Color.Blue;
                WeightTextBox.Text = ""; //TextBox清空
                WeightTextBox.Focus(); //游標位置
                return;
            }

            bmi = weight / ((height / 100.0f) * (height / 100.0f));

            if (bmi > 24 || bmi < 18)
            {
                BmiStatusLabel.Text = "BMI = " + bmi.ToString("##.##") + "，BMI異常，請注意健康";
                BmiStatusLabel.ForeColor = Color.Red;
            }
            else
            {
                BmiStatusLabel.Text = "BMI = " + bmi.ToString("##.##") + "，BMI正常";
                BmiStatusLabel.ForeColor = Color.Green;
            }
        }
    }
}