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
    public partial class FormLoggin : Form
    {
        bool entrada = false;
        public FormLoggin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            if (textBoxUserName.Text.Equals(""))
            {
                MessageBox.Show("Hay que introducir un nombre de usuario");
            }
            else
            {
                if (textBoxPassword.Text.Equals(""))
                {
                    MessageBox.Show("Hay que introducir una contraseña");
                }
                else
                {
                    String username = textBoxUserName.Text;
                    List<usuaris> _user =  AdminOrm.Select(username);
                    
                    if (_user.Count == 1)
                    {
                        String pass = textBoxPassword.Text;
                        entrada = BCrypt.Net.BCrypt.EnhancedVerify(pass, _user[0].contrasenya, hashType: BCrypt.Net.HashType.SHA512);
                        if (entrada)
                        {
                            if (_user[0].id_rol==1)
                            {
                                User.SuperAdmin = true;
                            }
                            else
                            {
                                User.SuperAdmin = false;
                            }
                            User.id = _user[0].id;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrecta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta");
                    }
                }
            }
        }

        private void FormLoggin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!entrada)
            {
                Application.Exit();
            }
>>>>>>> a4667850846a6f9af266007fa118176fae016784
        }
    }
}
