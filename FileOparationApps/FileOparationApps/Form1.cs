using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileOparationApps
{
    public partial class FileOparationApps : Form
    {
        public FileOparationApps()
        {
            InitializeComponent();
        }

        private string fileLocation = @"B:/emon.txt";

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream aFileStream=new FileStream(fileLocation,FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(txtEnterName.Text + "_");
            aStreamWriter.Write(textBox1.Text);

            aStreamWriter.WriteLine();
            aStreamWriter.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FileStream aFileStream=new FileStream(fileLocation,FileMode.Open);
            StreamReader aStreamReader=new StreamReader(aFileStream);
            EnterNameListBox.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                string aLine = aStreamReader.ReadLine();
                EnterNameListBox.Items.Add(aLine);
            }
            aStreamReader.Close();
        }
    }
}
