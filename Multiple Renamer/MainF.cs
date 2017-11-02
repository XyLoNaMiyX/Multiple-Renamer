using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;

namespace Multiple_Renamer
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        private void folderB_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            folderTB.Text = fd.SelectedPath;
        }

        private void renameB_Click(object sender, EventArgs e)
        {
            if (filesLB.Items.Count > 3999 && (nRomanRB.Checked || nRomanLowerRB.Checked)) {
                MessageBox.Show("Se han seleccionado demasiados archivos como para poder renombrarlos utilizando " +
                "los numeros romanos. El máximo de archivos permitidos es 3999.",
                "Archivos no renombrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string oriText = Text;
            Text += " (renombrando...)";
            Cursor = Cursors.WaitCursor;

            string prefix = prefixTB.Text;
            string suffix = suffixTB.Text;
            if (folderRB.Checked) {
                string folder = folderTB.Text;
                DirectoryInfo dir = new DirectoryInfo(folder);

                int i = (int)startFrom.Value;
                try {
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        string fPath = file.DirectoryName;
                        string name = file.Name;
                        string fEx = file.Extension;

                        string index = i.ToString();
                        if (nHexRB.Checked)
                            index = i.ToString("X");
                        else if (nRomanRB.Checked)
                            index = GetRomanNumber(i);
                        else if (nRomanLowerRB.Checked)
                            index = GetRomanNumberLower(i);

                        name = prefix + i + suffix;
                        file.MoveTo(fPath + "\\" + name + fEx);
                        i++;
                    }
                    Prompt(true);
                }
                catch {
                    Prompt(false);
                }
            } else {
                try {
                    int i = (int)startFrom.Value;
                    foreach (var fileO in filesLB.Items) {
                        string file = (string)fileO;
                        string path = Path.GetDirectoryName(file);
                        string index = i.ToString();
                        if (nHexRB.Checked)
                            index = i.ToString("X");
                        else if (nRomanRB.Checked)
                            index = GetRomanNumber(i);
                        else if (nRomanLowerRB.Checked)
                            index = GetRomanNumberLower(i);

                        File.Move(file, path + "\\" + prefix + index + suffix + Path.GetExtension(file));
                        i++;
                    }
                    Prompt(true);
                    filesLB.Items.Clear();
                } catch {
                    Prompt(false);
                }
            }

            Text = oriText;
            Cursor = Cursors.Arrow;
        }

        void Prompt(bool success) {
            if (success)
                MessageBox.Show("¡Los archivos se han renombrado correctamente!", "Archivos renombrados",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudieron renombrar todos los archivos. Tal vez, algunos se encuentren " +
                "en uso (de ser así, ciérrelos y vuelva a intentarlo) o no se disponga de los permisos necesarios " +
                "(si ya existe un archivo con este nombre, no se sobreescribirá por motivos de seguridad).",
                "Archivos no renombrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void checkUpdatesB_Click(object sender, EventArgs e) {
            new UpdateChecker.UpdateChecker(System.Reflection.Assembly.GetExecutingAssembly().Location, "renamer").Show();
        }

        private void filesLB_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        private void filesLB_DragDrop(object sender, DragEventArgs e) {
            AddToList((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void addFilesB_Click(object sender, EventArgs e)
        {
            if (addFilesOFD.ShowDialog() == DialogResult.OK)
                AddToList(addFilesOFD.FileNames);
        }

        void AddToList(string[] items) {
            foreach (var item in items)
                if (!filesLB.Items.Contains(item))
                    filesLB.Items.Add(item);
        }

        #region GetRoman

        public static string GetRomanNumber(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("¡El valor es demasiado grande para los números romanos!");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + GetRomanNumber(number - 1000);
            if (number >= 900) return "CM" + GetRomanNumber(number - 900);
            if (number >= 500) return "D" + GetRomanNumber(number - 500);
            if (number >= 400) return "CD" + GetRomanNumber(number - 400);
            if (number >= 100) return "C" + GetRomanNumber(number - 100);
            if (number >= 90) return "XC" + GetRomanNumber(number - 90);
            if (number >= 50) return "L" + GetRomanNumber(number - 50);
            if (number >= 40) return "XL" + GetRomanNumber(number - 40);
            if (number >= 10) return "X" + GetRomanNumber(number - 10);
            if (number >= 9) return "IX" + GetRomanNumber(number - 9);
            if (number >= 5) return "V" + GetRomanNumber(number - 5);
            if (number >= 4) return "IV" + GetRomanNumber(number - 4);
            if (number >= 1) return "I" + GetRomanNumber(number - 1);
            throw new ArgumentOutOfRangeException("Algo no ha ido bien.");
        }
        public static string GetRomanNumberLower(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("¡El valor es demasiado grande para los números romanos!");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "m" + GetRomanNumberLower(number - 1000);
            if (number >= 900) return "cm" + GetRomanNumberLower(number - 900);
            if (number >= 500) return "d" + GetRomanNumberLower(number - 500);
            if (number >= 400) return "cd" + GetRomanNumberLower(number - 400);
            if (number >= 100) return "c" + GetRomanNumberLower(number - 100);
            if (number >= 90) return "xc" + GetRomanNumberLower(number - 90);
            if (number >= 50) return "l" + GetRomanNumberLower(number - 50);
            if (number >= 40) return "xl" + GetRomanNumberLower(number - 40);
            if (number >= 10) return "x" + GetRomanNumberLower(number - 10);
            if (number >= 9) return "ix" + GetRomanNumberLower(number - 9);
            if (number >= 5) return "v" + GetRomanNumberLower(number - 5);
            if (number >= 4) return "iv" + GetRomanNumberLower(number - 4);
            if (number >= 1) return "i" + GetRomanNumberLower(number - 1);
            throw new ArgumentOutOfRangeException("Algo no ha ido bien.");
        }

        #endregion

        private void filesLB_SelectedIndexChanged(object sender, EventArgs e) {
            removeSelectedB.Enabled = filesLB.SelectedIndex > -1;
        }

        private void clearListB_Click(object sender, EventArgs e) {
            filesLB.Items.Clear();
        }

        private void removeSelectedB_Click(object sender, EventArgs e)
        {
            int c = filesLB.Items.Count;
            int d = filesLB.SelectedItems.Count;
            string[] items = new string[c];
            for (int i = 0; i < d; i++)
                filesLB.Items[filesLB.SelectedIndices[i]] = "";
            for (int i = 0; i < c; i++)
                items[i] = (string)filesLB.Items[i];

            items = items.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            filesLB.Items.Clear();
            filesLB.Items.AddRange(items);

            removeSelectedB.Enabled = filesLB.SelectedIndex > -1;
        }

        private void spamLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("http://lonamiwebs.github.io");
        }

        private void folderTB_TextChanged(object sender, EventArgs e) {
            CanRename();
        }

        private void customFilesRB_CheckedChanged(object sender, EventArgs e) {
            CanRename();
        }

        void CanRename() {
            if (folderRB.Checked) 
                renameB.Enabled = Directory.Exists(folderTB.Text);
            else
                renameB.Enabled = true;
        
            folderTB.Enabled = folderB.Enabled = folderRB.Checked;
            filesLB.Enabled = clearListB.Enabled = removeSelectedB.Enabled = addFilesB.Enabled = !folderRB.Checked;
        }
    }
}
