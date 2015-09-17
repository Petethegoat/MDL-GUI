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
        private bool ValidPath(string path)
        {
            if(path != null && path.Length > 0)
            {
                return true;
            }
            return false;
        }

        private string GetFolderPath(string path)
        {
            if(ValidPath(path) && Path.GetDirectoryName(path) != null)
            {
                if(Path.HasExtension(path))
                {
                    return Path.GetDirectoryName(path);
                }
                return filePath;
            }
            else if(ValidPath(prefFilePath))
            {
                return prefFilePath;
            }
            else
            {
                return Directory.GetCurrentDirectory();
            }
        }

        private void ReadSettings() //lol
        {
            if(File.Exists("settings.ini"))
            {
                string[] lines = File.ReadAllLines("settings.ini");
                foreach(string line in lines)
                {
                    char[] c = new char[] { ':' };
                    string[] parts = line.Split(c, 2);
                    switch(parts[0])
                    {
                        case "compiler_path":
                            mdlCompilerPath = parts[1];
                            break;
                        case "decompiler_path":
                            mdlDecompilerPath = parts[1];
                            break;
                        case "last_file_path":
                            filePath = parts[1];
                            break;
                        case "pref_file_path":
                            if(parts[1].Length > 0)
                            {
                                prefFilePath = parts[1];
                                filePath = parts[1];
                            }
                            break;
                    }
                }
            }
        }

        private void WriteSettings() //lol
        {
            string[] lines = new string[4];
            lines[0] = "compiler_path:" + mdlCompilerPath;
            lines[1] = "decompiler_path:" + mdlDecompilerPath;
            lines[2] = "last_file_path:" + filePath;
            lines[3] = "pref_file_path:" + prefFilePath;
            File.WriteAllLines("settings.ini", lines);
        }
    }
}
