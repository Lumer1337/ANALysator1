using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3sem_analisator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void set_text(string txt)
        {
            textInput.Clear();
            textInput.AppendText(txt);
        }

        private void Example1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txt = "VAR name : file of char;";
            set_text(txt);
        }

        private void Example2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txt = "VAR C12 : file of STRING [10];";
            set_text(txt);
        }

        private void Example3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txt = "VAR name : file of char; _AB : file of char;";
            set_text(txt);
        }

        private void insert_tool_strip_but_Click(object sender, EventArgs e)
        {
            errorBox.Text = "Ошибок не обнаружено";
            string s = textInput.Text;
            try
            {
                string resultParse = SyntaxClassD.Run(s);
              //  OutputTextBox.Text = "Идентификаторы" + Environment.NewLine + resultParse[0] + Environment.NewLine + "Константы" + Environment.NewLine + resultParse[1];
            }
            catch (ExceptionWithPosition err)
            {
                errorBox.Text = err.Message;
                textInput.Focus();
                textInput.SelectionStart = err.Position;
            }
            catch (Exception err)
            {
                errorBox.Text = err.Message;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Example4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txt = "VAR name : char;";
            set_text(txt);
        }

        private void Example5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txt = "VAR _A_C : STRING [10];";
            set_text(txt);
        }
    }
}
