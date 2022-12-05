using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void f(TextBox textBox2, string n, int i = 0, double result = 0)
        {
            double slag = 0;
            if (i < n.Length)
            {

                if (n[i] == '1')
                {
                    slag = Math.Pow(2, n.Length - i - 1);
                }
                result += slag;
                f(textBox2, n, i + 1, result);
            }
            else
            {
                if (n[0] == '-') result = -result;
                textBox2.Text = result.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int flag = 0;
            foreach (char item in a)
            {
                if (item != '0' && item != '1')
                {
                    MessageBox.Show("Некорректный ввод данных");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                int n = Convert.ToInt32(a[0]);
                f(textBox2, a);
            }
        }
    }
}
