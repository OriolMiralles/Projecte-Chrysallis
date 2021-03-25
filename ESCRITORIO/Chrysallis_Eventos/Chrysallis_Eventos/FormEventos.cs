using Chrysallis_Eventos.MODELOS;
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
    public partial class FormEventos : Form
    {
        public FormEventos()
        {
            InitializeComponent();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            String missatge = "";



            if (User.SuperAdmin)
            {
                bindingSourceComboComuni.DataSource = ComunitatsOrm.Select(ref missatge);
                comboBoxComunidades.SelectedIndex = 7;
            }
            else
            {
                List<usuaris> _usuaris = AdminOrm.Select(ref missatge, User.id);

                bindingSourceComboComuni.DataSource = _usuaris[0].comunitats.ToList();
            }


            if (!missatge.Equals(""))
            {
                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void comboBoxComunidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            String missatge = "";
            List<esdeveniments> esdeveniments = EventosOrm.Select(ref missatge, (comunitats)comboBoxComunidades.SelectedItem);
            if(esdeveniments.Count > 0)
            {
                bindingSourceComboComuni.DataSource = esdeveniments;
            }
            

        }

        private void toolStripButtonAddEvent_Click(object sender, EventArgs e)
        {
            FormInsertarEventos formInsertarEventos = new FormInsertarEventos((comunitats)comboBoxComunidades.SelectedItem);
            formInsertarEventos.ShowDialog();
        }

        private void toolStripButtonEditEvent_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.Rows[0].DataBoundItem != null)
            {
                esdeveniments esdeveniment = (esdeveniments) dataGridViewEvents.Rows[0].DataBoundItem;
                comunitats comunitat = (comunitats)comboBoxComunidades.SelectedItem;
                FormInsertarEventos formInsertarEventos = new FormInsertarEventos(esdeveniment, comunitat);
                formInsertarEventos.ShowDialog();
            }

        }
    }
}
