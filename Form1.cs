using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csapat_jegy_05_27 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
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

        }
    }
}