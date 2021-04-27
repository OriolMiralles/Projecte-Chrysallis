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
        List<esdeveniments> esdeveniments = new List<esdeveniments>();
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
                refrescarGrid();
            }
            else
            {
                List<usuaris> _usuaris = AdminOrm.Select(ref missatge, User.id);

                bindingSourceComboComuni.DataSource = _usuaris[0].comunitats.ToList();
                refrescarGrid();
            }


            if (!missatge.Equals(""))
            {
                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void comboBoxComunidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescarGrid();

        }

        private void toolStripButtonAddEvent_Click(object sender, EventArgs e)
        {
            FormInsertarEventos formInsertarEventos = new FormInsertarEventos((comunitats)comboBoxComunidades.SelectedItem);
            formInsertarEventos.ShowDialog();
            refrescarGrid();
        }

        private void toolStripButtonEditEvent_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count == 1)
            {
                esdeveniments esdeveniment = (esdeveniments) dataGridViewEvents.SelectedRows[0].DataBoundItem;
                comunitats comunitat = (comunitats)comboBoxComunidades.SelectedItem;
                FormInsertarEventos formInsertarEventos = new FormInsertarEventos(esdeveniment, comunitat);
                formInsertarEventos.ShowDialog();
            }

        }

        private void refrescarGrid()
        {
            String missatge = "";

                esdeveniments = EventosOrm.Select(ref missatge, (comunitats)comboBoxComunidades.SelectedItem);

                bindingSourceGridEventos.DataSource = null;
                bindingSourceGridEventos.DataSource = esdeveniments;

        }

        private void toolStripButtonDelEvent_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count == 1)
            {
                String missatge = "";
                esdeveniments esdev = (esdeveniments)dataGridViewEvents.SelectedRows[0].DataBoundItem;
                
                DialogResult dg = MessageBox.Show("Estás segure que quieres borrar el evento?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    missatge = EventosOrm.Delete(ref missatge, (esdeveniments)dataGridViewEvents.SelectedRows[0].DataBoundItem);
                    if (missatge.Equals(""))
                    {
                        MessageBox.Show("Evento eliminade correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refrescarGrid();
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccionar un evento de la grid", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewEvents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==15)
            {
                esdeveniments _esdev = (esdeveniments)dataGridViewEvents.Rows[e.RowIndex].DataBoundItem;
                if (_esdev != null)
                {
                    if(_esdev.id_localitat != null)
                    {
                        e.Value = _esdev.localitats.nom;
                    }
                    else{
                        e.Value = "Online";
                    }

                    
                }

            }
            if (e.ColumnIndex == 3)
            {
                esdeveniments _esdev = (esdeveniments)dataGridViewEvents.Rows[e.RowIndex].DataBoundItem;
                if(_esdev != null)
                {
                    String hor = "";
                    TimeSpan hora = _esdev.hora;
                    String horaDef = "";
                    String minDef = ""; 
                    if (hora.Hours < 10)
                    {
                        horaDef = "0" + hora.Hours;
                    }
                    else
                    {
                        horaDef = hora.Hours.ToString();
                    }
                    if(hora.Minutes < 10)
                    {
                        minDef = "0" + hora.Minutes;
                    }
                    else
                    {
                        minDef = hora.Minutes.ToString();
                    }
                    hor = horaDef  + ":" + minDef;
                    e.Value = hor;
                }
                
            }
            
        }

        private void textBoxBuscarEvent_TextChanged(object sender, EventArgs e)
        {
            List<esdeveniments> llistaFiltrada = null;
            
            llistaFiltrada = new List<esdeveniments>(esdeveniments.Where(esdev => esdev.localitats!=null && esdev.localitats.nom.ToLower().Contains(textBoxBuscarEvent.Text.ToLower())).ToList());

            bindingSourceGridEventos.DataSource = llistaFiltrada;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridViewEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count == 1)
            {
                esdeveniments esdeveniment = (esdeveniments)dataGridViewEvents.SelectedRows[0].DataBoundItem;
                FormVerParticipantes formVerParticipantes = new FormVerParticipantes(esdeveniment);
                formVerParticipantes.ShowDialog();
            }
        }
    }
}
