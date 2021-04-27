using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
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
        public bool adjunt = false;
        public String arxiu;
        public documents document;
         

        public FormInsertarEventos(comunitats comunitat)
        {
            InitializeComponent();
            this.comunitat = comunitat;
            labelNumeroEvento.Visible = false;
            this.esdeveniment = new esdeveniments();
            _localitats = new List<localitats>();
            this.document = new documents();
        }

        public FormInsertarEventos(esdeveniments esdeveniment, comunitats comunitat)
        {
            InitializeComponent();
            this.esdeveniment = esdeveniment;
            this.modificar = true;
            this.comunitat = comunitat;
            labelNumeroEvento.Visible = true;
            buttonInsertarEvento.Text = "Modificar";
            if (esdeveniment.documents.Count > 0)
            {
                document = esdeveniment.documents.ElementAt(0);
            }
            
        }

        private void FormInsertarEventos_Load(object sender, EventArgs e)
        {
            String missatge = "";

            bindingSourceTipoEventos.DataSource = TipusEventsOrm.Select(ref missatge);
            bindingSourceProvincies.DataSource = comunitat.provincies.ToList();

            dateTimePickerEvento.Format = DateTimePickerFormat.Custom;
            dateTimePickerEvento.CustomFormat = "dd/MM/yyyy";
            dateTimePickerEvento.MinDate = DateTime.Today;
            //dateTimePickerHora.Format = DateTimePickerFormat.Custom;
            //dateTimePickerHora.CustomFormat = "hh:mm";
            dateTimePickerHora.Format = DateTimePickerFormat.Custom;
            dateTimePickerHora.CustomFormat = "HH:mm";
            dateTimePickerHora.ShowUpDown = true;


            if (!modificar)
            {
                textBoxComunidadEvento.Text = comunitat.nom;
                dateTimePickerEvento.Value = DateTime.Now;
                textBoxTotalparticipantesEvento.Text = "0";
                comboBoxTipoEvento.SelectedItem = null;
                comboBoxProvincias.SelectedItem = null;
                comboBoxCiudadesBuscadas.SelectedItem = null;
                textBoxMaximoasistentesEvento.Text = "0";
                textBoxMinimoAsistentesEvento.Text = "0";
            }
            
            else
            {
                textBoxTituloEvento.Text = esdeveniment.titol;
                comboBoxTipoEvento.SelectedItem = esdeveniment.tipus_events;
                textBoxComunidadEvento.Text = esdeveniment.comunitats.nom;
                int ano = esdeveniment.data.Year;
                int mes = esdeveniment.data.Month;
                int dia = esdeveniment.data.Day;
                dateTimePickerEvento.MaxDate = new DateTime(9998, 6, 20);
                dateTimePickerEvento.MinDate = new DateTime(2000, 6, 20);
                dateTimePickerEvento.Value = new DateTime(ano, mes, dia);
                dateTimePickerHora.Text = esdeveniment.hora.ToString();
                if (!esdeveniment.tipus_events.nom.Equals("Online"))
                {
                    comboBoxProvincias.SelectedItem = esdeveniment.localitats.provincies;
                }
                if(esdeveniment.documents.Count > 0)
                {
                    adjunt = true;
                }
                bindingSourceCiutats.DataSource = CiutatsOrm.Select(ref missatge, (provincies)comboBoxProvincias.SelectedItem);
                textBoxDireccionEvento.Text = esdeveniment.adreca;
                richTextBoxDescripcionEvento.Text = esdeveniment.descripcio;
                checkBoxActividadPagoEvento.Checked = (bool)esdeveniment.pagament;
                textBoxPrecioPersonaEvento.Text = esdeveniment.preu.ToString();
                textBoxMinimoAsistentesEvento.Text = esdeveniment.quantitat_mínima.ToString();
                textBoxMaximoasistentesEvento.Text = esdeveniment.quantitat_max.ToString();
                textBoxTotalparticipantesEvento.Text = esdeveniment.cont_assitents.ToString();
                checkBoxEstatal.Checked = esdeveniment.eventoEstatal.Value;
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

        private void comboBoxProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProvincias.SelectedItem != null)
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

        private void buttonInsertarEvento_Click(object sender, EventArgs e)
        {
            String missatge = "";
            if (comprobarDatos()){

                if (this.modificar)
                {
                    omplirEsdeveniment();
                    EventosOrm.Update(ref missatge, esdeveniment);
                    if (missatge.Equals(""))
                    {
                        MessageBox.Show("Se ha modificado el evento correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    omplirEsdeveniment();

                    EventosOrm.Insert(ref missatge, esdeveniment);
                    if (missatge.Equals(""))
                    {
                        if (!textBoxAdjunto.Text.Equals(""))
                        {
                            String missatgeInsert = "";
                           
                            String pathMostrar = "abp-politecnics.com/2021/dam2a02/documentos/";
                            List<esdeveniments> listaEvent = EventosOrm.Select(ref missatge, esdeveniment.titol);
                            esdeveniments _esdev = listaEvent[listaEvent.Count - 1];
                            documents docu = new documents();
                            FileInfo fi = new FileInfo(arxiu);
                            docu.id_esdeveniment = _esdev.id;
                            docu.nom = fi.Name;
                            docu.ruta = pathMostrar + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString() + "_" + fi.Name;
                            DocumentsOrm.Insert(ref missatgeInsert, docu);
                            subirArchivos();
                            //ftp.onwindows - es.setupdns.net / documentos /
                            //docu.nom = 
                        }
                        MessageBox.Show("Se ha insertado el evento correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            
        }
        private void omplirEsdeveniment()
        {
            esdeveniment.titol = textBoxTituloEvento.Text;
            esdeveniment.descripcio = richTextBoxDescripcionEvento.Text;
            esdeveniment.eventoEstatal = checkBoxEstatal.Checked;
            esdeveniment.data = dateTimePickerEvento.Value;
            esdeveniment.hora = dateTimePickerHora.Value.TimeOfDay;
            esdeveniment.adreca = textBoxDireccionEvento.Text;
            esdeveniment.id_comunitat = comunitat.id;
            esdeveniment.quantitat_max = Int32.Parse(textBoxMaximoasistentesEvento.Text);
            esdeveniment.quantitat_mínima = Int32.Parse(textBoxMinimoAsistentesEvento.Text);
            if (checkBoxActividadPagoEvento.Checked)
            {
                esdeveniment.preu = decimal.Parse(textBoxPrecioPersonaEvento.Text);
            }

            esdeveniment.pagament = checkBoxActividadPagoEvento.Checked;
            esdeveniment.cont_assitents = Int32.Parse(textBoxTotalparticipantesEvento.Text);
            tipus_events tipus = (tipus_events)comboBoxTipoEvento.SelectedItem;
            esdeveniment.id_tipus = tipus.idTipus;
            if (comboBoxCiudadesBuscadas.Enabled)
            {
                esdeveniment.id_localitat = ((localitats)comboBoxCiudadesBuscadas.SelectedItem).id;
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
            if(textBoxTituloEvento.Text.Length > 20)
            {
                MessageBox.Show("El título debe tener 20 caracteres máximo", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTituloEvento.Focus();
            }
            else if (comboBoxTipoEvento.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de evento", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxTipoEvento.Focus();
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
            else if(((tipus_events)comboBoxTipoEvento.SelectedItem).nom != "Online")
            {
                if (comboBoxProvincias.SelectedItem == null)
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
                else if (!comprobarEntero(textBoxMaximoasistentesEvento.Text))
                {
                    MessageBox.Show("Debe introducir un numero entero en Maximo Asistentes", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxMaximoasistentesEvento.Focus();
                }
                else if (!comprobarEntero(textBoxMinimoAsistentesEvento.Text))
                {
                    MessageBox.Show("Debe introducir un numero entero en Mínimo Asistentes", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxMinimoAsistentesEvento.Focus();
                }
                
                if (checkBoxActividadPagoEvento.Checked)
                {
                    if (textBoxPrecioPersonaEvento.Text.Length == 0)
                    {
                        MessageBox.Show("Debe introducir un precio por persona", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxPrecioPersonaEvento.Focus();
                    }
                    else
                    {
                        if (!comprobarFloat(textBoxPrecioPersonaEvento.Text))
                        {
                            MessageBox.Show("Debe introducir un numero correcto en Precio por persona", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxPrecioPersonaEvento.Focus();
                        }
                        else
                        {
                            correcto = true;
                        }
                    }
                }
                else
                {

                    correcto = true;

                }
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
                    
                        correcto = true;
                       
                    }
                }
                else
                {
                   
                    correcto = true;

                }
            }

            return correcto;
        }
        public Boolean comprobarEntero(String texto)
        {
            int numero;
            bool ok = Int32.TryParse(texto, out numero);
            return ok;
        }
        public Boolean comprobarFloat(String texto)
        {
            decimal numero;
            bool ok = decimal.TryParse(texto, out numero);
            return ok;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTituloEvento_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoEvento.SelectedItem != null)
            {
                if (((tipus_events)(comboBoxTipoEvento.SelectedItem)).nom.Equals("Online"))
                {
                    labelDireccionEvento.Text = "Dirección Web";
                    comboBoxProvincias.Enabled = false;
                    comboBoxCiudadesBuscadas.Enabled = false;
                    textBoxCiudadEvento.Enabled = false;
                }
                else
                {
                    labelDireccionEvento.Text = "Dirección";
                    comboBoxProvincias.Enabled = true;
                    comboBoxCiudadesBuscadas.Enabled = true;
                    textBoxCiudadEvento.Enabled = true;
                }
            }
            
            
        }

        private void richTextBoxDescripcionEvento_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDescripcionEvento_Click(object sender, EventArgs e)
        {

        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            if(adjunt == false)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos pdf|*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    arxiu = ofd.FileName;
                    FileInfo fi = new FileInfo(arxiu);
                    textBoxAdjunto.Text = fi.Name;
                    document.nom = fi.Name;
                    adjunt = true;
                }
            }
            else
            {
                MessageBox.Show("Solo se permite un archivo adjunto");
            }
            
        }
        private void subirArchivos()
        {
            String usuario = "dam2a02@abp-politecnics.com";
            String contrasena = "Informatica_2021";
       
            try
            {
                /*
                FileInfo fi = new FileInfo(arxiu);
                String nombreFicher = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Millisecond.ToString() + "_" + fi.Name;
                String path = rutaDestino + nombreFicher;*/
                String pathSubida = "ftp.onwindows-es.setupdns.net/documentos/";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSubida);
                request.Credentials = new NetworkCredential(usuario, contrasena);

                request.Method = WebRequestMethods.Ftp.UploadFile;

                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                FileStream fileStream = File.OpenRead(arxiu);
                Stream requestStream = request.GetRequestStream();
                fileStream.CopyTo(requestStream);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                MessageBox.Show(response.StatusDescription);
                response.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        }

        private void buttonInsertarEvento_Click_1(object sender, EventArgs e)
        {

        }
    }

    
}
