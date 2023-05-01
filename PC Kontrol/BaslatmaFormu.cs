using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Kontrol
{
    public partial class BaslatmaFormu : Form
    {
        public BaslatmaFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frmAnaForm = new Form1();
            frmAnaForm.Show();
            this.Hide();
        }
    }
}
