namespace Apagados_Programados
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
            this.labelH = new System.Windows.Forms.Label();
            this.horas = new System.Windows.Forms.TextBox();
            this.minutos = new System.Windows.Forms.TextBox();
            this.segundos = new System.Windows.Forms.TextBox();
            this.Apagado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.ForeColor = System.Drawing.Color.Snow;
            this.labelH.Location = new System.Drawing.Point(190, 25);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(331, 20);
            this.labelH.TabIndex = 0;
            this.labelH.Tag = "labelH";
            this.labelH.Text = "Indica el tiempo para el Apagado programado\r\n";
            this.labelH.Click += new System.EventHandler(this.label1_Click);
            // 
            // horas
            // 
            this.horas.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.horas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.ForeColor = System.Drawing.SystemColors.Window;
            this.horas.Location = new System.Drawing.Point(213, 98);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(63, 44);
            this.horas.TabIndex = 3;
            this.horas.Text = "00";
            // 
            // minutos
            // 
            this.minutos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.minutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutos.ForeColor = System.Drawing.SystemColors.Window;
            this.minutos.Location = new System.Drawing.Point(314, 98);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(63, 44);
            this.minutos.TabIndex = 4;
            this.minutos.Text = "00";
            // 
            // segundos
            // 
            this.segundos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.segundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundos.ForeColor = System.Drawing.SystemColors.Window;
            this.segundos.Location = new System.Drawing.Point(413, 98);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(63, 44);
            this.segundos.TabIndex = 5;
            this.segundos.Text = "00";
            // 
            // Apagado
            // 
            this.Apagado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Apagado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Apagado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Apagado.FlatAppearance.BorderSize = 0;
            this.Apagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apagado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Apagado.Location = new System.Drawing.Point(299, 193);
            this.Apagado.Name = "Apagado";
            this.Apagado.Size = new System.Drawing.Size(96, 36);
            this.Apagado.TabIndex = 6;
            this.Apagado.Tag = "Apagado";
            this.Apagado.Text = "Apagado";
            this.Apagado.UseVisualStyleBackColor = false;
            this.Apagado.Click += new System.EventHandler(this.Apagado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(281, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(380, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Apagado);
            this.Controls.Add(this.segundos);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.labelH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.TextBox horas;
        private System.Windows.Forms.TextBox minutos;
        private System.Windows.Forms.TextBox segundos;
        private System.Windows.Forms.Button Apagado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

