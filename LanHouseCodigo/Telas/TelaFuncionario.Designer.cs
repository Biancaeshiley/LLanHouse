namespace LanHouseCodigo.Telas
{
    partial class TelaFuncionario
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_emailF = new System.Windows.Forms.TextBox();
            this.tx_NumBF = new System.Windows.Forms.TextBox();
            this.tx_nomeF = new System.Windows.Forms.TextBox();
            this.tx_endF = new System.Windows.Forms.TextBox();
            this.tx_cpfF = new System.Windows.Forms.MaskedTextBox();
            this.tx_dtNasF = new System.Windows.Forms.MaskedTextBox();
            this.tx_teleF = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DgvF = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(706, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1036, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Voltar para tela inicial) ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero da conta Bancaria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(790, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(764, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(685, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Nascimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(764, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(790, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "CPF";
            // 
            // tx_emailF
            // 
            this.tx_emailF.Location = new System.Drawing.Point(864, 134);
            this.tx_emailF.Name = "tx_emailF";
            this.tx_emailF.Size = new System.Drawing.Size(368, 22);
            this.tx_emailF.TabIndex = 8;
            // 
            // tx_NumBF
            // 
            this.tx_NumBF.Location = new System.Drawing.Point(864, 348);
            this.tx_NumBF.Name = "tx_NumBF";
            this.tx_NumBF.Size = new System.Drawing.Size(132, 22);
            this.tx_NumBF.TabIndex = 9;
            this.tx_NumBF.TextChanged += new System.EventHandler(this.tx_NumBF_TextChanged);
            // 
            // tx_nomeF
            // 
            this.tx_nomeF.Location = new System.Drawing.Point(864, 94);
            this.tx_nomeF.Name = "tx_nomeF";
            this.tx_nomeF.Size = new System.Drawing.Size(368, 22);
            this.tx_nomeF.TabIndex = 10;
            // 
            // tx_endF
            // 
            this.tx_endF.Location = new System.Drawing.Point(866, 176);
            this.tx_endF.Name = "tx_endF";
            this.tx_endF.Size = new System.Drawing.Size(366, 22);
            this.tx_endF.TabIndex = 11;
            // 
            // tx_cpfF
            // 
            this.tx_cpfF.Location = new System.Drawing.Point(864, 260);
            this.tx_cpfF.Mask = "000,000,000-00";
            this.tx_cpfF.Name = "tx_cpfF";
            this.tx_cpfF.Size = new System.Drawing.Size(121, 22);
            this.tx_cpfF.TabIndex = 12;
            this.tx_cpfF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_cpfF_MaskInputRejected);
            // 
            // tx_dtNasF
            // 
            this.tx_dtNasF.Location = new System.Drawing.Point(866, 304);
            this.tx_dtNasF.Mask = "00/00/0000";
            this.tx_dtNasF.Name = "tx_dtNasF";
            this.tx_dtNasF.Size = new System.Drawing.Size(123, 22);
            this.tx_dtNasF.TabIndex = 13;
            this.tx_dtNasF.ValidatingType = typeof(System.DateTime);
            // 
            // tx_teleF
            // 
            this.tx_teleF.Location = new System.Drawing.Point(864, 220);
            this.tx_teleF.Mask = "000-0000";
            this.tx_teleF.Name = "tx_teleF";
            this.tx_teleF.Size = new System.Drawing.Size(121, 22);
            this.tx_teleF.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1062, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1062, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 59);
            this.button2.TabIndex = 16;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DgvF
            // 
            this.DgvF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvF.Location = new System.Drawing.Point(16, 32);
            this.DgvF.Name = "DgvF";
            this.DgvF.RowHeadersWidth = 51;
            this.DgvF.RowTemplate.Height = 24;
            this.DgvF.Size = new System.Drawing.Size(575, 386);
            this.DgvF.TabIndex = 17;
            this.DgvF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvF_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Endereço";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefone";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CPF";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Data Nasc.";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Num. Conta";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(788, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(364, 33);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cadastrar Funcionário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LanHouseCodigo.Properties.Resources.imagemUsuarioFun_resized;
            this.pictureBox1.Location = new System.Drawing.Point(702, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 61);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1260, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DgvF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_teleF);
            this.Controls.Add(this.tx_dtNasF);
            this.Controls.Add(this.tx_cpfF);
            this.Controls.Add(this.tx_endF);
            this.Controls.Add(this.tx_nomeF);
            this.Controls.Add(this.tx_NumBF);
            this.Controls.Add(this.tx_emailF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaFuncionario";
            this.Text = "TelaFuncionario";
            this.Load += new System.EventHandler(this.TelaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_emailF;
        private System.Windows.Forms.TextBox tx_NumBF;
        private System.Windows.Forms.TextBox tx_nomeF;
        private System.Windows.Forms.TextBox tx_endF;
        private System.Windows.Forms.MaskedTextBox tx_cpfF;
        private System.Windows.Forms.MaskedTextBox tx_dtNasF;
        private System.Windows.Forms.MaskedTextBox tx_teleF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DgvF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}