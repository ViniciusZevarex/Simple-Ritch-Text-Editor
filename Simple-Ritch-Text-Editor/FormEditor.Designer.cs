namespace Simple_Ritch_Text_Editor
{
    partial class EditorWindow
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
            this.richText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnToggleBold = new System.Windows.Forms.Button();
            this.btnToggleItalic = new System.Windows.Forms.Button();
            this.btnToggleUnderline = new System.Windows.Forms.Button();
            this.btnToggleCodeFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.BackColor = System.Drawing.Color.White;
            this.richText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richText.Location = new System.Drawing.Point(12, 78);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(776, 360);
            this.richText.TabIndex = 1;
            this.richText.Text = "";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "T";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnToggleBold
            // 
            this.btnToggleBold.FlatAppearance.BorderSize = 0;
            this.btnToggleBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleBold.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleBold.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToggleBold.Location = new System.Drawing.Point(58, 30);
            this.btnToggleBold.Name = "btnToggleBold";
            this.btnToggleBold.Size = new System.Drawing.Size(52, 42);
            this.btnToggleBold.TabIndex = 3;
            this.btnToggleBold.Text = "B";
            this.btnToggleBold.UseVisualStyleBackColor = true;
            this.btnToggleBold.Click += new System.EventHandler(this.btnToggleBold_Click);
            // 
            // btnToggleItalic
            // 
            this.btnToggleItalic.FlatAppearance.BorderSize = 0;
            this.btnToggleItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleItalic.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleItalic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToggleItalic.Location = new System.Drawing.Point(116, 30);
            this.btnToggleItalic.Name = "btnToggleItalic";
            this.btnToggleItalic.Size = new System.Drawing.Size(52, 42);
            this.btnToggleItalic.TabIndex = 4;
            this.btnToggleItalic.Text = "I";
            this.btnToggleItalic.UseVisualStyleBackColor = true;
            this.btnToggleItalic.Click += new System.EventHandler(this.btnToggleItalic_Click);
            // 
            // btnToggleUnderline
            // 
            this.btnToggleUnderline.FlatAppearance.BorderSize = 0;
            this.btnToggleUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleUnderline.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleUnderline.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToggleUnderline.Location = new System.Drawing.Point(174, 30);
            this.btnToggleUnderline.Name = "btnToggleUnderline";
            this.btnToggleUnderline.Size = new System.Drawing.Size(52, 42);
            this.btnToggleUnderline.TabIndex = 5;
            this.btnToggleUnderline.Text = "U";
            this.btnToggleUnderline.UseVisualStyleBackColor = true;
            this.btnToggleUnderline.Click += new System.EventHandler(this.btnToggleUnderline_Click);
            // 
            // btnToggleCodeFont
            // 
            this.btnToggleCodeFont.FlatAppearance.BorderSize = 0;
            this.btnToggleCodeFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleCodeFont.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleCodeFont.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToggleCodeFont.Location = new System.Drawing.Point(232, 30);
            this.btnToggleCodeFont.Name = "btnToggleCodeFont";
            this.btnToggleCodeFont.Size = new System.Drawing.Size(52, 42);
            this.btnToggleCodeFont.TabIndex = 6;
            this.btnToggleCodeFont.Text = "<>";
            this.btnToggleCodeFont.UseVisualStyleBackColor = true;
            this.btnToggleCodeFont.Click += new System.EventHandler(this.btnToggleCodeFont_Click);
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToggleCodeFont);
            this.Controls.Add(this.btnToggleUnderline);
            this.Controls.Add(this.btnToggleItalic);
            this.Controls.Add(this.btnToggleBold);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditorWindow";
            this.Text = "Editor";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnToggleBold;
        private System.Windows.Forms.Button btnToggleItalic;
        private System.Windows.Forms.Button btnToggleUnderline;
        private System.Windows.Forms.Button btnToggleCodeFont;
    }
}

