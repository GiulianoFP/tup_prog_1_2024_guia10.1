namespace ejercicio1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTPublico = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbMoto = new System.Windows.Forms.RadioButton();
            this.rbBici = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resultado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar número";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(532, 133);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(96, 38);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar Encuesta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDistancia);
            this.groupBox3.Location = new System.Drawing.Point(8, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 82);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distancia aproximada según el vehiculo seleccionado";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(183, 38);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTPublico);
            this.groupBox2.Controls.Add(this.rbAuto);
            this.groupBox2.Controls.Add(this.rbMoto);
            this.groupBox2.Controls.Add(this.rbBici);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de transporte de usi más fecuente";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbTPublico
            // 
            this.rbTPublico.AutoSize = true;
            this.rbTPublico.Location = new System.Drawing.Point(34, 102);
            this.rbTPublico.Name = "rbTPublico";
            this.rbTPublico.Size = new System.Drawing.Size(113, 17);
            this.rbTPublico.TabIndex = 3;
            this.rbTPublico.TabStop = true;
            this.rbTPublico.Text = "Transporte público";
            this.rbTPublico.UseVisualStyleBackColor = true;
            this.rbTPublico.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(34, 79);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(71, 17);
            this.rbAuto.TabIndex = 2;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Automovil";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // rbMoto
            // 
            this.rbMoto.AutoSize = true;
            this.rbMoto.Location = new System.Drawing.Point(34, 56);
            this.rbMoto.Name = "rbMoto";
            this.rbMoto.Size = new System.Drawing.Size(80, 17);
            this.rbMoto.TabIndex = 1;
            this.rbMoto.TabStop = true;
            this.rbMoto.Text = "Motocicleta";
            this.rbMoto.UseVisualStyleBackColor = true;
            // 
            // rbBici
            // 
            this.rbBici.AutoSize = true;
            this.rbBici.Location = new System.Drawing.Point(34, 33);
            this.rbBici.Name = "rbBici";
            this.rbBici.Size = new System.Drawing.Size(65, 17);
            this.rbBici.TabIndex = 0;
            this.rbBici.TabStop = true;
            this.rbBici.Text = "Bicicleta";
            this.rbBici.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(652, 69);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resultado);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(666, 133);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(238, 100);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(186, 27);
            this.resultado.TabIndex = 2;
            this.resultado.Text = "Ver Resultados";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTPublico;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbMoto;
        private System.Windows.Forms.RadioButton rbBici;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button resultado;
    }
}

