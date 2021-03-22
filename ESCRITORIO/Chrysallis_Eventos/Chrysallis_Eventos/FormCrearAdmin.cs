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
        public FormCrearAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormCrearAdmin_Load(object sender, EventArgs e)
        {
            String missatge = "";
            List<rols> rols = RolsOrm.Select(ref missatge);
            _comunitats = new List<comunitats>();
            dataGridViewComunidades.DataSource = _comunitats;
            if (missatge.Equals(""))
            {
                bindingSourceRols.DataSource = rols;
                comboBoxRol.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRol.SelectedIndex != -1)
            {
                rols rol = (rols)comboBoxRol.SelectedItem;
                String tipo = rol.nom.ToString();
                if (tipo.Equals("Administrador"))
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
                MessageBox.Show("Hay que escribir un nombre");
                textBoxUserName.Focus();
            }
            else
            {
                if (textBoxEmail.Text.Equals(""))
                {
                    MessageBox.Show("Hay que escribir un email");
                    textBoxEmail.Focus();
                }
                else
                {
                    if (comprobarPassword())
                    {
                        if(comboBoxRol.SelectedIndex == -1)
                        {
                            MessageBox.Show("Seleccionar un rol");
                        }
                        else
                        {
                            String username = textBoxUserName.Text;
                            String email = textBoxEmail.Text;
                            String password = textBoxPassword.Text;
                            rols rol = (rols)comboBoxRol.SelectedItem;
                            String passCryp = BCrypt.Net.BCrypt.EnhancedHashPassword(password, BCrypt.Net.HashType.SHA512);
                            if (rol.nom.Equals("SuperAdministrador")){
                                usuaris usuari = new usuaris();
                                usuari.username = username;
                                usuari.email = email;
                                usuari.contrasenya = passCryp;
                                usuari.id_rol = rol.id;
                                AdminOrm.Insert(usuari);
                            }
                            else
                            {
                                if (bindingSourceComunitats.Count == 0)
                                {
                                    MessageBox.Show("Hay que introducir almenos 1 comunidad");
                                }
                                else
                                {
                                    usuaris usuari = new usuaris();
                                    usuari.username = username;
                                    usuari.email = email;
                                    usuari.contrasenya = passCryp;
                                    usuari.id_rol = rol.id;
                                    List<comunitats> _comunitats = new List<comunitats>();
                                    foreach (comunitats item in dataGridViewComunidades.Rows)
                                    {
                                        _comunitats.Add(item);
                                    }
                                    usuari.comunitats = _comunitats;    
                                    AdminOrm.Insert(usuari);
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
            if(textBoxEmail.Text.Length < 8)
            {
                MessageBox.Show("Mínimo 8 caracteres");

            }
            else
            {
                correcto = true;
            }

            return correcto;
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            _comunitats.Add((comunitats)comboBoxComunidades.SelectedItem);
            dataGridViewComunidades.DataSource = null;
            dataGridViewComunidades.DataSource = _comunitats;
        }
    }

}
