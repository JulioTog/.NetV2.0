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
            this.tsCurso = new System.Windows.Forms.ToolStrip();
            this.tlCurso = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tcCurso.ContentPanel.SuspendLayout();
            this.tcCurso.TopToolStripPanel.SuspendLayout();
            this.tcCurso.SuspendLayout();
            this.tlCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
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
            // tsCurso
            // 
            this.tsCurso.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCurso.Location = new System.Drawing.Point(3, 0);
            this.tsCurso.Name = "tsCurso";
            this.tsCurso.Size = new System.Drawing.Size(111, 25);
            this.tsCurso.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcCurso;
        private System.Windows.Forms.TableLayoutPanel tlCurso;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsCurso;

    }
}