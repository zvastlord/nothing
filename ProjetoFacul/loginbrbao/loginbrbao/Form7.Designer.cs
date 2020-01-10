namespace loginbrbao
{
    partial class Form7
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
            this.dgvponto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvponto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvponto
            // 
            this.dgvponto.AllowUserToAddRows = false;
            this.dgvponto.AllowUserToDeleteRows = false;
            this.dgvponto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvponto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvponto.Location = new System.Drawing.Point(13, 13);
            this.dgvponto.Name = "dgvponto";
            this.dgvponto.ReadOnly = true;
            this.dgvponto.Size = new System.Drawing.Size(445, 237);
            this.dgvponto.TabIndex = 0;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 262);
            this.Controls.Add(this.dgvponto);
            this.Name = "Form7";
            this.Text = "SGP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvponto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvponto;
    }
}