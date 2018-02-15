using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadyoCsharp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = "http://bit.do/kanaldhd";
        }
    }
}
