using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mir
{
    public partial class Mir : Form
    {
        public Mir()
        {
            InitializeComponent();
        }

        private void btvoid_Click(object sender, EventArgs e)
        {
            Mirr form2 = new Mirr();
            form2.Show();
            // осуществляет переход на другую форму (Mirr.cs)
        }
    }
}
