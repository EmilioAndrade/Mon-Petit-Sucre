namespace Mon_Petit_Sucre.Forms
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.groupBoxProduto = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.groupBoxProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.Controls.Add(this.richTextBoxDescricao);
            this.groupBoxProduto.Controls.Add(this.comboBoxStatus);
            this.groupBoxProduto.Controls.Add(this.textBoxPreco);
            this.groupBoxProduto.Controls.Add(this.textBoxNomeProduto);
            this.groupBoxProduto.Controls.Add(this.label4);
            this.groupBoxProduto.Controls.Add(this.lblStatus);
            this.groupBoxProduto.Controls.Add(this.lblPreco);
            this.groupBoxProduto.Controls.Add(this.lblNomeProduto);
            this.groupBoxProduto.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Size = new System.Drawing.Size(382, 332);
            this.groupBoxProduto.TabIndex = 0;
            this.groupBoxProduto.TabStop = false;
            this.groupBoxProduto.Text = "Informações do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 152);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(6, 100);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(54, 20);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(6, 51);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(115, 20);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome Produto:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(87, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 46);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(269, 362);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 46);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblSalvar
            // 
            this.lblSalvar.AutoSize = true;
            this.lblSalvar.Location = new System.Drawing.Point(99, 427);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(53, 20);
            this.lblSalvar.TabIndex = 3;
            this.lblSalvar.Text = "Salvar";
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Location = new System.Drawing.Point(284, 427);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(51, 20);
            this.lblVoltar.TabIndex = 4;
            this.lblVoltar.Text = "Voltar";
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(127, 48);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(236, 26);
            this.textBoxNomeProduto.TabIndex = 4;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(127, 97);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(142, 26);
            this.textBoxPreco.TabIndex = 5;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Em Produção",
            "Sem Produção",
            "Sob Encomenda"});
            this.comboBoxStatus.Location = new System.Drawing.Point(127, 149);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(142, 28);
            this.comboBoxStatus.TabIndex = 6;
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(127, 203);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(236, 105);
            this.richTextBoxDescricao.TabIndex = 7;
            this.richTextBoxDescricao.Text = "";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 456);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBoxProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.groupBoxProduto.ResumeLayout(false);
            this.groupBoxProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProduto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
    }
}