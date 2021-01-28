
namespace ManaDigital.UserControls
{
    partial class DocUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CVpdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.CVpictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CVpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CVpdfViewer1
            // 
            this.CVpdfViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CVpdfViewer1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CVpdfViewer1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CVpdfViewer1.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.CVpdfViewer1.Appearance.Options.UseBackColor = true;
            this.CVpdfViewer1.Appearance.Options.UseBorderColor = true;
            this.CVpdfViewer1.Appearance.Options.UseForeColor = true;
            this.CVpdfViewer1.HighlightedFormFieldColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CVpdfViewer1.Location = new System.Drawing.Point(-3, 3);
            this.CVpdfViewer1.Name = "CVpdfViewer1";
            this.CVpdfViewer1.Size = new System.Drawing.Size(876, 576);
            this.CVpdfViewer1.TabIndex = 0;
            // 
            // CVpictureBox1
            // 
            this.CVpictureBox1.Location = new System.Drawing.Point(-3, 3);
            this.CVpictureBox1.Name = "CVpictureBox1";
            this.CVpictureBox1.Size = new System.Drawing.Size(913, 623);
            this.CVpictureBox1.TabIndex = 1;
            this.CVpictureBox1.TabStop = false;
            this.CVpictureBox1.Click += new System.EventHandler(this.CVpictureBox1_Click);
            // 
            // DocUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.CVpictureBox1);
            this.Controls.Add(this.CVpdfViewer1);
            this.Name = "DocUserControl1";
            this.Size = new System.Drawing.Size(910, 629);
            this.Load += new System.EventHandler(this.DocUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CVpictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer CVpdfViewer1;
        private System.Windows.Forms.PictureBox CVpictureBox1;
    }
}
