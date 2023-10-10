using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aktarmalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int bakiye = 200;


        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text=bakiye.ToString();

        }
    }
}
