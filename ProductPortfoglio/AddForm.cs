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
    public partial class AddForm : MetroFramework.Forms.MetroForm
    {
        public MainForm MF;
        public int currentProjId;
        public AddForm(MainForm MFOwner)
        {
            MF = MFOwner;
            InitializeComponent();
        }



        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {                
                MF.JP.JDS.project.Add(new Projects()
                {
                    name = nameTextBox.Text,
                    desc = descTextBox.Text,
                    hasLink = hasLink.Checked,
                    link = linkTextBox.Text,
                    hasPath = hasPath.Checked,
                    path = pathTextBox.Text,
                });
                if(imgList.Text == "" || imgList.Text == null)
                {
                    MF.JP.JDS.project[MF.JP.JDS.project.Count - 1].img.Add(new ProjectImg()
                    {
                        path = @"imgNotFound.png"
                    });
                } else
                {
                    var tempLines = imgList.Text.Split(new[] { '\r', '\n' });
                    for (int i=0; i < tempLines.Length; i++)
                    {
                        MF.JP.JDS.project[MF.JP.JDS.project.Count - 1].img.Add(new ProjectImg()
                        {
                            path = tempLines[i]
                        });
                    }
                }


                MF.JP.UpdateJsonFile();
                MF.UpdateListBox();
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
