namespace Trabalho_A1_Supermecado
{
    partial class Relatorios
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.DateTIme = new System.Windows.Forms.DateTimePicker();
            this.cb_empregado = new System.Windows.Forms.ComboBox();
            this.empregadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermecadoDataSet = new Trabalho_A1_Supermecado.SupermecadoDataSet();
            this.fornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cb_produto = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkidloteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasvalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesokgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkempregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historicoTableAdapter = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.HistoricoTableAdapter();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.itemTableAdapter = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.ItemTableAdapter();
            this.fornecedorTableAdapter = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.FornecedorTableAdapter();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.empregadoTableAdapter = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.EmpregadoTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empregadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermecadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Histórico";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(575, 90);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(121, 40);
            this.btn_pesquisar.TabIndex = 6;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // DateTIme
            // 
            this.DateTIme.Location = new System.Drawing.Point(69, 88);
            this.DateTIme.Name = "DateTIme";
            this.DateTIme.Size = new System.Drawing.Size(200, 20);
            this.DateTIme.TabIndex = 7;
            // 
            // cb_empregado
            // 
            this.cb_empregado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empregadoBindingSource, "id", true));
            this.cb_empregado.DataSource = this.empregadoBindingSource;
            this.cb_empregado.DisplayMember = "nome_completo";
            this.cb_empregado.FormattingEnabled = true;
            this.cb_empregado.Location = new System.Drawing.Point(98, 114);
            this.cb_empregado.Name = "cb_empregado";
            this.cb_empregado.Size = new System.Drawing.Size(171, 21);
            this.cb_empregado.TabIndex = 9;
            this.cb_empregado.ValueMember = "id";
            // 
            // empregadoBindingSource
            // 
            this.empregadoBindingSource.DataMember = "Empregado";
            this.empregadoBindingSource.DataSource = this.supermecadoDataSet;
            // 
            // supermecadoDataSet
            // 
            this.supermecadoDataSet.DataSetName = "SupermecadoDataSet";
            this.supermecadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorBindingSource1
            // 
            this.fornecedorBindingSource1.DataMember = "Fornecedor";
            this.fornecedorBindingSource1.DataSource = this.supermecadoDataSet;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(700, 42);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(79, 40);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Responsável";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data";
            // 
            // cb_fornecedor
            // 
            this.cb_fornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedorBindingSource, "id", true));
            this.cb_fornecedor.DataSource = this.fornecedorBindingSource;
            this.cb_fornecedor.DisplayMember = "nome";
            this.cb_fornecedor.FormattingEnabled = true;
            this.cb_fornecedor.Location = new System.Drawing.Point(357, 115);
            this.cb_fornecedor.Name = "cb_fornecedor";
            this.cb_fornecedor.Size = new System.Drawing.Size(107, 21);
            this.cb_fornecedor.TabIndex = 16;
            this.cb_fornecedor.ValueMember = "id";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.supermecadoDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Lote cod.";
            // 
            // cb_produto
            // 
            this.cb_produto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemBindingSource, "id", true));
            this.cb_produto.DataSource = this.itemBindingSource;
            this.cb_produto.DisplayMember = "nome";
            this.cb_produto.FormattingEnabled = true;
            this.cb_produto.Location = new System.Drawing.Point(357, 91);
            this.cb_produto.Name = "cb_produto";
            this.cb_produto.Size = new System.Drawing.Size(212, 21);
            this.cb_produto.TabIndex = 19;
            this.cb_produto.ValueMember = "id";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.supermecadoDataSet;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn,
            this.operacaoDataGridViewTextBoxColumn,
            this.fkidloteDataGridViewTextBoxColumn,
            this.tipoestoqueDataGridViewTextBoxColumn,
            this.diasvalidadeDataGridViewTextBoxColumn,
            this.pesokgDataGridViewTextBoxColumn,
            this.valorcompraDataGridViewTextBoxColumn,
            this.qtdestoqueDataGridViewTextBoxColumn,
            this.fkitemDataGridViewTextBoxColumn,
            this.fkfornecedorDataGridViewTextBoxColumn,
            this.fkempregadoDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.historicoBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(13, 151);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(775, 287);
            this.dataGrid.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "Data e Hora";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operacaoDataGridViewTextBoxColumn
            // 
            this.operacaoDataGridViewTextBoxColumn.DataPropertyName = "operacao";
            this.operacaoDataGridViewTextBoxColumn.HeaderText = "Operacao";
            this.operacaoDataGridViewTextBoxColumn.Name = "operacaoDataGridViewTextBoxColumn";
            this.operacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkidloteDataGridViewTextBoxColumn
            // 
            this.fkidloteDataGridViewTextBoxColumn.DataPropertyName = "fk_id_lote";
            this.fkidloteDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.fkidloteDataGridViewTextBoxColumn.Name = "fkidloteDataGridViewTextBoxColumn";
            this.fkidloteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoestoqueDataGridViewTextBoxColumn
            // 
            this.tipoestoqueDataGridViewTextBoxColumn.DataPropertyName = "tipo_estoque";
            this.tipoestoqueDataGridViewTextBoxColumn.HeaderText = "Tipo de estoque";
            this.tipoestoqueDataGridViewTextBoxColumn.Name = "tipoestoqueDataGridViewTextBoxColumn";
            this.tipoestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasvalidadeDataGridViewTextBoxColumn
            // 
            this.diasvalidadeDataGridViewTextBoxColumn.DataPropertyName = "dias_validade";
            this.diasvalidadeDataGridViewTextBoxColumn.HeaderText = "Dias validade";
            this.diasvalidadeDataGridViewTextBoxColumn.Name = "diasvalidadeDataGridViewTextBoxColumn";
            this.diasvalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesokgDataGridViewTextBoxColumn
            // 
            this.pesokgDataGridViewTextBoxColumn.DataPropertyName = "peso_kg";
            this.pesokgDataGridViewTextBoxColumn.HeaderText = "peso (kg)";
            this.pesokgDataGridViewTextBoxColumn.Name = "pesokgDataGridViewTextBoxColumn";
            this.pesokgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorcompraDataGridViewTextBoxColumn
            // 
            this.valorcompraDataGridViewTextBoxColumn.DataPropertyName = "valor_compra";
            this.valorcompraDataGridViewTextBoxColumn.HeaderText = "Valor de compra";
            this.valorcompraDataGridViewTextBoxColumn.Name = "valorcompraDataGridViewTextBoxColumn";
            this.valorcompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdestoqueDataGridViewTextBoxColumn
            // 
            this.qtdestoqueDataGridViewTextBoxColumn.DataPropertyName = "qtd_estoque";
            this.qtdestoqueDataGridViewTextBoxColumn.HeaderText = "Quantidade";
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
            // fkempregadoDataGridViewTextBoxColumn
            // 
            this.fkempregadoDataGridViewTextBoxColumn.DataPropertyName = "fk_empregado";
            this.fkempregadoDataGridViewTextBoxColumn.HeaderText = "Empregado";
            this.fkempregadoDataGridViewTextBoxColumn.Name = "fkempregadoDataGridViewTextBoxColumn";
            this.fkempregadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historicoBindingSource
            // 
            this.historicoBindingSource.DataMember = "Historico";
            this.historicoBindingSource.DataSource = this.supermecadoDataSet;
            // 
            // historicoTableAdapter
            // 
            this.historicoTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(519, 117);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(50, 20);
            this.id.TabIndex = 21;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(700, 90);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(79, 40);
            this.btn_limpar.TabIndex = 22;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // empregadoTableAdapter
            // 
            this.empregadoTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.cb_produto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_fornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.cb_empregado);
            this.Controls.Add(this.DateTIme);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empregadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermecadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DateTimePicker DateTIme;
        private System.Windows.Forms.ComboBox cb_empregado;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_fornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_produto;
        private System.Windows.Forms.DataGridView dataGrid;
        private SupermecadoDataSet supermecadoDataSet;
        private System.Windows.Forms.BindingSource historicoBindingSource;
        private SupermecadoDataSetTableAdapters.HistoricoTableAdapter historicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkidloteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasvalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesokgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkempregadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private SupermecadoDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private SupermecadoDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.BindingSource fornecedorBindingSource1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.BindingSource empregadoBindingSource;
        private SupermecadoDataSetTableAdapters.EmpregadoTableAdapter empregadoTableAdapter;
    }
}