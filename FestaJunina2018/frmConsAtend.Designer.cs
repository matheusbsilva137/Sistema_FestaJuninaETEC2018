namespace FestaJunina2018
{
    partial class frmConsAtend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsAtend));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPrim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnUlt = new System.Windows.Forms.Button();
            this.dgvAtend = new System.Windows.Forms.DataGridView();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesq = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrim
            // 
            this.btnPrim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrim.Image = ((System.Drawing.Image)(resources.GetObject("btnPrim.Image")));
            this.btnPrim.Location = new System.Drawing.Point(17, 194);
            this.btnPrim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(107, 33);
            this.btnPrim.TabIndex = 70;
            this.btnPrim.UseVisualStyleBackColor = false;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAtualizar);
            this.groupBox2.Controls.Add(this.btnExc);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(331, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(122, 86);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(6, 51);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(111, 28);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExc
            // 
            this.btnExc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExc.Image = ((System.Drawing.Image)(resources.GetObject("btnExc.Image")));
            this.btnExc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExc.Location = new System.Drawing.Point(6, 24);
            this.btnExc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(111, 28);
            this.btnExc.TabIndex = 13;
            this.btnExc.Text = "Excluir";
            this.btnExc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExc.UseVisualStyleBackColor = false;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnt.Image = ((System.Drawing.Image)(resources.GetObject("btnAnt.Image")));
            this.btnAnt.Location = new System.Drawing.Point(123, 194);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(107, 33);
            this.btnAnt.TabIndex = 71;
            this.btnAnt.UseVisualStyleBackColor = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnProx
            // 
            this.btnProx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProx.Image = ((System.Drawing.Image)(resources.GetObject("btnProx.Image")));
            this.btnProx.Location = new System.Drawing.Point(229, 194);
            this.btnProx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(107, 33);
            this.btnProx.TabIndex = 72;
            this.btnProx.UseVisualStyleBackColor = false;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnUlt
            // 
            this.btnUlt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUlt.Image = ((System.Drawing.Image)(resources.GetObject("btnUlt.Image")));
            this.btnUlt.Location = new System.Drawing.Point(335, 194);
            this.btnUlt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUlt.Name = "btnUlt";
            this.btnUlt.Size = new System.Drawing.Size(107, 33);
            this.btnUlt.TabIndex = 73;
            this.btnUlt.UseVisualStyleBackColor = false;
            this.btnUlt.Click += new System.EventHandler(this.btnUlt_Click);
            // 
            // dgvAtend
            // 
            this.dgvAtend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAtend.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAtend.Location = new System.Drawing.Point(8, 234);
            this.dgvAtend.Name = "dgvAtend";
            this.dgvAtend.Size = new System.Drawing.Size(445, 150);
            this.dgvAtend.TabIndex = 82;
            this.dgvAtend.Click += new System.EventHandler(this.dgvAtend_Click);
            this.dgvAtend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvAtend_KeyUp);
            // 
            // txbLogin
            // 
            this.txbLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin.Location = new System.Drawing.Point(75, 151);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(250, 22);
            this.txbLogin.TabIndex = 79;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(75, 117);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(250, 22);
            this.txbNome.TabIndex = 78;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(14, 151);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(52, 18);
            this.lblLogin.TabIndex = 77;
            this.lblLogin.Text = "Login:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(13, 121);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 18);
            this.lblNome.TabIndex = 76;
            this.lblNome.Text = "Nome:";
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pctLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.BackgroundImage")));
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.ErrorImage")));
            this.pctLogo.Location = new System.Drawing.Point(291, 6);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(66, 38);
            this.pctLogo.TabIndex = 74;
            this.pctLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 136);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(322, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 102);
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.Location = new System.Drawing.Point(158, 396);
            this.txbPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(294, 21);
            this.txbPesquisa.TabIndex = 86;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // lblPesq
            // 
            this.lblPesq.AutoSize = true;
            this.lblPesq.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesq.Location = new System.Drawing.Point(5, 396);
            this.lblPesq.Name = "lblPesq";
            this.lblPesq.Size = new System.Drawing.Size(153, 18);
            this.lblPesq.TabIndex = 85;
            this.lblPesq.Text = "Pesquisa por Nome:";
            // 
            // frmConsAtend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 426);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.lblPesq);
            this.Controls.Add(this.btnPrim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.btnUlt);
            this.Controls.Add(this.dgvAtend);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsAtend";
            this.Text = "Consulta de Atendentes";
            this.Load += new System.EventHandler(this.frmConsAtend_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnUlt;
        private System.Windows.Forms.DataGridView dgvAtend;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Label lblPesq;
    }
}