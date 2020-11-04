namespace ej4_b
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
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxTipoOperacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxElegirOperacion = new System.Windows.Forms.ListBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxOperador2 = new System.Windows.Forms.TextBox();
            this.textBoxOperador1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(156, 301);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBoxTipoOperacion
            // 
            this.textBoxTipoOperacion.Location = new System.Drawing.Point(357, 262);
            this.textBoxTipoOperacion.Name = "textBoxTipoOperacion";
            this.textBoxTipoOperacion.Size = new System.Drawing.Size(68, 22);
            this.textBoxTipoOperacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // listBoxElegirOperacion
            // 
            this.listBoxElegirOperacion.FormattingEnabled = true;
            this.listBoxElegirOperacion.ItemHeight = 16;
            this.listBoxElegirOperacion.Items.AddRange(new object[] {
            "+",
            "-"});
            this.listBoxElegirOperacion.Location = new System.Drawing.Point(357, 118);
            this.listBoxElegirOperacion.Name = "listBoxElegirOperacion";
            this.listBoxElegirOperacion.Size = new System.Drawing.Size(68, 20);
            this.listBoxElegirOperacion.TabIndex = 3;
            this.listBoxElegirOperacion.SelectedIndexChanged += new System.EventHandler(this.listBoxElegirOperacion_SelectedIndexChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(534, 301);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxOperador2
            // 
            this.textBoxOperador2.Location = new System.Drawing.Point(146, 185);
            this.textBoxOperador2.Name = "textBoxOperador2";
            this.textBoxOperador2.Size = new System.Drawing.Size(100, 22);
            this.textBoxOperador2.TabIndex = 5;
            // 
            // textBoxOperador1
            // 
            this.textBoxOperador1.Location = new System.Drawing.Point(146, 118);
            this.textBoxOperador1.Name = "textBoxOperador1";
            this.textBoxOperador1.Size = new System.Drawing.Size(100, 22);
            this.textBoxOperador1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(534, 148);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(100, 22);
            this.textBoxResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOperador1);
            this.Controls.Add(this.textBoxOperador2);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.listBoxElegirOperacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTipoOperacion);
            this.Controls.Add(this.buttonCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxTipoOperacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxElegirOperacion;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxOperador2;
        private System.Windows.Forms.TextBox textBoxOperador1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResultado;
    }
}

