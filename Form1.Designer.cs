namespace Digitacao {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);



        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDigitar = new System.Windows.Forms.TextBox();
            this.txtFinalizar = new System.Windows.Forms.Button();
            this.txtTamanhoSenha = new System.Windows.Forms.TextBox();
            this.btnGerarSenha1 = new System.Windows.Forms.Button();
            this.btnGerarSenha2 = new System.Windows.Forms.Button();
            this.btnGerarSenha3 = new System.Windows.Forms.Button();
            this.btnGerarSenha4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Location = new System.Drawing.Point(32, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(18, 15);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(695, 62);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDigitar);
            this.panel2.Location = new System.Drawing.Point(32, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 100);
            this.panel2.TabIndex = 1;
            // 
            // txtDigitar
            // 
            this.txtDigitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigitar.Location = new System.Drawing.Point(18, 18);
            this.txtDigitar.Name = "txtDigitar";
            this.txtDigitar.Size = new System.Drawing.Size(695, 62);
            this.txtDigitar.TabIndex = 1;
            this.txtDigitar.TextChanged += new System.EventHandler(this.TxtDigitar_TextChanged);
            this.txtDigitar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDigitar_KeyDown);
            this.txtDigitar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDigitar_KeyPress);
            // 
            // txtFinalizar
            // 
            this.txtFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalizar.Location = new System.Drawing.Point(50, 329);
            this.txtFinalizar.Name = "txtFinalizar";
            this.txtFinalizar.Size = new System.Drawing.Size(695, 67);
            this.txtFinalizar.TabIndex = 2;
            this.txtFinalizar.Text = "Finalizar";
            this.txtFinalizar.UseVisualStyleBackColor = true;
            this.txtFinalizar.Click += new System.EventHandler(this.TxtFinalizar_Click);
            this.txtFinalizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtFinalizar_MouseClick);
            // 
            // txtTamanhoSenha
            // 
            this.txtTamanhoSenha.Location = new System.Drawing.Point(32, 43);
            this.txtTamanhoSenha.Name = "txtTamanhoSenha";
            this.txtTamanhoSenha.Size = new System.Drawing.Size(38, 20);
            this.txtTamanhoSenha.TabIndex = 3;
            this.txtTamanhoSenha.Text = "6";
            this.txtTamanhoSenha.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtTamanhoSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamanhoSenha_KeyPress);
            // 
            // btnGerarSenha1
            // 
            this.btnGerarSenha1.Location = new System.Drawing.Point(85, 428);
            this.btnGerarSenha1.Name = "btnGerarSenha1";
            this.btnGerarSenha1.Size = new System.Drawing.Size(75, 23);
            this.btnGerarSenha1.TabIndex = 4;
            this.btnGerarSenha1.Text = "button1";
            this.btnGerarSenha1.UseVisualStyleBackColor = true;
            this.btnGerarSenha1.Click += new System.EventHandler(this.btnGerarSenha1_Click);
            // 
            // btnGerarSenha2
            // 
            this.btnGerarSenha2.Location = new System.Drawing.Point(197, 438);
            this.btnGerarSenha2.Name = "btnGerarSenha2";
            this.btnGerarSenha2.Size = new System.Drawing.Size(75, 23);
            this.btnGerarSenha2.TabIndex = 5;
            this.btnGerarSenha2.Text = "button2";
            this.btnGerarSenha2.UseVisualStyleBackColor = true;
            // 
            // btnGerarSenha3
            // 
            this.btnGerarSenha3.Location = new System.Drawing.Point(337, 451);
            this.btnGerarSenha3.Name = "btnGerarSenha3";
            this.btnGerarSenha3.Size = new System.Drawing.Size(75, 23);
            this.btnGerarSenha3.TabIndex = 6;
            this.btnGerarSenha3.Text = "button3";
            this.btnGerarSenha3.UseVisualStyleBackColor = true;
            // 
            // btnGerarSenha4
            // 
            this.btnGerarSenha4.Location = new System.Drawing.Point(456, 443);
            this.btnGerarSenha4.Name = "btnGerarSenha4";
            this.btnGerarSenha4.Size = new System.Drawing.Size(75, 23);
            this.btnGerarSenha4.TabIndex = 7;
            this.btnGerarSenha4.Text = "button4";
            this.btnGerarSenha4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(670, 438);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(35, 13);
            this.lblSegundos.TabIndex = 10;
            this.lblSegundos.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Insira o número de caracteres: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 505);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarSenha4);
            this.Controls.Add(this.btnGerarSenha3);
            this.Controls.Add(this.btnGerarSenha2);
            this.Controls.Add(this.btnGerarSenha1);
            this.Controls.Add(this.txtTamanhoSenha);
            this.Controls.Add(this.txtFinalizar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDigitar;
        private System.Windows.Forms.Button txtFinalizar;
        private System.Windows.Forms.TextBox txtTamanhoSenha;
        private System.Windows.Forms.Button btnGerarSenha1;
        private System.Windows.Forms.Button btnGerarSenha2;
        private System.Windows.Forms.Button btnGerarSenha3;
        private System.Windows.Forms.Button btnGerarSenha4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label label3;
    }
}

