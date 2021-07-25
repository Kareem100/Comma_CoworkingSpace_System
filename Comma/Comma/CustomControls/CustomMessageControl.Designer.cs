
namespace Comma.Forms.Customer_Forms
{
    partial class CustomMessage
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
            this.fromLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.deleteLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.ForeColor = System.Drawing.Color.Crimson;
            this.fromLbl.Location = new System.Drawing.Point(4, 4);
            this.fromLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(40, 19);
            this.fromLbl.TabIndex = 0;
            this.fromLbl.Text = "From";
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.messageLbl.Location = new System.Drawing.Point(5, 26);
            this.messageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLbl.MaximumSize = new System.Drawing.Size(240, 0);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(97, 15);
            this.messageLbl.TabIndex = 1;
            this.messageLbl.Text = "Message Content";
            // 
            // deleteLbl
            // 
            this.deleteLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteLbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLbl.ForeColor = System.Drawing.Color.Crimson;
            this.deleteLbl.Location = new System.Drawing.Point(224, 1);
            this.deleteLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deleteLbl.Name = "deleteLbl";
            this.deleteLbl.Size = new System.Drawing.Size(22, 23);
            this.deleteLbl.TabIndex = 2;
            this.deleteLbl.Text = "X";
            this.deleteLbl.Click += new System.EventHandler(this.deleteLbl_Click);
            // 
            // CustomMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteLbl);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.fromLbl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomMessage";
            this.Size = new System.Drawing.Size(250, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Label deleteLbl;
    }
}
