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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.inventoryDataSet.suppliers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);
        }
    }
}
