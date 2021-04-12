using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ProductPortfoglio
{
    public partial class InitForm : MetroFramework.Forms.MetroForm
    {
        public InitForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            var mnFrm = new MainForm();
            mnFrm.Owner = this;
            this.Hide();
            mnFrm.Show();
            
        }
    }
}
