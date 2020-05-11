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
            this.lstMatriz.Location = new System.Drawing.Point(13, 49);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(120, 186);
            this.lstMatriz.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 258);
            this.Controls.Add(this.lstMatriz);
            this.Controls.Add(this.btnPreenche);
            this.Name = "Form1";
            this.Text = "Matrizes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPreenche;
        private System.Windows.Forms.ListBox lstMatriz;
    }
}

