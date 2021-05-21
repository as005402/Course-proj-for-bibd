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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.inventoryDataSet.supplies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.report_on_stock". При необходимости она может быть перемещена или удалена.
            this.report_on_stockTableAdapter.Fill(this.inventoryDataSet.report_on_stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.realization". При необходимости она может быть перемещена или удалена.
            this.realizationTableAdapter.Fill(this.inventoryDataSet.realization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.inventoryDataSet.stock);

            this.reportViewer1.RefreshReport();
        }
    }
}
