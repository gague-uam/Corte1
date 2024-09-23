namespace Corte1
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
            this.lblNames = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbNames = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtbFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEvalueAge = new System.Windows.Forms.Button();
            this.lblmostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(28, 20);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(112, 13);
            this.lblNames.TabIndex = 0;
            this.lblNames.Text = "Agregue sus nombres:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(29, 52);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(113, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Agregue sus apellidos:";
            // 
            // tbNames
            // 
            this.tbNames.Location = new System.Drawing.Point(146, 20);
            this.tbNames.Name = "tbNames";
            this.tbNames.Size = new System.Drawing.Size(181, 20);
            this.tbNames.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(146, 52);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(181, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(31, 88);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // dtbFechaNac
            // 
            this.dtbFechaNac.Location = new System.Drawing.Point(146, 88);
            this.dtbFechaNac.Name = "dtbFechaNac";
            this.dtbFechaNac.Size = new System.Drawing.Size(193, 20);
            this.dtbFechaNac.TabIndex = 5;
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(143, 130);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(196, 21);
            this.cbCiudad.TabIndex = 6;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(94, 133);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 7;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 38);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Agregar Datos";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEvalueAge
            // 
            this.btnEvalueAge.Location = new System.Drawing.Point(229, 184);
            this.btnEvalueAge.Name = "btnEvalueAge";
            this.btnEvalueAge.Size = new System.Drawing.Size(124, 37);
            this.btnEvalueAge.TabIndex = 9;
            this.btnEvalueAge.Text = "Evaluar edad";
            this.btnEvalueAge.UseVisualStyleBackColor = true;
            // 
            // lblmostrar
            // 
            this.lblmostrar.AutoSize = true;
            this.lblmostrar.Location = new System.Drawing.Point(219, 261);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(52, 13);
            this.lblmostrar.TabIndex = 10;
            this.lblmostrar.Text = "Usted es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 375);
            this.Controls.Add(this.lblmostrar);
            this.Controls.Add(this.btnEvalueAge);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.dtbFechaNac);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbNames);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblNames);
            this.Name = "Form1";
            this.Text = "Registro de Datos - GG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbNames;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtbFechaNac;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEvalueAge;
        private System.Windows.Forms.Label lblmostrar;
    }
}

