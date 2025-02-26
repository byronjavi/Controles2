namespace Controles
{
    partial class Controles
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.sumar = new System.Windows.Forms.CheckBox();
            this.restar = new System.Windows.Forms.CheckBox();
            this.multiplicar = new System.Windows.Forms.CheckBox();
            this.dividir = new System.Windows.Forms.CheckBox();
            this.resto = new System.Windows.Forms.CheckBox();
            this.btn_nueva_pantalla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(236, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calcularSuma);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero2";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(256, 70);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(192, 30);
            this.txtNumero1.TabIndex = 3;
            this.txtNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNumero);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(256, 125);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(192, 30);
            this.txtNumero2.TabIndex = 4;
            this.txtNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNumero);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(241, 344);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(122, 29);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // sumar
            // 
            this.sumar.AutoSize = true;
            this.sumar.Location = new System.Drawing.Point(166, 193);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(36, 20);
            this.sumar.TabIndex = 6;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            // 
            // restar
            // 
            this.restar.AutoSize = true;
            this.restar.Location = new System.Drawing.Point(223, 193);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(63, 20);
            this.restar.TabIndex = 7;
            this.restar.Text = "restar";
            this.restar.UseVisualStyleBackColor = true;
            // 
            // multiplicar
            // 
            this.multiplicar.AutoSize = true;
            this.multiplicar.Location = new System.Drawing.Point(300, 193);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(35, 20);
            this.multiplicar.TabIndex = 8;
            this.multiplicar.Text = "x";
            this.multiplicar.UseVisualStyleBackColor = true;
            // 
            // dividir
            // 
            this.dividir.AutoSize = true;
            this.dividir.Location = new System.Drawing.Point(363, 193);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(33, 20);
            this.dividir.TabIndex = 9;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            // 
            // resto
            // 
            this.resto.AutoSize = true;
            this.resto.Location = new System.Drawing.Point(419, 193);
            this.resto.Name = "resto";
            this.resto.Size = new System.Drawing.Size(41, 20);
            this.resto.TabIndex = 10;
            this.resto.Text = "%";
            this.resto.UseVisualStyleBackColor = true;
            // 
            // btn_nueva_pantalla
            // 
            this.btn_nueva_pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_pantalla.Location = new System.Drawing.Point(363, 261);
            this.btn_nueva_pantalla.Name = "btn_nueva_pantalla";
            this.btn_nueva_pantalla.Size = new System.Drawing.Size(181, 40);
            this.btn_nueva_pantalla.TabIndex = 11;
            this.btn_nueva_pantalla.Text = "Ir Otra pantalla";
            this.btn_nueva_pantalla.UseVisualStyleBackColor = true;
            this.btn_nueva_pantalla.Click += new System.EventHandler(this.nuevaPantalla);
            // 
            // Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.btn_nueva_pantalla);
            this.Controls.Add(this.resto);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Controles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.CheckBox sumar;
        private System.Windows.Forms.CheckBox restar;
        private System.Windows.Forms.CheckBox multiplicar;
        private System.Windows.Forms.CheckBox dividir;
        private System.Windows.Forms.CheckBox resto;
        private System.Windows.Forms.Button btn_nueva_pantalla;
    }
}

