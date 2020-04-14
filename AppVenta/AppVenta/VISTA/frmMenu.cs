﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVenta.VISTA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles rol = new frmRoles();
            rol.MdiParent = this;
            rol.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios user = new frmUsuarios();
            user.MdiParent = this;
            user.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
    }
}
