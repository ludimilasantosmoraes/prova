namespace Prova_2_Bimestre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Valor = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label1 = new Label();
            codigo = new TextBox();
            descricao = new TextBox();
            valorr = new TextBox();
            confins = new TextBox();
            icms = new TextBox();
            pis = new TextBox();
            unidade = new ComboBox();
            lucro = new TextBox();
            button1 = new Button();
            Resultado = new Label();
            SuspendLayout();
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Valor.Location = new Point(476, 250);
            Valor.Name = "Valor";
            Valor.Size = new Size(53, 21);
            Valor.TabIndex = 0;
            Valor.Text = "ICMS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(464, 112);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Unidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(127, 112);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 2;
            label3.Text = "Código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(306, 36);
            label4.Name = "label4";
            label4.Size = new Size(198, 25);
            label4.TabIndex = 3;
            label4.Text = "Cadastro de Produto";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(502, 183);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 4;
            label5.Text = "PIS:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(408, 399);
            label6.Name = "label6";
            label6.Size = new Size(143, 21);
            label6.TabIndex = 5;
            label6.Text = "VALOR DE VENDA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(474, 307);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 6;
            label7.Text = "Lucro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(110, 187);
            label8.Name = "label8";
            label8.Size = new Size(85, 21);
            label8.TabIndex = 7;
            label8.Text = "Descrição:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(143, 249);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 8;
            label9.Text = "Valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(104, 322);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 9;
            label1.Text = "CONFISNS:";
            // 
            // codigo
            // 
            codigo.Location = new Point(201, 114);
            codigo.Name = "codigo";
            codigo.Size = new Size(135, 23);
            codigo.TabIndex = 10;
            // 
            // descricao
            // 
            descricao.Location = new Point(201, 189);
            descricao.Name = "descricao";
            descricao.Size = new Size(135, 23);
            descricao.TabIndex = 11;
            descricao.TextChanged += textBox2_TextChanged;
            // 
            // valorr
            // 
            valorr.Location = new Point(201, 252);
            valorr.Name = "valorr";
            valorr.Size = new Size(135, 23);
            valorr.TabIndex = 12;
            // 
            // confins
            // 
            confins.Location = new Point(201, 324);
            confins.Name = "confins";
            confins.Size = new Size(135, 23);
            confins.TabIndex = 13;
            // 
            // icms
            // 
            icms.Location = new Point(545, 252);
            icms.Name = "icms";
            icms.Size = new Size(131, 23);
            icms.TabIndex = 14;
            icms.TextChanged += textBox5_TextChanged;
            // 
            // pis
            // 
            pis.Location = new Point(545, 185);
            pis.Name = "pis";
            pis.Size = new Size(131, 23);
            pis.TabIndex = 15;
            // 
            // unidade
            // 
            unidade.FormattingEnabled = true;
            unidade.Items.AddRange(new object[] { "UN", "LT", "KL" });
            unidade.Location = new Point(545, 110);
            unidade.Name = "unidade";
            unidade.Size = new Size(121, 23);
            unidade.TabIndex = 16;
            // 
            // lucro
            // 
            lucro.Location = new Point(545, 309);
            lucro.Name = "lucro";
            lucro.Size = new Size(131, 23);
            lucro.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(176, 388);
            button1.Name = "button1";
            button1.Size = new Size(107, 32);
            button1.TabIndex = 18;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Resultado.Location = new Point(575, 399);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(60, 21);
            Resultado.TabIndex = 19;
            Resultado.Text = "label10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado);
            Controls.Add(button1);
            Controls.Add(lucro);
            Controls.Add(unidade);
            Controls.Add(pis);
            Controls.Add(icms);
            Controls.Add(confins);
            Controls.Add(valorr);
            Controls.Add(descricao);
            Controls.Add(codigo);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Valor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Valor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label1;
        private TextBox codigo;
        private TextBox descricao;
        private TextBox valorr;
        private TextBox confins;
        private TextBox icms;
        private TextBox pis;
        private ComboBox unidade;
        private TextBox lucro;
        private Button button1;
        private Label Resultado;
    }
}