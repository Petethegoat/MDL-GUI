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

namespace MDL_GUI
{
    public partial class Form1 : Form
    {
        string mdlCompilerExe = null;
        string mdlCompilerDir = null;

        string mdlDecompilerExe = null;
        string mdlDecompilerDir = null;

        string filePath = null;
        string fileDir = null;

        public Form1()
        {
            InitializeComponent();
            ReadSettings();
            UpdateInterface();
        }

        private void ReadSettings() //lol
        {
            if(File.Exists("settings.ini"))
            {
                string[] lines = File.ReadAllLines("settings.ini");
                foreach(string line in lines)
                {
                    char[] c = new char[]{':'};
                    string[] parts = line.Split(c, 2);
                    switch(parts[0])
                    {
                        case "compilerDir":
                            mdlCompilerDir = parts[1];
                            break;
                        case "compilerExe":
                            mdlCompilerExe = parts[1];
                            break;
                        case "decompilerDir":
                            mdlDecompilerDir = parts[1];
                            break;
                        case "decompilerExe":
                            mdlDecompilerExe = parts[1];
                            break;
                        case "fileDir":
                            fileDir = parts[1];
                            break;
                        case "filePath":
                            filePath = parts[1];
                            break;
                    }
                }
            }
        }

        private void WriteSettings() //lol
        {
            string[] lines = new string[6];
            lines[0] = "compilerDir:" + mdlCompilerDir;
            lines[1] = "compilerExe:" + mdlCompilerExe;
            lines[2] = "decompilerDir:" + mdlDecompilerDir;
            lines[3] = "decompilerExe:" + mdlDecompilerExe;
            lines[4] = "fileDir:" + fileDir;
            lines[5] = "filePath:" + filePath;
            File.WriteAllLines("settings.ini", lines);
        }

        private void UpdateInterface()
        {
            decompMenu.Image = null;
            if(mdlDecompilerExe != null)
            {
                decompMenu.ToolTipText = mdlDecompilerDir + "\\" + mdlDecompilerExe;
                decompMenu.Image = Properties.Resources.tick;
            }

            compMenu.Image = null;
            if(mdlCompilerExe != null)
            {
                compMenu.ToolTipText = mdlCompilerDir + "\\" + mdlCompilerExe;
                compMenu.Image = Properties.Resources.tick;
            }

            if(filePath != null && filePath != "\\")
            {
                textBoxTarget.Text = fileDir + "\\" + filePath;
                switch(Path.GetExtension(filePath))
                {
                    case ".qc":
                        {
                            buttonCompile.Text = "Compile";
                            buttonCompile.Enabled = true;
                            break;
                        }
                    case ".mdl":
                        {
                            buttonCompile.Text = "Decompile";
                            buttonCompile.Enabled = true;
                            break;
                        }
                    default:
                        {
                            buttonCompile.Text = "Unrecognized Extension";
                            buttonCompile.Enabled = false;
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

        private void buttonCompile_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(fileDir);
            switch(Path.GetExtension(filePath))
            {
                case ".qc":
                    {
                        CMD(mdlCompilerDir + "\\" + mdlCompilerExe, fileDir + "\\" + filePath);
                        break;
                    }
                case ".mdl":
                    {
                        CMD(mdlDecompilerDir + "\\" + mdlDecompilerExe, fileDir + "\\" + filePath);
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
            filePath = Path.GetFileName(files[0]);
            fileDir = Path.GetDirectoryName(files[0]);
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
            dialog.FileName = mdlDecompilerExe;
            dialog.InitialDirectory = mdlDecompilerDir;
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                mdlDecompilerExe = dialog.SafeFileName;
                mdlDecompilerDir = Path.GetDirectoryName(dialog.FileName);
                UpdateInterface();
            }
        }

        private void compMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select MDL Compiler";
            dialog.FileName = mdlCompilerExe;
            dialog.InitialDirectory = mdlCompilerDir;
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                mdlCompilerExe = dialog.SafeFileName;
                mdlCompilerDir = Path.GetDirectoryName(dialog.FileName);
                UpdateInterface();
            }
        }

        private void buttonBrowseTarget_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Target File";
            dialog.FileName = filePath;
            dialog.InitialDirectory = fileDir;
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                filePath = dialog.SafeFileName;
                fileDir = Path.GetDirectoryName(dialog.FileName);
                UpdateInterface();
            }
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
            processStartInfo.CreateNoWindow = false;

            Process process = new Process();
            process.StartInfo = processStartInfo;
            bool processStarted = process.Start();

            StreamWriter inputWriter = process.StandardInput;
            StreamReader outputReader = process.StandardOutput;
            StreamReader errorReader = process.StandardError;
            process.WaitForExit();

            textBoxConsole.Text = outputReader.ReadToEnd();
        }

        private void buttonGotoTarget_Click(object sender, EventArgs e)
        {
            Process.Start(@fileDir);
        }

        private void byPetethegoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/petethegoat/");
        }

        private void forkMeOnGithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Petethegoat/MDL-GUI");
        }
    }
}
