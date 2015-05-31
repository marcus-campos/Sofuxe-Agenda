namespace AgendaPessoal
{
    partial class Nova_Senha
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_senha_antiga = new System.Windows.Forms.TextBox();
            this.tb_senha_nova = new System.Windows.Forms.TextBox();
            this.tb_senha_nova_confirma = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha Antiga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nova Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Nova Senha:";
            // 
            // tb_senha_antiga
            // 
            this.tb_senha_antiga.Location = new System.Drawing.Point(15, 25);
            this.tb_senha_antiga.Name = "tb_senha_antiga";
            this.tb_senha_antiga.Size = new System.Drawing.Size(131, 20);
            this.tb_senha_antiga.TabIndex = 3;
            this.tb_senha_antiga.UseSystemPasswordChar = true;
            // 
            // tb_senha_nova
            // 
            this.tb_senha_nova.Location = new System.Drawing.Point(15, 64);
            this.tb_senha_nova.Name = "tb_senha_nova";
            this.tb_senha_nova.Size = new System.Drawing.Size(131, 20);
            this.tb_senha_nova.TabIndex = 4;
            this.tb_senha_nova.UseSystemPasswordChar = true;
            // 
            // tb_senha_nova_confirma
            // 
            this.tb_senha_nova_confirma.Location = new System.Drawing.Point(15, 103);
            this.tb_senha_nova_confirma.Name = "tb_senha_nova_confirma";
            this.tb_senha_nova_confirma.Size = new System.Drawing.Size(131, 20);
            this.tb_senha_nova_confirma.TabIndex = 5;
            this.tb_senha_nova_confirma.UseSystemPasswordChar = true;
            this.tb_senha_nova_confirma.TextChanged += new System.EventHandler(this.tb_senha_nova_confirma_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nova_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 205);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_senha_nova_confirma);
            this.Controls.Add(this.tb_senha_nova);
            this.Controls.Add(this.tb_senha_antiga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(178, 243);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(178, 243);
            this.Name = "Nova_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Senha";
            this.Load += new System.EventHandler(this.Nova_Senha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_senha_antiga;
        private System.Windows.Forms.TextBox tb_senha_nova;
        private System.Windows.Forms.TextBox tb_senha_nova_confirma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}