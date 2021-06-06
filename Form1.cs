using Mono.Cecil;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace nigfuscator
{
    public partial class Form1 : Form
    {

        String asmFile = string.Empty;
        String justName = "niggerslol.dll";
        String outputFolder = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectProjectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialogue = new OpenFileDialog())
            {
             
                if (openFileDialogue.ShowDialog() == DialogResult.OK)
                {
                    asmFile = openFileDialogue.FileName;
                    SelectOutputFolderButton.Enabled = true;
                }
            }

        }

        private void SelectOutputFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFolderDialogue = new FolderBrowserDialog())
            {

                if (openFolderDialogue.ShowDialog() == DialogResult.OK)
                {
                    outputFolder = openFolderDialogue.SelectedPath;
                    SelectOutputFolderButton.Enabled = true;
                }
            }
            NiggersLolButton.Enabled = true;
        }

        private void NiggersLolButton_Click(object sender, EventArgs e)
        {
            AssemblyDefinition asm = AssemblyDefinition.ReadAssembly(asmFile);
            var numberOfNiggers = 0;
            foreach (TypeDefinition t in asm.MainModule.Types)
            {
                if (!(t.Name == "<Module>"))//global type
                {
                    foreach (MethodDefinition m in t.Methods)
                    {
                        Console.WriteLine(m.Name);
                        m.Name = "NiggersLol" + numberOfNiggers;
                        numberOfNiggers++;
                       
                        // You better use a random name & an array where you can put
                        // names that has been already used in order to avoid having twice
                        // the same name
                    }
                }
            }
         //   asm.MainModule.Write(Path.Combine(outputFolder, justName));

        }
    }
}
