using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAge(monthCalendar1.SelectionRange.Start);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _cultureText = "th-TH";
            if (textBox1.Text.Length < 1)
            {
                return;
            }
            if (int.Parse(textBox1.Text.Split('/')[2]) < 2100)
            {
                _cultureText = "en-US";
            }
            DateTime _birthDate = DateTime.ParseExact(textBox1.Text, "dd/MM/yyyy",
                CultureInfo.GetCultureInfo(_cultureText));
            monthCalendar1.SetDate(_birthDate);
            ShowAge(_birthDate);
        }

        private void ShowAge(DateTime pBirthDate)
        {
            ApplicationLayer.ICalculateAge bs;
            if (radioButton1.Checked)
            {
                bs = new BusniessLayer.CalulateAgeTH();
            }
            else
            {
                bs = new BusniessLayer.CalulateAgeEN();
            }
            lblAge.Text = bs.getAge(pBirthDate).ToString();
            lblDateText.Text = bs.GetBirthDateText(pBirthDate);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ShowAge(monthCalendar1.SelectionRange.Start);
        }
    }
}
