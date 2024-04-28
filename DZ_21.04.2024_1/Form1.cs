using System.Windows.Forms;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DZ_21._04._2024_1
{
    public partial class Form1 : Form
    {
        private int lastVisibleChar = -1;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.VScroll += new EventHandler(richTextBox1_Scroll);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileContent = File.ReadAllText(filePath);

                richTextBox1.Clear();
                richTextBox1.Text = fileContent;
                UpdateProgressBar();
            }
        }

        private void richTextBox1_Scroll(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void UpdateProgressBar()
        {
            int firstLine = richTextBox1.GetLineFromCharIndex(lastVisibleChar);
            int lastLine = richTextBox1.GetLineFromCharIndex(richTextBox1.Text.Length);
            int totalLines = lastLine - firstLine + 1;
            int visibleLines = richTextBox1.GetLineFromCharIndex(richTextBox1.GetCharIndexFromPosition(new Point(1, richTextBox1.ClientSize.Height - 1))) - firstLine + 1;

            if (totalLines > 0)
            {
                int scrollPercentage = (int)(((double)visibleLines / totalLines) * 100);
                progressBar1.Value = scrollPercentage;
            }
            else
            {
                progressBar1.Value = 0;
            }
        }
    }
}
