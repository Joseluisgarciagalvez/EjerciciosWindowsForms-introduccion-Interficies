namespace ej7
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
            this.comboBoxColores = new System.Windows.Forms.ComboBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxColores
            // 
            this.comboBoxColores.FormattingEnabled = true;
            this.comboBoxColores.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Verde",
            "Naranja",
            "Morado"});
            this.comboBoxColores.Location = new System.Drawing.Point(139, 80);
            this.comboBoxColores.Name = "comboBoxColores";
            this.comboBoxColores.Size = new System.Drawing.Size(121, 24);
            this.comboBoxColores.TabIndex = 0;
            this.comboBoxColores.Text = "Colores";
            this.comboBoxColores.SelectedIndexChanged += new System.EventHandler(this.comboBoxColores_SelectedIndexChanged);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(139, 266);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(456, 22);
            this.textBoxResultado.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.comboBoxColores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxColores;
        private System.Windows.Forms.TextBox textBoxResultado;
    }
}

