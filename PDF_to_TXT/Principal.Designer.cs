namespace PDF_to_TXT
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.lblDiretorio = new System.Windows.Forms.Label();
            this.btnDiretorio = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(8, 28);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(386, 20);
            this.txtDiretorio.TabIndex = 0;
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.AutoSize = true;
            this.lblDiretorio.Location = new System.Drawing.Point(8, 9);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(49, 13);
            this.lblDiretorio.TabIndex = 1;
            this.lblDiretorio.Text = "Diretório:";
            // 
            // btnDiretorio
            // 
            this.btnDiretorio.Location = new System.Drawing.Point(8, 54);
            this.btnDiretorio.Name = "btnDiretorio";
            this.btnDiretorio.Size = new System.Drawing.Size(124, 23);
            this.btnDiretorio.TabIndex = 2;
            this.btnDiretorio.Text = "Selecionar Diretório";
            this.btnDiretorio.UseVisualStyleBackColor = true;
            this.btnDiretorio.Click += new System.EventHandler(this.btnDiretorio_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(138, 54);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 3;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(29, 94);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 103);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.btnDiretorio);
            this.Controls.Add(this.lblDiretorio);
            this.Controls.Add(this.txtDiretorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Principal";
            this.Text = "Extrator de Textos de aquivos PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label lblDiretorio;
        private System.Windows.Forms.Button btnDiretorio;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label lblStatus;
    }
}

