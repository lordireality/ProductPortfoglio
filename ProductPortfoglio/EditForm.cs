using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPortfoglio
{
    public partial class EditForm : MetroFramework.Forms.MetroForm
    {
        public MainForm MF;
        public int currentProjId;
        public EditForm(MainForm MFOwner, int localcurrentProjId)
        {
            MF = MFOwner;
            currentProjId = localcurrentProjId;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            nameTextBox.Text = MF.JP.JDS.project[currentProjId].name;
            descTextBox.Text = MF.JP.JDS.project[currentProjId].desc;
            hasLink.Checked = MF.JP.JDS.project[currentProjId].hasLink;
            linkTextBox.Text = MF.JP.JDS.project[currentProjId].link;
            hasPath.Checked = MF.JP.JDS.project[currentProjId].hasPath;
            pathTextBox.Text = MF.JP.JDS.project[currentProjId].path;

        }



        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MF.JP.JDS.project[currentProjId].name = nameTextBox.Text;
                MF.JP.JDS.project[currentProjId].desc = descTextBox.Text;
                MF.JP.JDS.project[currentProjId].hasLink = hasLink.Checked;
                MF.JP.JDS.project[currentProjId].link = linkTextBox.Text;
                MF.JP.JDS.project[currentProjId].hasPath = hasPath.Checked;
                MF.JP.JDS.project[currentProjId].path = pathTextBox.Text;
                MF.JP.UpdateJsonFile();
                MF.UpdateListBox();
                MF.LoadProjectInfo(currentProjId);
                this.Close();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Произошла ошибка!");
            }
        }

        private void hasPath_CheckedChanged(object sender, EventArgs e)
        {
            if (hasPath.Checked)
            {
                pathTextBox.Enabled = true;
            } else
            {
                pathTextBox.Enabled = false;
                pathTextBox.Text = "";
            }
        }

        private void hasLink_CheckedChanged(object sender, EventArgs e)
        {
            if (hasLink.Checked)
            {
                linkTextBox.Enabled = true;
            } else
            {
                linkTextBox.Enabled = false;
                linkTextBox.Text = "";
            }
        }
    }
}
