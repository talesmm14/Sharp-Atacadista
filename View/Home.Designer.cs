namespace Trabalho_A1_Supermecado
{
    partial class Home
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
            this.topmenu = new System.Windows.Forms.MenuStrip();
            this.cadastroMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_retirada = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Entrada = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.topmenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topmenu
            // 
            this.topmenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.topmenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroMenuItem,
            this.consultasMenuItem,
            this.relatoriosMenuItem,
            this.ajudaMenuItem});
            this.topmenu.Location = new System.Drawing.Point(0, 33);
            this.topmenu.Name = "topmenu";
            this.topmenu.Size = new System.Drawing.Size(113, 439);
            this.topmenu.TabIndex = 0;
            this.topmenu.Text = "topmenu";
            // 
            // cadastroMenuItem
            // 
            this.cadastroMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.cadastroMenuItem.Name = "cadastroMenuItem";
            this.cadastroMenuItem.Size = new System.Drawing.Size(100, 29);
            this.cadastroMenuItem.Text = "Cadastro";
            this.cadastroMenuItem.Click += new System.EventHandler(this.cadastroMenuItem_Click);
            // 
            // consultasMenuItem
            // 
            this.consultasMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.consultasMenuItem.Name = "consultasMenuItem";
            this.consultasMenuItem.Size = new System.Drawing.Size(100, 29);
            this.consultasMenuItem.Text = "Consultas";
            this.consultasMenuItem.Click += new System.EventHandler(this.consultasMenuItem_Click);
            // 
            // relatoriosMenuItem
            // 
            this.relatoriosMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatoriosMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.relatoriosMenuItem.Name = "relatoriosMenuItem";
            this.relatoriosMenuItem.Size = new System.Drawing.Size(100, 29);
            this.relatoriosMenuItem.Text = "Relatórios";
            this.relatoriosMenuItem.Click += new System.EventHandler(this.relatoriosMenuItem_Click);
            // 
            // ajudaMenuItem
            // 
            this.ajudaMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajudaMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ajudaMenuItem.Name = "ajudaMenuItem";
            this.ajudaMenuItem.Size = new System.Drawing.Size(100, 29);
            this.ajudaMenuItem.Text = "Ajuda";
            this.ajudaMenuItem.Click += new System.EventHandler(this.ajudaMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(665, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuario
            // 
            this.usuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfil,
            this.sair});
            this.usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(89, 29);
            this.usuario.Text = "Usuario";
            // 
            // perfil
            // 
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(127, 30);
            this.perfil.Text = "Perfil";
            // 
            // sair
            // 
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(127, 30);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btn_retirada
            // 
            this.btn_retirada.Location = new System.Drawing.Point(3, 3);
            this.btn_retirada.Name = "btn_retirada";
            this.btn_retirada.Size = new System.Drawing.Size(100, 100);
            this.btn_retirada.TabIndex = 2;
            this.btn_retirada.Text = "Retirada";
            this.btn_retirada.UseVisualStyleBackColor = true;
            this.btn_retirada.Click += new System.EventHandler(this.btn_retirada_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Entrada, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_retirada, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(131, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 276);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(399, 141);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 9;
            this.button7.Text = "Ajuda";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(267, 141);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(135, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_Entrada
            // 
            this.btn_Entrada.Location = new System.Drawing.Point(3, 141);
            this.btn_Entrada.Name = "btn_Entrada";
            this.btn_Entrada.Size = new System.Drawing.Size(100, 100);
            this.btn_Entrada.TabIndex = 6;
            this.btn_Entrada.Text = "Entrada";
            this.btn_Entrada.UseVisualStyleBackColor = true;
            this.btn_Entrada.Click += new System.EventHandler(this.btn_Entrada_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 4;
            this.button2.Text = "Relatórios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.relatoriosMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.consultasMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 472);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.topmenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.topmenu;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Supermecado";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.topmenu.ResumeLayout(false);
            this.topmenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topmenu;
        private System.Windows.Forms.ToolStripMenuItem cadastroMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuario;
        private System.Windows.Forms.ToolStripMenuItem perfil;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.Button btn_retirada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Entrada;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

