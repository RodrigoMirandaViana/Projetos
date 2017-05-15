namespace Calculadora
{
    partial class Form1
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
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.adicao = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.potenciacao = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdisplay
            // 
            this.txtdisplay.Location = new System.Drawing.Point(12, 12);
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.ReadOnly = true;
            this.txtdisplay.Size = new System.Drawing.Size(189, 20);
            this.txtdisplay.TabIndex = 0;
            this.txtdisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 154);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 38);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(122, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(67, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(122, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 38);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 38);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(67, 67);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(49, 38);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(122, 67);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 38);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(177, 67);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(32, 23);
            this.dividir.TabIndex = 10;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.button10_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(177, 38);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(32, 23);
            this.multiplicar.TabIndex = 11;
            this.multiplicar.Text = "x";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // subtracao
            // 
            this.subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(177, 96);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(32, 23);
            this.subtracao.TabIndex = 12;
            this.subtracao.Text = "-";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // adicao
            // 
            this.adicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicao.Location = new System.Drawing.Point(139, 38);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(32, 23);
            this.adicao.TabIndex = 13;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = true;
            this.adicao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // igual
            // 
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(122, 198);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(46, 38);
            this.igual.TabIndex = 14;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(67, 198);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(49, 38);
            this.button0.TabIndex = 15;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // raiz
            // 
            this.raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.Location = new System.Drawing.Point(25, 38);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(32, 23);
            this.raiz.TabIndex = 16;
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // potenciacao
            // 
            this.potenciacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potenciacao.Location = new System.Drawing.Point(63, 38);
            this.potenciacao.Name = "potenciacao";
            this.potenciacao.Size = new System.Drawing.Size(32, 23);
            this.potenciacao.TabIndex = 17;
            this.potenciacao.Text = "x²";
            this.potenciacao.UseVisualStyleBackColor = true;
            this.potenciacao.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(101, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "C";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 248);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.potenciacao);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtdisplay);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button potenciacao;
        private System.Windows.Forms.Button button8;
    }
}

