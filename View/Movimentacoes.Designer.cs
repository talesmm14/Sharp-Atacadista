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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeLote = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nuRetirar = new System.Windows.Forms.NumericUpDown();
            this.cbPesquisarFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermecadoDataSet2 = new Trabalho_A1_Supermecado.SupermecadoDataSet();
            this.cbPesquisarProduto = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkCod = new System.Windows.Forms.CheckBox();
            this.checkFornecedor = new System.Windows.Forms.CheckBox();
            this.checkEstoque = new System.Windows.Forms.CheckBox();
            this.checkProduto = new System.Windows.Forms.CheckBox();
            this.nValidade = new System.Windows.Forms.DateTimePicker();
            this.cbEstoque = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkValidade = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codPesquisarLote = new System.Windows.Forms.TextBox();
            this.itemTableAdapter1 = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.ItemTableAdapter();
            this.fornecedorTableAdapter1 = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.FornecedorTableAdapter();
            this.loteTableAdapter1 = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.LoteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRetirar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermecadoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
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
            this.btnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(255)))), ((int)(((byte)(113)))));
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(0, 182);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(142, 90);
            this.btnRetirar.TabIndex = 28;
            this.btnRetirar.Text = "Confirmar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.nomeLote);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnRetirar);
            this.panel3.Controls.Add(this.nuRetirar);
            this.panel3.Location = new System.Drawing.Point(651, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 272);
            this.panel3.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Quantidade";
            // 
            // nomeLote
            // 
            this.nomeLote.AutoSize = true;
            this.nomeLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLote.Location = new System.Drawing.Point(4, 78);
            this.nomeLote.Name = "nomeLote";
            this.nomeLote.Size = new System.Drawing.Size(57, 20);
            this.nomeLote.TabIndex = 54;
            this.nomeLote.Text = "Lote ...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Ações";
            // 
            // nuRetirar
            // 
            this.nuRetirar.DecimalPlaces = 2;
            this.nuRetirar.Location = new System.Drawing.Point(8, 141);
            this.nuRetirar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nuRetirar.Name = "nuRetirar";
            this.nuRetirar.Size = new System.Drawing.Size(127, 20);
            this.nuRetirar.TabIndex = 46;
            this.nuRetirar.ThousandsSeparator = true;
            // 
            // cbPesquisarFornecedor
            // 
            this.cbPesquisarFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedorBindingSource, "id", true));
            this.cbPesquisarFornecedor.DataSource = this.fornecedorBindingSource;
            this.cbPesquisarFornecedor.DisplayMember = "nome";
            this.cbPesquisarFornecedor.FormattingEnabled = true;
            this.cbPesquisarFornecedor.Location = new System.Drawing.Point(140, 65);
            this.cbPesquisarFornecedor.Name = "cbPesquisarFornecedor";
            this.cbPesquisarFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cbPesquisarFornecedor.TabIndex = 60;
            this.cbPesquisarFornecedor.ValueMember = "id";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.supermecadoDataSet2;
            // 
            // supermecadoDataSet2
            // 
            this.supermecadoDataSet2.DataSetName = "SupermecadoDataSet";
            this.supermecadoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbPesquisarProduto
            // 
            this.cbPesquisarProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemBindingSource, "id", true));
            this.cbPesquisarProduto.DataSource = this.itemBindingSource;
            this.cbPesquisarProduto.DisplayMember = "nome";
            this.cbPesquisarProduto.FormattingEnabled = true;
            this.cbPesquisarProduto.Location = new System.Drawing.Point(140, 35);
            this.cbPesquisarProduto.Name = "cbPesquisarProduto";
            this.cbPesquisarProduto.Size = new System.Drawing.Size(121, 21);
            this.cbPesquisarProduto.TabIndex = 59;
            this.cbPesquisarProduto.ValueMember = "id";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.supermecadoDataSet2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Fornecedor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "Cod.";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(586, 371);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(207, 66);
            this.btnPesquisar.TabIndex = 50;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(448, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(345, 40);
            this.button5.TabIndex = 57;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGrid.DataSource = this.loteBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(19, 58);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(626, 272);
            this.dataGrid.TabIndex = 61;
            this.dataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cod.";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tipo_estoque";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo de Estoque";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "validade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Validade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "peso_kg";
            this.dataGridViewTextBoxColumn4.HeaderText = "Peso(kg)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor_compra";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor(compra)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "qtd_estoque";
            this.dataGridViewTextBoxColumn6.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fk_item";
            this.dataGridViewTextBoxColumn7.HeaderText = "Item";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fk_fornecedor";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "data_entrada";
            this.dataGridViewTextBoxColumn9.HeaderText = "Data de entrada";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "data_fabricacao";
            this.dataGridViewTextBoxColumn10.HeaderText = "Data de fabricação";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // loteBindingSource
            // 
            this.loteBindingSource.DataMember = "Lote";
            this.loteBindingSource.DataSource = this.supermecadoDataSet2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.checkCod, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkFornecedor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkEstoque, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkProduto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nValidade, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbEstoque, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.id, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbPesquisarProduto, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkValidade, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbPesquisarFornecedor, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.codPesquisarLote, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 336);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 101);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // checkCod
            // 
            this.checkCod.AutoSize = true;
            this.checkCod.Location = new System.Drawing.Point(6, 6);
            this.checkCod.Name = "checkCod";
            this.checkCod.Size = new System.Drawing.Size(15, 14);
            this.checkCod.TabIndex = 76;
            this.checkCod.UseVisualStyleBackColor = true;
            // 
            // checkFornecedor
            // 
            this.checkFornecedor.AutoSize = true;
            this.checkFornecedor.Location = new System.Drawing.Point(6, 65);
            this.checkFornecedor.Name = "checkFornecedor";
            this.checkFornecedor.Size = new System.Drawing.Size(15, 14);
            this.checkFornecedor.TabIndex = 75;
            this.checkFornecedor.UseVisualStyleBackColor = true;
            // 
            // checkEstoque
            // 
            this.checkEstoque.AutoSize = true;
            this.checkEstoque.Location = new System.Drawing.Point(270, 35);
            this.checkEstoque.Name = "checkEstoque";
            this.checkEstoque.Size = new System.Drawing.Size(15, 14);
            this.checkEstoque.TabIndex = 74;
            this.checkEstoque.UseVisualStyleBackColor = true;
            // 
            // checkProduto
            // 
            this.checkProduto.AutoSize = true;
            this.checkProduto.Location = new System.Drawing.Point(6, 35);
            this.checkProduto.Name = "checkProduto";
            this.checkProduto.Size = new System.Drawing.Size(15, 14);
            this.checkProduto.TabIndex = 73;
            this.checkProduto.UseVisualStyleBackColor = true;
            // 
            // nValidade
            // 
            this.nValidade.Location = new System.Drawing.Point(430, 6);
            this.nValidade.Name = "nValidade";
            this.nValidade.Size = new System.Drawing.Size(121, 20);
            this.nValidade.TabIndex = 67;
            // 
            // cbEstoque
            // 
            this.cbEstoque.FormattingEnabled = true;
            this.cbEstoque.Items.AddRange(new object[] {
            "Estoque de proteção",
            "Estoque em trânsito",
            "Estoque de antecipação",
            "Estoque consignado",
            "Dropshipping"});
            this.cbEstoque.Location = new System.Drawing.Point(430, 35);
            this.cbEstoque.Name = "cbEstoque";
            this.cbEstoque.Size = new System.Drawing.Size(121, 21);
            this.cbEstoque.TabIndex = 66;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(430, 65);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(120, 20);
            this.id.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Validade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Estoque (Tipo)";
            // 
            // checkValidade
            // 
            this.checkValidade.AutoSize = true;
            this.checkValidade.Location = new System.Drawing.Point(270, 6);
            this.checkValidade.Name = "checkValidade";
            this.checkValidade.Size = new System.Drawing.Size(15, 14);
            this.checkValidade.TabIndex = 71;
            this.checkValidade.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID";
            // 
            // codPesquisarLote
            // 
            this.codPesquisarLote.Location = new System.Drawing.Point(140, 6);
            this.codPesquisarLote.Name = "codPesquisarLote";
            this.codPesquisarLote.Size = new System.Drawing.Size(121, 20);
            this.codPesquisarLote.TabIndex = 68;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter1
            // 
            this.fornecedorTableAdapter1.ClearBeforeFill = true;
            // 
            // loteTableAdapter1
            // 
            this.loteTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(114)))), ((int)(((byte)(129)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(114)))), ((int)(((byte)(129)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(586, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 32);
            this.button1.TabIndex = 63;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(227)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(798, 452);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Name = "Movimentacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentações do estoque";
            this.Load += new System.EventHandler(this.Movimentacoes_Load);
            this.Click += new System.EventHandler(this.btn_voltar_Click);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRetirar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermecadoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.NumericUpDown nuRetirar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPesquisarFornecedor;
        private System.Windows.Forms.ComboBox cbPesquisarProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button button5;
        private SupermecadoDataSet supermecadoDataSet;
        private SupermecadoDataSetTableAdapters.LoteTableAdapter loteTableAdapter;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nomeLote;
        private SupermecadoDataSet supermecadoDataSet1;
        private SupermecadoDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private SupermecadoDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesokgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafabricacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker nValidade;
        private SupermecadoDataSet supermecadoDataSet2;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private SupermecadoDataSetTableAdapters.ItemTableAdapter itemTableAdapter1;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private SupermecadoDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter1;
        private System.Windows.Forms.TextBox codPesquisarLote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.BindingSource loteBindingSource;
        private SupermecadoDataSetTableAdapters.LoteTableAdapter loteTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.CheckBox checkCod;
        private System.Windows.Forms.CheckBox checkFornecedor;
        private System.Windows.Forms.CheckBox checkEstoque;
        private System.Windows.Forms.CheckBox checkProduto;
        private System.Windows.Forms.CheckBox checkValidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}