namespace ControldeCalificaciones
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btmCalcular = new System.Windows.Forms.Button();
            this.btmLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCalf1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCalf2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCalf3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCalf4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblCalfBaja = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE PROMEDIO DE CALIFICACIONES";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(12, 80);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(279, 20);
            this.txtAlumno.TabIndex = 1;
            this.txtAlumno.TextChanged += new System.EventHandler(this.txtAlumno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ALUMNO";
            // 
            // btmCalcular
            // 
            this.btmCalcular.Location = new System.Drawing.Point(12, 107);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(75, 23);
            this.btmCalcular.TabIndex = 3;
            this.btmCalcular.Text = "Calcular";
            this.btmCalcular.UseVisualStyleBackColor = true;
            this.btmCalcular.Click += new System.EventHandler(this.btmCalcular_Click);
            // 
            // btmLimpiar
            // 
            this.btmLimpiar.Location = new System.Drawing.Point(216, 107);
            this.btmLimpiar.Name = "btmLimpiar";
            this.btmLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btmLimpiar.TabIndex = 4;
            this.btmLimpiar.Text = "Limpiar";
            this.btmLimpiar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Promedio de calificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Calificacion mas baja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Condicion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCalf4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCalf3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCalf2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCalf1);
            this.groupBox1.Location = new System.Drawing.Point(313, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Calificaciones";
            // 
            // txtCalf1
            // 
            this.txtCalf1.Location = new System.Drawing.Point(10, 40);
            this.txtCalf1.Name = "txtCalf1";
            this.txtCalf1.Size = new System.Drawing.Size(67, 20);
            this.txtCalf1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Calificacion 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Calificacion 2";
            // 
            // txtCalf2
            // 
            this.txtCalf2.Location = new System.Drawing.Point(86, 40);
            this.txtCalf2.Name = "txtCalf2";
            this.txtCalf2.Size = new System.Drawing.Size(67, 20);
            this.txtCalf2.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Calificacion 3";
            // 
            // txtCalf3
            // 
            this.txtCalf3.Location = new System.Drawing.Point(162, 40);
            this.txtCalf3.Name = "txtCalf3";
            this.txtCalf3.Size = new System.Drawing.Size(67, 20);
            this.txtCalf3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Calificacion 4";
            // 
            // txtCalf4
            // 
            this.txtCalf4.Location = new System.Drawing.Point(238, 40);
            this.txtCalf4.Name = "txtCalf4";
            this.txtCalf4.Size = new System.Drawing.Size(67, 20);
            this.txtCalf4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(157, 152);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(51, 13);
            this.lblPromedio.TabIndex = 10;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(160, 210);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(54, 13);
            this.lblCondicion.TabIndex = 11;
            this.lblCondicion.Text = "Condicion";
            // 
            // lblCalfBaja
            // 
            this.lblCalfBaja.AutoSize = true;
            this.lblCalfBaja.Location = new System.Drawing.Point(160, 181);
            this.lblCalfBaja.Name = "lblCalfBaja";
            this.lblCalfBaja.Size = new System.Drawing.Size(85, 13);
            this.lblCalfBaja.TabIndex = 12;
            this.lblCalfBaja.Text = "Calificacion Baja";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 261);
            this.Controls.Add(this.lblCalfBaja);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btmLimpiar);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Control de Calificaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmCalcular;
        private System.Windows.Forms.Button btmLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalf1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCalf4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCalf3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCalf2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblCalfBaja;
        private System.Windows.Forms.ErrorProvider epError;
    }
}

