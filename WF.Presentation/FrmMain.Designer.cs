namespace WF.Presentation
{
    partial class FrmMain
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
            this.btnDeletarMarca = new System.Windows.Forms.Button();
            this.btnAlterarMarca = new System.Windows.Forms.Button();
            this.btnCadastrarMarca = new System.Windows.Forms.Button();
            this.dvgMarcas = new System.Windows.Forms.DataGridView();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAtualizarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.dvgProdutos = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeletarProduto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMarcas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeletarMarca);
            this.groupBox1.Controls.Add(this.btnAlterarMarca);
            this.groupBox1.Controls.Add(this.btnCadastrarMarca);
            this.groupBox1.Controls.Add(this.dvgMarcas);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1397, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcas ";
            // 
            // btnDeletarMarca
            // 
            this.btnDeletarMarca.Location = new System.Drawing.Point(1067, 186);
            this.btnDeletarMarca.Name = "btnDeletarMarca";
            this.btnDeletarMarca.Size = new System.Drawing.Size(322, 57);
            this.btnDeletarMarca.TabIndex = 3;
            this.btnDeletarMarca.Text = "Deletar Marca";
            this.btnDeletarMarca.UseVisualStyleBackColor = true;
            this.btnDeletarMarca.Click += new System.EventHandler(this.btnDeletarMarca_Click);
            // 
            // btnAlterarMarca
            // 
            this.btnAlterarMarca.Location = new System.Drawing.Point(1065, 111);
            this.btnAlterarMarca.Name = "btnAlterarMarca";
            this.btnAlterarMarca.Size = new System.Drawing.Size(322, 57);
            this.btnAlterarMarca.TabIndex = 2;
            this.btnAlterarMarca.Text = "Atualizar Marca";
            this.btnAlterarMarca.UseVisualStyleBackColor = true;
            this.btnAlterarMarca.Click += new System.EventHandler(this.btnAlterarMarca_Click);
            // 
            // btnCadastrarMarca
            // 
            this.btnCadastrarMarca.Location = new System.Drawing.Point(1065, 34);
            this.btnCadastrarMarca.Name = "btnCadastrarMarca";
            this.btnCadastrarMarca.Size = new System.Drawing.Size(322, 57);
            this.btnCadastrarMarca.TabIndex = 1;
            this.btnCadastrarMarca.Text = "Cadastrar Marca";
            this.btnCadastrarMarca.UseVisualStyleBackColor = true;
            this.btnCadastrarMarca.Click += new System.EventHandler(this.btnCadastrarMarca_Click);
            // 
            // dvgMarcas
            // 
            this.dvgMarcas.AllowUserToAddRows = false;
            this.dvgMarcas.AllowUserToDeleteRows = false;
            this.dvgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMarca,
            this.NomeMarca});
            this.dvgMarcas.Location = new System.Drawing.Point(6, 34);
            this.dvgMarcas.MultiSelect = false;
            this.dvgMarcas.Name = "dvgMarcas";
            this.dvgMarcas.ReadOnly = true;
            this.dvgMarcas.RowHeadersWidth = 92;
            this.dvgMarcas.RowTemplate.Height = 37;
            this.dvgMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMarcas.Size = new System.Drawing.Size(1053, 397);
            this.dvgMarcas.TabIndex = 0;
            // 
            // IdMarca
            // 
            this.IdMarca.DataPropertyName = "Id";
            this.IdMarca.HeaderText = "Id";
            this.IdMarca.MinimumWidth = 11;
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.ReadOnly = true;
            this.IdMarca.Visible = false;
            this.IdMarca.Width = 225;
            // 
            // NomeMarca
            // 
            this.NomeMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMarca.DataPropertyName = "Name";
            this.NomeMarca.HeaderText = "Nome da marca";
            this.NomeMarca.MinimumWidth = 11;
            this.NomeMarca.Name = "NomeMarca";
            this.NomeMarca.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeletarProduto);
            this.groupBox2.Controls.Add(this.btnAtualizarProduto);
            this.groupBox2.Controls.Add(this.btnCadastrarProduto);
            this.groupBox2.Controls.Add(this.dvgProdutos);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(4, 466);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1397, 451);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // btnAtualizarProduto
            // 
            this.btnAtualizarProduto.Location = new System.Drawing.Point(1065, 116);
            this.btnAtualizarProduto.Name = "btnAtualizarProduto";
            this.btnAtualizarProduto.Size = new System.Drawing.Size(322, 57);
            this.btnAtualizarProduto.TabIndex = 3;
            this.btnAtualizarProduto.Text = "Atualizar Produto";
            this.btnAtualizarProduto.UseVisualStyleBackColor = true;
            this.btnAtualizarProduto.Click += new System.EventHandler(this.btnAtualizarProduto_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(1065, 34);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(322, 57);
            this.btnCadastrarProduto.TabIndex = 2;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // dvgProdutos
            // 
            this.dvgProdutos.AllowUserToAddRows = false;
            this.dvgProdutos.AllowUserToDeleteRows = false;
            this.dvgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.IdBrand,
            this.NameProduct,
            this.BrandName});
            this.dvgProdutos.Location = new System.Drawing.Point(6, 35);
            this.dvgProdutos.MultiSelect = false;
            this.dvgProdutos.Name = "dvgProdutos";
            this.dvgProdutos.ReadOnly = true;
            this.dvgProdutos.RowHeadersWidth = 92;
            this.dvgProdutos.RowTemplate.Height = 37;
            this.dvgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProdutos.Size = new System.Drawing.Size(1053, 410);
            this.dvgProdutos.TabIndex = 1;
            // 
            // IdProduct
            // 
            this.IdProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdProduct.DataPropertyName = "Id";
            this.IdProduct.HeaderText = "Id";
            this.IdProduct.MinimumWidth = 11;
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            this.IdProduct.Visible = false;
            this.IdProduct.Width = 225;
            // 
            // IdBrand
            // 
            this.IdBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdBrand.DataPropertyName = "IdBrand";
            this.IdBrand.HeaderText = "Id da Marca";
            this.IdBrand.MinimumWidth = 11;
            this.IdBrand.Name = "IdBrand";
            this.IdBrand.ReadOnly = true;
            this.IdBrand.Visible = false;
            this.IdBrand.Width = 225;
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameProduct.DataPropertyName = "Name";
            this.NameProduct.HeaderText = "Nome do produto";
            this.NameProduct.MinimumWidth = 11;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrandName.DataPropertyName = "ProductBrand";
            this.BrandName.HeaderText = "Marca do produto";
            this.BrandName.MinimumWidth = 11;
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDeletarProduto
            // 
            this.btnDeletarProduto.Location = new System.Drawing.Point(1065, 195);
            this.btnDeletarProduto.Name = "btnDeletarProduto";
            this.btnDeletarProduto.Size = new System.Drawing.Size(322, 57);
            this.btnDeletarProduto.TabIndex = 4;
            this.btnDeletarProduto.Text = "Deletar Produto";
            this.btnDeletarProduto.UseVisualStyleBackColor = true;
            this.btnDeletarProduto.Click += new System.EventHandler(this.btnDeletarProduto_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 929);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos e Marcas";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMarcas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvgMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dvgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.Button btnCadastrarMarca;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnAlterarMarca;
        private System.Windows.Forms.Button btnAtualizarProduto;
        private System.Windows.Forms.Button btnDeletarMarca;
        private System.Windows.Forms.Button btnDeletarProduto;
    }
}

