using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_winform窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //绑定事件
        private void button1_Click(object sender, EventArgs e)
        {
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button4.Click += new System.EventHandler(this.button2_Click);
            this.button5.Click += new System.EventHandler(this.button2_Click);
            //=========================================================
            this.button2.Click += new System.EventHandler(this.SayHill);
            this.button4.Click += new System.EventHandler(this.SayHill);
            this.button5.Click += new System.EventHandler(this.SayHill);
        }
        //解绑事件
        private void button3_Click(object sender, EventArgs e)
        {
            this.button2.Click -= new System.EventHandler(this.SayHill);
            this.button4.Click -= new System.EventHandler(this.SayHill);
            this.button5.Click -= new System.EventHandler(this.SayHill);
        }
        //事件所调用的方法
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("中午好！");
        }
        //自己定义的方法
        public void SayHill(object obj, EventArgs eventArgs)
        {
            MessageBox.Show("Hill!");
        }
    }
}
