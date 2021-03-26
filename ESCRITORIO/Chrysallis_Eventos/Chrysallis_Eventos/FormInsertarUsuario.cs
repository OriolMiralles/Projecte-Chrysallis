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

        public FormInsertarUsuario(comunitats comunitat)
        {
            InitializeComponent();
            this.comunitat = comunitat;
            labelNumeroUsuario.Visible = false;
            this.soci = new socis();
            _localitats = new List<localitats>();
        }
         public FormInsertarUsuario(socis soci, comunitats comunitat)
        {
            InitializeComponent();
            this.soci = soci;
            this.modificar = true;
            this.comunitat = comunitat;
            labelNumeroUsuario.Visible = true;
            buttonInsertarUsuario.Text = "Modificar";
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
            }
            else
            {
                textBoxNombreUsuario.Text = soci.nom;
                textBoxApellidoUsuario.Text = soci.cognoms;
                textBoxDNIUsuario.Text = soci.dni;
                textBoxPasswordUsuario.Text = soci.contrasenya;
                dateTimePickerUsuario.Value = soci.data_naixement.Value;
                textBoxTelefono1Usuario.Text = soci.telefon1;
                textBoxTelefono2Usuario.Text = soci.telefon2;
                textBoxEmailUsuario.Text = soci.email;
                textBoxComunidadUsuario.Text = soci.comunitats.ToString();                
                bindingSourceCiutats.DataSource = CiutatsOrm.Select(ref missatge, (provincies)comboBoxProvinciasUsuario.SelectedItem);
                textBoxDireccionUsuario.Text = soci.adresa;
                textBoxNombreMenorUsuario.Text = soci.menors_socis.ToString();
                //textBoxRelacionMenorUsuario.Text = soci.num;
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
            llistaFiltrada = new BindingList<localitats>(_localitats.Where(l => l.nom.ToLower().Contains(textBoxCiudadUsuario.Text.ToLower())).ToList());
            bindingSourceCiutats.DataSource = llistaFiltrada;
        }

        private void buttonInsertarUsuario_Click(object sender, EventArgs e)
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
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void omplirUsuario()
        {
            soci.nom = textBoxNombreUsuario.Text;
            soci.cognoms = textBoxApellidoUsuario.Text;
            soci.dni = textBoxDNIUsuario.Text;
            soci.contrasenya = textBoxPasswordUsuario.Text;
            soci.data_naixement = dateTimePickerUsuario.Value;
            soci.telefon1 = textBoxTelefono1Usuario.Text;
            soci.telefon2 = textBoxTelefono2Usuario.Text;
            soci.email = textBoxEmailUsuario.Text;
            //soci.comunitats= comunitat.nom;
            soci.adresa = textBoxDireccionUsuario.Text;
            //soci.menors_socis = textBoxNombreMenorUsuario.Text;
            //soci.num = textBoxRelacionMenorUsuario.Text;

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
            else if (textBoxPasswordUsuario.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir una Contraseña al usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPasswordUsuario.Focus();
            }
            else if (textBoxTelefono1Usuario.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un Telefono al usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPasswordUsuario.Focus();
            }
            else if (textBoxTelefono2Usuario.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir otro Telefono al usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTelefono2Usuario.Focus();
            }
            else if (textBoxEmailUsuario.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir un Email al usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmailUsuario.Focus();
            }
            else if(comboBoxProvinciasUsuario.SelectedItem == null)
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
            else if (textBoxNombreMenorUsuario.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir el Nombre del Menor", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombreMenorUsuario.Focus();
            }
            else if (textBoxRelacionMenorUsuario.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir la Relacion con el Menor del usuario", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRelacionMenorUsuario.Focus();
            }
            else
            {               
                correcto = true;
            }

            return correcto;
        }
    }
}
