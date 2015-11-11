namespace UI.Desktop
{
    partial class Curso
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
            this.tcCurso = new System.Windows.Forms.ToolStripContainer();
            this.tlCurso = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsCurso = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tslEditar = new System.Windows.Forms.ToolStripButton();
            this.tslEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcCurso.ContentPanel.SuspendLayout();
            this.tcCurso.TopToolStripPanel.SuspendLayout();
            this.tcCurso.SuspendLayout();
            this.tlCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.tsCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCurso
            // 
            // 
            // tcCurso.ContentPanel
            // 
            this.tcCurso.ContentPanel.Controls.Add(this.tlCurso);
            this.tcCurso.ContentPanel.Size = new System.Drawing.Size(893, 457);
            this.tcCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCurso.Location = new System.Drawing.Point(0, 0);
            this.tcCurso.Name = "tcCurso";
            this.tcCurso.Size = new System.Drawing.Size(893, 482);
            this.tcCurso.TabIndex = 0;
            this.tcCurso.Text = "toolStripContainer1";
            // 
            // tcCurso.TopToolStripPanel
            // 
            this.tcCurso.TopToolStripPanel.Controls.Add(this.tsCurso);
            // 
            // tlCurso
            // 
            this.tlCurso.ColumnCount = 2;
            this.tlCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCurso.Controls.Add(this.dgvCurso, 0, 0);
            this.tlCurso.Controls.Add(this.btnActualizar, 0, 1);
            this.tlCurso.Controls.Add(this.btnSalir, 1, 1);
            this.tlCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCurso.Location = new System.Drawing.Point(0, 0);
            this.tlCurso.Name = "tlCurso";
            this.tlCurso.RowCount = 2;
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCurso.Size = new System.Drawing.Size(893, 457);
            this.tlCurso.TabIndex = 0;
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlCurso.SetColumnSpan(this.dgvCurso, 2);
            this.dgvCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurso.Location = new System.Drawing.Point(3, 3);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.Size = new System.Drawing.Size(887, 422);
            this.dgvCurso.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(734, 431);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(815, 431);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsCurso
            // 
            this.tsCurso.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCurso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tslEditar,
            this.tslEliminar});
            this.tsCurso.Location = new System.Drawing.Point(3, 0);
            this.tsCurso.Name = "tsCurso";
            this.tsCurso.Size = new System.Drawing.Size(112, 25);
            this.tsCurso.TabIndex = 0;
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
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
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
            this.tslEditar.Click += new System.EventHandler(this.tslEditar_Click);
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
            this.tslEliminar.Click += new System.EventHandler(this.tslEliminar_Click);
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 482);
            this.Controls.Add(this.tcCurso);
            this.Name = "Curso";
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Curso_Load);
            this.tcCurso.ContentPanel.ResumeLayout(false);
            this.tcCurso.TopToolStripPanel.ResumeLayout(false);
            this.tcCurso.TopToolStripPanel.PerformLayout();
            this.tcCurso.ResumeLayout(false);
            this.tcCurso.PerformLayout();
            this.tlCurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.tsCurso.ResumeLayout(false);
            this.tsCurso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcCurso;
        private System.Windows.Forms.TableLayoutPanel tlCurso;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsCurso;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tslEditar;
        private System.Windows.Forms.ToolStripButton tslEliminar;

    }
}