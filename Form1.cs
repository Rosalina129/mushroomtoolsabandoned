using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mushroomtools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenFileDialog DataSaves = new OpenFileDialog();
        }

        private void makeAMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mapmaker = new Form2();
            mapmaker.ShowDialog();
        }

        private void designerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void hUDEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 design = new Form3();
            design.ShowDialog();
        }
    }
}
