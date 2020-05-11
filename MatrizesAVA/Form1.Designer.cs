namespace MatrizesAVA
{
    partial class FrmMatriz
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
            this.btnPreenche = new System.Windows.Forms.Button();
            this.lstMatriz = new System.Windows.Forms.ListBox();
            this.lstTransposta = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPreenche
            // 
            this.btnPreenche.Location = new System.Drawing.Point(13, 13);
            this.btnPreenche.Name = "btnPreenche";
            this.btnPreenche.Size = new System.Drawing.Size(120, 23);
            this.btnPreenche.TabIndex = 0;
            this.btnPreenche.Text = "Matriz";
            this.btnPreenche.UseVisualStyleBackColor = true;
            this.btnPreenche.Click += new System.EventHandler(this.btnPreenche_Click);
            // 
            // lstMatriz
            // 
            this.lstMatriz.FormattingEnabled = true;
            this.lstMatriz.Location = new System.Drawing.Point(13, 62);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(120, 173);
            this.lstMatriz.TabIndex = 1;
            // 
            // lstTransposta
            // 
            this.lstTransposta.FormattingEnabled = true;
            this.lstTransposta.Location = new System.Drawing.Point(162, 62);
            this.lstTransposta.Name = "lstTransposta";
            this.lstTransposta.Size = new System.Drawing.Size(120, 173);
            this.lstTransposta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Linhas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colunas:";
            // 
            // FrmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTransposta);
            this.Controls.Add(this.lstMatriz);
            this.Controls.Add(this.btnPreenche);
            this.Name = "FrmMatriz";
            this.Text = "Matrizes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPreenche;
        private System.Windows.Forms.ListBox lstMatriz;
        private System.Windows.Forms.ListBox lstTransposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

