namespace ej3
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
            this.labelOperador1 = new System.Windows.Forms.Label();
            this.labelOperador2 = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonSumar = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxOperador2 = new System.Windows.Forms.TextBox();
            this.textBoxOperador1 = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOperador1
            // 
            this.labelOperador1.AutoSize = true;
            this.labelOperador1.Location = new System.Drawing.Point(68, 81);
            this.labelOperador1.Name = "labelOperador1";
            this.labelOperador1.Size = new System.Drawing.Size(77, 17);
            this.labelOperador1.TabIndex = 0;
            this.labelOperador1.Text = "Operador1";
            // 
            // labelOperador2
            // 
            this.labelOperador2.AutoSize = true;
            this.labelOperador2.Location = new System.Drawing.Point(68, 108);
            this.labelOperador2.Name = "labelOperador2";
            this.labelOperador2.Size = new System.Drawing.Size(77, 17);
            this.labelOperador2.TabIndex = 1;
            this.labelOperador2.Text = "Operador2";
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(151, 241);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(100, 22);
            this.textBoxResultado.TabIndex = 2;
            // 
            // buttonSumar
            // 
            this.buttonSumar.Location = new System.Drawing.Point(71, 175);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(75, 23);
            this.buttonSumar.TabIndex = 3;
            this.buttonSumar.Text = "+";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Click += new System.EventHandler(this.buttonSumar_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(183, 175);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxOperador2
            // 
            this.textBoxOperador2.Location = new System.Drawing.Point(151, 108);
            this.textBoxOperador2.Name = "textBoxOperador2";
            this.textBoxOperador2.Size = new System.Drawing.Size(100, 22);
            this.textBoxOperador2.TabIndex = 5;
            // 
            // textBoxOperador1
            // 
            this.textBoxOperador1.Location = new System.Drawing.Point(151, 76);
            this.textBoxOperador1.Name = "textBoxOperador1";
            this.textBoxOperador1.Size = new System.Drawing.Size(100, 22);
            this.textBoxOperador1.TabIndex = 6;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(74, 246);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(72, 17);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxOperador1);
            this.Controls.Add(this.textBoxOperador2);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSumar);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.labelOperador2);
            this.Controls.Add(this.labelOperador1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOperador1;
        private System.Windows.Forms.Label labelOperador2;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonSumar;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxOperador2;
        private System.Windows.Forms.TextBox textBoxOperador1;
        private System.Windows.Forms.Label labelResultado;
    }
}

