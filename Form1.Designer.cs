namespace Pig_Latin_chap_8_pro_7_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            sentencetb = new TextBox();
            sentenceConvertedlbl = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 207);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter a Sentence";
            // 
            // sentencetb
            // 
            sentencetb.Location = new Point(310, 200);
            sentencetb.Name = "sentencetb";
            sentencetb.Size = new Size(926, 27);
            sentencetb.TabIndex = 1;
            // 
            // sentenceConvertedlbl
            // 
            sentenceConvertedlbl.BorderStyle = BorderStyle.FixedSingle;
            sentenceConvertedlbl.Location = new Point(169, 343);
            sentenceConvertedlbl.Name = "sentenceConvertedlbl";
            sentenceConvertedlbl.Size = new Size(1067, 190);
            sentenceConvertedlbl.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(553, 290);
            label3.Name = "label3";
            label3.Size = new Size(230, 28);
            label3.TabIndex = 3;
            label3.Text = "Sentence in \"Pig Latin\"";
            // 
            // button1
            // 
            button1.Location = new Point(417, 563);
            button1.Name = "button1";
            button1.Size = new Size(171, 51);
            button1.TabIndex = 4;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(774, 578);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 5;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 641);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(sentenceConvertedlbl);
            Controls.Add(sentencetb);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox sentencetb;
        private Label sentenceConvertedlbl;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}
