namespace AGIPAG
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPix = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnSaldo = new System.Windows.Forms.Panel();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.Location = new System.Drawing.Point(574, 427);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnPagar
            // 
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Location = new System.Drawing.Point(12, 56);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(195, 40);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar Conta";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.FlatAppearance.BorderSize = 0;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Location = new System.Drawing.Point(12, 109);
            this.btnTransferir.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(195, 40);
            this.btnTransferir.TabIndex = 4;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pagar Conta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPix
            // 
            this.btnPix.FlatAppearance.BorderSize = 0;
            this.btnPix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPix.Location = new System.Drawing.Point(12, 215);
            this.btnPix.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(195, 40);
            this.btnPix.TabIndex = 6;
            this.btnPix.Text = "Pix";
            this.btnPix.UseVisualStyleBackColor = true;
            // 
            // pnSaldo
            // 
            this.pnSaldo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnSaldo.Controls.Add(this.btnSair);
            this.pnSaldo.Controls.Add(this.btnConta);
            this.pnSaldo.Location = new System.Drawing.Point(2, 10);
            this.pnSaldo.Name = "pnSaldo";
            this.pnSaldo.Size = new System.Drawing.Size(786, 27);
            this.pnSaldo.TabIndex = 7;
            // 
            // btnConta
            // 
            this.btnConta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConta.Location = new System.Drawing.Point(8, 3);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(110, 23);
            this.btnConta.TabIndex = 0;
            this.btnConta.Text = "Conta";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(671, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnSaldo);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "AGIBANK";
            this.pnSaldo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPix;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnSaldo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConta;
    }
}

