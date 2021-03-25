
namespace Chrysallis_Eventos
{
    partial class FormInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.buttonEventos = new System.Windows.Forms.Button();
            this.buttonSocies = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Chrysallis_Eventos.Properties.Resources.NOU_LOGO_SIN_FONDO;
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(242, 11);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(282, 263);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUsuarios.FlatAppearance.BorderSize = 2;
            this.buttonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuarios.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.Location = new System.Drawing.Point(266, 296);
            this.buttonUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(240, 46);
            this.buttonUsuarios.TabIndex = 1;
            this.buttonUsuarios.Text = "Socies";
            this.buttonUsuarios.UseVisualStyleBackColor = false;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // buttonEventos
            // 
            this.buttonEventos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEventos.FlatAppearance.BorderSize = 2;
            this.buttonEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEventos.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEventos.Location = new System.Drawing.Point(266, 357);
            this.buttonEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEventos.Name = "buttonEventos";
            this.buttonEventos.Size = new System.Drawing.Size(240, 46);
            this.buttonEventos.TabIndex = 2;
            this.buttonEventos.Text = "Eventos";
            this.buttonEventos.UseVisualStyleBackColor = false;
            this.buttonEventos.Click += new System.EventHandler(this.buttonEventos_Click);
            // 
            // buttonSocies
            // 
            this.buttonSocies.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSocies.FlatAppearance.BorderSize = 2;
            this.buttonSocies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSocies.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSocies.Location = new System.Drawing.Point(266, 502);
            this.buttonSocies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSocies.Name = "buttonSocies";
            this.buttonSocies.Size = new System.Drawing.Size(240, 46);
            this.buttonSocies.TabIndex = 3;
            this.buttonSocies.Text = "Usuarios";
            this.buttonSocies.UseVisualStyleBackColor = false;
            this.buttonSocies.Click += new System.EventHandler(this.buttonSocies_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 580);
            this.Controls.Add(this.buttonSocies);
            this.Controls.Add(this.buttonEventos);
            this.Controls.Add(this.buttonUsuarios);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chrysallis";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Button buttonEventos;
        private System.Windows.Forms.Button buttonSocies;
    }
}