namespace UI.Desktop
{
    partial class Especialidades
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
            this.tclEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tsEspecialidades = new System.Windows.Forms.ToolStrip();
            this.tlEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tslEditar = new System.Windows.Forms.ToolStripButton();
            this.tslEliminar = new System.Windows.Forms.ToolStripButton();
            this.tclEspecialidades.ContentPanel.SuspendLayout();
            this.tclEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tclEspecialidades.SuspendLayout();
            this.tsEspecialidades.SuspendLayout();
            this.tlEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // tclEspecialidades
            // 
            // 
            // tclEspecialidades.ContentPanel
            // 
            this.tclEspecialidades.ContentPanel.Controls.Add(this.tlEspecialidades);
            this.tclEspecialidades.ContentPanel.Size = new System.Drawing.Size(811, 438);
            this.tclEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tclEspecialidades.Name = "tclEspecialidades";
            this.tclEspecialidades.Size = new System.Drawing.Size(811, 463);
            this.tclEspecialidades.TabIndex = 0;
            this.tclEspecialidades.Text = "toolStripContainer1";
            // 
            // tclEspecialidades.TopToolStripPanel
            // 
            this.tclEspecialidades.TopToolStripPanel.Controls.Add(this.tsEspecialidades);
            // 
            // tsEspecialidades
            // 
            this.tsEspecialidades.Dock = System.Windows.Forms.DockStyle.None;
            this.tsEspecialidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tslEditar,
            this.tslEliminar});
            this.tsEspecialidades.Location = new System.Drawing.Point(3, 0);
            this.tsEspecialidades.Name = "tsEspecialidades";
            this.tsEspecialidades.Size = new System.Drawing.Size(112, 25);
            this.tsEspecialidades.TabIndex = 0;
            // 
            // tlEspecialidades
            // 
            this.tlEspecialidades.ColumnCount = 2;
            this.tlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlEspecialidades.Controls.Add(this.dgvEspecialidades, 0, 0);
            this.tlEspecialidades.Controls.Add(this.btnActualizar, 0, 1);
            this.tlEspecialidades.Controls.Add(this.btnSalir, 1, 1);
            this.tlEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlEspecialidades.Name = "tlEspecialidades";
            this.tlEspecialidades.RowCount = 2;
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlEspecialidades.Size = new System.Drawing.Size(811, 438);
            this.tlEspecialidades.TabIndex = 0;
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlEspecialidades.SetColumnSpan(this.dgvEspecialidades, 2);
            this.dgvEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecialidades.Location = new System.Drawing.Point(3, 3);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.Size = new System.Drawing.Size(805, 403);
            this.dgvEspecialidades.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(652, 412);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(733, 412);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::UI.Desktop.Properties.Resources.icon_alta;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            // 
            // tslEditar
            // 
            this.tslEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslEditar.Image = global::UI.Desktop.Properties.Resources.icon_modifacion;
            this.tslEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslEditar.Name = "tslEditar";
            this.tslEditar.Size = new System.Drawing.Size(23, 22);
            this.tslEditar.Text = "toolStripButton1";
            this.tslEditar.ToolTipText = "Editar";
            // 
            // tslEliminar
            // 
            this.tslEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslEliminar.Image = global::UI.Desktop.Properties.Resources.icon_baja;
            this.tslEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslEliminar.Name = "tslEliminar";
            this.tslEliminar.Size = new System.Drawing.Size(23, 22);
            this.tslEliminar.Text = "toolStripButton1";
            this.tslEliminar.ToolTipText = "Eliminar";
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 463);
            this.Controls.Add(this.tclEspecialidades);
            this.Name = "Especialidades";
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.Especialidades_Load);
            this.tclEspecialidades.ContentPanel.ResumeLayout(false);
            this.tclEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tclEspecialidades.TopToolStripPanel.PerformLayout();
            this.tclEspecialidades.ResumeLayout(false);
            this.tclEspecialidades.PerformLayout();
            this.tsEspecialidades.ResumeLayout(false);
            this.tsEspecialidades.PerformLayout();
            this.tlEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tclEspecialidades;
        private System.Windows.Forms.TableLayoutPanel tlEspecialidades;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsEspecialidades;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tslEditar;
        private System.Windows.Forms.ToolStripButton tslEliminar;
    }
}