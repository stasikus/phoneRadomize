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

namespace phoneRadomize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        public string folder;

        private DialogResult STAShowDialog(FileDialog dialog)
        {
            DialogState state = new DialogState();
            state.dialog = dialog;
            System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.IsBackground = true;
            t.Join();
            return state.result;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
           try
           {
                String Location = String.Empty;
                OpenFileDialog frm = new OpenFileDialog();
                frm.InitializeLifetimeService();
                frm.Filter = "Config Files (*.txt)|*.txt";
                frm.Title = "Browse Config file";
                DialogResult ret = STAShowDialog(frm);

                if (ret == DialogResult.OK)
                    Location = frm.FileName;

                string path;
                if (Location != "")
                {
                    path = Location;
                    LoadList.loadGroupList(path);
                    loadFromFile_lbl.Text = LoadList.newList.Count.ToString();
                }
                else
                {
                    loadFromFile_lbl.Text = "0";
                }
            }
           catch
           {
               MessageBox.Show("Файл не загружен - что-то пошло не так...");
           }
        }

        private void randomize_btn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                
                dialog.Description = "Choose your directory";
                dialog.ShowNewFolderButton = false;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    folder = dialog.SelectedPath;
                }
            }
            panel1.Enabled = false;
            OutRandomInfo.saveToInfo(folder, panel1);
        }



    }
}
