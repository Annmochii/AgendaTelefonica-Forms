namespace AgendaTelefonica
{
    partial class Form2
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinhaAgenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(104, 330);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(416, 34);
            this.btnAdicionar.TabIndex = 22;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(103, 274);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(417, 21);
            this.cbxTipo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(103, 219);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(417, 20);
            this.txbTelefone.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefone";
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(103, 166);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(417, 20);
            this.txbSobrenome.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sobrenome";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(103, 113);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(417, 20);
            this.txbNome.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // lblMinhaAgenda
            // 
            this.lblMinhaAgenda.AutoSize = true;
            this.lblMinhaAgenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinhaAgenda.Location = new System.Drawing.Point(234, 39);
            this.lblMinhaAgenda.Name = "lblMinhaAgenda";
            this.lblMinhaAgenda.Size = new System.Drawing.Size(154, 24);
            this.lblMinhaAgenda.TabIndex = 13;
            this.lblMinhaAgenda.Text = "Minha Agenda";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 408);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMinhaAgenda);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinhaAgenda;
    }
}