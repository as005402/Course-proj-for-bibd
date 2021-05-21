﻿using System;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.realization". При необходимости она может быть перемещена или удалена.
            this.realizationTableAdapter.Fill(this.inventoryDataSet.realization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.inventoryDataSet.supplies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.inventoryDataSet.products);

            this.reportViewer1.RefreshReport();
        }
    }
}
