using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.PlaylistEditor.UI
{
    public partial class Form1 : Form
    {
        //Fields
        private int borderSize = 2;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(borderSize);
            //this.BackColor = Color.FromArgb(220, 193, 176);
        }
    }
}
