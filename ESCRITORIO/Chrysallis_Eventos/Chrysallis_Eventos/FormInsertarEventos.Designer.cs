
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCiudadesBuscadas = new System.Windows.Forms.ComboBox();
            this.bindingSourceCiutats = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxProvincias = new System.Windows.Forms.ComboBox();
            this.bindingSourceProvincies = new System.Windows.Forms.BindingSource(this.components);
            this.labelDireccionEvento = new System.Windows.Forms.Label();
            this.labelCiudadEvento = new System.Windows.Forms.Label();
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
            this.comboBoxTipoEvento = new System.Windows.Forms.ComboBox();
            this.bindingSourceTipoEventos = new System.Windows.Forms.BindingSource(this.components);
            this.buttonInsertarEvento = new System.Windows.Forms.Button();
            this.labelNumeroEvento = new System.Windows.Forms.Label();
            this.dateTimePickerEvento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.checkBoxEstatal = new System.Windows.Forms.CheckBox();
            this.groupBoxUbicacionEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCiutats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincies)).BeginInit();
            this.groupBoxCosteEvento.SuspendLayout();
            this.groupBoxParticipantesEvento.SuspendLayout();
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
            this.labelFechaEvento.Location = new System.Drawing.Point(49, 70);
            this.labelFechaEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaEvento.Name = "labelFechaEvento";
            this.labelFechaEvento.Size = new System.Drawing.Size(54, 23);
            this.labelFechaEvento.TabIndex = 2;
            this.labelFechaEvento.Text = "Fecha";
            // 
            // labelTipoEvento
            // 
            this.labelTipoEvento.AutoSize = true;
            this.labelTipoEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoEvento.Location = new System.Drawing.Point(49, 162);
            this.labelTipoEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoEvento.Name = "labelTipoEvento";
            this.labelTipoEvento.Size = new System.Drawing.Size(128, 23);
            this.labelTipoEvento.TabIndex = 7;
            this.labelTipoEvento.Text = "Tipo de evento:";
            // 
            // groupBoxUbicacionEvento
            // 
            this.groupBoxUbicacionEvento.Controls.Add(this.label1);
            this.groupBoxUbicacionEvento.Controls.Add(this.comboBoxCiudadesBuscadas);
            this.groupBoxUbicacionEvento.Controls.Add(this.comboBoxProvincias);
            this.groupBoxUbicacionEvento.Controls.Add(this.labelDireccionEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.labelCiudadEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.textBoxDireccionEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.textBoxCiudadEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.labelProvinciaEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.textBoxComunidadEvento);
            this.groupBoxUbicacionEvento.Controls.Add(this.labelComunidadEvento);
            this.groupBoxUbicacionEvento.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUbicacionEvento.Location = new System.Drawing.Point(51, 204);
            this.groupBoxUbicacionEvento.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUbicacionEvento.Name = "groupBoxUbicacionEvento";
            this.groupBoxUbicacionEvento.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUbicacionEvento.Size = new System.Drawing.Size(707, 229);
            this.groupBoxUbicacionEvento.TabIndex = 9;
            this.groupBoxUbicacionEvento.TabStop = false;
            this.groupBoxUbicacionEvento.Text = "Ubicación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ciudad:";
            // 
            // comboBoxCiudadesBuscadas
            // 
            this.comboBoxCiudadesBuscadas.DataSource = this.bindingSourceCiutats;
            this.comboBoxCiudadesBuscadas.DisplayMember = "nom";
            this.comboBoxCiudadesBuscadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCiudadesBuscadas.FormattingEnabled = true;
            this.comboBoxCiudadesBuscadas.Location = new System.Drawing.Point(164, 147);
            this.comboBoxCiudadesBuscadas.Name = "comboBoxCiudadesBuscadas";
            this.comboBoxCiudadesBuscadas.Size = new System.Drawing.Size(499, 34);
            this.comboBoxCiudadesBuscadas.TabIndex = 7;
            this.comboBoxCiudadesBuscadas.ValueMember = "id";
            // 
            // bindingSourceCiutats
            // 
            this.bindingSourceCiutats.DataSource = typeof(Chrysallis_Eventos.MODELOS.localitats);
            // 
            // comboBoxProvincias
            // 
            this.comboBoxProvincias.DataSource = this.bindingSourceProvincies;
            this.comboBoxProvincias.DisplayMember = "nom";
            this.comboBoxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincias.FormattingEnabled = true;
            this.comboBoxProvincias.Location = new System.Drawing.Point(164, 68);
            this.comboBoxProvincias.Name = "comboBoxProvincias";
            this.comboBoxProvincias.Size = new System.Drawing.Size(499, 34);
            this.comboBoxProvincias.TabIndex = 3;
            this.comboBoxProvincias.ValueMember = "id_comunitat";
            this.comboBoxProvincias.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincias_SelectedIndexChanged);
            // 
            // bindingSourceProvincies
            // 
            this.bindingSourceProvincies.DataSource = typeof(Chrysallis_Eventos.MODELOS.provincies);
            // 
            // labelDireccionEvento
            // 
            this.labelDireccionEvento.AutoSize = true;
            this.labelDireccionEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccionEvento.Location = new System.Drawing.Point(21, 194);
            this.labelDireccionEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccionEvento.Name = "labelDireccionEvento";
            this.labelDireccionEvento.Size = new System.Drawing.Size(86, 23);
            this.labelDireccionEvento.TabIndex = 8;
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
            this.labelCiudadEvento.TabIndex = 4;
            this.labelCiudadEvento.Text = "Buscar ciudad:";
            // 
            // textBoxDireccionEvento
            // 
            this.textBoxDireccionEvento.Location = new System.Drawing.Point(164, 188);
            this.textBoxDireccionEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDireccionEvento.Name = "textBoxDireccionEvento";
            this.textBoxDireccionEvento.Size = new System.Drawing.Size(499, 31);
            this.textBoxDireccionEvento.TabIndex = 9;
            // 
            // textBoxCiudadEvento
            // 
            this.textBoxCiudadEvento.Location = new System.Drawing.Point(164, 109);
            this.textBoxCiudadEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCiudadEvento.Name = "textBoxCiudadEvento";
            this.textBoxCiudadEvento.Size = new System.Drawing.Size(499, 31);
            this.textBoxCiudadEvento.TabIndex = 5;
            this.textBoxCiudadEvento.TextChanged += new System.EventHandler(this.textBoxCiudadEvento_TextChanged);
            // 
            // labelProvinciaEvento
            // 
            this.labelProvinciaEvento.AutoSize = true;
            this.labelProvinciaEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvinciaEvento.Location = new System.Drawing.Point(20, 74);
            this.labelProvinciaEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProvinciaEvento.Name = "labelProvinciaEvento";
            this.labelProvinciaEvento.Size = new System.Drawing.Size(85, 23);
            this.labelProvinciaEvento.TabIndex = 2;
            this.labelProvinciaEvento.Text = "Província:";
            // 
            // textBoxComunidadEvento
            // 
            this.textBoxComunidadEvento.Location = new System.Drawing.Point(164, 28);
            this.textBoxComunidadEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComunidadEvento.Name = "textBoxComunidadEvento";
            this.textBoxComunidadEvento.ReadOnly = true;
            this.textBoxComunidadEvento.Size = new System.Drawing.Size(499, 31);
            this.textBoxComunidadEvento.TabIndex = 1;
            // 
            // labelComunidadEvento
            // 
            this.labelComunidadEvento.AutoSize = true;
            this.labelComunidadEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComunidadEvento.Location = new System.Drawing.Point(20, 32);
            this.labelComunidadEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComunidadEvento.Name = "labelComunidadEvento";
            this.labelComunidadEvento.Size = new System.Drawing.Size(99, 23);
            this.labelComunidadEvento.TabIndex = 0;
            this.labelComunidadEvento.Text = "Comunidad:";
            // 
            // labelDescripcionEvento
            // 
            this.labelDescripcionEvento.AutoSize = true;
            this.labelDescripcionEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionEvento.Location = new System.Drawing.Point(72, 448);
            this.labelDescripcionEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripcionEvento.Name = "labelDescripcionEvento";
            this.labelDescripcionEvento.Size = new System.Drawing.Size(108, 23);
            this.labelDescripcionEvento.TabIndex = 10;
            this.labelDescripcionEvento.Text = "Descripcion: ";
            // 
            // richTextBoxDescripcionEvento
            // 
            this.richTextBoxDescripcionEvento.Location = new System.Drawing.Point(215, 448);
            this.richTextBoxDescripcionEvento.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDescripcionEvento.Name = "richTextBoxDescripcionEvento";
            this.richTextBoxDescripcionEvento.Size = new System.Drawing.Size(541, 117);
            this.richTextBoxDescripcionEvento.TabIndex = 11;
            this.richTextBoxDescripcionEvento.Text = "";
            // 
            // labelPrecioPersonaEvento
            // 
            this.labelPrecioPersonaEvento.AutoSize = true;
            this.labelPrecioPersonaEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioPersonaEvento.Location = new System.Drawing.Point(260, 36);
            this.labelPrecioPersonaEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecioPersonaEvento.Name = "labelPrecioPersonaEvento";
            this.labelPrecioPersonaEvento.Size = new System.Drawing.Size(157, 23);
            this.labelPrecioPersonaEvento.TabIndex = 1;
            this.labelPrecioPersonaEvento.Text = "Precio por persona:";
            // 
            // textBoxPrecioPersonaEvento
            // 
            this.textBoxPrecioPersonaEvento.Location = new System.Drawing.Point(447, 30);
            this.textBoxPrecioPersonaEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecioPersonaEvento.Name = "textBoxPrecioPersonaEvento";
            this.textBoxPrecioPersonaEvento.Size = new System.Drawing.Size(216, 31);
            this.textBoxPrecioPersonaEvento.TabIndex = 2;
            // 
            // groupBoxCosteEvento
            // 
            this.groupBoxCosteEvento.Controls.Add(this.checkBoxActividadPagoEvento);
            this.groupBoxCosteEvento.Controls.Add(this.textBoxPrecioPersonaEvento);
            this.groupBoxCosteEvento.Controls.Add(this.labelPrecioPersonaEvento);
            this.groupBoxCosteEvento.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCosteEvento.Location = new System.Drawing.Point(51, 573);
            this.groupBoxCosteEvento.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCosteEvento.Name = "groupBoxCosteEvento";
            this.groupBoxCosteEvento.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCosteEvento.Size = new System.Drawing.Size(685, 85);
            this.groupBoxCosteEvento.TabIndex = 12;
            this.groupBoxCosteEvento.TabStop = false;
            this.groupBoxCosteEvento.Text = "Coste";
            // 
            // checkBoxActividadPagoEvento
            // 
            this.checkBoxActividadPagoEvento.AutoSize = true;
            this.checkBoxActividadPagoEvento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActividadPagoEvento.Checked = true;
            this.checkBoxActividadPagoEvento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActividadPagoEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActividadPagoEvento.Location = new System.Drawing.Point(21, 36);
            this.checkBoxActividadPagoEvento.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxActividadPagoEvento.Name = "checkBoxActividadPagoEvento";
            this.checkBoxActividadPagoEvento.Size = new System.Drawing.Size(174, 27);
            this.checkBoxActividadPagoEvento.TabIndex = 0;
            this.checkBoxActividadPagoEvento.Text = "Actividad de pago:";
            this.checkBoxActividadPagoEvento.UseVisualStyleBackColor = true;
            this.checkBoxActividadPagoEvento.CheckedChanged += new System.EventHandler(this.checkBoxActividadPagoEvento_CheckedChanged);
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
            this.groupBoxParticipantesEvento.Location = new System.Drawing.Point(51, 665);
            this.groupBoxParticipantesEvento.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxParticipantesEvento.Name = "groupBoxParticipantesEvento";
            this.groupBoxParticipantesEvento.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxParticipantesEvento.Size = new System.Drawing.Size(685, 222);
            this.groupBoxParticipantesEvento.TabIndex = 13;
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
            this.buttonInsertarUsuario.TabIndex = 6;
            this.buttonInsertarUsuario.Text = "Ver Participantes";
            this.buttonInsertarUsuario.UseVisualStyleBackColor = false;
            this.buttonInsertarUsuario.Click += new System.EventHandler(this.buttonInsertarUsuario_Click);
            // 
            // labelTotalparticipantesEvento
            // 
            this.labelTotalparticipantesEvento.AutoSize = true;
            this.labelTotalparticipantesEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalparticipantesEvento.Location = new System.Drawing.Point(20, 117);
            this.labelTotalparticipantesEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalparticipantesEvento.Name = "labelTotalparticipantesEvento";
            this.labelTotalparticipantesEvento.Size = new System.Drawing.Size(243, 23);
            this.labelTotalparticipantesEvento.TabIndex = 4;
            this.labelTotalparticipantesEvento.Text = "Total participantes apuntades:";
            // 
            // textBoxTotalparticipantesEvento
            // 
            this.textBoxTotalparticipantesEvento.Location = new System.Drawing.Point(447, 113);
            this.textBoxTotalparticipantesEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalparticipantesEvento.Name = "textBoxTotalparticipantesEvento";
            this.textBoxTotalparticipantesEvento.ReadOnly = true;
            this.textBoxTotalparticipantesEvento.Size = new System.Drawing.Size(216, 31);
            this.textBoxTotalparticipantesEvento.TabIndex = 5;
            // 
            // textBoxMaximoasistentesEvento
            // 
            this.textBoxMaximoasistentesEvento.Location = new System.Drawing.Point(447, 70);
            this.textBoxMaximoasistentesEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaximoasistentesEvento.Name = "textBoxMaximoasistentesEvento";
            this.textBoxMaximoasistentesEvento.Size = new System.Drawing.Size(216, 31);
            this.textBoxMaximoasistentesEvento.TabIndex = 3;
            // 
            // labelMaximoasistentesEvento
            // 
            this.labelMaximoasistentesEvento.AutoSize = true;
            this.labelMaximoasistentesEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaximoasistentesEvento.Location = new System.Drawing.Point(20, 74);
            this.labelMaximoasistentesEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaximoasistentesEvento.Name = "labelMaximoasistentesEvento";
            this.labelMaximoasistentesEvento.Size = new System.Drawing.Size(359, 23);
            this.labelMaximoasistentesEvento.TabIndex = 2;
            this.labelMaximoasistentesEvento.Text = "Máximo de asistentes para realizar actividad:";
            // 
            // textBoxMinimoAsistentesEvento
            // 
            this.textBoxMinimoAsistentesEvento.Location = new System.Drawing.Point(447, 28);
            this.textBoxMinimoAsistentesEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinimoAsistentesEvento.Name = "textBoxMinimoAsistentesEvento";
            this.textBoxMinimoAsistentesEvento.Size = new System.Drawing.Size(216, 31);
            this.textBoxMinimoAsistentesEvento.TabIndex = 1;
            // 
            // labelMinimoAsistentesEvento
            // 
            this.labelMinimoAsistentesEvento.AutoSize = true;
            this.labelMinimoAsistentesEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimoAsistentesEvento.Location = new System.Drawing.Point(20, 32);
            this.labelMinimoAsistentesEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinimoAsistentesEvento.Name = "labelMinimoAsistentesEvento";
            this.labelMinimoAsistentesEvento.Size = new System.Drawing.Size(355, 23);
            this.labelMinimoAsistentesEvento.TabIndex = 0;
            this.labelMinimoAsistentesEvento.Text = "Mínimo de asistentes para realizar actividad:";
            // 
            // textBoxTituloEvento
            // 
            this.textBoxTituloEvento.Location = new System.Drawing.Point(215, 26);
            this.textBoxTituloEvento.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTituloEvento.Name = "textBoxTituloEvento";
            this.textBoxTituloEvento.Size = new System.Drawing.Size(541, 22);
            this.textBoxTituloEvento.TabIndex = 1;
            this.textBoxTituloEvento.TextChanged += new System.EventHandler(this.textBoxTituloEvento_TextChanged);
            // 
            // comboBoxTipoEvento
            // 
            this.comboBoxTipoEvento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxTipoEvento.DataSource = this.bindingSourceTipoEventos;
            this.comboBoxTipoEvento.DisplayMember = "nom";
            this.comboBoxTipoEvento.FormattingEnabled = true;
            this.comboBoxTipoEvento.Location = new System.Drawing.Point(215, 161);
            this.comboBoxTipoEvento.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipoEvento.Name = "comboBoxTipoEvento";
            this.comboBoxTipoEvento.Size = new System.Drawing.Size(294, 24);
            this.comboBoxTipoEvento.TabIndex = 8;
            this.comboBoxTipoEvento.ValueMember = "idTipus";
            this.comboBoxTipoEvento.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoEvento_SelectedIndexChanged);
            // 
            // bindingSourceTipoEventos
            // 
            this.bindingSourceTipoEventos.DataSource = typeof(Chrysallis_Eventos.MODELOS.tipus_events);
            // 
            // buttonInsertarEvento
            // 
            this.buttonInsertarEvento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsertarEvento.FlatAppearance.BorderSize = 2;
            this.buttonInsertarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertarEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarEvento.Location = new System.Drawing.Point(564, 893);
            this.buttonInsertarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsertarEvento.Name = "buttonInsertarEvento";
            this.buttonInsertarEvento.Size = new System.Drawing.Size(172, 42);
            this.buttonInsertarEvento.TabIndex = 15;
            this.buttonInsertarEvento.Text = "Insertar";
            this.buttonInsertarEvento.UseVisualStyleBackColor = false;
            this.buttonInsertarEvento.Click += new System.EventHandler(this.buttonInsertarEvento_Click);
            // 
            // labelNumeroEvento
            // 
            this.labelNumeroEvento.AutoSize = true;
            this.labelNumeroEvento.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroEvento.Location = new System.Drawing.Point(47, 906);
            this.labelNumeroEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroEvento.Name = "labelNumeroEvento";
            this.labelNumeroEvento.Size = new System.Drawing.Size(22, 18);
            this.labelNumeroEvento.TabIndex = 14;
            this.labelNumeroEvento.Text = "1#";
            // 
            // dateTimePickerEvento
            // 
            this.dateTimePickerEvento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEvento.Location = new System.Drawing.Point(215, 66);
            this.dateTimePickerEvento.Name = "dateTimePickerEvento";
            this.dateTimePickerEvento.Size = new System.Drawing.Size(351, 27);
            this.dateTimePickerEvento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hora";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHora.Location = new System.Drawing.Point(215, 113);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.Size = new System.Drawing.Size(147, 27);
            this.dateTimePickerHora.TabIndex = 6;
            // 
            // checkBoxEstatal
            // 
            this.checkBoxEstatal.AutoSize = true;
            this.checkBoxEstatal.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstatal.Location = new System.Drawing.Point(615, 66);
            this.checkBoxEstatal.Name = "checkBoxEstatal";
            this.checkBoxEstatal.Size = new System.Drawing.Size(143, 27);
            this.checkBoxEstatal.TabIndex = 4;
            this.checkBoxEstatal.Text = "Evento estatal";
            this.checkBoxEstatal.UseVisualStyleBackColor = true;
            // 
            // FormInsertarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 1044);
            this.Controls.Add(this.checkBoxEstatal);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerEvento);
            this.Controls.Add(this.labelNumeroEvento);
            this.Controls.Add(this.buttonInsertarEvento);
            this.Controls.Add(this.comboBoxTipoEvento);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar eventos";
            this.Load += new System.EventHandler(this.FormInsertarEventos_Load);
            this.groupBoxUbicacionEvento.ResumeLayout(false);
            this.groupBoxUbicacionEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCiutats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProvincies)).EndInit();
            this.groupBoxCosteEvento.ResumeLayout(false);
            this.groupBoxCosteEvento.PerformLayout();
            this.groupBoxParticipantesEvento.ResumeLayout(false);
            this.groupBoxParticipantesEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloEvento;
        private System.Windows.Forms.Label labelFechaEvento;
        private System.Windows.Forms.Label labelTipoEvento;
        private System.Windows.Forms.GroupBox groupBoxUbicacionEvento;
        private System.Windows.Forms.Label labelDireccionEvento;
        private System.Windows.Forms.Label labelCiudadEvento;
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
        private System.Windows.Forms.ComboBox comboBoxTipoEvento;
        private System.Windows.Forms.Button buttonInsertarUsuario;
        private System.Windows.Forms.Button buttonInsertarEvento;
        private System.Windows.Forms.Label labelNumeroEvento;
        private System.Windows.Forms.ComboBox comboBoxProvincias;
        private System.Windows.Forms.BindingSource bindingSourceProvincies;
        private System.Windows.Forms.BindingSource bindingSourceTipoEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCiudadesBuscadas;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvento;
        private System.Windows.Forms.BindingSource bindingSourceCiutats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.CheckBox checkBoxEstatal;
    }
}