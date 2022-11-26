namespace ErpMicroOrcamento
{
    partial class Ermpmricro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ermpmricro));
            this.lbnomeDoOrcamento = new System.Windows.Forms.Label();
            this.lbValorDoproduto = new System.Windows.Forms.Label();
            this.lbqtdDoProduto = new System.Windows.Forms.Label();
            this.txtNomeDoProduto = new System.Windows.Forms.TextBox();
            this.txtValorDoProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btSomar = new System.Windows.Forms.Button();
            this.btExibir = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.nameResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbnomeDoOrcamento
            // 
            this.lbnomeDoOrcamento.AutoSize = true;
            this.lbnomeDoOrcamento.BackColor = System.Drawing.Color.Transparent;
            this.lbnomeDoOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnomeDoOrcamento.Location = new System.Drawing.Point(69, 188);
            this.lbnomeDoOrcamento.Name = "lbnomeDoOrcamento";
            this.lbnomeDoOrcamento.Size = new System.Drawing.Size(216, 26);
            this.lbnomeDoOrcamento.TabIndex = 0;
            this.lbnomeDoOrcamento.Text = "Nome do orçamento:";
            this.lbnomeDoOrcamento.Click += new System.EventHandler(this.lbnomeDoProduto_Click);
            // 
            // lbValorDoproduto
            // 
            this.lbValorDoproduto.AutoSize = true;
            this.lbValorDoproduto.BackColor = System.Drawing.Color.Transparent;
            this.lbValorDoproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorDoproduto.Location = new System.Drawing.Point(69, 234);
            this.lbValorDoproduto.Name = "lbValorDoproduto";
            this.lbValorDoproduto.Size = new System.Drawing.Size(178, 26);
            this.lbValorDoproduto.TabIndex = 1;
            this.lbValorDoproduto.Text = "Valor do produto:";
            this.lbValorDoproduto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbqtdDoProduto
            // 
            this.lbqtdDoProduto.AutoSize = true;
            this.lbqtdDoProduto.BackColor = System.Drawing.Color.Transparent;
            this.lbqtdDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqtdDoProduto.Location = new System.Drawing.Point(69, 281);
            this.lbqtdDoProduto.Name = "lbqtdDoProduto";
            this.lbqtdDoProduto.Size = new System.Drawing.Size(130, 26);
            this.lbqtdDoProduto.TabIndex = 2;
            this.lbqtdDoProduto.Text = "Quantidade:";
            // 
            // txtNomeDoProduto
            // 
            this.txtNomeDoProduto.Location = new System.Drawing.Point(291, 194);
            this.txtNomeDoProduto.Name = "txtNomeDoProduto";
            this.txtNomeDoProduto.Size = new System.Drawing.Size(152, 20);
            this.txtNomeDoProduto.TabIndex = 3;
            this.txtNomeDoProduto.TextChanged += new System.EventHandler(this.txtNomeDoProduto_TextChanged);
            // 
            // txtValorDoProduto
            // 
            this.txtValorDoProduto.Location = new System.Drawing.Point(291, 240);
            this.txtValorDoProduto.Name = "txtValorDoProduto";
            this.txtValorDoProduto.Size = new System.Drawing.Size(152, 20);
            this.txtValorDoProduto.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(291, 287);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(152, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // btSomar
            // 
            this.btSomar.BackColor = System.Drawing.Color.White;
            this.btSomar.Location = new System.Drawing.Point(411, 372);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(90, 31);
            this.btSomar.TabIndex = 6;
            this.btSomar.Text = "Somar";
            this.btSomar.UseVisualStyleBackColor = false;
            this.btSomar.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // btExibir
            // 
            this.btExibir.BackColor = System.Drawing.Color.White;
            this.btExibir.Location = new System.Drawing.Point(633, 372);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(90, 31);
            this.btExibir.TabIndex = 7;
            this.btExibir.Text = "Exibir historico";
            this.btExibir.UseVisualStyleBackColor = false;
            this.btExibir.Click += new System.EventHandler(this.btExibir_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.White;
            this.btFinalizar.Location = new System.Drawing.Point(523, 372);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(90, 31);
            this.btFinalizar.TabIndex = 8;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.BackColor = System.Drawing.Color.Transparent;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(58, 393);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(116, 26);
            this.lbResultado.TabIndex = 9;
            this.lbResultado.Text = "Resultado:";
            this.lbResultado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(180, 393);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(36, 26);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.Text = "00";
            this.lbTotal.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // nameResultado
            // 
            this.nameResultado.AutoSize = true;
            this.nameResultado.BackColor = System.Drawing.Color.Transparent;
            this.nameResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameResultado.Location = new System.Drawing.Point(58, 357);
            this.nameResultado.Name = "nameResultado";
            this.nameResultado.Size = new System.Drawing.Size(30, 26);
            this.nameResultado.TabIndex = 11;
            this.nameResultado.Text = "...";
            this.nameResultado.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Ermpmricro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ErpMicroOrcamento.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 478);
            this.Controls.Add(this.nameResultado);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.btSomar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtValorDoProduto);
            this.Controls.Add(this.txtNomeDoProduto);
            this.Controls.Add(this.lbqtdDoProduto);
            this.Controls.Add(this.lbValorDoproduto);
            this.Controls.Add(this.lbnomeDoOrcamento);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ermpmricro";
            this.Text = "ErpMicro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnomeDoOrcamento;
        private System.Windows.Forms.Label lbValorDoproduto;
        private System.Windows.Forms.Label lbqtdDoProduto;
        private System.Windows.Forms.TextBox txtNomeDoProduto;
        private System.Windows.Forms.TextBox txtValorDoProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btSomar;
        private System.Windows.Forms.Button btExibir;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label nameResultado;
    }
}

