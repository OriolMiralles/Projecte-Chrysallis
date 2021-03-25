using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Chrysallis_Eventos.MODELOS;

namespace Chrysallis_Eventos
{
    public partial class FormInsertarEventos : Form
    {
        public comunitats comunitat;
        public esdeveniments esdeveniment;
        public Boolean modificar = false;
        public List<localitats> _localitats = null;

        public FormInsertarEventos(comunitats comunitat)
        {
            InitializeComponent();
            this.comunitat = comunitat;
            labelNumeroEvento.Visible = false;
            _localitats = new List<localitats>();
        }

        public FormInsertarEventos(esdeveniments esdeveniment, comunitats comunitat)
        {
            InitializeComponent();
            this.esdeveniment = esdeveniment;
            this.modificar = true;
            this.comunitat = comunitat;
            labelNumeroEvento.Visible = true;
            buttonInsertarEvento.Text = "Modificar";
        }

        private void FormInsertarEventos_Load(object sender, EventArgs e)
        {
            String missatge = "";

            bindingSourceTipoEventos.DataSource = TipusEventsOrm.Select(ref missatge);
            bindingSourceProvincies.DataSource = comunitat.provincies.ToList();

            if (!modificar)
            {
                textBoxComunidadEvento.Text = comunitat.nom;
                dateTimePickerEvento.Value = DateTime.Now;
                comboBoxTipoEvento.SelectedItem = null;
                comboBoxProvincias.SelectedItem = null;
                comboBoxCiudadesBuscadas.SelectedItem = null;
            }
            else
            {
                textBoxTituloEvento.Text = esdeveniment.titol;
                dateTimePickerEvento.Value = esdeveniment.data;
                comboBoxTipoEvento.SelectedItem = esdeveniment.tipus_events;
                textBoxComunidadEvento.Text = esdeveniment.comunitats.nom;
                comboBoxProvincias.SelectedItem = esdeveniment.localitats.provincies.nom;
                bindingSourceCiutats.DataSource = CiutatsOrm.Select(ref missatge, (provincies)comboBoxProvincias.SelectedItem);
                textBoxDireccionEvento.Text = esdeveniment.adreca;
                richTextBoxDescripcionEvento.Text = esdeveniment.descripcio;
                checkBoxActividadPagoEvento.Checked = (bool)esdeveniment.pagament;
                textBoxPrecioPersonaEvento.Text = esdeveniment.preu.ToString();
                textBoxMinimoAsistentesEvento.Text = esdeveniment.quantitat_mínima.ToString();
                textBoxMaximoasistentesEvento.Text = esdeveniment.quantitat_max.ToString();
                textBoxTotalparticipantesEvento.Text = esdeveniment.cont_assitents.ToString();
            }
        }

        private void checkBoxActividadPagoEvento_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxActividadPagoEvento.Checked)
            {
                textBoxPrecioPersonaEvento.Enabled = false;
            }
            else
            {
                textBoxPrecioPersonaEvento.Enabled = true;
            }
        }

        private void buttonInsertarUsuario_Click(object sender, EventArgs e)
        {
            FormVerParticipantes formVerParticipantes = new FormVerParticipantes();
            formVerParticipantes.ShowDialog();
        }

        private void buttonInsertarEvento_Click(object sender, EventArgs e)
        {
            if (comprobarDatos()){

                //if (this.modificar)
                //{
                //    EventosOrm.Update();
                //}
                //else
                //{
                //    EventosOrm.Insert();
                //}
            }
            
        }

        private Boolean comprobarDatos()
        {
            Boolean correcto = false;

            if (textBoxTituloEvento.Text.Length == 0)
            {              
                MessageBox.Show("Debe introducir un título de evento", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTituloEvento.Focus();
            }
            else if (comboBoxTipoEvento.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de evento", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxTipoEvento.Focus();
            }
            else if (comboBoxProvincias.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una provincia", "Advertencia",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxProvincias.Focus();
            }
            else if (comboBoxCiudadesBuscadas.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una ciudad/población", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxCiudadesBuscadas.Focus();
            }
            else if (textBoxDireccionEvento.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir una dirección de evento", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDireccionEvento.Focus();
            }
            else if (richTextBoxDescripcionEvento.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir una descripción de evento", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                richTextBoxDescripcionEvento.Focus();
            }
            else if (textBoxMinimoAsistentesEvento.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un número mínimo de asistentes", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMinimoAsistentesEvento.Focus();
            }
            else if (textBoxMaximoasistentesEvento.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un número máximo de asistentes", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMaximoasistentesEvento.Focus();
            }
            else
            {
                if (checkBoxActividadPagoEvento.Checked)
                {
                    if(textBoxPrecioPersonaEvento.Text.Length == 0)
                    {
                        MessageBox.Show("Debe introducir un precio por persona", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxPrecioPersonaEvento.Focus();
                    }
                    else
                    {
                        if (this.modificar)
                        {
                            if(textBoxTotalparticipantesEvento.Text.Length == 0)
                            {
                                MessageBox.Show("Debe introducir el número de participantes", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textBoxTotalparticipantesEvento.Focus();
                            }
                            else
                            {
                                correcto = true;
                            }
                            
                        }
                        else
                        {
                            correcto = true;
                        }
                    }
                }
                else
                {
                    if (this.modificar)
                    {
                        if (textBoxTotalparticipantesEvento.Text.Length == 0)
                        {
                            MessageBox.Show("Debe introducir el número de participantes", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxTotalparticipantesEvento.Focus();
                        }
                        else
                        {
                            correcto = true;
                        }

                    }
                    else
                    {
                        correcto = true;
                    }
                }
            }

            return correcto;
        }

        private void comboBoxProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxProvincias.SelectedItem != null)
            {
                String missatge = "";
                _localitats = CiutatsOrm.Select(ref missatge, (provincies)comboBoxProvincias.SelectedItem);
                bindingSourceCiutats.DataSource = _localitats;
            }
           
        }

        private void textBoxCiudadEvento_TextChanged(object sender, EventArgs e)
        {
            BindingList<localitats> llistaFiltrada = null;

            llistaFiltrada = new BindingList<localitats>(_localitats.Where(l => l.nom.ToLower().Contains(textBoxCiudadEvento.Text.ToLower())).ToList());

            bindingSourceCiutats.DataSource = llistaFiltrada;

        }
    }
}
