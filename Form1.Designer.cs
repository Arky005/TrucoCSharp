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
            this.panelJogador1 = new System.Windows.Forms.Panel();
            this.carta1 = new TrucoCSharp.Carta(this.components);
            this.carta3 = new TrucoCSharp.Carta(this.components);
            this.carta2 = new TrucoCSharp.Carta(this.components);
            this.panelJogadas = new System.Windows.Forms.Panel();
            this.carta8 = new TrucoCSharp.Carta(this.components);
            this.carta7 = new TrucoCSharp.Carta(this.components);
            this.panelJogador2 = new System.Windows.Forms.Panel();
            this.carta4 = new TrucoCSharp.Carta(this.components);
            this.carta5 = new TrucoCSharp.Carta(this.components);
            this.carta6 = new TrucoCSharp.Carta(this.components);
            this.panelJogador1.SuspendLayout();
            this.panelJogadas.SuspendLayout();
            this.panelJogador2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelJogador1
            // 
            this.panelJogador1.Controls.Add(this.carta1);
            this.panelJogador1.Controls.Add(this.carta3);
            this.panelJogador1.Controls.Add(this.carta2);
            this.panelJogador1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelJogador1.Location = new System.Drawing.Point(0, 416);
            this.panelJogador1.Name = "panelJogador1";
            this.panelJogador1.Size = new System.Drawing.Size(959, 140);
            this.panelJogador1.TabIndex = 3;
            // 
            // carta1
            // 
            this.carta1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carta1.Image = global::TrucoCSharp.Properties.Resources._0;
            this.carta1.Location = new System.Drawing.Point(317, 18);
            this.carta1.Name = "carta1";
            this.carta1.Size = new System.Drawing.Size(79, 113);
            this.carta1.TabIndex = 0;
            this.carta1.Text = "carta1";
            // 
            // carta3
            // 
            this.carta3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carta3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carta3.Location = new System.Drawing.Point(534, 18);
            this.carta3.MaximumSize = new System.Drawing.Size(96, 148);
            this.carta3.Name = "carta3";
            this.carta3.Size = new System.Drawing.Size(79, 113);
            this.carta3.TabIndex = 2;
            this.carta3.Text = "carta3";
            // 
            // carta2
            // 
            this.carta2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carta2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carta2.Location = new System.Drawing.Point(432, 18);
            this.carta2.MaximumSize = new System.Drawing.Size(96, 148);
            this.carta2.Name = "carta2";
            this.carta2.Size = new System.Drawing.Size(79, 113);
            this.carta2.TabIndex = 1;
            this.carta2.Text = "carta2";
            // 
            // panelJogadas
            // 
            this.panelJogadas.Controls.Add(this.carta8);
            this.panelJogadas.Controls.Add(this.carta7);
            this.panelJogadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJogadas.Location = new System.Drawing.Point(0, 140);
            this.panelJogadas.Name = "panelJogadas";
            this.panelJogadas.Size = new System.Drawing.Size(959, 276);
            this.panelJogadas.TabIndex = 5;
            // 
            // carta8
            // 
            this.carta8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carta8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carta8.Location = new System.Drawing.Point(432, 151);
            this.carta8.MaximumSize = new System.Drawing.Size(96, 148);
            this.carta8.Name = "carta8";
            this.carta8.Size = new System.Drawing.Size(79, 113);
            this.carta8.TabIndex = 3;
            this.carta8.Text = "carta8";
            // 
            // carta7
            // 
            this.carta7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carta7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carta7.Location = new System.Drawing.Point(432, 12);
            this.carta7.MaximumSize = new System.Drawing.Size(96, 148);
            this.carta7.Name = "carta7";
            this.carta7.Size = new System.Drawing.Size(79, 113);
            this.carta7.TabIndex = 2;
            this.carta7.Text = "carta7";
            // 
            // panelJogador2
            // 
            this.panelJogador2.Controls.Add(this.carta4);
            this.panelJogador2.Controls.Add(this.carta5);
            this.panelJogador2.Controls.Add(this.carta6);
            this.panelJogador2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJogador2.Location = new System.Drawing.Point(0, 0);
            this.panelJogador2.Name = "panelJogador2";
            this.panelJogador2.Size = new System.Drawing.Size(959, 140);
            this.panelJogador2.TabIndex = 4;
            // 
            // carta4
            // 
            this.carta4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carta4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carta4.Location = new System.Drawing.Point(330, 9);
            this.carta4.Name = "carta4";
            this.carta4.Size = new System.Drawing.Size(79, 113);
            this.carta4.TabIndex = 0;
            this.carta4.Text = "carta4";
            // 
            // carta5
            // 
            this.carta5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carta5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carta5.Location = new System.Drawing.Point(534, 9);
            this.carta5.MaximumSize = new System.Drawing.Size(96, 148);
            this.carta5.Name = "carta5";
            this.carta5.Size = new System.Drawing.Size(79, 113);
            this.carta5.TabIndex = 2;
            this.carta5.Text = "carta5";
            // 
            // carta6
            // 
            this.carta6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carta6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carta6.Location = new System.Drawing.Point(432, 9);
            this.carta6.MaximumSize = new System.Drawing.Size(96, 148);
            this.carta6.Name = "carta6";
            this.carta6.Size = new System.Drawing.Size(79, 113);
            this.carta6.TabIndex = 1;
            this.carta6.Text = "carta6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(959, 556);
            this.Controls.Add(this.panelJogadas);
            this.Controls.Add(this.panelJogador2);
            this.Controls.Add(this.panelJogador1);
            this.MinimumSize = new System.Drawing.Size(975, 595);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truco";
            this.panelJogador1.ResumeLayout(false);
            this.panelJogadas.ResumeLayout(false);
            this.panelJogador2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Carta carta2;
        private Carta carta3;
        private Carta carta1;
        private System.Windows.Forms.Panel panelJogador1;
        private Carta carta7;
        private Carta carta8;
        private System.Windows.Forms.Panel panelJogadas;
        private Carta carta6;
        private Carta carta5;
        private Carta carta4;
        private System.Windows.Forms.Panel panelJogador2;
    }
}

