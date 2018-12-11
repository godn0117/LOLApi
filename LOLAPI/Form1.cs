using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOLAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FrmSpell fs;
        FrmRune fr;
        FrmItems fi;
        FrmChampion fc;
        //private void 스펠SpellToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (fs == null)
        //    {
        //        fs = new FrmSpell();
        //        fs.MdiParent = this;
        //        fs.Show();
        //    }
        //    else
        //    {
        //        fs.Focus();
        //    }
        //}

        //private void 챔피언ChampionToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (fc == null)
        //    {
        //        fc = new FrmChampion();
        //        fc.MdiParent = this;
        //        fc.Show();
        //    }
        //    else
        //    {
        //        fc.Focus();
        //    }
        //}

        //private void 룬RuneToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (fr == null)
        //    {
        //        fr = new FrmRune();
        //        fr.MdiParent = this;
        //        fr.Show();
        //    }
        //    else
        //    {
        //        fr.Focus();
        //    }
        //}

        //private void 아이템ItemToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (fi == null)
        //    {
        //        fi = new FrmItems();
        //        fi.MdiParent = this;
        //        fi.Show();
        //    }
        //    else
        //    {
        //        fi.Focus();
        //    }
        //}
    }
}
