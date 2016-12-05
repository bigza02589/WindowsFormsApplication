using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form2 : Form
    {
        int num;
        double num2;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double T1 = double.Parse(textBox1.Text);
                double T2 = double.Parse(textBox2.Text);
                double T3 = double.Parse(textBox3.Text);
                double T4 = double.Parse(textBox4.Text);
                double T5 = double.Parse(textBox5.Text);

                double A = (T2 * T3);
                double B = (T4 * T5);
                double C = T1 + A + B;

                MessageBox.Show("ค่าห้อง : " + T1 + " บาท" + "\r\n" + "ค่าไฟ : " + A + " บาท" + "\r\n" + "ค่าน้ำ : " + B + " บาท" + "\r\n" + "รวม : " + C + " บาท");
            }
            catch
            {
                MessageBox.Show("กรอกข้อมูลให้ครบถ้วน");
            }
            detect(textBox1);
            detect(textBox2);
            detect(textBox3);
            detect(textBox4);
            detect(textBox5);
        }
        public void detect(TextBox textBoxes)
        {
            if (!String.IsNullOrWhiteSpace(textBoxes.Text))
            {
                if (!int.TryParse(textBoxes.Text, out num) || (!double.TryParse(textBoxes.Text, out num2)))
                {
                    MessageBox.Show("ข้อมูลผิดพลาด" + "\r\n" + "กรุณาใส่เป็นตัวเลข");
                    textBoxes.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
