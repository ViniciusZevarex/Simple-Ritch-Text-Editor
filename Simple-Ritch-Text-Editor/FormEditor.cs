using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Ritch_Text_Editor
{
    public partial class EditorWindow : Form
    {
        public EditorWindow()
        {
            InitializeComponent();
        }

        private void btnToggleBold_Click(object sender, EventArgs e)
        {
            ToggleBold();
        }

        private void btnToggleItalic_Click(object sender, EventArgs e)
        {
            ToggleItalic();
        }

        private void btnToggleUnderline_Click(object sender, EventArgs e)
        {
            ToggleUnderline();
        }

        public void ToggleBold()
        {
            System.Drawing.Font currentFont = richText.SelectionFont;

            if (currentFont.Bold == false)
            {
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold);
            }
            else
            {
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
            }
        }

        public void ToggleItalic()
        {
            System.Drawing.Font currentFont = richText.SelectionFont;

            if (currentFont.Italic == false)
            {
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Italic);
            }
            else
            {
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
            }
        }

        public void ToggleUnderline()
        {
            System.Drawing.Font currentFont = richText.SelectionFont;

            if (currentFont.Underline == false)
            {
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Underline);
            }
            else
            {
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
            }
        }
    }
}
