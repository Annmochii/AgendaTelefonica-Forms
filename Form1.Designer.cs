namespace AgendaTelefonica
{
    partial class FormHome
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
            this.lblMinhaAgenda = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinhaAgenda
            // 
            this.lblMinhaAgenda.AutoSize = true;
            this.lblMinhaAgenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinhaAgenda.Location = new System.Drawing.Point(219, 31);
            this.lblMinhaAgenda.Name = "lblMinhaAgenda";
            this.lblMinhaAgenda.Size = new System.Drawing.Size(154, 24);
            this.lblMinhaAgenda.TabIndex = 0;
            this.lblMinhaAgenda.Text = "Minha Agenda";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(58, 322);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(156, 34);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvContatos
            // 
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(58, 78);
            this.dgvContatos.MultiSelect = false;
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.ReadOnly = true;
            this.dgvContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatos.Size = new System.Drawing.Size(484, 238);
            this.dgvContatos.TabIndex = 10;
            this.dgvContatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContatos_CellMouseClick);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(220, 322);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(160, 34);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(386, 322);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 34);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 417);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.dgvContatos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblMinhaAgenda);
            this.Name = "FormHome";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinhaAgenda;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.DataGridView dgvContatos;
    }
}

