namespace FestaJunina2018
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAtendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeAtendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.atendentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.produtosToolStripMenuItem.Text = "&Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeVendasToolStripMenuItem,
            this.consultaDeVendasToolStripMenuItem});
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.vendasToolStripMenuItem.Text = "&Vendas";
            // 
            // cadastroDeVendasToolStripMenuItem
            // 
            this.cadastroDeVendasToolStripMenuItem.Name = "cadastroDeVendasToolStripMenuItem";
            this.cadastroDeVendasToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.cadastroDeVendasToolStripMenuItem.Text = "Cadastro de Vendas";
            this.cadastroDeVendasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeVendasToolStripMenuItem_Click);
            // 
            // consultaDeVendasToolStripMenuItem
            // 
            this.consultaDeVendasToolStripMenuItem.Name = "consultaDeVendasToolStripMenuItem";
            this.consultaDeVendasToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.consultaDeVendasToolStripMenuItem.Text = "Consulta de Vendas";
            this.consultaDeVendasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeVendasToolStripMenuItem_Click);
            // 
            // atendentesToolStripMenuItem
            // 
            this.atendentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAtendentesToolStripMenuItem,
            this.consultaDeAtendentesToolStripMenuItem});
            this.atendentesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atendentesToolStripMenuItem.Name = "atendentesToolStripMenuItem";
            this.atendentesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.atendentesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.atendentesToolStripMenuItem.Text = "&Atendentes";
            // 
            // cadastroDeAtendentesToolStripMenuItem
            // 
            this.cadastroDeAtendentesToolStripMenuItem.Name = "cadastroDeAtendentesToolStripMenuItem";
            this.cadastroDeAtendentesToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.cadastroDeAtendentesToolStripMenuItem.Text = "Cadastro de Atendentes";
            this.cadastroDeAtendentesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAtendentesToolStripMenuItem_Click);
            // 
            // consultaDeAtendentesToolStripMenuItem
            // 
            this.consultaDeAtendentesToolStripMenuItem.Name = "consultaDeAtendentesToolStripMenuItem";
            this.consultaDeAtendentesToolStripMenuItem.Size = new System.Drawing.Size(259, 24);
            this.consultaDeAtendentesToolStripMenuItem.Text = "Consulta de Atendentes";
            this.consultaDeAtendentesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeAtendentesToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendentesToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAtendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeAtendentesToolStripMenuItem;
    }
}