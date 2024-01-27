using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practical_taskk;
using practical__task;

 

namespace practical__task
{


    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }


        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static double[] arr = new double[100];
        static double[] U = new double[100];

        static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static bool AreRelativelyPrime(int c, int m)
        {
            // Calculate the GCD (Greatest Common Divisor)
            int gcd = CalculateGCD(c, m);

            // If GCD is 1, the numbers are relatively prime
            return gcd == 1;
        }
        static bool IsPowerOf2(int m)
        {
             
            double flag = Math.Log(m,2);
            if (Math.Pow(2, (int)flag) == m&&m>1)
                return true;
            else
                return false;
        }
        int get_data(int a, int m, int c, int x0, int itirations,ref double[] arr,ref double[] U)
        {
            int cycle = 0;

            int kk = m - 1;
            for (int k = 0; k < 100; k++)
            {
                arr[k] = 0;
                U[k] = 0;
            }
            U[0] = 0;
            arr[0] = x0;
            for (int j = 1; j < itirations; j++)
            {
               

                    arr[j] = (a * arr[j - 1] + c) % m;
                U[j] = arr[j] / m;
                Console.WriteLine(arr[j] + "    " + U[j]);
                 

                if (IsPowerOf2(m) && c != 0 && a == 4 * kk + 1&& AreRelativelyPrime(  c,   m))
                {
                    cycle = m;
                }
                else if (IsPowerOf2(m) && c == 0 && x0 % 2 != 0 && (a == 5 + 8 * kk || a == 3 + 8 * kk))
                {
                    cycle = m / 4;
                }
                else if (IsPrime(m) && c == 0 && Math.Pow(a, kk) % m == 0)
                {
                    cycle = m - 1;
                }
                else {
                    if (arr[j] == x0 && j != 0)
                    {
                        cycle++;
                        break;
                    }
                    else
                        cycle++;



                }
                Console.WriteLine(cycle);
                if (m - 1 <= cycle)
                {
                    Console.WriteLine("full period");

                }
            }
            return cycle;

         
    }


        public void display_table(double[] X, double[] U)
        {


            dataGridView1.Rows.Clear();
            for(int i=0; i < X.Length; i++)
            {
                dataGridView1.Rows.Add(i+1,X[i], U[i]);
            }
             
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int a);
            int.TryParse(textBox2.Text, out int  x0);
            int.TryParse(textBox3.Text, out int c);
            int.TryParse(textBox4.Text, out int m);
            int.TryParse(textBox5.Text, out int i);

           
            textBox6.Text = get_data(a,m,c,x0,i,ref arr,ref U).ToString();
            display_table(arr, U);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
