using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_6
{
    public partial class Form1 : Form
    {
        playerDb _db = new playerDb();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Player nameplayer = new HW_6.Player();
            nameplayer.Id = Convert.ToInt16(txtID.Text);
            nameplayer.Name = txtName.Text;
            nameplayer.Team = txtTeam.Text;
            _db.Players.Add(nameplayer);
            _db.SaveChanges();
            txtID.Clear();
            txtName.Clear();
            txtTeam.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
