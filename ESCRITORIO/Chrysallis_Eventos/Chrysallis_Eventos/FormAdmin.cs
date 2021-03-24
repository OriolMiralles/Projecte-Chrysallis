using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chrysallis_Eventos.MODELOS;
namespace Chrysallis_Eventos
{
    public partial class FormAdmin : Form
    {
        List<usuaris> _usuaris;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            
            if (User.SuperAdmin)
            {
                String missatge = "";
                _usuaris = AdminOrm.Select(ref missatge);
            }
            else
            {
                String missatge = "";
                _usuaris = AdminOrm.Select(ref missatge, User.id);
                toolStripButtonAnadir.Enabled = false;
                toolStripButtonModificar.Enabled = false;
            }
            bindingSourceUsuaris.DataSource = _usuaris.ToList();
        }

        private void dataGridViewUsuaris_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                usuaris _user = (usuaris)dataGridViewUsuaris.Rows[e.RowIndex].DataBoundItem;
                if (_user != null)
                {
                    e.Value = _user.rols.nom;
                }
            }
        }

        private void toolStripButtonAnadir_Click(object sender, EventArgs e)
        {
            FormCrearAdmin formCrear = new FormCrearAdmin();
            formCrear.ShowDialog();
            refrescarGrid();
        }

        private void toolStripButtonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuaris.SelectedRows.Count == 1)
            {
                FormCrearAdmin formCrear = new FormCrearAdmin((usuaris)dataGridViewUsuaris.SelectedRows[0].DataBoundItem);
                formCrear.ShowDialog();
                refrescarGrid();
            }
            else
            {
                MessageBox.Show("Seleccionar un usuario de la grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public void refrescarGrid()
        {
            String missatge = "";
            _usuaris = AdminOrm.Select(ref missatge);
            bindingSourceUsuaris.DataSource = null;
            bindingSourceUsuaris.DataSource = _usuaris;
        }

        private void toolStripButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonPass_Click(object sender, EventArgs e)
        {
            if(dataGridViewUsuaris.SelectedRows.Count == 1)
            {
                FormResetPass fr = new FormResetPass((usuaris)dataGridViewUsuaris.SelectedRows[0].DataBoundItem);
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccionar un usuario de la grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
