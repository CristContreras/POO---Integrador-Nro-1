namespace UI
{
    partial class AsignarAuto
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
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(186, 209);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 0;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // AsignarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsignar);
            this.Name = "AsignarAuto";
            this.Text = "AsignarAuto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsignar;
    }
}