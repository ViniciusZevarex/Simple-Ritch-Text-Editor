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
        public FontFamily FontDefault { get; private set; }

        public EditorWindow()
        {
            FontDefault = new FontFamily("Segoe UI");
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

        private void btnToggleCodeFont_Click(object sender, EventArgs e)
        {
            ToggleCodeFont();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleTitleStyle();
        }

        public void ToggleTitleStyle()
        {
            System.Drawing.Font currentFont = richText.SelectionFont;

            if(currentFont.Size == 14.25)
            {
                richText.SelectionFont = new Font(FontDefault, 20.25f, FontStyle.Bold);
            }
            else
            {
                richText.SelectionFont = new Font(FontDefault, 14.25f, currentFont.Style);
            }
        }


        public void ToggleBold()
        {
            System.Drawing.Font currentFont = richText.SelectionFont;

            if (currentFont.Bold == false)
            {
                if (currentFont.Italic == true)
                {
                    richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Bold | FontStyle.Italic);
                }
                else if (currentFont.Underline == true)
                {
                    richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Bold | FontStyle.Underline);
                }
                else
                {
                    richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Bold);
                }
            }
            else
            {
                richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Regular);
            }
        }

        public void ToggleItalic()
        {
            System.Drawing.Font currentFont = richText.SelectionFont;

            if (currentFont.Italic == false)
            {
                if (currentFont.Bold == true)
                {
                    richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Bold | FontStyle.Italic);
                }
                else if (currentFont.Underline == true)
                {
                    richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Italic | FontStyle.Underline);

                }
                else
                {
                    richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Italic);
                }
            }
            else
            {
                richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Regular);
            }
        }

        public void ToggleUnderline()
        {
            System.Drawing.Font currentFont = richText.SelectionFont;

            if (currentFont.Underline == false)
            {
                if (currentFont.Bold == true)
                {
                    richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Bold | FontStyle.Underline);
                }
                else if (currentFont.Italic == true)
                {
                    richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Italic | FontStyle.Underline);

                }
                else
                {
                    richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Underline);
                }
            }
            else
            {
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
            }
        }

        public void ToggleCodeFont()
        {
            System.Drawing.Font currentFont = richText.SelectionFont;
            var fontCode = new FontFamily("Courier New");

            if (currentFont.FontFamily.Name == FontDefault.Name)
            {
                richText.SelectionFont = new Font(fontCode, currentFont.Size, FontStyle.Regular);
            }
            else
            {
                richText.SelectionFont = new Font(FontDefault, currentFont.Size, FontStyle.Regular);
            }
        }
    }
}
