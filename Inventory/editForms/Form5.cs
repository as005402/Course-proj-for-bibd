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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.inventoryDataSet.stock);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stockBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stockBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stockBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stockBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stockBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stockBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);
        }
    }
}
