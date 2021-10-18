
namespace ErrorForm
{
    partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.LabelError = new System.Windows.Forms.Label();
            this.ButtonCloseWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelError
            // 
            this.LabelError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelError.AutoSize = true;
            this.LabelError.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelError.Location = new System.Drawing.Point(12, 9);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(37, 18);
            this.LabelError.TabIndex = 0;
            this.LabelError.Text = "Error";
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonCloseWindow
            // 
            this.ButtonCloseWindow.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCloseWindow.Location = new System.Drawing.Point(131, 89);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(75, 23);
            this.ButtonCloseWindow.TabIndex = 1;
            this.ButtonCloseWindow.Text = "OK";
            this.ButtonCloseWindow.UseVisualStyleBackColor = true;
            this.ButtonCloseWindow.Click += new System.EventHandler(this.CloseWindow);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 124);
            this.Controls.Add(this.ButtonCloseWindow);
            this.Controls.Add(this.LabelError);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrorForm";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.Button ButtonCloseWindow;
    }
}