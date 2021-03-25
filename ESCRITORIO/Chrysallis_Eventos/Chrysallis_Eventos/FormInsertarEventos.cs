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
    public partial class FormInsertarEventos : Form
    {
        public comunitats comunitat;
        public esdeveniments esdeveniment;
        public Boolean modificar = false;

        public FormInsertarEventos(comunitats comunitat)
        {
            InitializeComponent();
            this.comunitat = comunitat;
            labelNumeroEvento.Visible = false;
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
            bindingSourceProvincies.DataSource = esdeveniment.comunitats.provincies.ToList();

            if (!modificar)
            {
                textBoxComunidadEvento.Text = comunitat.nom;
                dateTimePickerEvento.Value = DateTime.Now;
                comboBoxTipoEvento.SelectedItem = null;
                comboBoxProvincias.SelectedItem = null;



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
            
            }
            else if (comboBoxTipoEvento.SelectedItem == null)
            { 
            
            }
            else if (comboBoxProvincias.SelectedItem == null)
            { 
            
            }
            else if (comboBoxCiudadesBuscadas.SelectedItem == null)
            { 
            
            }
            else if (textBoxDireccionEvento.Text.Length == 0)
            { 
            
            }
            else if (richTextBoxDescripcionEvento.Text.Length == 0)
            { 
            
            }
            else if (textBoxMinimoAsistentesEvento.Text.Length == 0)
            {

            }
            else if (textBoxMaximoasistentesEvento.Text.Length == 0)
            {

            }
            else
            {
                if (checkBoxActividadPagoEvento.Checked)
                {
                    if(textBoxPrecioPersonaEvento.Text.Length == 0)
                    {

                    }
                    else
                    {
                        if (this.modificar)
                        {
                            if(textBoxTotalparticipantesEvento.Text.Length == 0)
                            {

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
    }
}
