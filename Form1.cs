using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Stamper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var now = GetTimestamp(DateTime.Now);
            txtBxTime.Text = now;
            Clipboard.SetText(txtBxTime.Text);
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("MMddyyyyHHmmss");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBxTime.Text = GetTimestamp(DateTime.Now);
            Clipboard.SetText(txtBxTime.Text);
        }
    }
}
