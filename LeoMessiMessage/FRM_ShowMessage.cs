using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeoMessiMessage
{
    public partial class FRM_ShowMessage : Form
    {
        public FRM_ShowMessage()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = MessiMessage.Result;
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Text = MessiMessage.Result;
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Text = MessiMessage.Result;
            this.Close();
        }
    }
}
