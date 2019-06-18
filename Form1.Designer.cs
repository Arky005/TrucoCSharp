namespace TrucoCSharp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.carta1 = new TrucoCSharp.Carta(this.components);
            this.SuspendLayout();
            // 
            // carta1
            // 
            this.carta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carta1.Location = new System.Drawing.Point(140, 247);
            this.carta1.Name = "carta1";
            this.carta1.Size = new System.Drawing.Size(96, 148);
            this.carta1.TabIndex = 0;
            this.carta1.Text = "carta1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carta1);
            this.Name = "Form1";
            this.Text = "Truco";
            this.ResumeLayout(false);

        }

        #endregion

        private Carta carta1;
    }
}

