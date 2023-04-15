namespace TintSysDesk
{
    partial class FrmCliente
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
            this.tbcCliente = new System.Windows.Forms.TabControl();
            this.tpgDados = new System.Windows.Forms.TabPage();
            this.mktCpf = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpgEnderecos = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tpgTelefones = new System.Windows.Forms.TabPage();
            this.tbcCliente.SuspendLayout();
            this.tpgDados.SuspendLayout();
            this.tpgEnderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCliente
            // 
            this.tbcCliente.Controls.Add(this.tpgDados);
            this.tbcCliente.Controls.Add(this.tpgEnderecos);
            this.tbcCliente.Controls.Add(this.tpgTelefones);
            this.tbcCliente.Location = new System.Drawing.Point(44, 49);
            this.tbcCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcCliente.Name = "tbcCliente";
            this.tbcCliente.SelectedIndex = 0;
            this.tbcCliente.Size = new System.Drawing.Size(780, 391);
            this.tbcCliente.TabIndex = 0;
            // 
            // tpgDados
            // 
            this.tpgDados.Controls.Add(this.mktCpf);
            this.tpgDados.Controls.Add(this.checkBox1);
            this.tpgDados.Controls.Add(this.txtEmail);
            this.tpgDados.Controls.Add(this.txtNome);
            this.tpgDados.Controls.Add(this.txtId);
            this.tpgDados.Controls.Add(this.button3);
            this.tpgDados.Controls.Add(this.btnConsultar);
            this.tpgDados.Controls.Add(this.btnInserir);
            this.tpgDados.Controls.Add(this.label4);
            this.tpgDados.Controls.Add(this.label3);
            this.tpgDados.Controls.Add(this.label2);
            this.tpgDados.Controls.Add(this.label1);
            this.tpgDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgDados.Location = new System.Drawing.Point(4, 25);
            this.tpgDados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgDados.Name = "tpgDados";
            this.tpgDados.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgDados.Size = new System.Drawing.Size(772, 362);
            this.tpgDados.TabIndex = 0;
            this.tpgDados.Text = "Dados Pessoais";
            this.tpgDados.UseVisualStyleBackColor = true;
            // 
            // mktCpf
            // 
            this.mktCpf.Location = new System.Drawing.Point(125, 174);
            this.mktCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mktCpf.Mask = "000.000.000-99";
            this.mktCpf.Name = "mktCpf";
            this.mktCpf.Size = new System.Drawing.Size(163, 26);
            this.mktCpf.TabIndex = 24;
            this.mktCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(387, 71);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 24);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 135);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(376, 26);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 102);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(376, 26);
            this.txtNome.TabIndex = 19;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 69);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(107, 26);
            this.txtId.TabIndex = 18;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(397, 282);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(225, 282);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(53, 282);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 28);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // tpgEnderecos
            // 
            this.tpgEnderecos.Controls.Add(this.dataGridView1);
            this.tpgEnderecos.Controls.Add(this.button1);
            this.tpgEnderecos.Location = new System.Drawing.Point(4, 25);
            this.tpgEnderecos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgEnderecos.Name = "tpgEnderecos";
            this.tpgEnderecos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgEnderecos.Size = new System.Drawing.Size(772, 362);
            this.tpgEnderecos.TabIndex = 1;
            this.tpgEnderecos.Text = "Endereços";
            this.tpgEnderecos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 250);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(753, 102);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpgTelefones
            // 
            this.tpgTelefones.Location = new System.Drawing.Point(4, 25);
            this.tpgTelefones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgTelefones.Name = "tpgTelefones";
            this.tpgTelefones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgTelefones.Size = new System.Drawing.Size(772, 362);
            this.tpgTelefones.TabIndex = 2;
            this.tpgTelefones.Text = "Telefones";
            this.tpgTelefones.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tbcCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tbcCliente.ResumeLayout(false);
            this.tpgDados.ResumeLayout(false);
            this.tpgDados.PerformLayout();
            this.tpgEnderecos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCliente;
        private System.Windows.Forms.TabPage tpgDados;
        private System.Windows.Forms.TabPage tpgEnderecos;
        private System.Windows.Forms.TabPage tpgTelefones;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mktCpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}