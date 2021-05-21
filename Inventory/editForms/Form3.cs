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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void realizationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.realizationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.inventoryDataSet.products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.realization". При необходимости она может быть перемещена или удалена.
            this.realizationTableAdapter.Fill(this.inventoryDataSet.realization);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            realizationBindingSource.MoveFirst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            realizationBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            realizationBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            realizationBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            realizationBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            realizationBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.realizationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rToPayTextBox.Text = (decimal.Parse(rPriceTextBox.Text) - decimal.Parse(rDiscountTextBox.Text)).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in inventoryDataSet.products.Rows)
            {
                if (Convert.ToInt32(row[0]) == Convert.ToInt32(pIDNumericUpDown.Value)) { rPriceTextBox.Text = (Convert.ToDecimal(row[2]) * Convert.ToDecimal(rQuantityTextBox.Text)).ToString(); }
            }

        }
    }
}
