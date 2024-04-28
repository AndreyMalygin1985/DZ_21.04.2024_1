namespace DZ_21._04._2024_1
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
            btnOpenFile = new Button();
            progressBar1 = new ProgressBar();
            openFileDialog1 = new OpenFileDialog();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(302, 12);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(194, 39);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Открыть текстовый файл";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(8, 415);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(785, 23);
            progressBar1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(8, 57);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(780, 352);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(progressBar1);
            Controls.Add(btnOpenFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenFile;
        private ProgressBar progressBar1;
        private OpenFileDialog openFileDialog1;
        private RichTextBox richTextBox1;
    }
}
