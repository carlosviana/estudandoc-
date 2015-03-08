namespace Aprendendo
{
    partial class EditorDeTexto
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
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.botaoGrava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoConteudo.Location = new System.Drawing.Point(21, 12);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textoConteudo.Size = new System.Drawing.Size(384, 297);
            this.textoConteudo.TabIndex = 0;
            this.textoConteudo.TextChanged += new System.EventHandler(this.textoConteudo_TextChanged);
            // 
            // botaoGrava
            // 
            this.botaoGrava.Location = new System.Drawing.Point(181, 315);
            this.botaoGrava.Name = "botaoGrava";
            this.botaoGrava.Size = new System.Drawing.Size(75, 23);
            this.botaoGrava.TabIndex = 1;
            this.botaoGrava.Text = "Salva";
            this.botaoGrava.UseVisualStyleBackColor = true;
            this.botaoGrava.Click += new System.EventHandler(this.botaoGrava_Click);
            // 
            // EditorDeTexto
            // 
            this.ClientSize = new System.Drawing.Size(417, 350);
            this.Controls.Add(this.botaoGrava);
            this.Controls.Add(this.textoConteudo);
            this.Name = "EditorDeTexto";
            this.Load += new System.EventHandler(this.EditorDeTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button botaoGrava;
    }
}

