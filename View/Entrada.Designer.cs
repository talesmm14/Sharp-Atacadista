namespace Trabalho_A1_Supermecado.View
{
    partial class Entrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.valorCompra = new System.Windows.Forms.NumericUpDown();
            this.cbEstoqueTipo = new System.Windows.Forms.ComboBox();
            this.validadeDias = new System.Windows.Forms.NumericUpDown();
            this.pesoKg = new System.Windows.Forms.NumericUpDown();
            this.estoque = new System.Windows.Forms.NumericUpDown();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAddF = new System.Windows.Forms.Button();
            this.btnAddI = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.codFornecedor = new System.Windows.Forms.NumericUpDown();
            this.codItem = new System.Windows.Forms.NumericUpDown();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valorCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validadeDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoque)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada de Lote";
            // 
            // valorCompra
            // 
            this.valorCompra.DecimalPlaces = 2;
            this.valorCompra.Location = new System.Drawing.Point(153, 42);
            this.valorCompra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valorCompra.Name = "valorCompra";
            this.valorCompra.Size = new System.Drawing.Size(107, 20);
            this.valorCompra.TabIndex = 41;
            this.valorCompra.ThousandsSeparator = true;
            // 
            // cbEstoqueTipo
            // 
            this.cbEstoqueTipo.FormattingEnabled = true;
            this.cbEstoqueTipo.Location = new System.Drawing.Point(153, 6);
            this.cbEstoqueTipo.Name = "cbEstoqueTipo";
            this.cbEstoqueTipo.Size = new System.Drawing.Size(137, 21);
            this.cbEstoqueTipo.TabIndex = 42;
            // 
            // validadeDias
            // 
            this.validadeDias.Location = new System.Drawing.Point(153, 114);
            this.validadeDias.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.validadeDias.Name = "validadeDias";
            this.validadeDias.Size = new System.Drawing.Size(137, 20);
            this.validadeDias.TabIndex = 43;
            this.validadeDias.ThousandsSeparator = true;
            // 
            // pesoKg
            // 
            this.pesoKg.DecimalPlaces = 2;
            this.pesoKg.Location = new System.Drawing.Point(153, 150);
            this.pesoKg.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pesoKg.Name = "pesoKg";
            this.pesoKg.Size = new System.Drawing.Size(137, 20);
            this.pesoKg.TabIndex = 44;
            this.pesoKg.ThousandsSeparator = true;
            // 
            // estoque
            // 
            this.estoque.Location = new System.Drawing.Point(153, 78);
            this.estoque.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.estoque.Name = "estoque";
            this.estoque.Size = new System.Drawing.Size(107, 20);
            this.estoque.TabIndex = 45;
            this.estoque.ThousandsSeparator = true;
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(153, 222);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(193, 21);
            this.cbItem.TabIndex = 46;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(153, 186);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(193, 21);
            this.cbFornecedor.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Validade (Dias)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Peso (kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Valor (Compra)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "Estoque (Tipo)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Fornecedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 24);
            this.label8.TabIndex = 54;
            this.label8.Text = "Item";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(71, 350);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(272, 51);
            this.btnCadastrar.TabIndex = 57;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAddF
            // 
            this.btnAddF.BackColor = System.Drawing.Color.Lime;
            this.btnAddF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddF.Location = new System.Drawing.Point(409, 186);
            this.btnAddF.Name = "btnAddF";
            this.btnAddF.Size = new System.Drawing.Size(29, 26);
            this.btnAddF.TabIndex = 58;
            this.btnAddF.Text = "+";
            this.btnAddF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddF.UseVisualStyleBackColor = false;
            this.btnAddF.Click += new System.EventHandler(this.btnAddF_Click);
            // 
            // btnAddI
            // 
            this.btnAddI.BackColor = System.Drawing.Color.Lime;
            this.btnAddI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddI.Location = new System.Drawing.Point(409, 222);
            this.btnAddI.Name = "btnAddI";
            this.btnAddI.Size = new System.Drawing.Size(29, 26);
            this.btnAddI.TabIndex = 59;
            this.btnAddI.Text = "+";
            this.btnAddI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddI.UseVisualStyleBackColor = false;
            this.btnAddI.Click += new System.EventHandler(this.btnAddF_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.estoque, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.validadeDias, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbItem, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbFornecedor, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.valorCompra, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pesoKg, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbEstoqueTipo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddF, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.codFornecedor, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAddI, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.codItem, 2, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 262);
            this.tableLayoutPanel1.TabIndex = 60;
            // 
            // codFornecedor
            // 
            this.codFornecedor.Location = new System.Drawing.Point(355, 186);
            this.codFornecedor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.codFornecedor.Name = "codFornecedor";
            this.codFornecedor.Size = new System.Drawing.Size(45, 20);
            this.codFornecedor.TabIndex = 60;
            this.codFornecedor.ValueChanged += new System.EventHandler(this.codFornecedor_ValueChanged);
            // 
            // codItem
            // 
            this.codItem.Location = new System.Drawing.Point(355, 222);
            this.codItem.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.codItem.Name = "codItem";
            this.codItem.Size = new System.Drawing.Size(45, 20);
            this.codItem.TabIndex = 61;
            this.codItem.ValueChanged += new System.EventHandler(this.codItem_ValueChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(340, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 34);
            this.btnVoltar.TabIndex = 61;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 413);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.valorCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validadeDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoque)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown valorCompra;
        private System.Windows.Forms.ComboBox cbEstoqueTipo;
        private System.Windows.Forms.NumericUpDown validadeDias;
        private System.Windows.Forms.NumericUpDown pesoKg;
        private System.Windows.Forms.NumericUpDown estoque;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAddF;
        private System.Windows.Forms.Button btnAddI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.NumericUpDown codFornecedor;
        private System.Windows.Forms.NumericUpDown codItem;
    }
}