namespace UDP_Receiver
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbData = new System.Windows.Forms.TextBox();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.BackColor = System.Drawing.Color.White;
            this.tbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbData.Location = new System.Drawing.Point(12, 12);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ReadOnly = true;
            this.tbData.Size = new System.Drawing.Size(264, 110);
            this.tbData.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(288, 136);
            this.Controls.Add(this.tbData);
            this.Name = "Form1";
            this.Text = "UDP Receiver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Timer timerData;
    }
}

