using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Teil_1
{
    public partial class NameDialog : Form
    {
        public NameDialog()
        {
            InitializeComponent();
        }
        public string LiefereName()
        {
            return textBox1.Text;
        }
    }
}
