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
            this.dateTIme = new System.Windows.Forms.DateTimePicker();
            this.cb_empregado = new System.Windows.Forms.ComboBox();
            this.empregadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermecadoDataSet1 = new Trabalho_A1_Supermecado.SupermecadoDataSet();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafabricacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.historicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.NumericUpDown();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.empregadoTableAdapter1 = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.EmpregadoTableAdapter();
            this.itemTableAdapter1 = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.ItemTableAdapter();
            this.fornecedorTableAdapter1 = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.FornecedorTableAdapter();
            this.historicoTableAdapter1 = new Trabalho_A1_Supermecado.SupermecadoDataSetTableAdapters.HistoricoTableAdapter();
            this.checkProtudo = new System.Windows.Forms.CheckBox();
            this.checkFornecedor = new System.Windows.Forms.CheckBox();
            this.checkData = new System.Windows.Forms.CheckBox();
            this.checkResponsavel = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empregadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermecadoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(808, 33);
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
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(127, 30);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(127, 30);
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
            // dateTIme
            // 
            this.dateTIme.Location = new System.Drawing.Point(69, 88);
            this.dateTIme.Name = "dateTIme";
            this.dateTIme.Size = new System.Drawing.Size(200, 20);
            this.dateTIme.TabIndex = 7;
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
            this.empregadoBindingSource.DataSource = this.supermecadoDataSet1;
            // 
            // supermecadoDataSet1
            // 
            this.supermecadoDataSet1.DataSetName = "SupermecadoDataSet";
            this.supermecadoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(700, 42);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(88, 40);
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
            this.fornecedorBindingSource.DataSource = this.supermecadoDataSet1;
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
            this.itemBindingSource.DataSource = this.supermecadoDataSet1;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.datafabricacaoDataGridViewTextBoxColumn,
            this.dataentradaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.historicoBindingSource1;
            this.dataGrid.Location = new System.Drawing.Point(13, 151);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(775, 287);
            this.dataGrid.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "datetime";
            this.dataGridViewTextBoxColumn2.HeaderText = "datetime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "operacao";
            this.dataGridViewTextBoxColumn3.HeaderText = "operacao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fk_id_lote";
            this.dataGridViewTextBoxColumn4.HeaderText = "fk_id_lote";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tipo_estoque";
            this.dataGridViewTextBoxColumn5.HeaderText = "tipo_estoque";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dias_validade";
            this.dataGridViewTextBoxColumn6.HeaderText = "dias_validade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "peso_kg";
            this.dataGridViewTextBoxColumn7.HeaderText = "peso_kg";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "valor_compra";
            this.dataGridViewTextBoxColumn8.HeaderText = "valor_compra";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "qtd_estoque";
            this.dataGridViewTextBoxColumn9.HeaderText = "qtd_estoque";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fk_item";
            this.dataGridViewTextBoxColumn10.HeaderText = "fk_item";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "fk_fornecedor";
            this.dataGridViewTextBoxColumn11.HeaderText = "fk_fornecedor";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "fk_empregado";
            this.dataGridViewTextBoxColumn12.HeaderText = "fk_empregado";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // datafabricacaoDataGridViewTextBoxColumn
            // 
            this.datafabricacaoDataGridViewTextBoxColumn.DataPropertyName = "data_fabricacao";
            this.datafabricacaoDataGridViewTextBoxColumn.HeaderText = "data_fabricacao";
            this.datafabricacaoDataGridViewTextBoxColumn.Name = "datafabricacaoDataGridViewTextBoxColumn";
            this.datafabricacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataentradaDataGridViewTextBoxColumn
            // 
            this.dataentradaDataGridViewTextBoxColumn.DataPropertyName = "data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.HeaderText = "data_entrada";
            this.dataentradaDataGridViewTextBoxColumn.Name = "dataentradaDataGridViewTextBoxColumn";
            this.dataentradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historicoBindingSource1
            // 
            this.historicoBindingSource1.DataMember = "Historico";
            this.historicoBindingSource1.DataSource = this.supermecadoDataSet1;
            // 
            // historicoBindingSource
            // 
            this.historicoBindingSource.DataMember = "Historico";
            this.historicoBindingSource.DataSource = this.supermecadoDataSet1;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(519, 117);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(50, 20);
            this.id.TabIndex = 21;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(700, 90);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(88, 40);
            this.btn_limpar.TabIndex = 22;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // empregadoTableAdapter1
            // 
            this.empregadoTableAdapter1.ClearBeforeFill = true;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter1
            // 
            this.fornecedorTableAdapter1.ClearBeforeFill = true;
            // 
            // historicoTableAdapter1
            // 
            this.historicoTableAdapter1.ClearBeforeFill = true;
            // 
            // checkProtudo
            // 
            this.checkProtudo.AutoSize = true;
            this.checkProtudo.Location = new System.Drawing.Point(276, 90);
            this.checkProtudo.Name = "checkProtudo";
            this.checkProtudo.Size = new System.Drawing.Size(15, 14);
            this.checkProtudo.TabIndex = 23;
            this.checkProtudo.UseVisualStyleBackColor = true;
            // 
            // checkFornecedor
            // 
            this.checkFornecedor.AutoSize = true;
            this.checkFornecedor.Location = new System.Drawing.Point(276, 117);
            this.checkFornecedor.Name = "checkFornecedor";
            this.checkFornecedor.Size = new System.Drawing.Size(15, 14);
            this.checkFornecedor.TabIndex = 24;
            this.checkFornecedor.UseVisualStyleBackColor = true;
            // 
            // checkData
            // 
            this.checkData.AutoSize = true;
            this.checkData.Location = new System.Drawing.Point(12, 92);
            this.checkData.Name = "checkData";
            this.checkData.Size = new System.Drawing.Size(15, 14);
            this.checkData.TabIndex = 25;
            this.checkData.UseVisualStyleBackColor = true;
            // 
            // checkResponsavel
            // 
            this.checkResponsavel.AutoSize = true;
            this.checkResponsavel.Location = new System.Drawing.Point(12, 118);
            this.checkResponsavel.Name = "checkResponsavel";
            this.checkResponsavel.Size = new System.Drawing.Size(15, 14);
            this.checkResponsavel.TabIndex = 26;
            this.checkResponsavel.UseVisualStyleBackColor = true;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.ControlBox = false;
            this.Controls.Add(this.checkResponsavel);
            this.Controls.Add(this.checkData);
            this.Controls.Add(this.checkFornecedor);
            this.Controls.Add(this.checkProtudo);
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
            this.Controls.Add(this.dateTIme);
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
            ((System.ComponentModel.ISupportInitialize)(this.supermecadoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTIme;
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
        private SupermecadoDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private SupermecadoDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.Button btn_limpar;
        private SupermecadoDataSetTableAdapters.EmpregadoTableAdapter empregadoTableAdapter;
        private SupermecadoDataSet supermecadoDataSet1;
        private System.Windows.Forms.BindingSource empregadoBindingSource;
        private SupermecadoDataSetTableAdapters.EmpregadoTableAdapter empregadoTableAdapter1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private SupermecadoDataSetTableAdapters.ItemTableAdapter itemTableAdapter1;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private SupermecadoDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter1;
        private System.Windows.Forms.BindingSource historicoBindingSource;
        private SupermecadoDataSetTableAdapters.HistoricoTableAdapter historicoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafabricacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historicoBindingSource1;
        private System.Windows.Forms.CheckBox checkProtudo;
        private System.Windows.Forms.CheckBox checkFornecedor;
        private System.Windows.Forms.CheckBox checkData;
        private System.Windows.Forms.CheckBox checkResponsavel;
    }
}