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
    public partial class FormCrearAdmin : Form
    {
        List<comunitats> _comunitats;
        usuaris usuari;
        bool modificar;
        public FormCrearAdmin()
        {
            InitializeComponent();
            usuari = new usuaris();
            modificar = false;
            dataGridViewComunidades.AutoGenerateColumns = false;
        }
        public FormCrearAdmin(usuaris usuari)
        {
            InitializeComponent();
            this.usuari = usuari;
            modificar = true;
            dataGridViewComunidades.AutoGenerateColumns = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormCrearAdmin_Load(object sender, EventArgs e)
        {
            String missatge = "";
            List<rols> rols = RolsOrm.Select(ref missatge);
            _comunitats = new List<comunitats>();
            if (missatge.Equals(""))
            {
                bindingSourceRols.DataSource = rols;
                comboBoxRol.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (modificar)
            {
                textBoxUserName.Text = usuari.username.ToString();
                textBoxEmail.Text = usuari.email.ToString();
                textBoxPassword.Enabled = false;
                textBoxUserName.Enabled = false;
                comboBoxRol.SelectedItem = usuari.rols;
                button1.Text = "Modificar";
                if (usuari.comunitats != null)
                {
                    _comunitats = usuari.comunitats.ToList();
                    dataGridViewComunidades.DataSource = _comunitats;
                }
                if (usuari.username.Equals("sa"))
                {
                    MessageBox.Show("No se puede modificar le usuarie sa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
            

        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRol.SelectedIndex != -1)
            {
                rols rol = (rols)comboBoxRol.SelectedItem;
                if (comboBoxRol.SelectedIndex == 0)
                {
                    comboBoxComunidades.SelectedIndex = -1;
                    bindingSourceComunitats.DataSource = null;
                    dataGridViewComunidades.DataSource = null;
                    _comunitats.Clear();
                }
                else
                {
                    String missatge = "";
                    List<comunitats> comunitats = ComunitatsOrm.Select(ref missatge);
                    if (missatge.Equals(""))
                    {
                        bindingSourceComunitats.DataSource = comunitats;
                        comboBoxComunidades.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Equals(""))
            {
                MessageBox.Show("Hay que escribir un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUserName.Focus();
            }
            else
            {
                if (textBoxEmail.Text.Equals(""))
                {
                    MessageBox.Show("Hay que escribir un email", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxEmail.Focus();
                }
                else
                {
                        if(comboBoxRol.SelectedIndex == -1)
                        {
                            MessageBox.Show("Seleccionar un rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            String username = textBoxUserName.Text;
                            String email = textBoxEmail.Text;
                            rols rol = (rols)comboBoxRol.SelectedItem;
                            if (rol.nom.Equals("SuperAdministrador"))
                            {
                                usuari.username = username;
                                usuari.email = email;
                                usuari.id_rol = rol.id;
                                usuari.comunitats = null;
                                String missatge = "";
                                if (!modificar)
                                {
                                    String password = textBoxPassword.Text;
                                    String passCryp = BCrypt.Net.BCrypt.EnhancedHashPassword(password, BCrypt.Net.HashType.SHA512);
                                    usuari.contrasenya = passCryp;
                                    if (comprobarPassword())
                                    {
                                        missatge = AdminOrm.Insert(usuari);
                                        if (missatge.Equals(""))
                                        {
                                            MessageBox.Show("Usuare introducide correctamente.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    
                                }
                                else
                                {
                                    missatge = AdminOrm.Update(usuari);
                                    if (missatge.Equals(""))
                                    {
                                        MessageBox.Show("Usuarie modificade correctamente", "Información" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                
                            }
                            else
                            {
                                if (_comunitats.Count == 0)
                                {
                                    MessageBox.Show("Hay que introducir almenos 1 comunidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    String missatge = "";
                                    usuari.username = username;
                                    usuari.email = email;  
                                    usuari.id_rol = rol.id;
                                    usuari.comunitats = _comunitats;
                                    if (!modificar)
                                    {
                                        String password = textBoxPassword.Text;
                                        String passCryp = BCrypt.Net.BCrypt.EnhancedHashPassword(password, BCrypt.Net.HashType.SHA512);
                                        usuari.contrasenya = passCryp;
                                        if (comprobarPassword())
                                        {
                                            missatge = AdminOrm.Insert(usuari);
                                            if (missatge.Equals(""))
                                            {
                                                MessageBox.Show("Usuarie introducide correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        missatge = AdminOrm.Update(usuari);
                                        if (missatge.Equals(""))
                                        {
                                            MessageBox.Show("Usuarie modificade correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }

                                    }
                                    
                                }
                            }
                        }
                    
                }
            }
        }

        private bool comprobarPassword()
        {
            bool correcto = false;
            if(textBoxPassword.Text.Length < 8)
            {
                MessageBox.Show("La contraseña tiene que tener un mínimo de 8 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                correcto = true;
            }

            return correcto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAnadir_Click_1(object sender, EventArgs e)
        {
            if (comboBoxComunidades.SelectedIndex != -1)
            {
                bool existe = false;
                comunitats com = (comunitats)comboBoxComunidades.SelectedItem;
                foreach (comunitats item in _comunitats)
                {
                    if (item.Equals(com))
                    {
                        existe = true;
                    }
                }
                if (!existe)
                {
                    _comunitats.Add((comunitats)comboBoxComunidades.SelectedItem);
                    dataGridViewComunidades.DataSource = null;
                    dataGridViewComunidades.DataSource = _comunitats;
                }

            }
        }

        private void comboBoxComunidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
