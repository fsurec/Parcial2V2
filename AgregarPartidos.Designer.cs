namespace Parcial2V2
{
    partial class AgregarPartidos
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
            this.listLocal = new System.Windows.Forms.ComboBox();
            this.listVisit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.golvisit = new System.Windows.Forms.TextBox();
            this.gollocal = new System.Windows.Forms.TextBox();
            this.btnPartido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultado de Partidos";
            // 
            // listLocal
            // 
            this.listLocal.FormattingEnabled = true;
            this.listLocal.Location = new System.Drawing.Point(41, 117);
            this.listLocal.Name = "listLocal";
            this.listLocal.Size = new System.Drawing.Size(121, 21);
            this.listLocal.TabIndex = 1;
            // 
            // listVisit
            // 
            this.listVisit.FormattingEnabled = true;
            this.listVisit.Location = new System.Drawing.Point(268, 117);
            this.listVisit.Name = "listVisit";
            this.listVisit.Size = new System.Drawing.Size(121, 21);
            this.listVisit.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Equipo Local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Equipo Visitante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Goles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Goles";
            // 
            // golvisit
            // 
            this.golvisit.Location = new System.Drawing.Point(308, 193);
            this.golvisit.Name = "golvisit";
            this.golvisit.Size = new System.Drawing.Size(81, 20);
            this.golvisit.TabIndex = 7;
            // 
            // gollocal
            // 
            this.gollocal.Location = new System.Drawing.Point(78, 193);
            this.gollocal.Name = "gollocal";
            this.gollocal.Size = new System.Drawing.Size(84, 20);
            this.gollocal.TabIndex = 8;
            // 
            // btnPartido
            // 
            this.btnPartido.Location = new System.Drawing.Point(144, 249);
            this.btnPartido.Name = "btnPartido";
            this.btnPartido.Size = new System.Drawing.Size(136, 54);
            this.btnPartido.TabIndex = 9;
            this.btnPartido.Text = "Agregar";
            this.btnPartido.UseVisualStyleBackColor = true;
            // 
            // AgregarPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 334);
            this.Controls.Add(this.btnPartido);
            this.Controls.Add(this.gollocal);
            this.Controls.Add(this.golvisit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listVisit);
            this.Controls.Add(this.listLocal);
            this.Controls.Add(this.label1);
            this.Name = "AgregarPartidos";
            this.Text = "AgregarPartidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listLocal;
        private System.Windows.Forms.ComboBox listVisit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox golvisit;
        private System.Windows.Forms.TextBox gollocal;
        private System.Windows.Forms.Button btnPartido;
    }
}