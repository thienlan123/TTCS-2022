using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapCoSo_62139022
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_SelectionSort_Click(object sender, EventArgs e)
        {
                SelectionSort Ss = new SelectionSort();
                Ss.ShowDialog();
        }

        private void button_BubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSort Bs = new BubbleSort();
            Bs.ShowDialog();
        }

        private void button_InterchangeSort_Click(object sender, EventArgs e)
        {
            InterchangeSort Is = new InterchangeSort();
            Is.ShowDialog();
        }
    }
}
