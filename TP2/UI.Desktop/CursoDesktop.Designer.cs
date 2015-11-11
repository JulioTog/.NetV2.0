namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(3, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(49, 13);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Id Curso:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(3, 94);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(57, 13);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Id Materia:";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(3, 46);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(52, 26);
            this.lblComision.TabIndex = 2;
            this.lblComision.Text = "Id Comision:";
            this.lblComision.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(217, 94);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(60, 26);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año Calendario:";
            // 
            // lblCupo
            // 
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(217, 46);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(35, 13);
            this.lblCupo.TabIndex = 4;
            this.lblCupo.Text = "Cupo:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.Controls.Add(this.lblCurso, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblComision, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMateria, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCurso, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtComision, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMateria, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCupo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCupo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAnio, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAnio, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 173);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(70, 3);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(141, 20);
            this.txtCurso.TabIndex = 5;
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(70, 49);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(140, 20);
            this.txtComision.TabIndex = 6;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(70, 97);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(141, 20);
            this.txtMateria.TabIndex = 7;
            // 
            // txtCupo
            // 
            this.txtCupo.Location = new System.Drawing.Point(286, 49);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(142, 20);
            this.txtCupo.TabIndex = 9;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(286, 97);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(142, 20);
            this.txtAnio.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(217, 146);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(63, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(286, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 173);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}