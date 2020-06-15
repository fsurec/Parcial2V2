namespace Parcial2V2
{
    partial class ResumenResultados
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
            this.dataResultados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalgoles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataResultados
            // 
            this.dataResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultados.Location = new System.Drawing.Point(78, 84);
            this.dataResultados.Name = "dataResultados";
            this.dataResultados.Size = new System.Drawing.Size(334, 185);
            this.dataResultados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resumen de Resultados ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Goles en el Torneo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // totalgoles
            // 
            this.totalgoles.AutoSize = true;
            this.totalgoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalgoles.Location = new System.Drawing.Point(231, 320);
            this.totalgoles.Name = "totalgoles";
            this.totalgoles.Size = new System.Drawing.Size(0, 17);
            this.totalgoles.TabIndex = 3;
            // 
            // ResumenResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 356);
            this.Controls.Add(this.totalgoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataResultados);
            this.Name = "ResumenResultados";
            this.Text = "ResumenResultados";
            this.Load += new System.EventHandler(this.ResumenResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalgoles;
    }
}