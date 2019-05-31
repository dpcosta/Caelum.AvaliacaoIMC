namespace Caelum.AvaliacaoIMC.WinFormsApp
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIMC = new System.Windows.Forms.Button();
            this.textoAltura = new System.Windows.Forms.TextBox();
            this.textoPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaPessoas = new System.Windows.Forms.ListBox();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIMC);
            this.groupBox1.Controls.Add(this.textoAltura);
            this.groupBox1.Controls.Add(this.textoPeso);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // btnIMC
            // 
            this.btnIMC.Location = new System.Drawing.Point(70, 105);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(100, 28);
            this.btnIMC.TabIndex = 5;
            this.btnIMC.Text = "Calcular IMC";
            this.btnIMC.UseVisualStyleBackColor = true;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // textoAltura
            // 
            this.textoAltura.Location = new System.Drawing.Point(70, 70);
            this.textoAltura.Name = "textoAltura";
            this.textoAltura.Size = new System.Drawing.Size(100, 20);
            this.textoAltura.TabIndex = 4;
            // 
            // textoPeso
            // 
            this.textoPeso.Location = new System.Drawing.Point(70, 35);
            this.textoPeso.Name = "textoPeso";
            this.textoPeso.Size = new System.Drawing.Size(100, 20);
            this.textoPeso.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Peso (kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Altura (m):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnArquivo);
            this.groupBox2.Controls.Add(this.listaPessoas);
            this.groupBox2.Location = new System.Drawing.Point(236, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 346);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arquivo";
            // 
            // listaPessoas
            // 
            this.listaPessoas.FormattingEnabled = true;
            this.listaPessoas.Location = new System.Drawing.Point(17, 19);
            this.listaPessoas.Name = "listaPessoas";
            this.listaPessoas.Size = new System.Drawing.Size(269, 264);
            this.listaPessoas.TabIndex = 5;
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(17, 302);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(112, 30);
            this.btnArquivo.TabIndex = 6;
            this.btnArquivo.Text = "Processar Arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora de IMC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.TextBox textoAltura;
        private System.Windows.Forms.TextBox textoPeso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.ListBox listaPessoas;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
    }
}

