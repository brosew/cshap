using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fname = "ทศพล หิมพานต์";
        const double vat_rate = 0.07;

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(fname,"ชื่อ-สกุล");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var num = 7;
            //var vatrate = 0.07;
            //var fullname = "อลิษา สุปการ";
            //MessageBox.Show(vatrate.ToString());
            MessageBox.Show(fname + "\n" + "okok", "Result"); //\n\n ขึ้นบันทัดใหม่ 2 บันทัด
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string str = "สบายดี ";
            double amt = 1024.65;
            MessageBox.Show(str + amt.ToString("n2"));

        }

        private void button26_Click(object sender, EventArgs e)
        {
            var str = "สบายดีพี่น้องแม้ว";
            var amt = 8600.50;
            MessageBox.Show(str + amt.ToString("n2"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 345;
            string str = $"หนังสือราคา : {num}";
            MessageBox.Show(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //    var FullName = ("อลิษา", "สุปการ");
            //    MessageBox.Show(FullName.Item1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength.Equals(0))
            {
                textBox1.Focus();
                return; //ออกจาก sub

            }
            if (textBox1.Text.Equals("ชาย"))
            {
                MessageBox.Show("เพศชาย");
            }
            else if (textBox1.Text.Equals("หญิง"))
            {
                MessageBox.Show("เพศหญิง");
            }
            else
            {
                MessageBox.Show("สงสัยจะเป็น ตุ๊ด");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mymessage();
        }
        private void mymessage()
        {
            string a = "aaaaaabbbbb";
            MessageBox.Show(a);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var result = AddNumber(500, 1000);
            MessageBox.Show($"คำตอบคือ {result}");
        }
        private int AddNumber(int x, int y)
        {
            return x + y;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result1.Text = calnumber(double.Parse(number1.Text), double.Parse(number2.Text)).ToString();
        }
        private int calnumber(int x, int y)
        {
            return x + y;
        }
        private double calnumber(double x, double y)
        {
            return x + y;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.CustomerID = "001";
            c.FullName = "อลิษา สุปการ";
            c.Address = "นนทบุรี";
            MessageBox.Show("รหัสลูกค้า   : " + c.CustomerID + Environment.NewLine
                + "ชื่อ-สกุล      : " + c.FullName + Environment.NewLine
                + "ที่อยู่           : " + c.Address, "ข้อมูลลูกค้า");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = "ตู้เย็น ขนาด 14 คิว LQ-780MTR";
            p.ProductPrice = 8500;
            string str = $"{p.ID} {p.ProductName} {p.ProductPrice}";
            MessageBox.Show(str, "ข้อมูลสินค้า");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double area;
            Rectangle p = new Rectangle();
            p.Width = 200;
            p.Height = 1.5;
            area = p.CalculateArea();
            MessageBox.Show(area.ToString(), "พื้นที่");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double result;
            result = Area.Calculate(2100, 5);
            MessageBox.Show(result.ToString("n0"));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            p1.speak();
            p1.walk();

            Programmer p2 = new Programmer();
            p2.speak();
            p2.walk();
            p2.Programming();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Rectangle2 r1 = new Rectangle2();
            double result = 0;
            r1.Width = 10;
            r1.Height = 20;
            result = r1.Calculate();
            MessageBox.Show("พื้นที่ " + Environment.NewLine + result.ToString("n2"), "ผลการทำงาน");

            Cube c = new Cube();
            double result2 = 0;
            c.Width = 5;
            c.Height = 8;
            c.Thick = 20;
            result2 = c.CalculateCube();
            MessageBox.Show("ปริมาตร " + Environment.NewLine + result2.ToString("n2"), "ผลการทำงาน");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Customer_partial cus = new Customer_partial();
            cus.FistName = "อลิษา";
            cus.LastName = "สุปการ";
            cus.Address = "นนทบุรีรัมย์";
            MessageBox.Show(cus.FistName + " " + cus.LastName + " " + cus.Address, "ผลลัพท์");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int[] num = { 100, 5, 20, 275, 60 };
            string result = "";
            for (int i = 0; i < 5; i++)
            {
                result = result + "เลข : " + num[i] + Environment.NewLine;
            }
            MessageBox.Show(result, "ผลลัพท์");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int[] num = { 100, 5, 20, 275, 60 };
            MessageBox.Show(num.Count().ToString(), "ผลลัพท์");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            {
                int[] num = { 100, 5, 20, 275, 60 };
                MessageBox.Show(num.Sum().ToString(), "ผลลัพท์");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int[] num = { 100, 5, 20, 275, 60 };
            double result = 0.0;
            for (int i = 0; i < 5; i++)
            {
                result += num[i];
            }
            MessageBox.Show(result.ToString(), "ผลลัพท์");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int[] arrint = { 1, 3, 5, 7, 9 };
            printarray(arrint, 5);
        }
        private void printarray(int[] arr, int arrsize)
        {
            string result = "";
            for (int i = 0; i < arrsize; i++)
            {
                result = result + "เลข : " + arr[i] + Environment.NewLine;
            }
            MessageBox.Show(result, "ผลลัพท์");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Showdata(12);
            Showdata(26.38);
            Showdata("อลิกิกิ");
        }
            private void Showdata<T>(T x)
        {
            MessageBox.Show(x.ToString(), "ผลลัพท์");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var x = 1000;
            var y = "กรุงเทพฯ";
            Showdata<int, string>(x, y);
        }
        private void Showdata<T,U>(T data1,U data2)
        {
            MessageBox.Show(data1.ToString()+" "+data2.ToString(), "ผลลัพท์");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<String>();
            lst.Add("Visual C++");
            lst.Add("ASP.NET Core");
            lst.Add("SQL SERVER");
            lst.Sort();

            string str="";
            foreach (string s in lst)
            {
                str += s + Environment.NewLine;
            }
            MessageBox.Show(str, "ผลลัพท์");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string str = "";
            Stack<int> st = new Stack<int>();
            for (int i=0; i < 10; i++)
            {
                st.Push(i);
                str += st.Peek();
            }
            MessageBox.Show(str + "\nจำนวน : " + st.Count(), "อ่านข้อมูลทั้งหมด");

            str = "";
            for (int i=0; i <3; ++i)
            {
                str += st.Peek();
                st.Pop();
            }
            MessageBox.Show(str + "\nจำนวน : " + st.Count(), "อ่านข้อมูหลัง Pop");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);
            string str = "";
            foreach (int item in q)
            {
                str += item.ToString() + Environment.NewLine;
            }
            MessageBox.Show(str, "ข้อมูลทั้งหมดใน Queue");

            q.Dequeue();
            q.Dequeue();

            str = "";
            foreach (int item in q)
            {
                str += item.ToString() + Environment.NewLine;
            }
            MessageBox.Show(str, "ข้อมูลหลัง Dequeue");

        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                double amt;
                amt = vat_rate * double.Parse(textBox2.Text);
                MessageBox.Show(amt.ToString(), "ข้อมูลหลัง Dequeue");
            }

            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Result");
                }
         }
    }
}
