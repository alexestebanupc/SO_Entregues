namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.caps = new System.Windows.Forms.RadioButton();
            this.palindromo = new System.Windows.Forms.RadioButton();
            this.alturaRbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.TextBox();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.cuantosServiciosBtn = new System.Windows.Forms.Button();
            this.cuantosServiciosLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(155, 38);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 22);
            this.nombre.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.caps);
            this.groupBox1.Controls.Add(this.palindromo);
            this.groupBox1.Controls.Add(this.alturaRbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.altura);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(16, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 347);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // caps
            // 
            this.caps.AutoSize = true;
            this.caps.Location = new System.Drawing.Point(155, 199);
            this.caps.Margin = new System.Windows.Forms.Padding(4);
            this.caps.Name = "caps";
            this.caps.Size = new System.Drawing.Size(162, 21);
            this.caps.TabIndex = 13;
            this.caps.TabStop = true;
            this.caps.Text = "Transforma en CAPS";
            this.caps.UseVisualStyleBackColor = true;
            // 
            // palindromo
            // 
            this.palindromo.AutoSize = true;
            this.palindromo.Location = new System.Drawing.Point(155, 170);
            this.palindromo.Margin = new System.Windows.Forms.Padding(4);
            this.palindromo.Name = "palindromo";
            this.palindromo.Size = new System.Drawing.Size(238, 21);
            this.palindromo.TabIndex = 12;
            this.palindromo.TabStop = true;
            this.palindromo.Text = "Dime si mi nombre es palíndromo";
            this.palindromo.UseVisualStyleBackColor = true;
            // 
            // alturaRbtn
            // 
            this.alturaRbtn.AutoSize = true;
            this.alturaRbtn.Location = new System.Drawing.Point(155, 141);
            this.alturaRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.alturaRbtn.Name = "alturaRbtn";
            this.alturaRbtn.Size = new System.Drawing.Size(128, 21);
            this.alturaRbtn.TabIndex = 11;
            this.alturaRbtn.TabStop = true;
            this.alturaRbtn.Text = "Dime si soy alto";
            this.alturaRbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.75F);
            this.label1.Location = new System.Drawing.Point(34, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Altura";
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(37, 122);
            this.altura.Margin = new System.Windows.Forms.Padding(4);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(69, 22);
            this.altura.TabIndex = 9;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(155, 112);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(220, 21);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(155, 84);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(207, 21);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(72, 37);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(156, 59);
            this.conectar.TabIndex = 12;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(82, 494);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(124, 49);
            this.desconectar.TabIndex = 13;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // cuantosServiciosBtn
            // 
            this.cuantosServiciosBtn.Location = new System.Drawing.Point(633, 180);
            this.cuantosServiciosBtn.Name = "cuantosServiciosBtn";
            this.cuantosServiciosBtn.Size = new System.Drawing.Size(155, 48);
            this.cuantosServiciosBtn.TabIndex = 14;
            this.cuantosServiciosBtn.Text = "¿Cuántos servicios?";
            this.cuantosServiciosBtn.UseVisualStyleBackColor = true;
            this.cuantosServiciosBtn.Click += new System.EventHandler(this.cuantosServiciosBtn_Click);
            // 
            // cuantosServiciosLbl
            // 
            this.cuantosServiciosLbl.AutoSize = true;
            this.cuantosServiciosLbl.Location = new System.Drawing.Point(630, 243);
            this.cuantosServiciosLbl.Name = "cuantosServiciosLbl";
            this.cuantosServiciosLbl.Size = new System.Drawing.Size(0, 17);
            this.cuantosServiciosLbl.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.cuantosServiciosLbl);
            this.Controls.Add(this.cuantosServiciosBtn);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.RadioButton alturaRbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.RadioButton palindromo;
        private System.Windows.Forms.RadioButton caps;
        private System.Windows.Forms.Button cuantosServiciosBtn;
        private System.Windows.Forms.Label cuantosServiciosLbl;
    }
}

