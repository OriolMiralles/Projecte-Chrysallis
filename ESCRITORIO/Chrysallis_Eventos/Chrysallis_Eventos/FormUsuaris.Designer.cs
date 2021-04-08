
namespace Chrysallis_Eventos
{
    partial class FormUsuaris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.textBoxBuscarUser = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.telefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanaixementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataaltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisappDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codipostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlocalitatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menorssocisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunitatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esdevenimentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceUsuarios = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxComunidades = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.labelComunidad = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.groupBoxBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddUser,
            this.toolStripButtonEditUser,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(807, 27);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButtonAddUser
            // 
            this.toolStripButtonAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUser.Image = global::Chrysallis_Eventos.Properties.Resources.add_32px;
            this.toolStripButtonAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUser.Name = "toolStripButtonAddUser";
            this.toolStripButtonAddUser.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAddUser.Text = "Añadir";
            this.toolStripButtonAddUser.Click += new System.EventHandler(this.toolStripButtonAddUser_Click);
            // 
            // toolStripButtonEditUser
            // 
            this.toolStripButtonEditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditUser.Image = global::Chrysallis_Eventos.Properties.Resources.edit_file_32px;
            this.toolStripButtonEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditUser.Name = "toolStripButtonEditUser";
            this.toolStripButtonEditUser.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEditUser.Text = "Modificar";
            this.toolStripButtonEditUser.Click += new System.EventHandler(this.toolStripButtonEditUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Chrysallis_Eventos.Properties.Resources.exit_32px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.checkBoxActivo);
            this.groupBoxBuscar.Controls.Add(this.textBoxBuscarUser);
            this.groupBoxBuscar.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscar.Location = new System.Drawing.Point(13, 66);
            this.groupBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBuscar.Size = new System.Drawing.Size(776, 65);
            this.groupBoxBuscar.TabIndex = 1;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar";
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActivo.Location = new System.Drawing.Point(661, 26);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(81, 27);
            this.checkBoxActivo.TabIndex = 1;
            this.checkBoxActivo.Text = "Activo";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            this.checkBoxActivo.CheckedChanged += new System.EventHandler(this.checkBoxActivo_CheckedChanged);
            // 
            // textBoxBuscarUser
            // 
            this.textBoxBuscarUser.Location = new System.Drawing.Point(16, 25);
            this.textBoxBuscarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscarUser.Name = "textBoxBuscarUser";
            this.textBoxBuscarUser.Size = new System.Drawing.Size(591, 23);
            this.textBoxBuscarUser.TabIndex = 0;
            this.textBoxBuscarUser.TextChanged += new System.EventHandler(this.textBoxBuscarUser_TextChanged);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.cognomsDataGridViewTextBoxColumn,
            this.actiuDataGridViewCheckBoxColumn,
            this.telefon1DataGridViewTextBoxColumn,
            this.telefon2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.contrasenyaDataGridViewTextBoxColumn,
            this.datanaixementDataGridViewTextBoxColumn,
            this.databaixaDataGridViewTextBoxColumn,
            this.dataaltaDataGridViewTextBoxColumn,
            this.permisappDataGridViewCheckBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.codipostalDataGridViewTextBoxColumn,
            this.idlocalitatDataGridViewTextBoxColumn,
            this.assistirDataGridViewTextBoxColumn,
            this.localitatsDataGridViewTextBoxColumn,
            this.menorssocisDataGridViewTextBoxColumn,
            this.valoracionsDataGridViewTextBoxColumn,
            this.comunitatsDataGridViewTextBoxColumn,
            this.esdevenimentsDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.bindingSourceUsuarios;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUsers.Location = new System.Drawing.Point(13, 138);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(775, 336);
            this.dataGridViewUsers.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num Socio";
            this.numDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cognomsDataGridViewTextBoxColumn
            // 
            this.cognomsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cognomsDataGridViewTextBoxColumn.DataPropertyName = "cognoms";
            this.cognomsDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.cognomsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cognomsDataGridViewTextBoxColumn.Name = "cognomsDataGridViewTextBoxColumn";
            this.cognomsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actiuDataGridViewCheckBoxColumn
            // 
            this.actiuDataGridViewCheckBoxColumn.DataPropertyName = "actiu";
            this.actiuDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.actiuDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.actiuDataGridViewCheckBoxColumn.Name = "actiuDataGridViewCheckBoxColumn";
            this.actiuDataGridViewCheckBoxColumn.ReadOnly = true;
            this.actiuDataGridViewCheckBoxColumn.Width = 125;
            // 
            // telefon1DataGridViewTextBoxColumn
            // 
            this.telefon1DataGridViewTextBoxColumn.DataPropertyName = "telefon1";
            this.telefon1DataGridViewTextBoxColumn.HeaderText = "telefon1";
            this.telefon1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefon1DataGridViewTextBoxColumn.Name = "telefon1DataGridViewTextBoxColumn";
            this.telefon1DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefon1DataGridViewTextBoxColumn.Visible = false;
            this.telefon1DataGridViewTextBoxColumn.Width = 125;
            // 
            // telefon2DataGridViewTextBoxColumn
            // 
            this.telefon2DataGridViewTextBoxColumn.DataPropertyName = "telefon2";
            this.telefon2DataGridViewTextBoxColumn.HeaderText = "telefon2";
            this.telefon2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefon2DataGridViewTextBoxColumn.Name = "telefon2DataGridViewTextBoxColumn";
            this.telefon2DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefon2DataGridViewTextBoxColumn.Visible = false;
            this.telefon2DataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            this.dniDataGridViewTextBoxColumn.Visible = false;
            this.dniDataGridViewTextBoxColumn.Width = 125;
            // 
            // contrasenyaDataGridViewTextBoxColumn
            // 
            this.contrasenyaDataGridViewTextBoxColumn.DataPropertyName = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.HeaderText = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contrasenyaDataGridViewTextBoxColumn.Name = "contrasenyaDataGridViewTextBoxColumn";
            this.contrasenyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contrasenyaDataGridViewTextBoxColumn.Visible = false;
            this.contrasenyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // datanaixementDataGridViewTextBoxColumn
            // 
            this.datanaixementDataGridViewTextBoxColumn.DataPropertyName = "data_naixement";
            this.datanaixementDataGridViewTextBoxColumn.HeaderText = "data_naixement";
            this.datanaixementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datanaixementDataGridViewTextBoxColumn.Name = "datanaixementDataGridViewTextBoxColumn";
            this.datanaixementDataGridViewTextBoxColumn.ReadOnly = true;
            this.datanaixementDataGridViewTextBoxColumn.Visible = false;
            this.datanaixementDataGridViewTextBoxColumn.Width = 125;
            // 
            // databaixaDataGridViewTextBoxColumn
            // 
            this.databaixaDataGridViewTextBoxColumn.DataPropertyName = "data_baixa";
            this.databaixaDataGridViewTextBoxColumn.HeaderText = "data_baixa";
            this.databaixaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.databaixaDataGridViewTextBoxColumn.Name = "databaixaDataGridViewTextBoxColumn";
            this.databaixaDataGridViewTextBoxColumn.ReadOnly = true;
            this.databaixaDataGridViewTextBoxColumn.Visible = false;
            this.databaixaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataaltaDataGridViewTextBoxColumn
            // 
            this.dataaltaDataGridViewTextBoxColumn.DataPropertyName = "data_alta";
            this.dataaltaDataGridViewTextBoxColumn.HeaderText = "data_alta";
            this.dataaltaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataaltaDataGridViewTextBoxColumn.Name = "dataaltaDataGridViewTextBoxColumn";
            this.dataaltaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataaltaDataGridViewTextBoxColumn.Visible = false;
            this.dataaltaDataGridViewTextBoxColumn.Width = 125;
            // 
            // permisappDataGridViewCheckBoxColumn
            // 
            this.permisappDataGridViewCheckBoxColumn.DataPropertyName = "permis_app";
            this.permisappDataGridViewCheckBoxColumn.HeaderText = "permis_app";
            this.permisappDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.permisappDataGridViewCheckBoxColumn.Name = "permisappDataGridViewCheckBoxColumn";
            this.permisappDataGridViewCheckBoxColumn.ReadOnly = true;
            this.permisappDataGridViewCheckBoxColumn.Visible = false;
            this.permisappDataGridViewCheckBoxColumn.Width = 125;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresaDataGridViewTextBoxColumn.Visible = false;
            this.adresaDataGridViewTextBoxColumn.Width = 125;
            // 
            // codipostalDataGridViewTextBoxColumn
            // 
            this.codipostalDataGridViewTextBoxColumn.DataPropertyName = "codi_postal";
            this.codipostalDataGridViewTextBoxColumn.HeaderText = "codi_postal";
            this.codipostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codipostalDataGridViewTextBoxColumn.Name = "codipostalDataGridViewTextBoxColumn";
            this.codipostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codipostalDataGridViewTextBoxColumn.Visible = false;
            this.codipostalDataGridViewTextBoxColumn.Width = 125;
            // 
            // idlocalitatDataGridViewTextBoxColumn
            // 
            this.idlocalitatDataGridViewTextBoxColumn.DataPropertyName = "id_localitat";
            this.idlocalitatDataGridViewTextBoxColumn.HeaderText = "id_localitat";
            this.idlocalitatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlocalitatDataGridViewTextBoxColumn.Name = "idlocalitatDataGridViewTextBoxColumn";
            this.idlocalitatDataGridViewTextBoxColumn.ReadOnly = true;
            this.idlocalitatDataGridViewTextBoxColumn.Visible = false;
            this.idlocalitatDataGridViewTextBoxColumn.Width = 125;
            // 
            // assistirDataGridViewTextBoxColumn
            // 
            this.assistirDataGridViewTextBoxColumn.DataPropertyName = "assistir";
            this.assistirDataGridViewTextBoxColumn.HeaderText = "assistir";
            this.assistirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assistirDataGridViewTextBoxColumn.Name = "assistirDataGridViewTextBoxColumn";
            this.assistirDataGridViewTextBoxColumn.ReadOnly = true;
            this.assistirDataGridViewTextBoxColumn.Visible = false;
            this.assistirDataGridViewTextBoxColumn.Width = 125;
            // 
            // localitatsDataGridViewTextBoxColumn
            // 
            this.localitatsDataGridViewTextBoxColumn.DataPropertyName = "localitats";
            this.localitatsDataGridViewTextBoxColumn.HeaderText = "localitats";
            this.localitatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.localitatsDataGridViewTextBoxColumn.Name = "localitatsDataGridViewTextBoxColumn";
            this.localitatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.localitatsDataGridViewTextBoxColumn.Visible = false;
            this.localitatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // menorssocisDataGridViewTextBoxColumn
            // 
            this.menorssocisDataGridViewTextBoxColumn.DataPropertyName = "menors_socis";
            this.menorssocisDataGridViewTextBoxColumn.HeaderText = "menors_socis";
            this.menorssocisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.menorssocisDataGridViewTextBoxColumn.Name = "menorssocisDataGridViewTextBoxColumn";
            this.menorssocisDataGridViewTextBoxColumn.ReadOnly = true;
            this.menorssocisDataGridViewTextBoxColumn.Visible = false;
            this.menorssocisDataGridViewTextBoxColumn.Width = 125;
            // 
            // valoracionsDataGridViewTextBoxColumn
            // 
            this.valoracionsDataGridViewTextBoxColumn.DataPropertyName = "valoracions";
            this.valoracionsDataGridViewTextBoxColumn.HeaderText = "valoracions";
            this.valoracionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoracionsDataGridViewTextBoxColumn.Name = "valoracionsDataGridViewTextBoxColumn";
            this.valoracionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.valoracionsDataGridViewTextBoxColumn.Visible = false;
            this.valoracionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // comunitatsDataGridViewTextBoxColumn
            // 
            this.comunitatsDataGridViewTextBoxColumn.DataPropertyName = "comunitats";
            this.comunitatsDataGridViewTextBoxColumn.HeaderText = "comunitats";
            this.comunitatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comunitatsDataGridViewTextBoxColumn.Name = "comunitatsDataGridViewTextBoxColumn";
            this.comunitatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.comunitatsDataGridViewTextBoxColumn.Visible = false;
            this.comunitatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // esdevenimentsDataGridViewTextBoxColumn
            // 
            this.esdevenimentsDataGridViewTextBoxColumn.DataPropertyName = "esdeveniments";
            this.esdevenimentsDataGridViewTextBoxColumn.HeaderText = "esdeveniments";
            this.esdevenimentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.esdevenimentsDataGridViewTextBoxColumn.Name = "esdevenimentsDataGridViewTextBoxColumn";
            this.esdevenimentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.esdevenimentsDataGridViewTextBoxColumn.Visible = false;
            this.esdevenimentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceUsuarios
            // 
            this.bindingSourceUsuarios.DataSource = typeof(Chrysallis_Eventos.MODELOS.socis);
            // 
            // comboBoxComunidades
            // 
            this.comboBoxComunidades.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunidades.DisplayMember = "nom";
            this.comboBoxComunidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidades.FormattingEnabled = true;
            this.comboBoxComunidades.Location = new System.Drawing.Point(121, 37);
            this.comboBoxComunidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxComunidades.Name = "comboBoxComunidades";
            this.comboBoxComunidades.Size = new System.Drawing.Size(518, 24);
            this.comboBoxComunidades.TabIndex = 3;
            this.comboBoxComunidades.ValueMember = "id";
            this.comboBoxComunidades.SelectedIndexChanged += new System.EventHandler(this.comboBoxComunidades_SelectedIndexChanged);
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(Chrysallis_Eventos.MODELOS.comunitats);
            // 
            // labelComunidad
            // 
            this.labelComunidad.AutoSize = true;
            this.labelComunidad.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComunidad.Location = new System.Drawing.Point(27, 39);
            this.labelComunidad.Name = "labelComunidad";
            this.labelComunidad.Size = new System.Drawing.Size(78, 18);
            this.labelComunidad.TabIndex = 4;
            this.labelComunidad.Text = "Comunidad";
            // 
            // FormUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 494);
            this.Controls.Add(this.labelComunidad);
            this.Controls.Add(this.comboBoxComunidades);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUsuaris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios Chrysallis";
            this.Activated += new System.EventHandler(this.FormUsuaris_Activated);
            this.Load += new System.EventHandler(this.FormUsuaris_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.TextBox textBoxBuscarUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.ComboBox comboBoxComunidades;
        private System.Windows.Forms.Label labelComunidad;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.BindingSource bindingSourceUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actiuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanaixementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataaltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permisappDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codipostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocalitatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menorssocisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunitatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esdevenimentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBoxActivo;
    }
}