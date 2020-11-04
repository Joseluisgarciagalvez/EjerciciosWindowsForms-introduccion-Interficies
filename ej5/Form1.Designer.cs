namespace ej5
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
            this.checkBoxGato = new System.Windows.Forms.CheckBox();
            this.checkBoxRaton = new System.Windows.Forms.CheckBox();
            this.checkBoxPerro = new System.Windows.Forms.CheckBox();
            this.buttonEscribir = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxGato
            // 
            this.checkBoxGato.AutoSize = true;
            this.checkBoxGato.Location = new System.Drawing.Point(94, 51);
            this.checkBoxGato.Name = "checkBoxGato";
            this.checkBoxGato.Size = new System.Drawing.Size(61, 21);
            this.checkBoxGato.TabIndex = 0;
            this.checkBoxGato.Text = "Gato";
            this.checkBoxGato.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaton
            // 
            this.checkBoxRaton.AutoSize = true;
            this.checkBoxRaton.Location = new System.Drawing.Point(94, 103);
            this.checkBoxRaton.Name = "checkBoxRaton";
            this.checkBoxRaton.Size = new System.Drawing.Size(68, 21);
            this.checkBoxRaton.TabIndex = 1;
            this.checkBoxRaton.Text = "Raton";
            this.checkBoxRaton.UseVisualStyleBackColor = true;
            // 
            // checkBoxPerro
            // 
            this.checkBoxPerro.AutoSize = true;
            this.checkBoxPerro.Location = new System.Drawing.Point(94, 157);
            this.checkBoxPerro.Name = "checkBoxPerro";
            this.checkBoxPerro.Size = new System.Drawing.Size(65, 21);
            this.checkBoxPerro.TabIndex = 2;
            this.checkBoxPerro.Text = "Perro";
            this.checkBoxPerro.UseVisualStyleBackColor = true;
            // 
            // buttonEscribir
            // 
            this.buttonEscribir.Location = new System.Drawing.Point(94, 219);
            this.buttonEscribir.Name = "buttonEscribir";
            this.buttonEscribir.Size = new System.Drawing.Size(75, 23);
            this.buttonEscribir.TabIndex = 3;
            this.buttonEscribir.Text = "Ok";
            this.buttonEscribir.UseVisualStyleBackColor = true;
            this.buttonEscribir.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(76, 265);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(424, 22);
            this.textBoxResultado.TabIndex = 4;
            this.textBoxResultado.Text = "Animales elegidos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonEscribir);
            this.Controls.Add(this.checkBoxPerro);
            this.Controls.Add(this.checkBoxRaton);
            this.Controls.Add(this.checkBoxGato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxGato;
        private System.Windows.Forms.CheckBox checkBoxRaton;
        private System.Windows.Forms.CheckBox checkBoxPerro;
        private System.Windows.Forms.Button buttonEscribir;
        private System.Windows.Forms.TextBox textBoxResultado;
    }
}

