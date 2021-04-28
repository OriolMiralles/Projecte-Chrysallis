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
    public partial class FormInsertarUsuario : Form
    {
        public comunitats comunitat;
        public socis soci;
        public Boolean modificar = false;
        public List<localitats> _localitats = null;
        public List<menors_socis> menors = null;

        public FormInsertarUsuario(comunitats comunitat)
        {
            InitializeComponent();
            this.comunitat = comunitat;
            labelNumeroUsuario.Visible = false;
            this.soci = new socis();
            _localitats = new List<localitats>();
            dataGridViewMenors.Visible = false;
            dataGridViewMenors.Enabled = false;
        }
        public FormInsertarUsuario(socis soci, comunitats comunitat)
        {
            String missatge = "";
            InitializeComponent();
            this.soci = soci;
            this.modificar = true;
            this.comunitat = comunitat;
            labelNumeroUsuario.Visible = true;

        }

        private void FormInsertarUsuario_Load(object sender, EventArgs e)
        {
            String missatge = "";

            bindingSourceProvincies.DataSource = comunitat.provincies.ToList();

            if (!modificar)
            {
                textBoxComunidadUsuario.Text = comunitat.nom;
                comboBoxProvinciasUsuario.SelectedItem = null;
                comboBoxCiudadesBuscadasUsuario.SelectedItem = null;
                labelInfo.Visible = false;
                buttonInsertarMenor.Visible = false;
                generarContraseña();
                buttonInsertar.Location = new Point(975,300);
                this.Size = new Size(1150, 400);
            }
            else
            {
                menors = MenorOrm.Select(ref missatge, soci);
                bindingSourceMenors.DataSource = menors;
                textBoxNombreUsuario.Text = soci.nom;
                textBoxApellidoUsuario.Text = soci.cognoms;
                checkBoxActivo.Checked = soci.actiu;
                checkBoxPermiso.Checked = soci.permis_app;
                textBoxDNIUsuario.Text = soci.dni;
                textBoxPasswordUsuario.Enabled = false;
                textBoxNumSocio.Text = soci.num.ToString();
                dateTimePickerUsuario.Value = soci.data_naixement.Value;
                textBoxTelefono1Usuario.Text = soci.telefon1;
                textBoxTelefono2Usuario.Text = soci.telefon2;
                textBoxEmailUsuario.Text = soci.email;
                textBoxComunidadUsuario.Text = soci.localitats.provincies.comunitats.nom;
                comboBoxProvinciasUsuario.SelectedItem = soci.localitats.provincies;
                _localitats = CiutatsOrm.Select(ref missatge, (provincies)comboBoxProvinciasUsuario.SelectedItem);
                bindingSourceCiutats.DataSource = _localitats;
                
                comboBoxCiudadesBuscadasUsuario.SelectedItem = soci.localitats;
                textBoxDireccionUsuario.Text = soci.adresa;
                buttonInsertar.Text = "Modificar";


            }
        }

        private void comboBoxProvinciasUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProvinciasUsuario.SelectedItem != null)
            {
                String missatge = "";
                _localitats = CiutatsOrm.Select(ref missatge, (provincies)comboBoxProvinciasUsuario.SelectedItem);
                bindingSourceCiutats.DataSource = _localitats;
            }
        }

        private void textBoxCiudadUsuario_TextChanged(object sender, EventArgs e)
        {
            BindingList<localitats> llistaFiltrada = null;
            if(_localitats != null)
            {
                llistaFiltrada = new BindingList<localitats>(_localitats.Where(l => l.nom.ToLower().Contains(textBoxCiudadUsuario.Text.ToLower())).ToList());
            }
            
            bindingSourceCiutats.DataSource = llistaFiltrada;
        }


        private void omplirUsuario()
        {
            soci.nom = textBoxNombreUsuario.Text;
            soci.num = Int32.Parse(textBoxNumSocio.Text);
            soci.data_alta = DateTime.Now;
            soci.actiu = checkBoxActivo.Checked;
            if (soci.actiu == true)
            {
                soci.permis_app = checkBoxPermiso.Checked;
            }
            else
            {
                soci.permis_app = false;
            }
           
            soci.cognoms = textBoxApellidoUsuario.Text;
            soci.dni = textBoxDNIUsuario.Text;
            soci.actiu = checkBoxActivo.Checked;
            if (!modificar)
            {
                soci.contrasenya = BCrypt.Net.BCrypt.HashPassword(textBoxPasswordUsuario.Text);
            }
            soci.data_naixement = dateTimePickerUsuario.Value;
            soci.telefon1 = textBoxTelefono1Usuario.Text;
            if (!textBoxTelefono2Usuario.Equals(""))
            {
                soci.telefon2 = textBoxTelefono2Usuario.Text;
            }
            soci.email = textBoxEmailUsuario.Text;
            soci.comunitats.Add(comunitat);
            soci.adresa = textBoxDireccionUsuario.Text;
            localitats localitat = (localitats)comboBoxCiudadesBuscadasUsuario.SelectedItem;
            soci.id_localitat = localitat.id;
            // soci.menors_socis. = textBoxNombreMenorUsuario.Text;
            //soci.num = textBoxRelacionMenorUsuario.Text;

        }
        public Boolean comprobarEntero(String texto)
        {
            int numero;
            bool ok = Int32.TryParse(texto, out numero);
            return ok;
        }

        private Boolean comprobarDatos()
        {
            Boolean correcto = false;

            if (textBoxNombreUsuario.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un Nombre al usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombreUsuario.Focus();
            }
            else if (textBoxApellidoUsuario.Text.Length == 0)
            {
                MessageBox.Show("Debe seleccionar un Apelllido al usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxApellidoUsuario.Focus();
            }
            else if (textBoxDNIUsuario.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un DNI al usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDNIUsuario.Focus();
            }
            else if (textBoxTelefono1Usuario.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un Telefono al usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPasswordUsuario.Focus();
            }
            else if (textBoxEmailUsuario.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un Email al usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmailUsuario.Focus();
            }
            else if (comboBoxProvinciasUsuario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una provincia", "Advertencia",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxProvinciasUsuario.Focus();
            }
            else if (comboBoxCiudadesBuscadasUsuario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una ciudad/población", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxCiudadesBuscadasUsuario.Focus();
            }
            else if (!comprobarEntero(textBoxNumSocio.Text))
            {
                MessageBox.Show("Debe introducir un numero de socio correcto", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNumSocio.Focus();
            }
            else
            {
                correcto = true;
            }
            if (!modificar)
            {
                if (textBoxPasswordUsuario.Text.Length == 0)
                {
                    MessageBox.Show("Debe introducir una Contraseña al usuario", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPasswordUsuario.Focus();
                    correcto = false;
                }
            }

            return correcto;
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            String missatge = "";
            if (comprobarDatos())
            {

                if (this.modificar)
                {
                    omplirUsuario();
                    UsuarioOrm.Update(ref missatge, soci);
                    if (missatge.Equals(""))
                    {
                        MessageBox.Show("Se ha modificado el Usuario correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    omplirUsuario();

                    UsuarioOrm.Insert(ref missatge, soci);
                    if (missatge.Equals(""))
                    {
                        MessageBox.Show("Se ha insertado el Usuario correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<socis> _soci = UsuarioOrm.Select(ref missatge, soci.dni);
                        FormInsertarMenor fim = new FormInsertarMenor(_soci[0]);
                        fim.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        }

        private void dataGridViewMenors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMenors_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            String missatge = "";
            if (dataGridViewMenors.SelectedRows.Count > 0)
            {
                DialogResult dg = MessageBox.Show("Estás segure de borrar le menor?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    missatge = MenorOrm.Delete((menors_socis)dataGridViewMenors.SelectedRows[0].DataBoundItem);
                    if (missatge.Equals(""))
                    {
                        MessageBox.Show("Menor borrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void buttonInsertarMenor_Click(object sender, EventArgs e)
        {
            String missatge = "";
            FormInsertarMenor fim = new FormInsertarMenor(soci);
            fim.ShowDialog();
            menors = MenorOrm.Select(ref missatge, soci);
            bindingSourceMenors.DataSource = menors;
        }

        private void dataGridViewMenors_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                menors_socis _menor = (menors_socis)dataGridViewMenors.Rows[e.RowIndex].DataBoundItem;
                if (_menor != null)
                {

                    e.Value = _menor.menors.nom;
                }

            }
        }
        private void generarContraseña()
        {
            String pass="";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                int numero = random.Next(97, 123);
                char letra = (char)numero;
                pass += letra;
            }

            textBoxPasswordUsuario.Text = pass;
            
        }

        private void checkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
