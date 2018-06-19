namespace FestaJunina2018
{
    partial class frmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.btn_aumentar = new System.Windows.Forms.Button();
            this.btn_diminuir = new System.Windows.Forms.Button();
            this.lbl_bd_preco = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.txb_qtd = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.cmb_Produtos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aumentar
            // 
            this.btn_aumentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aumentar.Image = ((System.Drawing.Image)(resources.GetObject("btn_aumentar.Image")));
            this.btn_aumentar.Location = new System.Drawing.Point(104, 67);
            this.btn_aumentar.Name = "btn_aumentar";
            this.btn_aumentar.Size = new System.Drawing.Size(94, 35);
            this.btn_aumentar.TabIndex = 17;
            this.btn_aumentar.UseVisualStyleBackColor = true;
            this.btn_aumentar.Click += new System.EventHandler(this.btn_aumentar_Click);
            // 
            // btn_diminuir
            // 
            this.btn_diminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diminuir.Image = ((System.Drawing.Image)(resources.GetObject("btn_diminuir.Image")));
            this.btn_diminuir.Location = new System.Drawing.Point(11, 67);
            this.btn_diminuir.Name = "btn_diminuir";
            this.btn_diminuir.Size = new System.Drawing.Size(94, 35);
            this.btn_diminuir.TabIndex = 16;
            this.btn_diminuir.UseVisualStyleBackColor = true;
            this.btn_diminuir.Click += new System.EventHandler(this.btn_diminuir_Click);
            // 
            // lbl_bd_preco
            // 
            this.lbl_bd_preco.AutoSize = true;
            this.lbl_bd_preco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bd_preco.Location = new System.Drawing.Point(407, 27);
            this.lbl_bd_preco.Name = "lbl_bd_preco";
            this.lbl_bd_preco.Size = new System.Drawing.Size(0, 17);
            this.lbl_bd_preco.TabIndex = 15;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco.Location = new System.Drawing.Point(353, 25);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(55, 18);
            this.lbl_preco.TabIndex = 14;
            this.lbl_preco.Text = "Preço:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(203, 27);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(101, 18);
            this.lblQtd.TabIndex = 13;
            this.lblQtd.Text = "Quantidade:";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(8, 27);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(68, 18);
            this.lblProd.TabIndex = 12;
            this.lblProd.Text = "Produto:";
            // 
            // txb_qtd
            // 
            this.txb_qtd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_qtd.Location = new System.Drawing.Point(304, 24);
            this.txb_qtd.Name = "txb_qtd";
            this.txb_qtd.Size = new System.Drawing.Size(42, 23);
            this.txb_qtd.TabIndex = 11;
            this.txb_qtd.TextChanged += new System.EventHandler(this.txb_qtd_TextChanged);
            this.txb_qtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_qtd_KeyPress);
            this.txb_qtd.Leave += new System.EventHandler(this.txb_qtd_Leave);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(206, 67);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(251, 35);
            this.btn_confirmar.TabIndex = 10;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // cmb_Produtos
            // 
            this.cmb_Produtos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Produtos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Produtos.FormattingEnabled = true;
            this.cmb_Produtos.Location = new System.Drawing.Point(75, 24);
            this.cmb_Produtos.Name = "cmb_Produtos";
            this.cmb_Produtos.Size = new System.Drawing.Size(123, 25);
            this.cmb_Produtos.TabIndex = 9;
            this.cmb_Produtos.SelectedIndexChanged += new System.EventHandler(this.cmb_Produtos_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 136);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(467, 112);
            this.Controls.Add(this.cmb_Produtos);
            this.Controls.Add(this.btn_aumentar);
            this.Controls.Add(this.btn_diminuir);
            this.Controls.Add(this.lbl_bd_preco);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.txb_qtd);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aumentar;
        private System.Windows.Forms.Button btn_diminuir;
        private System.Windows.Forms.Label lbl_bd_preco;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.TextBox txb_qtd;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.ComboBox cmb_Produtos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}