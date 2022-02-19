using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_Main {
    public partial class Bienvenida : Form {
        public Bienvenida() {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e) {
            Form main = new Main();
            main.ShowDialog();
        }
    }
}
