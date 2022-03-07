using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChipsVendingMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variable declation Globally
        double pc=1.50, dr=1.75, gf=1.00, sn=2.00, totalamt=0,totalitm;

        // Counter Variable
        int pcc = 0, drc=0, gfc=0, snc=0;

        //Image Box Click Event

        private void p_potatochips_Click(object sender, EventArgs e)
        {
            pcc++;
            ttl_pc.Text = pcc + " X " + pc + " = " + (pcc * pc);
            totalamt = totalamt + pc;
            total_calculate();
        }

        private void p_deepriver_Click(object sender, EventArgs e)
        {
            drc++;
            ttl_dr.Text = drc + " X " + dr + " = " + (drc * dr);
            totalamt = totalamt + dr;
            total_calculate();
        }

        private void p_goldenflake_Click(object sender, EventArgs e)
        {
            gfc++;
            ttl_gf.Text = gfc + " X " + gf + " = " + (gfc * gf);
            totalamt = totalamt + gf;
            total_calculate();
        }

        private void p_synder_Click(object sender, EventArgs e)
        {
            snc++;
            ttl_sn.Text = snc + " X " + sn + " = " + (snc * sn);
            totalamt = totalamt + sn;
            total_calculate();

        }

        private void total_calculate()
        {
            ttl_amt.Text = "$ " + totalamt.ToString();
            ttl_itmpckd.Text = (pcc + drc + gfc + snc).ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ttl_pc.Text = "0";
            ttl_dr.Text = "0";
            ttl_gf.Text = "0";
            ttl_sn.Text = "0";
            ttl_itmpckd.Text = "0";
            ttl_amt.Text = "0";
            pcc = drc = gfc = snc = 0;
            totalamt = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
