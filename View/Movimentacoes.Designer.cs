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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.nuRetirar = new System.Windows.Forms.NumericUpDown();
            this.btnRetirarTudo = new System.Windows.Forms.Button();
            this.loteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermecadoDataSet = new Trabalho_A1_Supermecado.SupermecadoDataSet();
            this.codPesquisarLote = new System.Windows.Forms.NumericUpDown();
            this.cbPesquisarFornecedor = new System.Windows.Forms.ComboBox();
            this.cbPesquisarProduto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.loteTableAdapter = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.LoteTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasvalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesokgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.nValidade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstoque = new System.Windows.Forms.ComboBox();
            this.nomeLote = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRetirar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermecadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codPesquisarLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nValidade)).BeginInit();
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
            this.btnRetirar.Location = new System.Drawing.Point(12, 166);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(127, 47);
            this.btnRetirar.TabIndex = 28;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(637, 336);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(156, 101);
            this.btnConfirmar.TabIndex = 50;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.nomeLote);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnRetirar);
            this.panel3.Controls.Add(this.nuRetirar);
            this.panel3.Controls.Add(this.btnRetirarTudo);
            this.panel3.Location = new System.Drawing.Point(637, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 272);
            this.panel3.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Ações";
            // 
            // nuRetirar
            // 
            this.nuRetirar.DecimalPlaces = 2;
            this.nuRetirar.Location = new System.Drawing.Point(12, 114);
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
            // btnRetirarTudo
            // 
            this.btnRetirarTudo.Location = new System.Drawing.Point(12, 140);
            this.btnRetirarTudo.Name = "btnRetirarTudo";
            this.btnRetirarTudo.Size = new System.Drawing.Size(127, 20);
            this.btnRetirarTudo.TabIndex = 49;
            this.btnRetirarTudo.Text = "Retirar tudo";
            this.btnRetirarTudo.UseVisualStyleBackColor = true;
            // 
            // loteBindingSource
            // 
            this.loteBindingSource.DataMember = "Lote";
            this.loteBindingSource.DataSource = this.supermecadoDataSet;
            // 
            // supermecadoDataSet
            // 
            this.supermecadoDataSet.DataSetName = "SupermecadoDataSet";
            this.supermecadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codPesquisarLote
            // 
            this.codPesquisarLote.Location = new System.Drawing.Point(116, 6);
            this.codPesquisarLote.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.codPesquisarLote.Name = "codPesquisarLote";
            this.codPesquisarLote.Size = new System.Drawing.Size(51, 20);
            this.codPesquisarLote.TabIndex = 45;
            // 
            // cbPesquisarFornecedor
            // 
            this.cbPesquisarFornecedor.FormattingEnabled = true;
            this.cbPesquisarFornecedor.Location = new System.Drawing.Point(116, 65);
            this.cbPesquisarFornecedor.Name = "cbPesquisarFornecedor";
            this.cbPesquisarFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cbPesquisarFornecedor.TabIndex = 60;
            // 
            // cbPesquisarProduto
            // 
            this.cbPesquisarProduto.FormattingEnabled = true;
            this.cbPesquisarProduto.Location = new System.Drawing.Point(116, 35);
            this.cbPesquisarProduto.Name = "cbPesquisarProduto";
            this.cbPesquisarProduto.Size = new System.Drawing.Size(121, 21);
            this.cbPesquisarProduto.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Produto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Fornecedor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "Cod.";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(537, 336);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 101);
            this.btnPesquisar.TabIndex = 50;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
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
            // loteTableAdapter
            // 
            this.loteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipoestoqueDataGridViewTextBoxColumn,
            this.diasvalidadeDataGridViewTextBoxColumn,
            this.pesokgDataGridViewTextBoxColumn,
            this.valorcompraDataGridViewTextBoxColumn,
            this.qtdestoqueDataGridViewTextBoxColumn,
            this.fkitemDataGridViewTextBoxColumn,
            this.fkfornecedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(612, 272);
            this.dataGridView1.TabIndex = 61;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // tipoestoqueDataGridViewTextBoxColumn
            // 
            this.tipoestoqueDataGridViewTextBoxColumn.DataPropertyName = "tipo_estoque";
            this.tipoestoqueDataGridViewTextBoxColumn.HeaderText = "Tipo de estoque";
            this.tipoestoqueDataGridViewTextBoxColumn.Name = "tipoestoqueDataGridViewTextBoxColumn";
            this.tipoestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoestoqueDataGridViewTextBoxColumn.Width = 70;
            // 
            // diasvalidadeDataGridViewTextBoxColumn
            // 
            this.diasvalidadeDataGridViewTextBoxColumn.DataPropertyName = "dias_validade";
            this.diasvalidadeDataGridViewTextBoxColumn.HeaderText = "Validade (Dias)";
            this.diasvalidadeDataGridViewTextBoxColumn.Name = "diasvalidadeDataGridViewTextBoxColumn";
            this.diasvalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.diasvalidadeDataGridViewTextBoxColumn.Width = 70;
            // 
            // pesokgDataGridViewTextBoxColumn
            // 
            this.pesokgDataGridViewTextBoxColumn.DataPropertyName = "peso_kg";
            this.pesokgDataGridViewTextBoxColumn.HeaderText = "Peso (kg)";
            this.pesokgDataGridViewTextBoxColumn.Name = "pesokgDataGridViewTextBoxColumn";
            this.pesokgDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesokgDataGridViewTextBoxColumn.Width = 70;
            // 
            // valorcompraDataGridViewTextBoxColumn
            // 
            this.valorcompraDataGridViewTextBoxColumn.DataPropertyName = "valor_compra";
            this.valorcompraDataGridViewTextBoxColumn.HeaderText = "Valor (Compra)";
            this.valorcompraDataGridViewTextBoxColumn.Name = "valorcompraDataGridViewTextBoxColumn";
            this.valorcompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorcompraDataGridViewTextBoxColumn.Width = 70;
            // 
            // qtdestoqueDataGridViewTextBoxColumn
            // 
            this.qtdestoqueDataGridViewTextBoxColumn.DataPropertyName = "qtd_estoque";
            this.qtdestoqueDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.qtdestoqueDataGridViewTextBoxColumn.Name = "qtdestoqueDataGridViewTextBoxColumn";
            this.qtdestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtdestoqueDataGridViewTextBoxColumn.Width = 90;
            // 
            // fkitemDataGridViewTextBoxColumn
            // 
            this.fkitemDataGridViewTextBoxColumn.DataPropertyName = "fk_item";
            this.fkitemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.fkitemDataGridViewTextBoxColumn.Name = "fkitemDataGridViewTextBoxColumn";
            this.fkitemDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkitemDataGridViewTextBoxColumn.Width = 70;
            // 
            // fkfornecedorDataGridViewTextBoxColumn
            // 
            this.fkfornecedorDataGridViewTextBoxColumn.DataPropertyName = "fk_fornecedor";
            this.fkfornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fkfornecedorDataGridViewTextBoxColumn.Name = "fkfornecedorDataGridViewTextBoxColumn";
            this.fkfornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkfornecedorDataGridViewTextBoxColumn.Width = 80;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.cbEstoque, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nValidade, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.codPesquisarLote, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbPesquisarProduto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbPesquisarFornecedor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 336);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 101);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Validade (Dias)";
            // 
            // nValidade
            // 
            this.nValidade.Location = new System.Drawing.Point(387, 6);
            this.nValidade.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nValidade.Name = "nValidade";
            this.nValidade.Size = new System.Drawing.Size(51, 20);
            this.nValidade.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Estoque (Tipo)";
            // 
            // cbEstoque
            // 
            this.cbEstoque.FormattingEnabled = true;
            this.cbEstoque.Location = new System.Drawing.Point(387, 35);
            this.cbEstoque.Name = "cbEstoque";
            this.cbEstoque.Size = new System.Drawing.Size(121, 21);
            this.cbEstoque.TabIndex = 66;
            // 
            // nomeLote
            // 
            this.nomeLote.AutoSize = true;
            this.nomeLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLote.Location = new System.Drawing.Point(38, 72);
            this.nomeLote.Name = "nomeLote";
            this.nomeLote.Size = new System.Drawing.Size(21, 20);
            this.nomeLote.TabIndex = 54;
            this.nomeLote.Text = "...";
            // 
            // Movimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 452);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnConfirmar);
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
            ((System.ComponentModel.ISupportInitialize)(this.loteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermecadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codPesquisarLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nValidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnRetirarTudo;
        private System.Windows.Forms.NumericUpDown nuRetirar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPesquisarFornecedor;
        private System.Windows.Forms.ComboBox cbPesquisarProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown codPesquisarLote;
        private SupermecadoDataSet supermecadoDataSet;
        private System.Windows.Forms.BindingSource loteBindingSource;
        private SupermecadoDataSetTableAdapters.LoteTableAdapter loteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasvalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesokgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nValidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nomeLote;
    }
}