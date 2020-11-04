namespace ej6
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
            this.buttonEscribir = new System.Windows.Forms.Button();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEscribir
            // 
            this.buttonEscribir.Location = new System.Drawing.Point(47, 231);
            this.buttonEscribir.Name = "buttonEscribir";
            this.buttonEscribir.Size = new System.Drawing.Size(75, 23);
            this.buttonEscribir.TabIndex = 0;
            this.buttonEscribir.Text = "OK";
            this.buttonEscribir.UseVisualStyleBackColor = true;
            this.buttonEscribir.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(13, 12);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(55, 21);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(13, 39);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(57, 21);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.Location = new System.Drawing.Point(13, 66);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(65, 21);
            this.radioButtonWhite.TabIndex = 3;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.Text = "White";
            this.radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(171, 231);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(450, 22);
            this.textBoxResultado.TabIndex = 1;
            this.textBoxResultado.Text = "Choosen Colour:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonWhite);
            this.panel1.Controls.Add(this.radioButtonBlue);
            this.panel1.Controls.Add(this.radioButtonRed);
            this.panel1.Location = new System.Drawing.Point(34, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 167);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonEscribir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.Button buttonEscribir;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Panel panel1;
    }
}

