using System;
using System.Windows.Forms;

namespace MT_Main {
    public partial class Bienvenida : Form {
        public Bienvenida() {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e) {
            Hide();
            Form main = new Main();
            main.FormClosed += (s, args) => Close();
            main.Show();
        }
    }
}
