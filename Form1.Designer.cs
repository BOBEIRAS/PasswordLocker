namespace o_Mini_Cofre_de_Palavras_Passe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Userlbl = new System.Windows.Forms.Label();
            this.sitelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Copybtn = new System.Windows.Forms.Button();
            this.Sitetxt = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lstContas = new System.Windows.Forms.DataGridView();
            this.Sitecoluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usercoluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passcoluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstContas)).BeginInit();
            this.SuspendLayout();
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Userlbl.Location = new System.Drawing.Point(22, 57);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(61, 13);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "Username :";
            // 
            // sitelbl
            // 
            this.sitelbl.AutoSize = true;
            this.sitelbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sitelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sitelbl.Location = new System.Drawing.Point(37, 17);
            this.sitelbl.Name = "sitelbl";
            this.sitelbl.Size = new System.Drawing.Size(32, 13);
            this.sitelbl.TabIndex = 1;
            this.sitelbl.Text = "Site :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.Black;
            this.Savebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Savebtn.Location = new System.Drawing.Point(25, 170);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 3;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Copybtn
            // 
            this.Copybtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Copybtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Copybtn.Location = new System.Drawing.Point(204, 170);
            this.Copybtn.Name = "Copybtn";
            this.Copybtn.Size = new System.Drawing.Size(65, 23);
            this.Copybtn.TabIndex = 4;
            this.Copybtn.Text = "Copy";
            this.Copybtn.UseVisualStyleBackColor = false;
            this.Copybtn.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Sitetxt
            // 
            this.Sitetxt.Location = new System.Drawing.Point(89, 14);
            this.Sitetxt.Name = "Sitetxt";
            this.Sitetxt.Size = new System.Drawing.Size(180, 20);
            this.Sitetxt.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(89, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(89, 95);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(180, 20);
            this.txtPass.TabIndex = 8;
            // 
            // lstContas
            // 
            this.lstContas.AllowUserToAddRows = false;
            this.lstContas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sitecoluna,
            this.Usercoluna,
            this.Passcoluna});
            this.lstContas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstContas.Location = new System.Drawing.Point(-41, 219);
            this.lstContas.Name = "lstContas";
            this.lstContas.Size = new System.Drawing.Size(433, 194);
            this.lstContas.TabIndex = 9;
            this.lstContas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasswords_CellClick);
            this.lstContas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstContas_CellContentClick);
            // 
            // Sitecoluna
            // 
            this.Sitecoluna.HeaderText = "Site";
            this.Sitecoluna.Name = "Sitecoluna";
            // 
            // Usercoluna
            // 
            this.Usercoluna.HeaderText = "Username";
            this.Usercoluna.Name = "Usercoluna";
            // 
            // Passcoluna
            // 
            this.Passcoluna.HeaderText = "Password";
            this.Passcoluna.Name = "Passcoluna";
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(89, 136);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(180, 20);
            this.txtpesquisar.TabIndex = 11;
            this.txtpesquisar.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(298, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.lstContas);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Sitetxt);
            this.Controls.Add(this.Copybtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sitelbl);
            this.Controls.Add(this.Userlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PasswordVault";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Label sitelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Copybtn;
        private System.Windows.Forms.TextBox Sitetxt;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.DataGridView lstContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sitecoluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usercoluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passcoluna;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.Label label1;
    }
}

