using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Person p = new Person();
            p.Navn = "a";
            //p.Alder = 10;
            p.FødselsDato = DateTime.Now;
            p.ErDansk = true;

            propertyGrid1.SelectedObject = p;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
