using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void suppliesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.inventoryDataSet.supplies);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            suppliesBindingSource.MoveFirst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            suppliesBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suppliesBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            suppliesBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            suppliesBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            suppliesBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);
        }
    }
}
