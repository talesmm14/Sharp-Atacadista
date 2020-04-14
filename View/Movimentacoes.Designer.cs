namespace Trabalho_A1_Supermecado.Forms
{
    partial class Movimentacoes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.cbAddFornecedor = new System.Windows.Forms.ComboBox();
            this.cbAddProduto = new System.Windows.Forms.ComboBox();
            this.Produto = new System.Windows.Forms.Label();
            this.cbAddTipoEstoque = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.validadeDias = new System.Windows.Forms.NumericUpDown();
            this.pesoKg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.valorCompra = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_fornecedor = new System.Windows.Forms.Button();
            this.btn_add_Item = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.btnRetirarTudo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbPesquisarFornecedor = new System.Windows.Forms.ComboBox();
            this.cbPesquisarProduto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.codPesquisarLote = new System.Windows.Forms.NumericUpDown();
            this.dgLote = new System.Windows.Forms.DataGridView();
            this.supermecadoDataSet = new Trabalho_A1_Supermecado.SupermecadoDataSet();
            this.loteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loteTableAdapter = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.LoteTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasvalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesokgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.validadeDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorCompra)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codPesquisarLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermecadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimentações do estoque";
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(136, 53);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(120, 47);
            this.btnRetirar.TabIndex = 28;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(13, 11);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(153, 31);
            this.lbNome.TabIndex = 31;
            this.lbNome.Text = "Fornecedor";
            // 
            // cbAddFornecedor
            // 
            this.cbAddFornecedor.FormattingEnabled = true;
            this.cbAddFornecedor.Location = new System.Drawing.Point(13, 45);
            this.cbAddFornecedor.Name = "cbAddFornecedor";
            this.cbAddFornecedor.Size = new System.Drawing.Size(229, 21);
            this.cbAddFornecedor.TabIndex = 32;
            // 
            // cbAddProduto
            // 
            this.cbAddProduto.FormattingEnabled = true;
            this.cbAddProduto.Location = new System.Drawing.Point(13, 104);
            this.cbAddProduto.Name = "cbAddProduto";
            this.cbAddProduto.Size = new System.Drawing.Size(229, 21);
            this.cbAddProduto.TabIndex = 34;
            // 
            // Produto
            // 
            this.Produto.AutoSize = true;
            this.Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produto.Location = new System.Drawing.Point(13, 69);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(109, 31);
            this.Produto.TabIndex = 33;
            this.Produto.Text = "Produto";
            // 
            // cbAddTipoEstoque
            // 
            this.cbAddTipoEstoque.FormattingEnabled = true;
            this.cbAddTipoEstoque.Location = new System.Drawing.Point(13, 163);
            this.cbAddTipoEstoque.Name = "cbAddTipoEstoque";
            this.cbAddTipoEstoque.Size = new System.Drawing.Size(229, 21);
            this.cbAddTipoEstoque.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tipo de estoque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 31);
            this.label5.TabIndex = 37;
            this.label5.Text = "Validade em dias";
            // 
            // validadeDias
            // 
            this.validadeDias.Location = new System.Drawing.Point(13, 223);
            this.validadeDias.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.validadeDias.Name = "validadeDias";
            this.validadeDias.Size = new System.Drawing.Size(229, 20);
            this.validadeDias.TabIndex = 38;
            this.validadeDias.ThousandsSeparator = true;
            // 
            // pesoKg
            // 
            this.pesoKg.DecimalPlaces = 2;
            this.pesoKg.Location = new System.Drawing.Point(13, 282);
            this.pesoKg.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pesoKg.Name = "pesoKg";
            this.pesoKg.Size = new System.Drawing.Size(229, 20);
            this.pesoKg.TabIndex = 40;
            this.pesoKg.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "Peso (kg)";
            // 
            // valorCompra
            // 
            this.valorCompra.DecimalPlaces = 2;
            this.valorCompra.Location = new System.Drawing.Point(13, 341);
            this.valorCompra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorCompra.Name = "valorCompra";
            this.valorCompra.Size = new System.Drawing.Size(229, 20);
            this.valorCompra.TabIndex = 42;
            this.valorCompra.Tag = "";
            this.valorCompra.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Valor de compra (R$)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_add_fornecedor);
            this.panel1.Controls.Add(this.btn_add_Item);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Controls.Add(this.cbAddFornecedor);
            this.panel1.Controls.Add(this.Produto);
            this.panel1.Controls.Add(this.valorCompra);
            this.panel1.Controls.Add(this.cbAddProduto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pesoKg);
            this.panel1.Controls.Add(this.cbAddTipoEstoque);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.validadeDias);
            this.panel1.Location = new System.Drawing.Point(13, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 377);
            this.panel1.TabIndex = 46;
            // 
            // btn_add_fornecedor
            // 
            this.btn_add_fornecedor.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_fornecedor.ForeColor = System.Drawing.Color.Green;
            this.btn_add_fornecedor.Location = new System.Drawing.Point(176, 11);
            this.btn_add_fornecedor.Name = "btn_add_fornecedor";
            this.btn_add_fornecedor.Size = new System.Drawing.Size(34, 30);
            this.btn_add_fornecedor.TabIndex = 44;
            this.btn_add_fornecedor.Text = "+";
            this.btn_add_fornecedor.UseVisualStyleBackColor = false;
            this.btn_add_fornecedor.Click += new System.EventHandler(this.btn_add_fornecedor_Click);
            // 
            // btn_add_Item
            // 
            this.btn_add_Item.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_Item.ForeColor = System.Drawing.Color.Green;
            this.btn_add_Item.Location = new System.Drawing.Point(128, 72);
            this.btn_add_Item.Name = "btn_add_Item";
            this.btn_add_Item.Size = new System.Drawing.Size(34, 30);
            this.btn_add_Item.TabIndex = 43;
            this.btn_add_Item.Text = "+";
            this.btn_add_Item.UseVisualStyleBackColor = false;
            this.btn_add_Item.Click += new System.EventHandler(this.btn_add_fornecedor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 37);
            this.label8.TabIndex = 47;
            this.label8.Text = "Lote";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(268, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 331);
            this.panel2.TabIndex = 49;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(23, 254);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(253, 60);
            this.btnConfirmar.TabIndex = 50;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnEntrada);
            this.panel3.Controls.Add(this.numericUpDown6);
            this.panel3.Controls.Add(this.btnRetirar);
            this.panel3.Controls.Add(this.numericUpDown5);
            this.panel3.Controls.Add(this.btnRetirarTudo);
            this.panel3.Location = new System.Drawing.Point(20, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 226);
            this.panel3.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Ações";
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(136, 146);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(120, 47);
            this.btnEntrada.TabIndex = 50;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 2;
            this.numericUpDown6.Location = new System.Drawing.Point(3, 161);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(127, 20);
            this.numericUpDown6.TabIndex = 51;
            this.numericUpDown6.ThousandsSeparator = true;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.Location = new System.Drawing.Point(3, 53);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(127, 20);
            this.numericUpDown5.TabIndex = 46;
            this.numericUpDown5.ThousandsSeparator = true;
            // 
            // btnRetirarTudo
            // 
            this.btnRetirarTudo.Location = new System.Drawing.Point(3, 79);
            this.btnRetirarTudo.Name = "btnRetirarTudo";
            this.btnRetirarTudo.Size = new System.Drawing.Size(127, 29);
            this.btnRetirarTudo.TabIndex = 49;
            this.btnRetirarTudo.Text = "Retirar tudo";
            this.btnRetirarTudo.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 37);
            this.label10.TabIndex = 50;
            this.label10.Text = "Movimentação";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.dgLote);
            this.panel4.Controls.Add(this.codPesquisarLote);
            this.panel4.Controls.Add(this.cbPesquisarFornecedor);
            this.panel4.Controls.Add(this.cbPesquisarProduto);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnPesquisar);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(567, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(419, 377);
            this.panel4.TabIndex = 55;
            // 
            // cbPesquisarFornecedor
            // 
            this.cbPesquisarFornecedor.FormattingEnabled = true;
            this.cbPesquisarFornecedor.Location = new System.Drawing.Point(124, 77);
            this.cbPesquisarFornecedor.Name = "cbPesquisarFornecedor";
            this.cbPesquisarFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cbPesquisarFornecedor.TabIndex = 60;
            // 
            // cbPesquisarProduto
            // 
            this.cbPesquisarProduto.FormattingEnabled = true;
            this.cbPesquisarProduto.Location = new System.Drawing.Point(203, 45);
            this.cbPesquisarProduto.Name = "cbPesquisarProduto";
            this.cbPesquisarProduto.Size = new System.Drawing.Size(121, 21);
            this.cbPesquisarProduto.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(124, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Fornecedor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "Cod.";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(22, 312);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(383, 40);
            this.btnPesquisar.TabIndex = 50;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 25);
            this.label14.TabIndex = 48;
            this.label14.Text = "Pesquisar";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(288, 444);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(256, 40);
            this.btn_voltar.TabIndex = 53;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 37);
            this.label3.TabIndex = 56;
            this.label3.Text = "Lotes existentes";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(604, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(383, 40);
            this.button5.TabIndex = 57;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // codPesquisarLote
            // 
            this.codPesquisarLote.Location = new System.Drawing.Point(67, 46);
            this.codPesquisarLote.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.codPesquisarLote.Name = "codPesquisarLote";
            this.codPesquisarLote.Size = new System.Drawing.Size(51, 20);
            this.codPesquisarLote.TabIndex = 45;
            // 
            // dgLote
            // 
            this.dgLote.AllowUserToAddRows = false;
            this.dgLote.AllowUserToDeleteRows = false;
            this.dgLote.AutoGenerateColumns = false;
            this.dgLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipoestoqueDataGridViewTextBoxColumn,
            this.diasvalidadeDataGridViewTextBoxColumn,
            this.pesokgDataGridViewTextBoxColumn,
            this.valorcompraDataGridViewTextBoxColumn,
            this.qtdestoqueDataGridViewTextBoxColumn,
            this.fkitemDataGridViewTextBoxColumn,
            this.fkfornecedorDataGridViewTextBoxColumn});
            this.dgLote.DataSource = this.loteBindingSource;
            this.dgLote.Location = new System.Drawing.Point(21, 104);
            this.dgLote.Name = "dgLote";
            this.dgLote.ReadOnly = true;
            this.dgLote.Size = new System.Drawing.Size(384, 198);
            this.dgLote.TabIndex = 61;
            // 
            // supermecadoDataSet
            // 
            this.supermecadoDataSet.DataSetName = "SupermecadoDataSet";
            this.supermecadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loteBindingSource
            // 
            this.loteBindingSource.DataMember = "Lote";
            this.loteBindingSource.DataSource = this.supermecadoDataSet;
            // 
            // loteTableAdapter
            // 
            this.loteTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoestoqueDataGridViewTextBoxColumn
            // 
            this.tipoestoqueDataGridViewTextBoxColumn.DataPropertyName = "tipo_estoque";
            this.tipoestoqueDataGridViewTextBoxColumn.HeaderText = "Tipo estocado";
            this.tipoestoqueDataGridViewTextBoxColumn.Name = "tipoestoqueDataGridViewTextBoxColumn";
            this.tipoestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasvalidadeDataGridViewTextBoxColumn
            // 
            this.diasvalidadeDataGridViewTextBoxColumn.DataPropertyName = "dias_validade";
            this.diasvalidadeDataGridViewTextBoxColumn.HeaderText = "Validade (Dias)";
            this.diasvalidadeDataGridViewTextBoxColumn.Name = "diasvalidadeDataGridViewTextBoxColumn";
            this.diasvalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesokgDataGridViewTextBoxColumn
            // 
            this.pesokgDataGridViewTextBoxColumn.DataPropertyName = "peso_kg";
            this.pesokgDataGridViewTextBoxColumn.HeaderText = "Peso (kg)";
            this.pesokgDataGridViewTextBoxColumn.Name = "pesokgDataGridViewTextBoxColumn";
            this.pesokgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorcompraDataGridViewTextBoxColumn
            // 
            this.valorcompraDataGridViewTextBoxColumn.DataPropertyName = "valor_compra";
            this.valorcompraDataGridViewTextBoxColumn.HeaderText = "Valor da compra";
            this.valorcompraDataGridViewTextBoxColumn.Name = "valorcompraDataGridViewTextBoxColumn";
            this.valorcompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdestoqueDataGridViewTextBoxColumn
            // 
            this.qtdestoqueDataGridViewTextBoxColumn.DataPropertyName = "qtd_estoque";
            this.qtdestoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.qtdestoqueDataGridViewTextBoxColumn.Name = "qtdestoqueDataGridViewTextBoxColumn";
            this.qtdestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkitemDataGridViewTextBoxColumn
            // 
            this.fkitemDataGridViewTextBoxColumn.DataPropertyName = "fk_item";
            this.fkitemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.fkitemDataGridViewTextBoxColumn.Name = "fkitemDataGridViewTextBoxColumn";
            this.fkitemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkfornecedorDataGridViewTextBoxColumn
            // 
            this.fkfornecedorDataGridViewTextBoxColumn.DataPropertyName = "fk_fornecedor";
            this.fkfornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fkfornecedorDataGridViewTextBoxColumn.Name = "fkfornecedorDataGridViewTextBoxColumn";
            this.fkfornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 506);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Movimentacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentações do estoque";
            this.Load += new System.EventHandler(this.Movimentacoes_Load);
            this.Click += new System.EventHandler(this.btn_voltar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.validadeDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorCompra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codPesquisarLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermecadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ComboBox cbAddFornecedor;
        private System.Windows.Forms.ComboBox cbAddProduto;
        private System.Windows.Forms.Label Produto;
        private System.Windows.Forms.ComboBox cbAddTipoEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown validadeDias;
        private System.Windows.Forms.NumericUpDown pesoKg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown valorCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnRetirarTudo;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbPesquisarFornecedor;
        private System.Windows.Forms.ComboBox cbPesquisarProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_add_fornecedor;
        private System.Windows.Forms.Button btn_add_Item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown codPesquisarLote;
        private System.Windows.Forms.DataGridView dgLote;
        private SupermecadoDataSet supermecadoDataSet;
        private System.Windows.Forms.BindingSource loteBindingSource;
        private SupermecadoDataSetTableAdapters.LoteTableAdapter loteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasvalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesokgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkfornecedorDataGridViewTextBoxColumn;
    }
}