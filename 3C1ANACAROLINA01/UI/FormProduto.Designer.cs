namespace _3C1ANACAROLINA01
{
    partial class FormLogin
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelProduto = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.labelPreco = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxId.HideSelection = false;
            this.textBoxId.Location = new System.Drawing.Point(49, 90);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxProduto.Location = new System.Drawing.Point(49, 160);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxProduto.TabIndex = 1;
            this.textBoxProduto.TextChanged += new System.EventHandler(this.textBoxProduto_TextChanged);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelId.Location = new System.Drawing.Point(46, 74);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "Id";
            this.labelId.Click += new System.EventHandler(this.labelId_Click);
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelProduto.Location = new System.Drawing.Point(46, 144);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(44, 13);
            this.labelProduto.TabIndex = 4;
            this.labelProduto.Text = "Produto";
            this.labelProduto.Click += new System.EventHandler(this.labelProduto_Click);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxPreco.Location = new System.Drawing.Point(49, 233);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(100, 20);
            this.textBoxPreco.TabIndex = 5;
            this.textBoxPreco.TextChanged += new System.EventHandler(this.textBoxPreco_TextChanged);
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPreco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPreco.Location = new System.Drawing.Point(46, 217);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 6;
            this.labelPreco.Text = "Preço";
            this.labelPreco.Click += new System.EventHandler(this.labelPreco_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExcluir.Location = new System.Drawing.Point(430, 288);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 9;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "SuperMercado EPA";
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEditar.Location = new System.Drawing.Point(309, 288);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCadastrar.Location = new System.Drawing.Point(186, 288);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(173, 40);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(342, 242);
            this.dataGridViewProdutos.TabIndex = 10;
            this.dataGridViewProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellContentClick);
            this.dataGridViewProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellContentClick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.textBoxId);
            this.Name = "FormLogin";
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
    }
}

