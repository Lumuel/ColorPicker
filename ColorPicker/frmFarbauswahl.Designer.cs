namespace ColorPicker
{
    partial class frmFarbauswahl
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.frmFarbauswahl_btnStart = new System.Windows.Forms.Button();
            this.frmFarbauswahl_cbPort = new System.Windows.Forms.ComboBox();
            this.frmFarbauswahl_lblSelection = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // frmFarbauswahl_btnStart
            // 
            this.frmFarbauswahl_btnStart.Location = new System.Drawing.Point(101, 110);
            this.frmFarbauswahl_btnStart.Name = "frmFarbauswahl_btnStart";
            this.frmFarbauswahl_btnStart.Size = new System.Drawing.Size(126, 23);
            this.frmFarbauswahl_btnStart.TabIndex = 0;
            this.frmFarbauswahl_btnStart.Text = "Start";
            this.frmFarbauswahl_btnStart.UseVisualStyleBackColor = true;
            this.frmFarbauswahl_btnStart.Click += new System.EventHandler(this.frmFarbauswahl_btnStart_Click);
            // 
            // frmFarbauswahl_cbPort
            // 
            this.frmFarbauswahl_cbPort.FormattingEnabled = true;
            this.frmFarbauswahl_cbPort.Location = new System.Drawing.Point(101, 51);
            this.frmFarbauswahl_cbPort.Name = "frmFarbauswahl_cbPort";
            this.frmFarbauswahl_cbPort.Size = new System.Drawing.Size(121, 21);
            this.frmFarbauswahl_cbPort.TabIndex = 2;
            // 
            // frmFarbauswahl_lblSelection
            // 
            this.frmFarbauswahl_lblSelection.AutoSize = true;
            this.frmFarbauswahl_lblSelection.Location = new System.Drawing.Point(101, 32);
            this.frmFarbauswahl_lblSelection.Name = "frmFarbauswahl_lblSelection";
            this.frmFarbauswahl_lblSelection.Size = new System.Drawing.Size(29, 13);
            this.frmFarbauswahl_lblSelection.TabIndex = 3;
            this.frmFarbauswahl_lblSelection.Text = "Port:";
            // 
            // backgroundWorker
            // 

            // 
            // frmFarbauswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 161);
            this.Controls.Add(this.frmFarbauswahl_lblSelection);
            this.Controls.Add(this.frmFarbauswahl_cbPort);
            this.Controls.Add(this.frmFarbauswahl_btnStart);
            this.Name = "frmFarbauswahl";
            this.Text = "Farbauswahl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button frmFarbauswahl_btnStart;
        private System.Windows.Forms.ComboBox frmFarbauswahl_cbPort;
        private System.Windows.Forms.Label frmFarbauswahl_lblSelection;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

