﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Client_POP3
{
    public static class RichTextBoxExtension
    {
        public static void AppendText(this RichTextBox box,string text,  Color color, bool addNewLine = false)
        {
            box.SuspendLayout();
            box.SelectionColor = color;
            box.AppendText(addNewLine
                ? $"{text}{Environment.NewLine}"
                : text);
            box.ScrollToCaret();
            box.ResumeLayout();
        }
    }
}
