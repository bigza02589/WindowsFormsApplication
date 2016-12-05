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
    public partial class Form3 : Form
    {
        int m12;  // กำหนดให้ m12 เป็นค่า int
        int num;  // กำหนดให้ num เป็นค่า int
        int mode1; // กำหนดให้ mode1 เป็นค่า int
        double num2; // กำหนดให้ num2 เป็นค่า int
        bool ok = false; // กำหนดให้ bool ok = เท็จ
        int Num; // กำหนดให้ Num เป็นค่า int
        int T5;// กำหนดให้ T5 เป็นค่า int
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); //ปิด
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
               
               
                int x = 1; // กำหนดให้ x = 1
                detect3(x); // ดึง method detect3 มาใช้กับ x
                detect(textBox1); // ดึง method detect มาใช้กับ textBox1
                detect2(textBox5); // ดึง method detect2 มาใช้กับ textBox5     
                detect2(textBox6); // ดึง method detect2 มาใช้กับ textBox6          
                string T1 = (textBox1.Text); // กำหนดให้ T1 = textBox1 เพื่อสามารถป้อนค่าได้
                string T2 = (textBox2.Text); // กำหนดให้ T2 = textBox1 เพื่อสามารถป้อนค่าได้
                string T3 = (textBox3.Text); // กำหนดให้ T3 = textBox1 เพื่อสามารถป้อนค่าได้
                int T6 = int.Parse(textBox6.Text); // กำหนดให้ T6 = textBox6 เพื่อสามารถป้อนค่าได้
                T5 = int.Parse(textBox5.Text);// กำหนดให้ T5 = textBox5 เพื่อสามารถป้อนค่าได้

                int datetime = (dateTimePicker2.Value - dateTimePicker1.Value).Days; // กำหนดให้ detetime = (dateTimePicker2.Value - dateTimePicker1.Value) จะออกมาเป็นค่าตัวเลข

                if (datetime < 0) // ถ้า datetime < 0

                {
                    radioButton1.Checked = false; // radioButton1ถูกเช็ค จะเป็นเท็จ
                    radioButton2.Checked = false; // radioButton2ถูกเช็ค จะเป็นเท็จ
                    MessageBox.Show("Checkout ผิดพลาด"); // MessageBox  จะโชว์ว่า "Checkout ผิดพลาด"
                }
                if (ok == true) // ถ้า ok เป็นจริง
                {
                    if (radioButton1.Checked == true && radioButton3.Checked == true && textBox1.Text != "") // ถ้า radioButton1 ถูกเช็คให้เป็นจริง และradioButton3 ถูกเช็คให้เป็นจริง และ textBox1 ไม่เท่ากับ
                    {
                        MessageBox.Show("ชื่อ-สกุล : " + T1 + "\r\n" + "เพศ : ชาย" + "\r\n" + "สัญชาติ : ไทย" + "\r\n" + "เลขบัตรประชาชน :" + T2 + "\r\n" + "Chekin : " + dateTimePicker1.Text + "\r\n" + "Chekout : " + dateTimePicker2.Text + " ออกก่อน 12:00 น." + "\r\n" + "จำนวนวันที่เข้าพัก : " + datetime + " คืน" + "\r\n"  + "ของเสียหาย : " + T6 + " บาท" + "\r\n" + "ยอมรวม : " + ((datetime * T5+ T6)+Num) + " บาท"); //MessageBox จะโชว์ข้อความ
                         ok = false; //ok = เท็จ
                    }
                    if (radioButton1.Checked == true && radioButton4.Checked == true && textBox1.Text != "")// ถ้า radioButton1 ถูกเช็คให้เป็นจริง และradioButton4 ถูกเช็คให้เป็นจริง และ textBox1 ไม่เท่ากับ
                    {
                        MessageBox.Show("Name : " + T1 + "\r\n" + "Gender : Man" + "\r\n" + "Nationality : Foreigner" + "\r\n" + "Passport : " + T3 + "\r\n" + "Chekin : " + dateTimePicker1.Text + "\r\n" + "Chekout : " + dateTimePicker2.Text + " First time 12:00 AM " + "\r\n" + "Days Hotel : " + datetime + " day"  + "\r\n" + "damaged goods : " + T6 + " Baht" + "\r\n" + "sum : " +( (datetime * T5 + T6)+Num) + " บาท");//MessageBox จะโชว์ข้อความ
                        ok = false;//ok = เท็จ
                    }

                    if (radioButton2.Checked == true && radioButton3.Checked == true && textBox1.Text != "")// ถ้า radioButton2 ถูกเช็คให้เป็นจริง และradioButton3 ถูกเช็คให้เป็นจริง และ textBox1 ไม่เท่ากับ
                    {
                            MessageBox.Show("ชื่อขสกุล : " + T1 + "\r\n" + "เพศ : หญิง" + "\r\n" + "สัญชาติ : ไทย" + "\r\n" + "เลขบัตรประชาชน :" + T2 + "\r\n" + "Chekin : " + dateTimePicker1.Text + "\r\n" + "Chekout : " + dateTimePicker2.Text + " ออกก่อน 12:00 น." + "\r\n" + "จำนวนวันที่เข้าพัก : " + datetime + " คืน" + "\r\n"  + "ของเสียหาย : " + T6 + " บาท" + "\r\n" + "ยอมรวม : " + ((datetime * T5  + T6)+Num) + " บาท");//MessageBox จะโชว์ข้อความ
                        ok = false;//ok = เท็จ
                    }

                    if (radioButton2.Checked == true && radioButton4.Checked == true && textBox1.Text != "")// ถ้า radioButton2 ถูกเช็คให้เป็นจริง และradioButton3 ถูกเช็คให้เป็นจริง และ textBox1 ไม่เท่ากับ
                    {
                        MessageBox.Show("Name : " + T1 + "\r\n" + "Gender : Woman" + "\r\n" + "Nationality : Foreigner" + "\r\n" + "Passport : " + "\r\n" + T3 + "Chekin : " + "\r\n" + dateTimePicker1.Text + "\r\n" + "Chekout : " + dateTimePicker2.Text + " First time 12:00 AM" + "\r\n" + "Days Hotel : " + datetime + " day" + "\r\n"  + "damaged goods : " + T6 + " Baht" + "\r\n" + "sum : " + ((datetime * T5  + T6)+Num) + " บาท");//MessageBox จะโชว์ข้อความ
                        ok = false;//ok = เท็จ
                    }
                }
                    
                  }
                
            catch //ถ้าโปรแกรมผิดพลาด
            { 
                MessageBox.Show("กรอกข้อมูลให้ครบถ้วน"); // MessageBox จะโชว์ข้อความ
                ok = false;
            }
         
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false; // textBox2 ปิดใช้งาน = เท็จ
            textBox3.Enabled = false; // textBox3 ปิดใช้งาน = เท็จ
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) // ถ้า radioButton3 ถูกเช็ค 
            {
                textBox2.Enabled = true; //  textBox2 ที่ปิดใช้งานให้ = จริง
            }

            else if (!radioButton3.Checked) // ถ้า radioButton3 ไม่ถูกเช็ค 
            {
                textBox2.Enabled = false; //  textBox2 ที่ปิดใช้งานให้ = เท็จ
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) // ถ้า radioButton4 ถูกเช็ค 
            {
                textBox3.Enabled = true;// ถ้า radioButton3 = จริง
            }

            else if (!radioButton4.Checked)// ถ้า radioButton4 ไม่ถูกเช็ค 
            {
                textBox3.Enabled = false; //  textBox3 ที่ปิดใช้งานให้ = เท็จ
            }
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {         

        }
        public void detect(TextBox textBoxes)
        {
            if (!String.IsNullOrWhiteSpace(textBoxes.Text))// ถ้าไม่ใช่ตัวอักษรหรือเป็นช่องว่า ที่อยู่ใน textBoxes
            {
                if (int.TryParse(textBoxes.Text, out num) || (double.TryParse(textBoxes.Text, out num2))) //ถ้าเป็นตัวเลขที่ป้อนเข้ามาใน textBoxes จะถูกเก็บไปไว้ใน num หรือ ถ้าเป็นตัวเลขทศนิยมที่ป้อนเข้ามาใน textBoxes จะถูกเก็บไปไว้ใน num2
                {
                    MessageBox.Show("ข้อมูลผิดพลาด" + "\r\n"+"ข้อมูลต้องเป็นตัวอักษร" ); //  MessageBox จะโชว์ข้อความ
                    textBoxes.Text = ""; //  textBoxes จะเป็นช่องว่า
                }
            }
            
        }
        public void detect2(TextBox textBoxes)
        {
            if (!String.IsNullOrWhiteSpace(textBoxes.Text))// ถ้าไม่ใช่ตัวอักษรหรือเป็นช่องว่า ที่อยู่ใน textBoxes
            {

                if (!int.TryParse(textBoxes.Text, out num) || (!double.TryParse(textBoxes.Text, out num2)))//ถ้าไม่เป็นตัวเลขที่ป้อนเข้ามาใน textBoxes จะถูกเก็บไปไว้ใน num หรือ ถ้าไม่เป็นตัวเลขทศนิยมที่ป้อนเข้ามาใน textBoxes จะถูกเก็บไปไว้ใน num2
                {
                    MessageBox.Show("ข้อมูลผิดพลาด" + "\r\n"+"ข้อมูลต้องเป็นตัวเลข");//MessageBox จะโชว์ข้อความ
                    textBoxes.Text = "";//textBoxes จะเป็นช่องว่าง
                }
            }
        }
        public void detect3(double x)
        {
            try
            {

                if (radioButton3.Checked == true && radioButton4.Checked == false) //ถ้า radiobutton3 และ radiobutton 4 ถูกเลือกให้เข้าเงื่อนไขนี้
                {
                    int[] M; //กำหนด Array int m
                    string T = (textBox2.Text); //ให้ t เก็บค่าจาก textbox2 เป็น string
                    string[] N = T.Split(' '); //สร้างตัวแปร array n เก็บค่าจากการแยกส่วน t ด้วยช่องว่าง
                    M = new int[N.Length]; //ให้ตัวแปร m เก็บค่าขนาดความยาวของ n
                    for (int i = 0; i < M.Length; i++)
                    {
                        M[i] = int.Parse(N[i]); //เข้า loop โดยให้ array m เก็บค่าจาก array n

                    }
                    int m = M[0] * 13; //กำหนดให้ตัวแปร m เก็บค่าจาก array m ลำดับที่ 1 ที่ตำแหน่ง 0 * 13
                    int m1 = M[1] * 12;//กำหนดให้ตัวแปร m1 เก็บค่าจาก array m ลำดับที่ 2 ที่ตำแหน่ง 1 * 13
                    int m2 = M[2] * 11;//กำหนดให้ตัวแปร m2 เก็บค่าจาก array m ลำดับที่ 3 ที่ตำแหน่ง 2 * 13
                    int m3 = M[3] * 10;//กำหนดให้ตัวแปร m3 เก็บค่าจาก array m ลำดับที่ 4 ที่ตำแหน่ง 3 * 13
                    int m4 = M[4] * 9; //กำหนดให้ตัวแปร m4 เก็บค่าจาก array m ลำดับที่ 5 ที่ตำแหน่ง 4 * 13
                    int m5 = M[5] * 8; //กำหนดให้ตัวแปร m5 เก็บค่าจาก array m ลำดับที่ 6 ที่ตำแหน่ง 5 * 13
                    int m6 = M[6] * 7; //กำหนดให้ตัวแปร m6 เก็บค่าจาก array m ลำดับที่ 7 ที่ตำแหน่ง 6 * 13
                    int m7 = M[7] * 6; //กำหนดให้ตัวแปร m7 เก็บค่าจาก array m ลำดับที่ 8 ที่ตำแหน่ง 7 * 13
                    int m8 = M[8] * 5; //กำหนดให้ตัวแปร m8 เก็บค่าจาก array m ลำดับที่ 9 ที่ตำแหน่ง 8 * 13
                    int m9 = M[9] * 4; //กำหนดให้ตัวแปร m9 เก็บค่าจาก array m ลำดับที่ 10 ที่ตำแหน่ง 9 * 13
                    int m10 = M[10] * 3;//กำหนดให้ตัวแปร m10 เก็บค่าจาก array m ลำดับที่ 11 ที่ตำแหน่ง 10 * 13
                    int m11 = M[11] * 2;//กำหนดให้ตัวแปร m11 เก็บค่าจาก array m ลำดับที่ 12 ที่ตำแหน่ง 11 * 13
                    m12 = M[12];//กำหนดให้ตัวแปร m12 เก็บค่าจาก array m12 
                    int sum = m + m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9 + m10 + m11; //ให้ตัวแปร int sum เก็บค่าการคำนวณ
                    int mode = sum % 11;//ให้ตัวแปร int mode หารด้วย 11 เพื่อหาเศษ
                    mode1 = 11 - mode; //ให้ตัวแปร mode1 เก็บค่า 11 - mode

                    if (mode1 == 11 - mode) //ถ้า mode1 เท่ากับ 11-mode

                    {
                        ok = true; //ให้ ok = จริง

                    }
                    if (mode1 != m12) //ถ้า mode1 ไม่เท่ากับ m12
                    {
                        MessageBox.Show("บัตรประชาชนไม่ถูกต้อง"); //MessageBox จะโชว์ข้อความ
                    }
                    else if (textBox2.Text == string.Empty) //ถ้าไม่ใช่ textBox2 = string
                    {
                        MessageBox.Show("กรุณากรอกบัตรประชาชน"); //MessageBox จะโชว์ข้อความ
                    }
                }
            }
            catch //ถ้าโปรแกรมผิดพลาด
            { 

                MessageBox.Show("ข้อมูลผิดพลาด"); //MessageBox จะโชว์ข้อความ
            }
        }
          private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Num = T5 + T5; //Num = T5+T5
            textBox5.Text = Num.ToString(); // textBox5 = num
        }
    }
 }

