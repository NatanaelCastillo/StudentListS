namespace StudentListS
{
    partial class StudentList
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
            this.LvStudent = new System.Windows.Forms.ListView();
            this.BtConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LvStudent
            // 
            this.LvStudent.Location = new System.Drawing.Point(13, 13);
            this.LvStudent.Name = "LvStudent";
            this.LvStudent.Size = new System.Drawing.Size(369, 310);
            this.LvStudent.TabIndex = 0;
            this.LvStudent.UseCompatibleStateImageBehavior = false;
            // 
            // BtConnect
            // 
            this.BtConnect.Location = new System.Drawing.Point(388, 13);
            this.BtConnect.Name = "BtConnect";
            this.BtConnect.Size = new System.Drawing.Size(96, 23);
            this.BtConnect.TabIndex = 1;
            this.BtConnect.Text = "Connect";
            this.BtConnect.UseVisualStyleBackColor = true;
            this.BtConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 335);
            this.Controls.Add(this.BtConnect);
            this.Controls.Add(this.LvStudent);
            this.Name = "StudentList";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvStudent;
        private System.Windows.Forms.Button BtConnect;
    }
}

