namespace Parcial2V2
{
    partial class AgregaEquipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fundacion = new System.Windows.Forms.DateTimePicker();
            this.btnequipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar Equipos";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(195, 94);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(200, 20);
            this.txtEquipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del Equipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciudad del Equipo";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(195, 148);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(200, 20);
            this.txtCiudad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Fundaciòn";
            // 
            // fundacion
            // 
            this.fundacion.Location = new System.Drawing.Point(195, 206);
            this.fundacion.Name = "fundacion";
            this.fundacion.Size = new System.Drawing.Size(200, 20);
            this.fundacion.TabIndex = 8;
            // 
            // btnequipo
            // 
            this.btnequipo.Location = new System.Drawing.Point(149, 272);
            this.btnequipo.Name = "btnequipo";
            this.btnequipo.Size = new System.Drawing.Size(169, 49);
            this.btnequipo.TabIndex = 9;
            this.btnequipo.Text = "Agregar Equipo";
            this.btnequipo.UseVisualStyleBackColor = true;
            // 
            // AgregaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 389);
            this.Controls.Add(this.btnequipo);
            this.Controls.Add(this.fundacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label1);
            this.Name = "AgregaEquipo";
            this.Text = "AgregaEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fundacion;
        private System.Windows.Forms.Button btnequipo;
    }
}