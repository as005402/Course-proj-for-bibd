using Inventory.reportForms;
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
    public partial class Form1 : Form
    {
        string[] products = { "ID", "Name", "Price" };
        string[] realization = { "ID",  "Responsible", "Product' ID" , "Quantity", "Date", "Price", "Discount", "Total" };
        string[] supplies = { "ID", "Supplier' ID", "Product' ID", "Price", "Date", "Quantity", "Responsible" };
        string[] stock = { "Product' ID", "Quantity" };
        string[] suppliers = { "ID", "Name", "Address", "Phone number"};
        string[] employees = { "ID", "Name", "Position", "Address", "Phone number" };

        DataGridView dataGrid;
        BindingSource bind;

        int tableChosen;
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.inventoryDataSet.employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.inventoryDataSet.suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.inventoryDataSet.stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.supplies". При необходимости она может быть перемещена или удалена.
            this.suppliesTableAdapter.Fill(this.inventoryDataSet.supplies);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.realization". При необходимости она может быть перемещена или удалена.
            this.realizationTableAdapter.Fill(this.inventoryDataSet.realization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "inventoryDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.inventoryDataSet.products);

            button1_Click(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.inventoryDataSet.products);

            button7.Enabled = false;

            productsDataGridView.Visible = true;
            realizationDataGridView.Visible = false;
            suppliesDataGridView.Visible = false;
            stockDataGridView.Visible = false;
            suppliersDataGridView.Visible = false;
            employeesDataGridView.Visible = false;

            productsBindingNavigator.BindingSource = productsBindingSource;

            listBox1.Items.Clear();
            listBox1.Items.AddRange(products);

            comboBox1.DataSource = productsBindingSource;
            comboBox1.DisplayMember = "PID";

            tableChosen = 1;
            dataGrid = productsDataGridView;
            bind = productsBindingSource;

            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.realizationTableAdapter.Fill(this.inventoryDataSet.realization);

            button7.Enabled = false;
            
            productsDataGridView.Visible = false;
            suppliesDataGridView.Visible = false;
            stockDataGridView.Visible = false;
            suppliersDataGridView.Visible = false;
            employeesDataGridView.Visible = false;
            realizationDataGridView.Visible = true;

            productsBindingNavigator.BindingSource = realizationBindingSource;

            listBox1.Items.Clear();
            listBox1.Items.AddRange(realization);

            comboBox1.DataSource = realizationBindingSource;
            comboBox1.DisplayMember = "RID";

            tableChosen = 2;
            dataGrid = realizationDataGridView;
            bind = realizationBindingSource;

            button13.Visible = true;
            button13.Text = "Sales contracts";
            button14.Visible = true;
            button14.Text = "Sale of goods";
            button15.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.suppliesTableAdapter.Fill(this.inventoryDataSet.supplies);
            button7.Enabled = false;

            productsDataGridView.Visible = false;
            realizationDataGridView.Visible = false;
            stockDataGridView.Visible = false;
            suppliersDataGridView.Visible = false;
            employeesDataGridView.Visible = false;
            suppliesDataGridView.Visible = true;

            productsBindingNavigator.BindingSource = suppliesBindingSource;

            listBox1.Items.Clear();
            listBox1.Items.AddRange(supplies);

            comboBox1.DataSource = suppliesBindingSource;
            comboBox1.DisplayMember = "SupID";

            tableChosen = 3;
            dataGrid = suppliesDataGridView;
            bind = suppliesBindingSource;

            button13.Visible = true;
            button13.Text = "Purchase contracts";
            button14.Visible = true;
            button14.Text = "Receiving of goods";
            button15.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.stockTableAdapter.Fill(this.inventoryDataSet.stock);
            button7.Enabled = false;

            productsDataGridView.Visible = false;
            realizationDataGridView.Visible = false;
            suppliesDataGridView.Visible = false;
            suppliersDataGridView.Visible = false;
            employeesDataGridView.Visible = false;
            stockDataGridView.Visible = true;

            productsBindingNavigator.BindingSource = stockBindingSource;

            listBox1.Items.Clear();
            listBox1.Items.AddRange(stock);

            comboBox1.DataSource = stockBindingSource;
            comboBox1.DisplayMember = "PID";

            tableChosen = 4;
            dataGrid = stockDataGridView;
            bind = stockBindingSource;

            button13.Visible = true;
            button13.Text = "Report on items in stock";
            button14.Visible = false;
            button15.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.inventoryDataSet.suppliers);
            button7.Enabled = false;

            productsDataGridView.Visible = false;
            realizationDataGridView.Visible = false;
            suppliesDataGridView.Visible = false;
            stockDataGridView.Visible = false;
            employeesDataGridView.Visible = false;
            suppliersDataGridView.Visible = true;

            productsBindingNavigator.BindingSource = suppliersBindingSource;

            listBox1.Items.Clear();
            listBox1.Items.AddRange(suppliers);

            comboBox1.DataSource = suppliersBindingSource;
            comboBox1.DisplayMember = "SID";

            tableChosen = 5;
            dataGrid = suppliersDataGridView;
            bind = suppliersBindingSource;

            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.inventoryDataSet.employees);
            button7.Enabled = false;

            productsDataGridView.Visible = false;
            realizationDataGridView.Visible = false;
            suppliesDataGridView.Visible = false;
            stockDataGridView.Visible = false;
            suppliersDataGridView.Visible = false;
            employeesDataGridView.Visible = true;

            productsBindingNavigator.BindingSource = employeesBindingSource;

            listBox1.Items.Clear();
            listBox1.Items.AddRange(employees);

            comboBox1.DataSource = employeesBindingSource;
            comboBox1.DisplayMember = "EID";

            tableChosen = 6;
            dataGrid = employeesDataGridView;
            bind = employeesBindingSource;

            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataGridViewColumn col = dataGrid.Columns[0];
            col = dataGrid.Columns[listBox1.SelectedIndex];
            if (radioButton2.Checked == true)
            {
                dataGrid.Sort(col, ListSortDirection.Descending);
            }
            else
            {
                dataGrid.Sort(col, ListSortDirection.Ascending);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BindingSource useThis = new BindingSource();
            string filter = "";
            switch (tableChosen)
            {
                case 1:
                    filter = "PID='";
                    break;
                case 2:
                    filter = "RID='";
                    break;
                case 3:
                    filter = "SupID='";
                    break;
                case 4:
                    filter = "PID='";
                    break;
                case 5:
                    filter = "SID='";
                    break;
                case 6:
                    filter = "EID='";
                    break;
            }

            bind.Filter = filter + comboBox1.Text + "'";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bind.Filter = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool f = false;
            for (int i = 0; i < dataGrid.ColumnCount - 1; i++)
                for (int j = 0; j < dataGrid.RowCount - 1; j++)
                {
                    dataGrid[i, j].Style.BackColor = Color.White;
                    dataGrid[i, j].Style.ForeColor = Color.Black;

                    if (0 == String.Compare(dataGrid[i, j].Value.ToString(), textBox1.Text))
                    {
                        dataGrid[i, j].Style.BackColor = Color.LightGray;
                        dataGrid[i, j].Style.ForeColor = Color.Black;
                        f = true;
                    }
                }
            if (!f) MessageBox.Show("Field not found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid.ColumnCount - 1; i++)
                for (int j = 0; j < dataGrid.RowCount - 1; j++)
                {
                    dataGrid[i, j].Style.BackColor = Color.White;
                    dataGrid[i, j].Style.ForeColor = Color.Black;
                }
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (tableChosen)
            {
                case 1:
                    Form2 f2 = new Form2();
                    f2.Show();
                    break;
                case 2:
                    Form3 f3 = new Form3();
                    f3.Show();
                    break;
                case 3:
                    Form4 f4 = new Form4();
                    f4.Show();
                    break;
                case 4:
                    Form5 f5 = new Form5();
                    f5.Show();
                    break;
                case 5:
                    Form6 f6 = new Form6();
                    f6.Show();
                    break;
                case 6:
                    Form7 f7 = new Form7();
                    f7.Show();
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (tableChosen)
            {
                case 2:
                    Form8 f8 = new Form8();
                    f8.Show();
                    break;
                case 3:
                    Form11 f11 = new Form11();
                    f11.Show();
                    break;
                case 4:
                    Form14 f14 = new Form14();
                    f14.Show();
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (tableChosen)
            {
                case 2:
                    Form9 f9 = new Form9();
                    f9.Show();
                    break;
                case 3:
                    Form12 f12 = new Form12();
                    f12.Show();
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (tableChosen)
            {
                case 2:
                    Form10 f10 = new Form10();
                    f10.Show();
                    break;
                case 3:
                    Form13 f13 = new Form13();
                    f13.Show();
                    break;
            }
        }
    }
}
