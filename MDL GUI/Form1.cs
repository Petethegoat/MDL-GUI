using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;
using Ookii.Dialogs;

namespace MDL_GUI
{
    public partial class Form1 : Form
    {
        string mdlCompilerPath = null;

        string mdlDecompilerPath = null;

        string filePath = null;
        string prefFilePath = null; //only used for setting default path

        public Form1()
        {
            InitializeComponent();
            ReadSettings();
            UpdateInterface();
        }

        private void UpdateInterface()
        {
            decompMenu.ToolTipText = null;
            decompMenu.Image = null;
            if(ValidPath(mdlDecompilerPath))
            {
                decompMenu.ToolTipText = mdlDecompilerPath;
                decompMenu.Image = Properties.Resources.tick;
            }

            compMenu.ToolTipText = null;
            compMenu.Image = null;
            if(ValidPath(mdlCompilerPath))
            {
                compMenu.ToolTipText = mdlCompilerPath;
                compMenu.Image = Properties.Resources.tick;
            }

            defaultDirMenu.ToolTipText = null;
            defaultDirMenu.Image = null;
            unsetDefaultDir.Enabled = false;
            if(ValidPath(prefFilePath))
            {
                defaultDirMenu.ToolTipText = prefFilePath;
                defaultDirMenu.Image = Properties.Resources.tick;
                unsetDefaultDir.Enabled = true;
            }

            if(ValidPath(filePath) && filePath != "\\")
            {
                textBoxTarget.Text = filePath;
                switch(Path.GetExtension(filePath))
                {
                    case ".qc":
                        {
                            buttonCompile.Text = "Compile";
                            buttonCompile.Enabled = true;
                            buttonGotoTarget.Enabled = true;
                            break;
                        }
                    case ".mdl":
                        {
                            buttonCompile.Text = "Decompile";
                            buttonCompile.Enabled = true;
                            buttonGotoTarget.Enabled = true;
                            break;
                        }
                    case "":
                        {
                            buttonCompile.Text = "Compile";
                            buttonCompile.Enabled = false;
                            buttonGotoTarget.Enabled = false;
                            break;
                        }
                    default:
                        {
                            buttonCompile.Text = "Unrecognized Extension";
                            buttonCompile.Enabled = false;
                            buttonGotoTarget.Enabled = false;
                            break;
                        }
                }
            }
            else
            {
                buttonCompile.Text = "Compile";
                buttonCompile.Enabled = false;
            }
            WriteSettings();
        }

        private void CMD(string prog, string arguments)
        {
            var processStartInfo = new ProcessStartInfo(prog);

            processStartInfo.UseShellExecute = false;
            processStartInfo.ErrorDialog = false;
            processStartInfo.Arguments = arguments;

            processStartInfo.RedirectStandardError = true;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = processStartInfo;
            bool processStarted = process.Start();

            StreamWriter inputWriter = process.StandardInput;
            StreamReader outputReader = process.StandardOutput;
            StreamReader errorReader = process.StandardError;
            process.WaitForExit();

            textBoxConsole.Text = outputReader.ReadToEnd();
        }

        private void buttonCompile_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(Path.GetDirectoryName(filePath));
            switch(Path.GetExtension(filePath))
            {
                case ".qc":
                    {
                        CMD(mdlCompilerPath, filePath);
                        break;
                    }
                case ".mdl":
                    {
                        CMD(mdlDecompilerPath, filePath);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if(files.Length > 1)
            {
                return;
            }
            filePath = files[0];
            UpdateInterface();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void decompMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select MDL Decompiler";
            dialog.FileName = Path.GetFileName(mdlDecompilerPath);
            dialog.InitialDirectory = GetFolderPath(mdlDecompilerPath);
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                mdlDecompilerPath = dialog.FileName;
                UpdateInterface();
            }
        }

        private void compMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select MDL Compiler";
            dialog.FileName = Path.GetFileName(mdlCompilerPath);
            dialog.InitialDirectory = GetFolderPath(mdlCompilerPath);
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                mdlCompilerPath = dialog.FileName;
                UpdateInterface();
            }
        }

        private void buttonBrowseTarget_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Target File";
            dialog.FileName = Path.GetFileName(filePath);
            dialog.InitialDirectory = GetFolderPath(filePath);
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                filePath = dialog.FileName;
                UpdateInterface();
            }
        }

        private void buttonGotoTarget_Click(object sender, EventArgs e)
        {
            if(ValidPath(filePath))
            {
                Process.Start(@Path.GetDirectoryName(filePath));
            }
        }

        private void byPetethegoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/petethegoat/");
        }

        private void forkMeOnGithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Petethegoat/MDL-GUI");
        }

        private void unsetDefaultDir_Click(object sender, EventArgs e)
        {
            prefFilePath = null;
            UpdateInterface();
        }

        private void setDefaultDir_Click(object sender, EventArgs e)
        {
            Ookii.Dialogs.VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog();
            dialog.Description = "Select Default Directory";
            dialog.SelectedPath = GetFolderPath(filePath);
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                prefFilePath = dialog.SelectedPath;
                UpdateInterface();
            }
        }
    }
}
