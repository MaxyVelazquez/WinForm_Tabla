namespace WinFormsApp_Tabla
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
            panelPrincipal = new Panel();
            richTextBoxTabla = new RichTextBox();
            buttonVer = new Button();
            textBoxNumero = new TextBox();
            labelPregunta = new Label();
            labelTitulo = new Label();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(128, 128, 255);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(richTextBoxTabla);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNumero);
            panelPrincipal.Controls.Add(labelPregunta);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(3, 6);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(632, 442);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxTabla
            // 
            richTextBoxTabla.Location = new Point(264, 65);
            richTextBoxTabla.Name = "richTextBoxTabla";
            richTextBoxTabla.Size = new Size(149, 213);
            richTextBoxTabla.TabIndex = 4;
            richTextBoxTabla.Text = "";
            richTextBoxTabla.TextChanged += richTextBox1_TextChanged;
            // 
            // buttonVer
            // 
            buttonVer.Location = new Point(76, 195);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(75, 23);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver tabla";
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(67, 133);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(100, 23);
            textBoxNumero.TabIndex = 2;
            textBoxNumero.TextChanged += textBoxNumero_TextChanged;
            // 
            // labelPregunta
            // 
            labelPregunta.AutoSize = true;
            labelPregunta.BackColor = Color.FromArgb(224, 224, 224);
            labelPregunta.Location = new Point(64, 83);
            labelPregunta.Name = "labelPregunta";
            labelPregunta.Size = new Size(104, 15);
            labelPregunta.TabIndex = 1;
            labelPregunta.Text = "Qué tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.FromArgb(224, 224, 224);
            labelTitulo.Location = new Point(60, 37);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(110, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de multiplicar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(262, 19);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 5;
            label1.Text = "Maxy Emiliano Velazquez Cuellar 301026";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelTitulo;
        private Button buttonVer;
        private TextBox textBoxNumero;
        private Label labelPregunta;
        private RichTextBox richTextBoxTabla;
        private Label label1;
    }
}
