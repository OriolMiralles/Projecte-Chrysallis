using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis_Eventos
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            FormLoggin formLoggin = new FormLoggin();
            formLoggin.ShowDialog();
        }

        private void buttonEventos_Click(object sender, EventArgs e)
        {
            FormEventos formEventos = new FormEventos();
            formEventos.ShowDialog();
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuaris fu = new FormUsuaris();
            fu.ShowDialog();
        }

        private void buttonSocies_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLoggin formLog = new FormLoggin();
            formLog.Show();
        }
    }
}
