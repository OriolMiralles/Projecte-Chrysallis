
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
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.groupBoxBuscarEvent = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscarEvent = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.groupBoxBuscarEvent.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(13, 108);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersWidth = 51;
            this.dataGridViewEvents.RowTemplate.Height = 24;
            this.dataGridViewEvents.Size = new System.Drawing.Size(775, 336);
            this.dataGridViewEvents.TabIndex = 5;
            // 
            // groupBoxBuscarEvent
            // 
            this.groupBoxBuscarEvent.Controls.Add(this.buttonBuscar);
            this.groupBoxBuscarEvent.Controls.Add(this.textBoxBuscarEvent);
            this.groupBoxBuscarEvent.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscarEvent.Location = new System.Drawing.Point(12, 36);
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonAddEvent
            // 
            this.toolStripButtonAddEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddEvent.Image = global::Chrysallis_Eventos.Properties.Resources.add_32px;
            this.toolStripButtonAddEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddEvent.Name = "toolStripButtonAddEvent";
            this.toolStripButtonAddEvent.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAddEvent.Text = "toolStripButton1";
            // 
            // toolStripButtonEditEvent
            // 
            this.toolStripButtonEditEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditEvent.Image = global::Chrysallis_Eventos.Properties.Resources.edit_file_32px;
            this.toolStripButtonEditEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditEvent.Name = "toolStripButtonEditEvent";
            this.toolStripButtonEditEvent.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEditEvent.Text = "toolStripButton2";
            // 
            // toolStripButtonDelEvent
            // 
            this.toolStripButtonDelEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelEvent.Image = global::Chrysallis_Eventos.Properties.Resources.delete_bin_32px;
            this.toolStripButtonDelEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelEvent.Name = "toolStripButtonDelEvent";
            this.toolStripButtonDelEvent.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDelEvent.Text = "toolStripButton3";
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::Chrysallis_Eventos.Properties.Resources.exit_32px;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonExit.Text = "toolStripButton1";
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.groupBoxBuscarEvent);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormEventos";
            this.Text = "FormEventos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.groupBoxBuscarEvent.ResumeLayout(false);
            this.groupBoxBuscarEvent.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}