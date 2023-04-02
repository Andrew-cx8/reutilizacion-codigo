namespace App_Reutilizacion
{
    partial class PDF_Reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF_Reader));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btn_abrirPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(12, 45);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(995, 602);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // btn_abrirPDF
            // 
            this.btn_abrirPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_abrirPDF.Location = new System.Drawing.Point(484, 12);
            this.btn_abrirPDF.Name = "btn_abrirPDF";
            this.btn_abrirPDF.Size = new System.Drawing.Size(75, 23);
            this.btn_abrirPDF.TabIndex = 1;
            this.btn_abrirPDF.Text = "&Abrir PDF";
            this.btn_abrirPDF.UseVisualStyleBackColor = true;
            this.btn_abrirPDF.Click += new System.EventHandler(this.btn_abrirPDF_Click);
            // 
            // PDF_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 657);
            this.Controls.Add(this.btn_abrirPDF);
            this.Controls.Add(this.axAcroPDF1);
            this.Name = "PDF_Reader";
            this.Text = "PDF_Reader";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button btn_abrirPDF;
    }
}