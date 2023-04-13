using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureWeek4Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int islemSuresi;

        Stack<string> stack = new Stack<string>();
        Queue<int> sureQueue = new Queue<int>();
        Queue<string> queue = new Queue<string>();

        public void ListeleStack()
        {
            listBox2.Items.Clear();
            foreach(string eleman in stack)
            {
                listBox2.Items.Add(eleman);
            }
        }

        public void ListeleQueue()
        {
            listBox1.Items.Clear();
            foreach(string eleman in queue)
            {
                listBox1.Items.Add(eleman+" " );
            }

            int i = 0;
           

            foreach (int eleman in sureQueue)
            {

                int j = 0;
                int toplam = 0;

                listBox1.Items[i] +=Convert.ToString(eleman)+" ";
                foreach (int eleman2 in sureQueue)
                {
                    if (j < i)
                    {
                        toplam += eleman2;

                        j++;
                    }

                }
                listBox1.Items[j] += Convert.ToString(toplam);
                i++;

            }

           
            
           

            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stack.Count() < numericUpDown1.Value)
            {
                stack.Push(textBox1.Text);           
                label6.Text ="Current Size= " +stack.Count();
                ListeleStack();
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Kapasite Dolmuştur");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stack.Pop();
            label6.Text = "Current Size= " + stack.Count();
            ListeleStack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (queue.Count() < numericUpDown2.Value)
            {
                if (numericUpDown3.Value != 0)
                {
                    queue.Enqueue(textBox2.Text);
                    sureQueue.Enqueue(Convert.ToInt32( numericUpDown3.Value));
                    label7.Text = "Current Size= " + queue.Count();
                    ListeleQueue();
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("İşlem Süresi Girilmelidir");
                }
            }
            else
            {
                MessageBox.Show("Kapasite Dolmuştur");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            queue.Dequeue();
            label7.Text = "Current Size= " + queue.Count();
            ListeleQueue();
        }
    }
}
