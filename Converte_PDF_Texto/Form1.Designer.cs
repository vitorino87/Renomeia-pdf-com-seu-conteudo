namespace Converte_PDF_Texto
{
    partial class Form1
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
			this.btnProcurar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ofd1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnProcurar
			// 
			this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcurar.Location = new System.Drawing.Point(164, 13);
			this.btnProcurar.Name = "btnProcurar";
			this.btnProcurar.Size = new System.Drawing.Size(107, 23);
			this.btnProcurar.TabIndex = 1;
			this.btnProcurar.Text = "Procurar...";
			this.btnProcurar.UseVisualStyleBackColor = true;
			this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Escolha o diretório:";
			// 
			// ofd1
			// 
			this.ofd1.FileName = "openFileDialog1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Obs: Os pdfs devem ser PDF-A";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(283, 79);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnProcurar);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mova, extraia e renomeia";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofd1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label label2;
	}
}

