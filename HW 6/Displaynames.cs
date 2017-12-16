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
    public partial class Displaynames : Form
    {
        public Displaynames()
        {
            InitializeComponent();
        }

        private void Displaynames_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Student9HW_6_playerDbDataSet1.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this._Student9HW_6_playerDbDataSet1.Players);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
