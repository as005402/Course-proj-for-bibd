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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.inventoryDataSet.employees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeesBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            employeesBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);
        }
    }
}
