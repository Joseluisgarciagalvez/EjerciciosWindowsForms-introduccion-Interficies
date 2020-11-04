namespace ej4_a
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
            this.buttonSumar = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTipoOperacion = new System.Windows.Forms.TextBox();
            this.textBoxOperador2 = new System.Windows.Forms.TextBox();
            this.textBoxOperador1 = new System.Windows.Forms.TextBox();
            this.buttonRestar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSumar
            // 
            this.buttonSumar.Location = new System.Drawing.Point(363, 123);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(75, 23);
            this.buttonSumar.TabIndex = 0;
            this.buttonSumar.Text = "Sum";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Click += new System.EventHandler(this.buttonSumar_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(544, 142);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(100, 22);
            this.textBoxResultado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la opcion a utilizar";
            // 
            // textBoxTipoOperacion
            // 
            this.textBoxTipoOperacion.Location = new System.Drawing.Point(378, 255);
            this.textBoxTipoOperacion.Name = "textBoxTipoOperacion";
            this.textBoxTipoOperacion.Size = new System.Drawing.Size(37, 22);
            this.textBoxTipoOperacion.TabIndex = 3;
            this.textBoxTipoOperacion.TextChanged += new System.EventHandler(this.textBoxTipoOperacion_TextChanged);
            // 
            // textBoxOperador2
            // 
            this.textBoxOperador2.Location = new System.Drawing.Point(179, 169);
            this.textBoxOperador2.Name = "textBoxOperador2";
            this.textBoxOperador2.Size = new System.Drawing.Size(100, 22);
            this.textBoxOperador2.TabIndex = 4;
            // 
            // textBoxOperador1
            // 
            this.textBoxOperador1.Location = new System.Drawing.Point(179, 102);
            this.textBoxOperador1.Name = "textBoxOperador1";
            this.textBoxOperador1.Size = new System.Drawing.Size(100, 22);
            this.textBoxOperador1.TabIndex = 5;
            // 
            // buttonRestar
            // 
            this.buttonRestar.Location = new System.Drawing.Point(363, 182);
            this.buttonRestar.Name = "buttonRestar";
            this.buttonRestar.Size = new System.Drawing.Size(75, 23);
            this.buttonRestar.TabIndex = 6;
            this.buttonRestar.Text = "Substract";
            this.buttonRestar.UseVisualStyleBackColor = true;
            this.buttonRestar.Click += new System.EventHandler(this.buttonRestar_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(214, 255);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 7;
            this.buttonCalcular.Text = "Calculate";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(544, 255);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.buttonRestar);
            this.Controls.Add(this.textBoxOperador1);
            this.Controls.Add(this.textBoxOperador2);
            this.Controls.Add(this.textBoxTipoOperacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonSumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSumar;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTipoOperacion;
        private System.Windows.Forms.TextBox textBoxOperador2;
        private System.Windows.Forms.TextBox textBoxOperador1;
        private System.Windows.Forms.Button buttonRestar;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonReset;
    }
}

