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
    public partial class FormUsuaris : Form
    {
        public const int COMUNIDAD_POR_DEFECTO = 7;
        List<socis> _socis;
        public FormUsuaris()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormUsuaris_Load(object sender, EventArgs e)
        {
            String missatge = "";
                    

            if (User.SuperAdmin)
            {            
                comboBoxComunidades.DataSource = ComunitatsOrm.Select(ref missatge);
                comboBoxComunidades.SelectedIndex = COMUNIDAD_POR_DEFECTO;
            }
            else
            {
                List<usuaris> _usuaris = AdminOrm.Select(ref missatge, User.id);

                comboBoxComunidades.DataSource = _usuaris[0].comunitats.ToList();
            }
           

            if (!missatge.Equals(""))
            {
                MessageBox.Show(missatge,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                cargarGrid();
            }

        }

        private void toolStripButtonAddUser_Click(object sender, EventArgs e)
        {
            FormInsertarUsuario fiu = new FormInsertarUsuario((comunitats)comboBoxComunidades.SelectedItem);
            fiu.ShowDialog();
           // cargarGrid();
        }

        private void toolStripButtonEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 1)
            {
                FormInsertarUsuario fiu = new FormInsertarUsuario((socis)dataGridViewUsers.SelectedRows[0].DataBoundItem, (comunitats)comboBoxComunidades.SelectedItem);
                fiu.ShowDialog();
               // cargarGrid();
            }
            else
            {
                MessageBox.Show("Seleccionar un usuarie de la grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxComunidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            String missatge = "";
            _socis = UsuarioOrm.Select(ref missatge, (comunitats)comboBoxComunidades.SelectedItem);
            bindingSourceUsuarios.DataSource = _socis;
        }

       private void cargarGrid()
        {
            String missatge = "";
           
            if (checkBoxActivo.Checked)
            {
                _socis = UsuarioOrm.Select(ref missatge, (comunitats)comboBoxComunidades.SelectedItem, checkBoxActivo.Checked);
                bindingSourceUsuarios.DataSource = null;
                bindingSourceUsuarios.DataSource = _socis;
            }
            else
            {
                _socis = UsuarioOrm.Select(ref missatge, (comunitats)comboBoxComunidades.SelectedItem);
                bindingSourceUsuarios.DataSource = null;
                bindingSourceUsuarios.DataSource = _socis;
            }
            
            
        }

        private void FormUsuaris_Activated(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void textBoxBuscarUser_TextChanged(object sender, EventArgs e)
        {
            List<socis> llistaFiltrada = null;

            llistaFiltrada = new List<socis>(_socis.Where(s => s.nom.ToLower().Contains(textBoxBuscarUser.Text.ToLower())|| s.cognoms.ToLower().Contains(textBoxBuscarUser.Text.ToLower())).ToList());

            bindingSourceUsuarios.DataSource = llistaFiltrada;
        }

        private void checkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 1)
            {
                FormResetPass fr = new FormResetPass((socis)dataGridViewUsers.SelectedRows[0].DataBoundItem);
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccionar un usuarie de la grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
