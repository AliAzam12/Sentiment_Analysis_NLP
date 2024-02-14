
namespace Sentiment_Analysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Review_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Predict_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Get_Review = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Review_TextBox
            // 
            this.Review_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Review_TextBox.Location = new System.Drawing.Point(74, 86);
            this.Review_TextBox.Multiline = true;
            this.Review_TextBox.Name = "Review_TextBox";
            this.Review_TextBox.Size = new System.Drawing.Size(197, 25);
            this.Review_TextBox.TabIndex = 0;
            this.Review_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Your Sentence";
            // 
            // Predict_Button
            // 
            this.Predict_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Predict_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Predict_Button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Predict_Button.Location = new System.Drawing.Point(129, 131);
            this.Predict_Button.Name = "Predict_Button";
            this.Predict_Button.Size = new System.Drawing.Size(87, 33);
            this.Predict_Button.TabIndex = 2;
            this.Predict_Button.Text = "Predict";
            this.Predict_Button.UseVisualStyleBackColor = true;
            this.Predict_Button.Click += new System.EventHandler(this.Predict_Button_Click);
            this.Predict_Button.MouseEnter += new System.EventHandler(this.Predict_Button_MouseEnter);
            this.Predict_Button.MouseLeave += new System.EventHandler(this.Predict_Button_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "The following sentence is : ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sentiment Analysis Application";
            // 
            // Get_Review
            // 
            this.Get_Review.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Get_Review.AutoSize = true;
            this.Get_Review.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_Review.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Get_Review.Location = new System.Drawing.Point(213, 187);
            this.Get_Review.Name = "Get_Review";
            this.Get_Review.Size = new System.Drawing.Size(78, 13);
            this.Get_Review.TabIndex = 6;
            this.Get_Review.Text = "Get_Review();";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 254);
            this.Controls.Add(this.Get_Review);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Predict_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Review_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentiment Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Review_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Predict_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Get_Review;
    }
}

