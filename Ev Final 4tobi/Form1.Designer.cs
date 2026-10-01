namespace Ev_Final_4tobi
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
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.TextContraseña = new System.Windows.Forms.TextBox();
            this.BtnIngrresar = new System.Windows.Forms.Button();
            this.LBL1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextUsuario
            // 
            this.TextUsuario.Location = new System.Drawing.Point(404, 100);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(100, 22);
            this.TextUsuario.TabIndex = 0;
            // 
            // TextContraseña
            // 
            this.TextContraseña.Location = new System.Drawing.Point(439, 163);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(100, 22);
            this.TextContraseña.TabIndex = 1;
            // 
            // BtnIngrresar
            // 
            this.BtnIngrresar.Location = new System.Drawing.Point(404, 37);
            this.BtnIngrresar.Name = "BtnIngrresar";
            this.BtnIngrresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngrresar.TabIndex = 2;
            this.BtnIngrresar.Text = "Ingresar";
            this.BtnIngrresar.UseVisualStyleBackColor = true;
            this.BtnIngrresar.Click += new System.EventHandler(this.BtnIngrresar_Click);
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(596, 57);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(88, 16);
            this.LBL1.TabIndex = 3;
            this.LBL1.Text = "Examen Final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.BtnIngrresar);
            this.Controls.Add(this.TextContraseña);
            this.Controls.Add(this.TextUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.TextBox TextContraseña;
        private System.Windows.Forms.Button BtnIngrresar;
        private System.Windows.Forms.Label LBL1;
    }
}

