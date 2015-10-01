using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CAZConsole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button_Init_Click(object sender, EventArgs e)
        {
            if (textBox_Triggers.Text == "")
            {
                Configuration oConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                textBox_Triggers.Text = oConfig.AppSettings.Settings["TriggersDefault"].Value;
            }
 
            if (checkedListBox1.Items.Count > 0)
            {
                checkedListBox1.Items.Clear();
            }

            //        textBox_Triggers.Text = "E:\\data\\ops\\setenvironmentvars.bat";
            string[] filePaths;
            try
            {
                filePaths = Directory.GetFiles(textBox_Triggers.Text, textBoxExtension.Text);
            } catch (Exception  err) 

            {
                 MessageBox.Show("Invalid Directory -- " + err.Message);
                 return;
            }
          

            foreach (string s in filePaths)
            {
                checkedListBox1.Items.Add(s, true);
            }


            foreach (string s in filePaths)
            {
                textBox1.Text += s + Environment.NewLine;
            }

            //textBox_Triggers.Text = System.Environment.GetEnvironmentVariable("CAZPrimaryServer");
            //    if (textBox_Triggers.Text == "")
            //    {
            //        //\E$\Data\Ops\Triggers
            //        //string strCmdText;
            //        //strCmdText = "E:\\data\\ops\\setenvironmentvars.bat";
            //        //strCmdText = "/C C:\\Data\\Documents\\Cumulus\\TestVars.bat";
            //        //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            //        //textBox_Triggers.Text = System.Environment.GetEnvironmentVariable("CAZPrimaryServer");
            //        textBox_Triggers.Text = "E:\\data\\ops\\setenvironmentvars.bat";
            //    }

        }

        private void textBox_Triggers_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            button_UnSel.Text = "UnSelect All";
            textBox1.Text = "";
            //for (int i =0;checkedListBox1.Items.Count;i++)
            foreach (var item in checkedListBox1.CheckedItems)
            {
                string name = item.ToString();
                int nameLength = name.IndexOf('_');

                File.Move(name, name.Substring(0, nameLength) + "_start");
                
            }

            checkedListBox1.Items.Clear();

            string[] filePaths = Directory.GetFiles(textBox_Triggers.Text, "*_start");

            foreach (string s in filePaths)
            {
                checkedListBox1.Items.Add(s, true);
                textBox1.Text += s + Environment.NewLine;
            }

        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            button_UnSel.Text = "UnSelect All";
            textBox1.Text = "";
            //for (int i =0;checkedListBox1.Items.Count;i++)
            foreach (var item in checkedListBox1.CheckedItems)
            {
                string name = item.ToString();
                int nameLength = name.IndexOf('_');

                File.Move(name, name.Substring(0, nameLength) + "_done");

            }
            checkedListBox1.Items.Clear();

            string[] filePaths = Directory.GetFiles(textBox_Triggers.Text, "*_done");

            foreach (string s in filePaths)
            {
                checkedListBox1.Items.Add(s, true);
                textBox1.Text += s + Environment.NewLine;
            }
        }

        private void button_UnSel_Click(object sender, EventArgs e)
        {
            if (button_UnSel.Text == "UnSelect All")
            {
                button_UnSel.Text = "Select All";
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }     
            } else
            {
                button_UnSel.Text = "UnSelect All";
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemCheckState(i,CheckState.Checked);
                }
                    
            }
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "E:\\Data\\Ops\\Triggers\\";
            folderBrowserDialog1.ShowDialog();
            textBox_Triggers.Text = folderBrowserDialog1.SelectedPath;

            Configuration oConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            oConfig.AppSettings.Settings["TriggersDefault"].Value = textBox_Triggers.Text;
            oConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void button_New_Click(object sender, EventArgs e)
        {



            if (textBox_NewMachine.Text != "")
            {
                try{

                    if (!File.Exists(textBox_Triggers.Text + textBox_NewMachine.Text + "_done")) File.Create(textBox_Triggers.Text + textBox_NewMachine.Text + "_done");

                    if (!File.Exists(textBox_Triggers.Text + textBox_NewMachine.Text + ".bat"))
                    {
                        string theText = File.ReadAllText(textBox_Triggers.Text + "AzureEZTemplate.bat");
                        theText = theText.Replace("THE_NEW_MACHINE_NAME", textBox_NewMachine.Text);
                        File.WriteAllText(textBox_Triggers.Text + textBox_NewMachine.Text + ".bat", theText);
                    }   
                } catch (Exception err)
                {
                    MessageBox.Show("Invalid file -- " + err.Message);
                }

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
