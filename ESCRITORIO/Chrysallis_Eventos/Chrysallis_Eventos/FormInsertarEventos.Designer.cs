
namespace Chrysallis_Eventos
{
    partial class FormInsertarEventos
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
            this.components = new System.ComponentModel.Container();
            this.labelTituloEvento = new System.Windows.Forms.Label();
            this.labelFechaEvento = new System.Windows.Forms.Label();
            this.labelTipoEvento = new System.Windows.Forms.Label();
            this.groupBoxUbicacionEvento = new System.Windows.Forms.GroupBox();
            this.labelCodigoPostalEvento = new System.Windows.Forms.Label();
            this.labelDireccionEvento = new System.Windows.Forms.Label();
            this.labelCiudadEvento = new System.Windows.Forms.Label();
            this.textBoxCodigoPostalEvento = new System.Windows.Forms.TextBox();
            this.textBoxDireccionEvento = new System.Windows.Forms.TextBox();
            this.textBoxCiudadEvento = new System.Windows.Forms.TextBox();
            this.labelProvinciaEvento = new System.Windows.Forms.Label();
            this.textBoxComunidadEvento = new System.Windows.Forms.TextBox();
            this.labelComunidadEvento = new System.Windows.Forms.Label();
            this.labelDescripcionEvento = new System.Windows.Forms.Label();
            this.richTextBoxDescripcionEvento = new System.Windows.Forms.RichTextBox();
            this.labelPrecioPersonaEvento = new System.Windows.Forms.Label();
            this.textBoxPrecioPersonaEvento = new System.Windows.Forms.TextBox();
            this.groupBoxCosteEvento = new System.Windows.Forms.GroupBox();
            this.checkBoxActividadPagoEvento = new System.Windows.Forms.CheckBox();
            this.groupBoxParticipantesEvento = new System.Windows.Forms.GroupBox();
            this.buttonInsertarUsuario = new System.Windows.Forms.Button();
            this.labelTotalparticipantesEvento = new System.Windows.Forms.Label();
            this.textBoxTotalparticipantesEvento = new System.Windows.Forms.TextBox();
            this.textBoxMaximoasistentesEvento = new System.Windows.Forms.TextBox();
            this.labelMaximoasistentesEvento = new System.Windows.Forms.Label();
            this.textBoxMinimoAsistentesEvento = new System.Windows.Forms.TextBox();
            this.labelMinimoAsistentesEvento = new System.Windows.Forms.Label();
            this.textBoxTituloEvento = new System.Windows.Forms.TextBox();
            this.textBoxFechaEvento = new System.Windows.Forms.TextBox();
            this.comboBoxTipoEvento = new System.Windows.Forms.ComboBox();
            this.buttonInsertarEvento = new System.Windows.Forms.Button();
            this.labelNumeroEvento = new System.Windows.Forms.Label();
            this.comboBoxProvincias = new System.Windows.Forms.ComboBox();
            this.bindingSourceProvincies = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTipoEventos = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxUbicacionEvento.SuspendLayout();
            this.groupBoxCosteEvento.SuspendLayout();
            this.groupBoxParticipantesEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloEvento
            // 
            this.labelTituloEvento.AutoSize = true;
            this.labelTituloEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloEvento.Location = new System.Drawing.Point(49, 26);
            this.labelTituloEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloEvento.Name = "labelTituloEvento";
            this.labelTituloEvento.Size = new System.Drawing.Size(60, 23);
            this.labelTituloEvento.TabIndex = 0;
            this.labelTituloEvento.Text = "Titulo:";
            // 
            // labelFechaEvento
            // 
            this.labelFechaEvento.AutoSize = true;
            this.labelFechaEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaEvento.Location = new System.Drawing.Point(49, 76);
            this.labelFechaEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaEvento.Name = "labelFechaEvento";
            this.labelFechaEvento.Size = new System.Drawing.Size(54, 23);
            this.labelFechaEvento.TabIndex = 1;
            this.labelFechaEvento.Text = "Fecha";
            // 
            // labelTipoEvento
            // 
            this.labelTipoEvento.AutoSize = true;
            this.labelTipoEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoEvento.Location = new System.Drawing.Point(404, 71);
            this.labelTipoEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoEvento.Name = "labelTipoEvento";
            this.labelTipoEvento.Size = new System.Drawing.Size(128, 23);
            this.labelTipoEvento.TabIndex = 2;
            this.labelTipoEvento.Text = "Tipo de Evento:";
            // 
            // groupBoxUbicacionEvento
            // 
            this.groupBoxUbicacionEvento.Controls.Add(this.label1);
            this.groupBoxUbicacionEvento.Controls.Add(this.comboBox1);
            this.groupBoxUbicacionEvento.Controls.Add(this.comboBoxProvincias);
            this.groupBoxUbicacionEvento.Controls.Add(this.labelCodigoPostalEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.labelDireccionEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.labelCiudadEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.textBoxCodigoPostalEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.textBoxDireccionEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.textBoxCiudadEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.labelProvinciaEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.textBoxComunidadEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.labelComunidadEvento);
            this.groupBoxUbicacionEvento.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUbicacionEvento.Location = new System.Drawing.Point(28, 106);
            this.groupBoxUbicacionEvento.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUbicacionEvento.Name = "groupBoxUbicacionEvento";
            this.groupBoxUbicacionEvento.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUbicacionEvento.Size = new System.Drawing.Size(707, 269);
            this.groupBoxUbicacionEvento.TabIndex = 13;
            this.groupBoxUbicacionEvento.TabStop = false;
            this.groupBoxUbicacionEvento.Text = "Ubicación";
            // 
            // labelCodigoPostalEvento
            // 
            this.labelCodigoPostalEvento.AutoSize = true;
            this.labelCodigoPostalEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoPostalEvento.Location = new System.Drawing.Point(21, 232);
            this.labelCodigoPostalEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodigoPostalEvento.Name = "labelCodigoPostalEvento";
            this.labelCodigoPostalEvento.Size = new System.Drawing.Size(118, 23);
            this.labelCodigoPostalEvento.TabIndex = 25;
            this.labelCodigoPostalEvento.Text = "Codigo Postal:";
            // 
            // labelDireccionEvento
            // 
            this.labelDireccionEvento.AutoSize = true;
            this.labelDireccionEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccionEvento.Location = new System.Drawing.Point(21, 194);
            this.labelDireccionEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccionEvento.Name = "labelDireccionEvento";
            this.labelDireccionEvento.Size = new System.Drawing.Size(86, 23);
            this.labelDireccionEvento.TabIndex = 24;
            this.labelDireccionEvento.Text = "Direccion:";
            // 
            // labelCiudadEvento
            // 
            this.labelCiudadEvento.AutoSize = true;
            this.labelCiudadEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudadEvento.Location = new System.Drawing.Point(20, 115);
            this.labelCiudadEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCiudadEvento.Name = "labelCiudadEvento";
            this.labelCiudadEvento.Size = new System.Drawing.Size(121, 23);
            this.labelCiudadEvento.TabIndex = 23;
            this.labelCiudadEvento.Text = "Buscar ciudad:";
            // 
            // textBoxCodigoPostalEvento
            // 
            this.textBoxCodigoPostalEvento.Location = new System.Drawing.Point(164, 226);
            this.textBoxCodigoPostalEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigoPostalEvento.Name = "textBoxCodigoPostalEvento";
            this.textBoxCodigoPostalEvento.Size = new System.Drawing.Size(499, 31);
            this.textBoxCodigoPostalEvento.TabIndex = 22;
            // 
            // textBoxDireccionEvento
            // 
            this.textBoxDireccionEvento.Location = new System.Drawing.Point(164, 188);
            this.textBoxDireccionEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDireccionEvento.Name = "textBoxDireccionEvento";
            this.textBoxDireccionEvento.Size = new System.Drawing.Size(499, 31);
            this.textBoxDireccionEvento.TabIndex = 21;
            // 
            // textBoxCiudadEvento
            // 
            this.textBoxCiudadEvento.Location = new System.Drawing.Point(164, 109);
            this.textBoxCiudadEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCiudadEvento.Name = "textBoxCiudadEvento";
            this.textBoxCiudadEvento.Size = new System.Drawing.Size(499, 31);
            this.textBoxCiudadEvento.TabIndex = 20;
            // 
            // labelProvinciaEvento
            // 
            this.labelProvinciaEvento.AutoSize = true;
            this.labelProvinciaEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvinciaEvento.Location = new System.Drawing.Point(20, 74);
            this.labelProvinciaEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProvinciaEvento.Name = "labelProvinciaEvento";
            this.labelProvinciaEvento.Size = new System.Drawing.Size(85, 23);
            this.labelProvinciaEvento.TabIndex = 18;
            this.labelProvinciaEvento.Text = "Província:";
            // 
            // textBoxComunidadEvento
            // 
            this.textBoxComunidadEvento.Location = new System.Drawing.Point(164, 28);
            this.textBoxComunidadEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComunidadEvento.Name = "textBoxComunidadEvento";
            this.textBoxComunidadEvento.ReadOnly = true;
            this.textBoxComunidadEvento.Size = new System.Drawing.Size(499, 31);
            this.textBoxComunidadEvento.TabIndex = 17;
            // 
            // labelComunidadEvento
            // 
            this.labelComunidadEvento.AutoSize = true;
            this.labelComunidadEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComunidadEvento.Location = new System.Drawing.Point(20, 32);
            this.labelComunidadEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComunidadEvento.Name = "labelComunidadEvento";
            this.labelComunidadEvento.Size = new System.Drawing.Size(99, 23);
            this.labelComunidadEvento.TabIndex = 17;
            this.labelComunidadEvento.Text = "Comunidad:";
            // 
            // labelDescripcionEvento
            // 
            this.labelDescripcionEvento.AutoSize = true;
            this.labelDescripcionEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionEvento.Location = new System.Drawing.Point(49, 383);
            this.labelDescripcionEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripcionEvento.Name = "labelDescripcionEvento";
            this.labelDescripcionEvento.Size = new System.Drawing.Size(108, 23);
            this.labelDescripcionEvento.TabIndex = 14;
            this.labelDescripcionEvento.Text = "Descripcion: ";
            // 
            // richTextBoxDescripcionEvento
            // 
            this.richTextBoxDescripcionEvento.Location = new System.Drawing.Point(192, 383);
            this.richTextBoxDescripcionEvento.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDescripcionEvento.Name = "richTextBoxDescripcionEvento";
            this.richTextBoxDescripcionEvento.Size = new System.Drawing.Size(541, 117);
            this.richTextBoxDescripcionEvento.TabIndex = 15;
            this.richTextBoxDescripcionEvento.Text = "";
            // 
            // labelPrecioPersonaEvento
            // 
            this.labelPrecioPersonaEvento.AutoSize = true;
            this.labelPrecioPersonaEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioPersonaEvento.Location = new System.Drawing.Point(260, 36);
            this.labelPrecioPersonaEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecioPersonaEvento.Name = "labelPrecioPersonaEvento";
            this.labelPrecioPersonaEvento.Size = new System.Drawing.Size(156, 23);
            this.labelPrecioPersonaEvento.TabIndex = 17;
            this.labelPrecioPersonaEvento.Text = "Precio por Persona:";
            // 
            // textBoxPrecioPersonaEvento
            // 
            this.textBoxPrecioPersonaEvento.Location = new System.Drawing.Point(447, 30);
            this.textBoxPrecioPersonaEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecioPersonaEvento.Name = "textBoxPrecioPersonaEvento";
            this.textBoxPrecioPersonaEvento.Size = new System.Drawing.Size(216, 31);
            this.textBoxPrecioPersonaEvento.TabIndex = 17;
            // 
            // groupBoxCosteEvento
            // 
            this.groupBoxCosteEvento.Controls.Add(this.checkBoxActividadPagoEvento);
            this.groupBoxCosteEvento.Controls.Add(this.textBoxPrecioPersonaEvento);
            this.groupBoxCosteEvento.Controls.Add(this.labelPrecioPersonaEvento);
            this.groupBoxCosteEvento.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCosteEvento.Location = new System.Drawing.Point(28, 508);
            this.groupBoxCosteEvento.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCosteEvento.Name = "groupBoxCosteEvento";
            this.groupBoxCosteEvento.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCosteEvento.Size = new System.Drawing.Size(685, 85);
            this.groupBoxCosteEvento.TabIndex = 26;
            this.groupBoxCosteEvento.TabStop = false;
            this.groupBoxCosteEvento.Text = "Coste";
            // 
            // checkBoxActividadPagoEvento
            // 
            this.checkBoxActividadPagoEvento.AutoSize = true;
            this.checkBoxActividadPagoEvento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActividadPagoEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActividadPagoEvento.Location = new System.Drawing.Point(21, 36);
            this.checkBoxActividadPagoEvento.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxActividadPagoEvento.Name = "checkBoxActividadPagoEvento";
            this.checkBoxActividadPagoEvento.Size = new System.Drawing.Size(173, 27);
            this.checkBoxActividadPagoEvento.TabIndex = 28;
            this.checkBoxActividadPagoEvento.Text = "Actividad de Pago:";
            this.checkBoxActividadPagoEvento.UseVisualStyleBackColor = true;
            // 
            // groupBoxParticipantesEvento
            // 
            this.groupBoxParticipantesEvento.Controls.Add(this.buttonInsertarUsuario);
            this.groupBoxParticipantesEvento.Controls.Add(this.labelTotalparticipantesEvento);
            this.groupBoxParticipantesEvento.Controls.Add(this.textBoxTotalparticipantesEvento);
            this.groupBoxParticipantesEvento.Controls.Add(this.textBoxMaximoasistentesEvento);
            this.groupBoxParticipantesEvento.Controls.Add(this.labelMaximoasistentesEvento);
            this.groupBoxParticipantesEvento.Controls.Add(this.textBoxMinimoAsistentesEvento);
            this.groupBoxParticipantesEvento.Controls.Add(this.labelMinimoAsistentesEvento);
            this.groupBoxParticipantesEvento.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxParticipantesEvento.Location = new System.Drawing.Point(28, 600);
            this.groupBoxParticipantesEvento.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxParticipantesEvento.Name = "groupBoxParticipantesEvento";
            this.groupBoxParticipantesEvento.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxParticipantesEvento.Size = new System.Drawing.Size(685, 222);
            this.groupBoxParticipantesEvento.TabIndex = 26;
            this.groupBoxParticipantesEvento.TabStop = false;
            this.groupBoxParticipantesEvento.Text = "Participantes";
            // 
            // buttonInsertarUsuario
            // 
            this.buttonInsertarUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsertarUsuario.FlatAppearance.BorderSize = 2;
            this.buttonInsertarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertarUsuario.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarUsuario.Location = new System.Drawing.Point(21, 158);
            this.buttonInsertarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsertarUsuario.Name = "buttonInsertarUsuario";
            this.buttonInsertarUsuario.Size = new System.Drawing.Size(172, 42);
            this.buttonInsertarUsuario.TabIndex = 31;
            this.buttonInsertarUsuario.Text = "Ver Participantes";
            this.buttonInsertarUsuario.UseVisualStyleBackColor = false;
            // 
            // labelTotalparticipantesEvento
            // 
            this.labelTotalparticipantesEvento.AutoSize = true;
            this.labelTotalparticipantesEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalparticipantesEvento.Location = new System.Drawing.Point(20, 117);
            this.labelTotalparticipantesEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalparticipantesEvento.Name = "labelTotalparticipantesEvento";
            this.labelTotalparticipantesEvento.Size = new System.Drawing.Size(243, 23);
            this.labelTotalparticipantesEvento.TabIndex = 23;
            this.labelTotalparticipantesEvento.Text = "Total participantes apuntados:";
            // 
            // textBoxTotalparticipantesEvento
            // 
            this.textBoxTotalparticipantesEvento.Location = new System.Drawing.Point(447, 113);
            this.textBoxTotalparticipantesEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalparticipantesEvento.Name = "textBoxTotalparticipantesEvento";
            this.textBoxTotalparticipantesEvento.Size = new System.Drawing.Size(216, 31);
            this.textBoxTotalparticipantesEvento.TabIndex = 20;
            // 
            // textBoxMaximoasistentesEvento
            // 
            this.textBoxMaximoasistentesEvento.Location = new System.Drawing.Point(447, 70);
            this.textBoxMaximoasistentesEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaximoasistentesEvento.Name = "textBoxMaximoasistentesEvento";
            this.textBoxMaximoasistentesEvento.Size = new System.Drawing.Size(216, 31);
            this.textBoxMaximoasistentesEvento.TabIndex = 19;
            // 
            // labelMaximoasistentesEvento
            // 
            this.labelMaximoasistentesEvento.AutoSize = true;
            this.labelMaximoasistentesEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaximoasistentesEvento.Location = new System.Drawing.Point(20, 74);
            this.labelMaximoasistentesEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaximoasistentesEvento.Name = "labelMaximoasistentesEvento";
            this.labelMaximoasistentesEvento.Size = new System.Drawing.Size(359, 23);
            this.labelMaximoasistentesEvento.TabIndex = 18;
            this.labelMaximoasistentesEvento.Text = "Máximo de asistentes para realizar actividad:";
            // 
            // textBoxMinimoAsistentesEvento
            // 
            this.textBoxMinimoAsistentesEvento.Location = new System.Drawing.Point(447, 28);
            this.textBoxMinimoAsistentesEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinimoAsistentesEvento.Name = "textBoxMinimoAsistentesEvento";
            this.textBoxMinimoAsistentesEvento.Size = new System.Drawing.Size(216, 31);
            this.textBoxMinimoAsistentesEvento.TabIndex = 17;
            // 
            // labelMinimoAsistentesEvento
            // 
            this.labelMinimoAsistentesEvento.AutoSize = true;
            this.labelMinimoAsistentesEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimoAsistentesEvento.Location = new System.Drawing.Point(20, 32);
            this.labelMinimoAsistentesEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinimoAsistentesEvento.Name = "labelMinimoAsistentesEvento";
            this.labelMinimoAsistentesEvento.Size = new System.Drawing.Size(355, 23);
            this.labelMinimoAsistentesEvento.TabIndex = 17;
            this.labelMinimoAsistentesEvento.Text = "Mínimo de asistentes para realizar actividad:";
            // 
            // textBoxTituloEvento
            // 
            this.textBoxTituloEvento.Location = new System.Drawing.Point(149, 22);
            this.textBoxTituloEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTituloEvento.Name = "textBoxTituloEvento";
            this.textBoxTituloEvento.Size = new System.Drawing.Size(584, 22);
            this.textBoxTituloEvento.TabIndex = 27;
            // 
            // textBoxFechaEvento
            // 
            this.textBoxFechaEvento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxFechaEvento.Location = new System.Drawing.Point(149, 68);
            this.textBoxFechaEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFechaEvento.Name = "textBoxFechaEvento";
            this.textBoxFechaEvento.Size = new System.Drawing.Size(245, 22);
            this.textBoxFechaEvento.TabIndex = 28;
            // 
            // comboBoxTipoEvento
            // 
            this.comboBoxTipoEvento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxTipoEvento.FormattingEnabled = true;
            this.comboBoxTipoEvento.Location = new System.Drawing.Point(531, 68);
            this.comboBoxTipoEvento.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipoEvento.Name = "comboBoxTipoEvento";
            this.comboBoxTipoEvento.Size = new System.Drawing.Size(203, 24);
            this.comboBoxTipoEvento.TabIndex = 29;
            // 
            // buttonInsertarEvento
            // 
            this.buttonInsertarEvento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsertarEvento.FlatAppearance.BorderSize = 2;
            this.buttonInsertarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertarEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarEvento.Location = new System.Drawing.Point(541, 828);
            this.buttonInsertarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsertarEvento.Name = "buttonInsertarEvento";
            this.buttonInsertarEvento.Size = new System.Drawing.Size(172, 42);
            this.buttonInsertarEvento.TabIndex = 32;
            this.buttonInsertarEvento.Text = "Insertar";
            this.buttonInsertarEvento.UseVisualStyleBackColor = false;
            // 
            // labelNumeroEvento
            // 
            this.labelNumeroEvento.AutoSize = true;
            this.labelNumeroEvento.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroEvento.Location = new System.Drawing.Point(24, 841);
            this.labelNumeroEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroEvento.Name = "labelNumeroEvento";
            this.labelNumeroEvento.Size = new System.Drawing.Size(22, 18);
            this.labelNumeroEvento.TabIndex = 33;
            this.labelNumeroEvento.Text = "1#";
            // 
            // comboBoxProvincias
            // 
            this.comboBoxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincias.FormattingEnabled = true;
            this.comboBoxProvincias.Location = new System.Drawing.Point(164, 68);
            this.comboBoxProvincias.Name = "comboBoxProvincias";
            this.comboBoxProvincias.Size = new System.Drawing.Size(499, 34);
            this.comboBoxProvincias.TabIndex = 26;
            // 
            // bindingSourceProvincies
            // 
            this.bindingSourceProvincies.DataSource = typeof(Chrysallis_Eventos.MODELOS.provincies);
            // 
            // bindingSourceTipoEventos
            // 
            this.bindingSourceTipoEventos.DataSource = typeof(Chrysallis_Eventos.MODELOS.tipus_events);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(499, 34);
            this.comboBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ciudad:";
            // 
            // FormInsertarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 884);
            this.Controls.Add(this.labelNumeroEvento);
            this.Controls.Add(this.buttonInsertarEvento);
            this.Controls.Add(this.comboBoxTipoEvento);
            this.Controls.Add(this.textBoxFechaEvento);
            this.Controls.Add(this.textBoxTituloEvento);
            this.Controls.Add(this.groupBoxParticipantesEvento);
            this.Controls.Add(this.groupBoxCosteEvento);
            this.Controls.Add(this.richTextBoxDescripcionEvento);
            this.Controls.Add(this.labelDescripcionEvento);
            this.Controls.Add(this.groupBoxUbicacionEvento);
            this.Controls.Add(this.labelTipoEvento);
            this.Controls.Add(this.labelFechaEvento);
            this.Controls.Add(this.labelTituloEvento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInsertarEventos";
            this.Text = "Insertar Eventos";
            this.Load += new System.EventHandler(this.FormInsertarEventos_Load);
            this.groupBoxUbicacionEvento.ResumeLayout(false);
            this.groupBoxUbicacionEvento.PerformLayout();
            this.groupBoxCosteEvento.ResumeLayout(false);
            this.groupBoxCosteEvento.PerformLayout();
            this.groupBoxParticipantesEvento.ResumeLayout(false);
            this.groupBoxParticipantesEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloEvento;
        private System.Windows.Forms.Label labelFechaEvento;
        private System.Windows.Forms.Label labelTipoEvento;
        private System.Windows.Forms.GroupBox groupBoxUbicacionEvento;
        private System.Windows.Forms.Label labelCodigoPostalEvento;
        private System.Windows.Forms.Label labelDireccionEvento;
        private System.Windows.Forms.Label labelCiudadEvento;
        private System.Windows.Forms.TextBox textBoxCodigoPostalEvento;
        private System.Windows.Forms.TextBox textBoxDireccionEvento;
        private System.Windows.Forms.TextBox textBoxCiudadEvento;
        private System.Windows.Forms.Label labelProvinciaEvento;
        private System.Windows.Forms.TextBox textBoxComunidadEvento;
        private System.Windows.Forms.Label labelComunidadEvento;
        private System.Windows.Forms.Label labelDescripcionEvento;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcionEvento;
        private System.Windows.Forms.Label labelPrecioPersonaEvento;
        private System.Windows.Forms.TextBox textBoxPrecioPersonaEvento;
        private System.Windows.Forms.GroupBox groupBoxCosteEvento;
        private System.Windows.Forms.GroupBox groupBoxParticipantesEvento;
        private System.Windows.Forms.Label labelTotalparticipantesEvento;
        private System.Windows.Forms.TextBox textBoxTotalparticipantesEvento;
        private System.Windows.Forms.TextBox textBoxMaximoasistentesEvento;
        private System.Windows.Forms.Label labelMaximoasistentesEvento;
        private System.Windows.Forms.TextBox textBoxMinimoAsistentesEvento;
        private System.Windows.Forms.Label labelMinimoAsistentesEvento;
        private System.Windows.Forms.CheckBox checkBoxActividadPagoEvento;
        private System.Windows.Forms.TextBox textBoxTituloEvento;
        private System.Windows.Forms.TextBox textBoxFechaEvento;
        private System.Windows.Forms.ComboBox comboBoxTipoEvento;
        private System.Windows.Forms.Button buttonInsertarUsuario;
        private System.Windows.Forms.Button buttonInsertarEvento;
        private System.Windows.Forms.Label labelNumeroEvento;
        private System.Windows.Forms.ComboBox comboBoxProvincias;
        private System.Windows.Forms.BindingSource bindingSourceProvincies;
        private System.Windows.Forms.BindingSource bindingSourceTipoEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}