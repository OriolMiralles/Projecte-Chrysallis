
namespace Chrysallis_Eventos
{
    partial class FormEventos
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
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrecaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomunitatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imatgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitatmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitatmínimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datamaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlocalitatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contassitentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunitatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipuseventsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceGridEventos = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxBuscarEvent = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscarEvent = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceComboComuni = new System.Windows.Forms.BindingSource(this.components);
            this.labelComunidad = new System.Windows.Forms.Label();
            this.comboBoxComunidades = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGridEventos)).BeginInit();
            this.groupBoxBuscarEvent.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComboComuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AllowUserToAddRows = false;
            this.dataGridViewEvents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEvents.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descripcioDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.titolDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.adrecaDataGridViewTextBoxColumn,
            this.idcomunitatDataGridViewTextBoxColumn,
            this.latitudDataGridViewTextBoxColumn,
            this.longitudDataGridViewTextBoxColumn,
            this.imatgeDataGridViewTextBoxColumn,
            this.quantitatmaxDataGridViewTextBoxColumn,
            this.quantitatmínimaDataGridViewTextBoxColumn,
            this.preuDataGridViewTextBoxColumn,
            this.pagamentDataGridViewTextBoxColumn,
            this.datamaxDataGridViewTextBoxColumn,
            this.idlocalitatDataGridViewTextBoxColumn,
            this.contassitentsDataGridViewTextBoxColumn,
            this.idtipusDataGridViewTextBoxColumn,
            this.meetDataGridViewTextBoxColumn,
            this.assistirDataGridViewTextBoxColumn,
            this.comunitatsDataGridViewTextBoxColumn,
            this.documentsDataGridViewTextBoxColumn,
            this.localitatsDataGridViewTextBoxColumn,
            this.tipuseventsDataGridViewTextBoxColumn,
            this.valoracionsDataGridViewTextBoxColumn,
            this.socisDataGridViewTextBoxColumn});
            this.dataGridViewEvents.DataSource = this.bindingSourceGridEventos;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEvents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEvents.Location = new System.Drawing.Point(13, 140);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEvents.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEvents.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEvents.RowTemplate.Height = 24;
            this.dataGridViewEvents.Size = new System.Drawing.Size(775, 304);
            this.dataGridViewEvents.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "#";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 44;
            // 
            // descripcioDataGridViewTextBoxColumn
            // 
            this.descripcioDataGridViewTextBoxColumn.DataPropertyName = "descripcio";
            this.descripcioDataGridViewTextBoxColumn.HeaderText = "descripcio";
            this.descripcioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcioDataGridViewTextBoxColumn.Name = "descripcioDataGridViewTextBoxColumn";
            this.descripcioDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcioDataGridViewTextBoxColumn.Visible = false;
            this.descripcioDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titolDataGridViewTextBoxColumn
            // 
            this.titolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titolDataGridViewTextBoxColumn.DataPropertyName = "titol";
            this.titolDataGridViewTextBoxColumn.HeaderText = "Título";
            this.titolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titolDataGridViewTextBoxColumn.Name = "titolDataGridViewTextBoxColumn";
            this.titolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaDataGridViewTextBoxColumn.Visible = false;
            this.horaDataGridViewTextBoxColumn.Width = 125;
            // 
            // adrecaDataGridViewTextBoxColumn
            // 
            this.adrecaDataGridViewTextBoxColumn.DataPropertyName = "adreca";
            this.adrecaDataGridViewTextBoxColumn.HeaderText = "adreca";
            this.adrecaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adrecaDataGridViewTextBoxColumn.Name = "adrecaDataGridViewTextBoxColumn";
            this.adrecaDataGridViewTextBoxColumn.ReadOnly = true;
            this.adrecaDataGridViewTextBoxColumn.Visible = false;
            this.adrecaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idcomunitatDataGridViewTextBoxColumn
            // 
            this.idcomunitatDataGridViewTextBoxColumn.DataPropertyName = "id_comunitat";
            this.idcomunitatDataGridViewTextBoxColumn.HeaderText = "id_comunitat";
            this.idcomunitatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcomunitatDataGridViewTextBoxColumn.Name = "idcomunitatDataGridViewTextBoxColumn";
            this.idcomunitatDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcomunitatDataGridViewTextBoxColumn.Visible = false;
            this.idcomunitatDataGridViewTextBoxColumn.Width = 125;
            // 
            // latitudDataGridViewTextBoxColumn
            // 
            this.latitudDataGridViewTextBoxColumn.DataPropertyName = "latitud";
            this.latitudDataGridViewTextBoxColumn.HeaderText = "latitud";
            this.latitudDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.latitudDataGridViewTextBoxColumn.Name = "latitudDataGridViewTextBoxColumn";
            this.latitudDataGridViewTextBoxColumn.ReadOnly = true;
            this.latitudDataGridViewTextBoxColumn.Visible = false;
            this.latitudDataGridViewTextBoxColumn.Width = 125;
            // 
            // longitudDataGridViewTextBoxColumn
            // 
            this.longitudDataGridViewTextBoxColumn.DataPropertyName = "longitud";
            this.longitudDataGridViewTextBoxColumn.HeaderText = "longitud";
            this.longitudDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.longitudDataGridViewTextBoxColumn.Name = "longitudDataGridViewTextBoxColumn";
            this.longitudDataGridViewTextBoxColumn.ReadOnly = true;
            this.longitudDataGridViewTextBoxColumn.Visible = false;
            this.longitudDataGridViewTextBoxColumn.Width = 125;
            // 
            // imatgeDataGridViewTextBoxColumn
            // 
            this.imatgeDataGridViewTextBoxColumn.DataPropertyName = "imatge";
            this.imatgeDataGridViewTextBoxColumn.HeaderText = "imatge";
            this.imatgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imatgeDataGridViewTextBoxColumn.Name = "imatgeDataGridViewTextBoxColumn";
            this.imatgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imatgeDataGridViewTextBoxColumn.Visible = false;
            this.imatgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantitatmaxDataGridViewTextBoxColumn
            // 
            this.quantitatmaxDataGridViewTextBoxColumn.DataPropertyName = "quantitat_max";
            this.quantitatmaxDataGridViewTextBoxColumn.HeaderText = "quantitat_max";
            this.quantitatmaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantitatmaxDataGridViewTextBoxColumn.Name = "quantitatmaxDataGridViewTextBoxColumn";
            this.quantitatmaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantitatmaxDataGridViewTextBoxColumn.Visible = false;
            this.quantitatmaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantitatmínimaDataGridViewTextBoxColumn
            // 
            this.quantitatmínimaDataGridViewTextBoxColumn.DataPropertyName = "quantitat_mínima";
            this.quantitatmínimaDataGridViewTextBoxColumn.HeaderText = "quantitat_mínima";
            this.quantitatmínimaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantitatmínimaDataGridViewTextBoxColumn.Name = "quantitatmínimaDataGridViewTextBoxColumn";
            this.quantitatmínimaDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantitatmínimaDataGridViewTextBoxColumn.Visible = false;
            this.quantitatmínimaDataGridViewTextBoxColumn.Width = 125;
            // 
            // preuDataGridViewTextBoxColumn
            // 
            this.preuDataGridViewTextBoxColumn.DataPropertyName = "preu";
            this.preuDataGridViewTextBoxColumn.HeaderText = "preu";
            this.preuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preuDataGridViewTextBoxColumn.Name = "preuDataGridViewTextBoxColumn";
            this.preuDataGridViewTextBoxColumn.ReadOnly = true;
            this.preuDataGridViewTextBoxColumn.Visible = false;
            this.preuDataGridViewTextBoxColumn.Width = 125;
            // 
            // pagamentDataGridViewTextBoxColumn
            // 
            this.pagamentDataGridViewTextBoxColumn.DataPropertyName = "pagament";
            this.pagamentDataGridViewTextBoxColumn.HeaderText = "pagament";
            this.pagamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pagamentDataGridViewTextBoxColumn.Name = "pagamentDataGridViewTextBoxColumn";
            this.pagamentDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagamentDataGridViewTextBoxColumn.Visible = false;
            this.pagamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // datamaxDataGridViewTextBoxColumn
            // 
            this.datamaxDataGridViewTextBoxColumn.DataPropertyName = "data_max";
            this.datamaxDataGridViewTextBoxColumn.HeaderText = "data_max";
            this.datamaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datamaxDataGridViewTextBoxColumn.Name = "datamaxDataGridViewTextBoxColumn";
            this.datamaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.datamaxDataGridViewTextBoxColumn.Visible = false;
            this.datamaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // idlocalitatDataGridViewTextBoxColumn
            // 
            this.idlocalitatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idlocalitatDataGridViewTextBoxColumn.DataPropertyName = "id_localitat";
            this.idlocalitatDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.idlocalitatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlocalitatDataGridViewTextBoxColumn.Name = "idlocalitatDataGridViewTextBoxColumn";
            this.idlocalitatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contassitentsDataGridViewTextBoxColumn
            // 
            this.contassitentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contassitentsDataGridViewTextBoxColumn.DataPropertyName = "cont_assitents";
            this.contassitentsDataGridViewTextBoxColumn.HeaderText = "Asistentes";
            this.contassitentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contassitentsDataGridViewTextBoxColumn.Name = "contassitentsDataGridViewTextBoxColumn";
            this.contassitentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtipusDataGridViewTextBoxColumn
            // 
            this.idtipusDataGridViewTextBoxColumn.DataPropertyName = "id_tipus";
            this.idtipusDataGridViewTextBoxColumn.HeaderText = "id_tipus";
            this.idtipusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtipusDataGridViewTextBoxColumn.Name = "idtipusDataGridViewTextBoxColumn";
            this.idtipusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtipusDataGridViewTextBoxColumn.Visible = false;
            this.idtipusDataGridViewTextBoxColumn.Width = 125;
            // 
            // meetDataGridViewTextBoxColumn
            // 
            this.meetDataGridViewTextBoxColumn.DataPropertyName = "meet";
            this.meetDataGridViewTextBoxColumn.HeaderText = "meet";
            this.meetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meetDataGridViewTextBoxColumn.Name = "meetDataGridViewTextBoxColumn";
            this.meetDataGridViewTextBoxColumn.ReadOnly = true;
            this.meetDataGridViewTextBoxColumn.Visible = false;
            this.meetDataGridViewTextBoxColumn.Width = 125;
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
            // documentsDataGridViewTextBoxColumn
            // 
            this.documentsDataGridViewTextBoxColumn.DataPropertyName = "documents";
            this.documentsDataGridViewTextBoxColumn.HeaderText = "documents";
            this.documentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentsDataGridViewTextBoxColumn.Name = "documentsDataGridViewTextBoxColumn";
            this.documentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentsDataGridViewTextBoxColumn.Visible = false;
            this.documentsDataGridViewTextBoxColumn.Width = 125;
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
            // tipuseventsDataGridViewTextBoxColumn
            // 
            this.tipuseventsDataGridViewTextBoxColumn.DataPropertyName = "tipus_events";
            this.tipuseventsDataGridViewTextBoxColumn.HeaderText = "tipus_events";
            this.tipuseventsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipuseventsDataGridViewTextBoxColumn.Name = "tipuseventsDataGridViewTextBoxColumn";
            this.tipuseventsDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipuseventsDataGridViewTextBoxColumn.Visible = false;
            this.tipuseventsDataGridViewTextBoxColumn.Width = 125;
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
            // socisDataGridViewTextBoxColumn
            // 
            this.socisDataGridViewTextBoxColumn.DataPropertyName = "socis";
            this.socisDataGridViewTextBoxColumn.HeaderText = "socis";
            this.socisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.socisDataGridViewTextBoxColumn.Name = "socisDataGridViewTextBoxColumn";
            this.socisDataGridViewTextBoxColumn.ReadOnly = true;
            this.socisDataGridViewTextBoxColumn.Visible = false;
            this.socisDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceGridEventos
            // 
            this.bindingSourceGridEventos.DataSource = typeof(Chrysallis_Eventos.MODELOS.esdeveniments);
            // 
            // groupBoxBuscarEvent
            // 
            this.groupBoxBuscarEvent.Controls.Add(this.buttonBuscar);
            this.groupBoxBuscarEvent.Controls.Add(this.textBoxBuscarEvent);
            this.groupBoxBuscarEvent.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscarEvent.Location = new System.Drawing.Point(13, 69);
            this.groupBoxBuscarEvent.Name = "groupBoxBuscarEvent";
            this.groupBoxBuscarEvent.Size = new System.Drawing.Size(776, 65);
            this.groupBoxBuscarEvent.TabIndex = 4;
            this.groupBoxBuscarEvent.TabStop = false;
            this.groupBoxBuscarEvent.Text = "Buscar";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBuscar.FlatAppearance.BorderSize = 2;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(643, 15);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(109, 41);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscarEvent
            // 
            this.textBoxBuscarEvent.Location = new System.Drawing.Point(16, 24);
            this.textBoxBuscarEvent.Name = "textBoxBuscarEvent";
            this.textBoxBuscarEvent.Size = new System.Drawing.Size(602, 23);
            this.textBoxBuscarEvent.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddEvent,
            this.toolStripButtonEditEvent,
            this.toolStripButtonDelEvent,
            this.toolStripSeparator1,
            this.toolStripButtonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddEvent
            // 
            this.toolStripButtonAddEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddEvent.Image = global::Chrysallis_Eventos.Properties.Resources.add_32px;
            this.toolStripButtonAddEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddEvent.Name = "toolStripButtonAddEvent";
            this.toolStripButtonAddEvent.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonAddEvent.Text = "Añadir";
            this.toolStripButtonAddEvent.Click += new System.EventHandler(this.toolStripButtonAddEvent_Click);
            // 
            // toolStripButtonEditEvent
            // 
            this.toolStripButtonEditEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditEvent.Image = global::Chrysallis_Eventos.Properties.Resources.edit_file_32px;
            this.toolStripButtonEditEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditEvent.Name = "toolStripButtonEditEvent";
            this.toolStripButtonEditEvent.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonEditEvent.Text = "Modificar";
            this.toolStripButtonEditEvent.Click += new System.EventHandler(this.toolStripButtonEditEvent_Click);
            // 
            // toolStripButtonDelEvent
            // 
            this.toolStripButtonDelEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelEvent.Image = global::Chrysallis_Eventos.Properties.Resources.delete_bin_32px;
            this.toolStripButtonDelEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelEvent.Name = "toolStripButtonDelEvent";
            this.toolStripButtonDelEvent.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonDelEvent.Text = "Eliminar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::Chrysallis_Eventos.Properties.Resources.exit_32px;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(29, 28);
            this.toolStripButtonExit.Text = "Salir";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // bindingSourceComboComuni
            // 
            this.bindingSourceComboComuni.DataSource = typeof(Chrysallis_Eventos.MODELOS.comunitats);
            // 
            // labelComunidad
            // 
            this.labelComunidad.AutoSize = true;
            this.labelComunidad.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComunidad.Location = new System.Drawing.Point(26, 41);
            this.labelComunidad.Name = "labelComunidad";
            this.labelComunidad.Size = new System.Drawing.Size(78, 18);
            this.labelComunidad.TabIndex = 7;
            this.labelComunidad.Text = "Comunidad";
            // 
            // comboBoxComunidades
            // 
            this.comboBoxComunidades.DataSource = this.bindingSourceComboComuni;
            this.comboBoxComunidades.DisplayMember = "nom";
            this.comboBoxComunidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidades.FormattingEnabled = true;
            this.comboBoxComunidades.Location = new System.Drawing.Point(121, 39);
            this.comboBoxComunidades.Name = "comboBoxComunidades";
            this.comboBoxComunidades.Size = new System.Drawing.Size(510, 24);
            this.comboBoxComunidades.TabIndex = 6;
            this.comboBoxComunidades.ValueMember = "id";
            this.comboBoxComunidades.SelectedIndexChanged += new System.EventHandler(this.comboBoxComunidades_SelectedIndexChanged);
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelComunidad);
            this.Controls.Add(this.comboBoxComunidades);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.groupBoxBuscarEvent);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormEventos";
            this.Text = "FormEventos";
            this.Load += new System.EventHandler(this.FormEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGridEventos)).EndInit();
            this.groupBoxBuscarEvent.ResumeLayout(false);
            this.groupBoxBuscarEvent.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComboComuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.GroupBox groupBoxBuscarEvent;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscarEvent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddEvent;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditEvent;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelEvent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.BindingSource bindingSourceGridEventos;
        private System.Windows.Forms.BindingSource bindingSourceComboComuni;
        private System.Windows.Forms.Label labelComunidad;
        private System.Windows.Forms.ComboBox comboBoxComunidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrecaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomunitatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imatgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitatmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitatmínimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datamaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocalitatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contassitentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunitatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipuseventsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socisDataGridViewTextBoxColumn;
    }
}