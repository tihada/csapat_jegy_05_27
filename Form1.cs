using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csapat_jegy_05_27 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        List<string> nevek = new List<string>();
        List<string> gyumolcsok = new List<string>();

        public void OnFilterTxtBoxChange(object sender, List<string> tofilter) {
            var filterTxtBox = sender as TextBox;
            string filter = filterTxtBox.Text;

            string lbName = $"{filterTxtBox.Name.Replace("_textBox", "")}_listBox";
            ListBox lb = (GetListBoxByName(lbName) as ListBox);

            lb.Items.Clear();

            if (filter == "") {
                foreach (var item in tofilter) {
                    lb.Items.Add(item);
                }
            }
            else {
                foreach (var item in tofilter) {
                    if (Regex.IsMatch(item.ToString(), filter)) {
                        lb.Items.Add(item);
                    }
                }
            }
        }

        public object GetListBoxByName(string listBoxName) {
            var listBox = this.Controls.Find(listBoxName, true).FirstOrDefault() as ListBox;
            if (listBox != null) {
                return listBox;
            }
            return new object[0];
        }

        private void kilépToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Biztosan kilép?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Tihanyi Ádám - Vörös Dávid\n2026.06.27", "Információk", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void beolvasHandler(object sender, EventArgs e) {
            if ((sender as ToolStripMenuItem).Text == "Nevek") {
                nevek = beolvasas();
                updateListbox(names_listBox, nevek);
            } else  {
                gyumolcsok = beolvasas();
                updateListbox(fruits_listBox, gyumolcsok);
            }

        }

        private List<string> beolvasas() {
            List<string> cont = new List<string>();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Fájl beolvasása";
            ofd.Filter = "Szöveges fájl|*.txt|Minden fájl|*.*";
            ofd.ShowDialog();
            string[] lines;
            try {
                lines = File.ReadAllLines(ofd.FileName);
            } catch {
                MessageBox.Show("Hiba a fájl beolvasásakor!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return cont;
            }
            cont.AddRange(lines);
            return cont;
        }

        private void updateListbox(ListBox lb, List<string> cont) {
            lb.Items.Clear();
            lb.Items.AddRange(cont.ToArray());
        }

        private void fruits_textBox_TextChanged(object sender, EventArgs e) {
            OnFilterTxtBoxChange(sender, gyumolcsok);
        }

        private void names_textBox_TextChanged(object sender, EventArgs e) {
            OnFilterTxtBoxChange(sender, nevek);
        }

        private void add_button_Click(object sender, EventArgs e) {
            if (names_listBox.SelectedItem != null && fruits_listBox.SelectedItem != null) {
                string selectedName = names_listBox.SelectedItem.ToString();
                string selectedFruit = fruits_listBox.SelectedItem.ToString();

                string entry = $"{selectedName} - {selectedFruit}";
                favourits_listBox.Items.Add(entry);
                names_listBox.Items.RemoveAt(names_listBox.SelectedIndex);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (names_listBox.SelectedItem != null && fruits_listBox.SelectedItem != null) {
                add_button.Enabled = true;
            }
            else {
                add_button.Enabled = false;
            }
        }
    }
}