namespace Exercicio2_pg15_16_18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_taxa = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_taxa
            // 
            this.lbl_taxa.AutoSize = true;
            this.lbl_taxa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_taxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taxa.ForeColor = System.Drawing.Color.Coral;
            this.lbl_taxa.Location = new System.Drawing.Point(117, 60);
            this.lbl_taxa.Name = "lbl_taxa";
            this.lbl_taxa.Size = new System.Drawing.Size(410, 24);
            this.lbl_taxa.TabIndex = 0;
            this.lbl_taxa.Text = "Insira o valor para descubrir o valor total e a taxa";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.Coral;
            this.btn_calcular.Location = new System.Drawing.Point(289, 256);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(101, 42);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(243, 136);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(185, 20);
            this.txt_valor.TabIndex = 2;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(243, 193);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(185, 20);
            this.txt_quantidade.TabIndex = 3;
            this.txt_quantidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exercicio2_pg15_16_18.Properties.Resources.exercicio2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 467);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_taxa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Exercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_taxa;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_quantidade;
    }
}

