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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.inventoryDataSet.supplies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.inventoryDataSet.stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.inventoryDataSet.employees);

            this.reportViewer1.RefreshReport();
        }
    }
}
