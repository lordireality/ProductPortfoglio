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
using System.IO;

namespace ProductPortfoglio
{
    
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
       
        public MainForm()
        {
            InitializeComponent();
            UpdateListBox();
            RenderNone();
        }
        public JsonParse JP = new JsonParse();
        int structId = 0;
        int curImgId = 0;

        private void nextImgBtn_Click(object sender, EventArgs e)
        {
            ProcessImage("next");
        }
        public void ProcessImage(string type)
        {
            if(type == "next")
            {
                curImgId += 1;
                if (curImgId - 1 < 0)
                {
                    prevImgBtn.Enabled = false;
                }
                else
                {
                    prevImgBtn.Enabled = true;
                }
                if (curImgId + 1 >= JP.JDS.project[structId].img.Count)
                {
                    nextImgBtn.Enabled = false;
                } else
                {
                    nextImgBtn.Enabled = true;
                }
            } else if (type == "previous")
            {
                curImgId -= 1;
                if(curImgId - 1 < 0)
                {
                    prevImgBtn.Enabled = false;
                } else
                {
                    prevImgBtn.Enabled = true;
                }
                if (curImgId + 1 >= JP.JDS.project[structId].img.Count)
                {
                    nextImgBtn.Enabled = false;
                }
                else
                {
                    nextImgBtn.Enabled = true;
                }
            } else { return; }
            if (File.Exists(@"./images/" + JP.JDS.project[structId].img[curImgId].path))
            {
                pictureBox1.Image = Image.FromFile(@"./images/" + JP.JDS.project[structId].img[curImgId].path);
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"./images/imgNotFound.png");
            }
            pictureNumLabel.Text = "Изображение" + (curImgId + 1) + "/" + JP.JDS.project[structId].img.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessImage("previous");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var AF = new AddForm(this);
                AF.ShowDialog();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Произошла ошибка");
            }
        }
        public void UpdateListBox()
        {
            JP.ReadJsonFile();
            projectList.Items.Clear();
            for (int i = 0; i < JP.JDS.project.Count; i++)
            {
                projectList.Items.Add(JP.JDS.project[i].name);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void projectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProjectInfo(projectList.SelectedIndex);
            }
            catch { return;  }
            
        }
        public void LoadProjectInfo(int projid)
        {
            RenderAll();
            structId = projid;
            projectNameLabel.Text = JP.JDS.project[structId].name;
            projectDescTextBox.Text = JP.JDS.project[structId].desc;
            if (File.Exists(@"./images/" + JP.JDS.project[structId].img[0].path)){
                pictureBox1.Image = Image.FromFile(@"./images/"+JP.JDS.project[structId].img[0].path);
                
            } else
            {
                pictureBox1.Image = Image.FromFile(@"./images/imgNotFound.png");
            }
            curImgId = 0;
            pictureNumLabel.Text = "Изображение "+ (curImgId+1) + "/" + JP.JDS.project[structId].img.Count;
            if (curImgId - 1 < 0)
            {
                prevImgBtn.Enabled = false;
            }
            else
            {
                prevImgBtn.Enabled = true;
            }
            if (curImgId + 1 >= JP.JDS.project[structId].img.Count)
            {
                nextImgBtn.Enabled = false;
            }
            else
            {
                nextImgBtn.Enabled = true;
            }


            if (JP.JDS.project[structId].hasPath)
            {
                execApp.Enabled = true;
            } else
            {
                execApp.Enabled = false;
            }

            if (JP.JDS.project[structId].hasLink)
            {
                openInBrowser.Enabled = true;
            }
            else
            {
                openInBrowser.Enabled = false;
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void openInBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(JP.JDS.project[structId].link);
            } catch
            {
                System.Windows.Forms.MessageBox.Show("Произошла ошибка. Пожалуйста проверьте правильность написания ссылки. Ссылка должна начинаться с HTTP:// или HTPPS://");
            }
            
        }

        private void execApp_Click(object sender, EventArgs e)
        {
            if (JP.isFileExist(JP.JDS.project[structId].path))
            {
                System.Diagnostics.Process.Start(JP.JDS.project[structId].path);
            } else
            {
                System.Windows.Forms.MessageBox.Show("Не найден исполняемый файл! Пожалуйста проверьте правильность написания пути");
            }
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var EF = new EditForm(this, structId);
                EF.ShowDialog();
            } catch
            {
                System.Windows.Forms.MessageBox.Show("Произошла ошибка");
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            JP.JDS.project.RemoveAt(structId);
            JP.UpdateJsonFile();
            UpdateListBox();
            if(JP.JDS.project.Count > 0)
            {
                LoadProjectInfo(0);
                RenderAll();
            } else
            {
                RenderNone();
            }
            
        }
        public void RenderNone()
        {
            ProjectPanel.Hide();
        }
        public void RenderAll()
        {
            ProjectPanel.Show();
        }
    }
}
