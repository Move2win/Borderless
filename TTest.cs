using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borderless
{
    public partial class TTest : Form
    {
        public TTest()
        {
            InitializeComponent();
        }

        #region 滑动条焦点指示器

        private void customTrackBar1_Enter(object sender, EventArgs e)
        {
            label1.Show();
        }

        private void customTrackBar1_Leave(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void customTrackBar2_Enter(object sender, EventArgs e)
        {
            label2.Show();
        }

        private void customTrackBar2_Leave(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void customTrackBar3_Enter(object sender, EventArgs e)
        {
            label3.Show();
        }

        private void customTrackBar3_Leave(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void customTrackBar4_Enter(object sender, EventArgs e)
        {
            label4.Show();
        }

        private void customTrackBar4_Leave(object sender, EventArgs e)
        {
            label4.Hide();
        }

        #endregion

        #region 滑动条数值指示器

        private void customTrackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(customTrackBar1.Value);
        }

        private void customTrackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(customTrackBar2.Value);
        }

        private void customTrackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(customTrackBar3.Value);
        }

        private void customTrackBar4_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(customTrackBar4.Value);
        }

        #endregion

        //private void FocusIndicator()
        //{
        //    if (customTrackBar1.Focused)
        //    {
        //        label1.Show();
        //    }
        //    else if (customTrackBar2.Focused)
        //    {
        //        label2.Show();
        //    }
        //    else if (customTrackBar3.Focused)
        //    {
        //        label3.Show();
        //    }
        //    else if (customTrackBar4.Focused)
        //    {
        //        label4.Show();
        //    }
        //    else
        //    {
        //        label1.Hide();
        //        label2.Hide();
        //        label3.Hide();
        //        label4.Hide();
        //    }
        //}

    }
}
