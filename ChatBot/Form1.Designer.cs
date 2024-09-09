namespace ChatBot
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
            lblResponse = new Label();
            rTbxPrompt = new RichTextBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.Location = new Point(208, 30);
            lblResponse.MaximumSize = new Size(350, 351);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(0, 27);
            lblResponse.TabIndex = 0;
            // 
            // rTbxPrompt
            // 
            rTbxPrompt.Location = new Point(208, 377);
            rTbxPrompt.Margin = new Padding(3, 4, 3, 4);
            rTbxPrompt.Name = "rTbxPrompt";
            rTbxPrompt.Size = new Size(350, 201);
            rTbxPrompt.TabIndex = 1;
            rTbxPrompt.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(646, 462);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 2;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 346);
            label2.Name = "label2";
            label2.Size = new Size(267, 27);
            label2.TabIndex = 3;
            label2.Text = "Enter a prompt to complate in English:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 608);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(rTbxPrompt);
            Controls.Add(lblResponse);
            Font = new Font("Myanmar Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResponse;
        private RichTextBox rTbxPrompt;
        private Button button1;
        private Label label2;
    }
}
