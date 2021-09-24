using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_002_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnByte_Click(object sender, EventArgs e)
        {
            lblType.Text = "byte";
            lblMinVal.Text = byte.MinValue.ToString();
            lblMaxVal.Text = byte.MaxValue.ToString();
            MessageBox.Show(string.Format("Type 'byte' has min value {0} and max value {1}", lblMinVal.Text, lblMaxVal.Text));
        }

        private void btnSbyte_Click(object sender, EventArgs e)
        {
            lblType.Text = "sbyte";
            lblMinVal.Text = sbyte.MinValue.ToString();
            lblMaxVal.Text = sbyte.MaxValue.ToString();
            MessageBox.Show(string.Format("Type 'sbyte' has min value {0} and max value {1}", lblMinVal.Text, lblMaxVal.Text));
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            lblType.Text = "short";
            lblMinVal.Text = short.MinValue.ToString();
            lblMaxVal.Text = short.MaxValue.ToString();
            MessageBox.Show(string.Format("Type 'short' has min value {0} and max value {1}", lblMinVal.Text, lblMaxVal.Text));
        }

        private void btnUshort_Click(object sender, EventArgs e)
        {
            lblType.Text = "ushort";
            lblMinVal.Text = ushort.MinValue.ToString();
            lblMaxVal.Text = ushort.MaxValue.ToString();
            MessageBox.Show(string.Format("Type 'ushort' has min value {0} and max value {1}", lblMinVal.Text, lblMaxVal.Text));
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            lblType.Text = "int";
            lblMinVal.Text = int.MinValue.ToString();
            lblMaxVal.Text = int.MaxValue.ToString();
            MessageBox.Show(string.Format("Type 'int' has min value {0} and max value {1}", lblMinVal.Text, lblMaxVal.Text));
        }

        private void bUint_Click(object sender, EventArgs e)
        {
            lblType.Text = "uint";
            lblMinVal.Text = uint.MinValue.ToString();
            lblMaxVal.Text = uint.MaxValue.ToString();
            MessageBox.Show(string.Format("Type 'uint' has min value {0} and max value {1}", lblMinVal.Text, lblMaxVal.Text));
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            lblType.Text = "long";
            lblMinVal.Text = long.MinValue.ToString();
            lblMaxVal.Text = long.MaxValue.ToString();
            MessageBox.Show(string.Format("Type 'long' has min value {0} and max value {1}", lblMinVal.Text, lblMaxVal.Text));
        }

        private void btnUlong_Click(object sender, EventArgs e)
        {
            lblType.Text = "ulong";
            lblMinVal.Text = ulong.MinValue.ToString();
            lblMaxVal.Text = ulong.MaxValue.ToString();
            MessageBox.Show(string.Format("Type 'ulong' has min value {0} and max value {1}", lblMinVal.Text, lblMaxVal.Text));
        }
    }
}
