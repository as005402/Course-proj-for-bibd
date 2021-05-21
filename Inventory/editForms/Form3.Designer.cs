
namespace Inventory
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label rIDLabel;
            System.Windows.Forms.Label eIDLabel;
            System.Windows.Forms.Label pIDLabel;
            System.Windows.Forms.Label rQuantityLabel;
            System.Windows.Forms.Label rDateLabel;
            System.Windows.Forms.Label rPriceLabel;
            System.Windows.Forms.Label rDiscountLabel;
            System.Windows.Forms.Label rToPayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryDataSet = new Inventory.inventoryDataSet();
            this.realizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realizationTableAdapter = new Inventory.inventoryDataSetTableAdapters.realizationTableAdapter();
            this.tableAdapterManager = new Inventory.inventoryDataSetTableAdapters.TableAdapterManager();
            this.realizationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.realizationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.eIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rQuantityTextBox = new System.Windows.Forms.TextBox();
            this.rDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rPriceTextBox = new System.Windows.Forms.TextBox();
            this.rDiscountTextBox = new System.Windows.Forms.TextBox();
            this.rToPayTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Inventory.inventoryDataSetTableAdapters.productsTableAdapter();
            rIDLabel = new System.Windows.Forms.Label();
            eIDLabel = new System.Windows.Forms.Label();
            pIDLabel = new System.Windows.Forms.Label();
            rQuantityLabel = new System.Windows.Forms.Label();
            rDateLabel = new System.Windows.Forms.Label();
            rPriceLabel = new System.Windows.Forms.Label();
            rDiscountLabel = new System.Windows.Forms.Label();
            rToPayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizationBindingNavigator)).BeginInit();
            this.realizationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rIDLabel
            // 
            rIDLabel.AutoSize = true;
            rIDLabel.Location = new System.Drawing.Point(79, 102);
            rIDLabel.Name = "rIDLabel";
            rIDLabel.Size = new System.Drawing.Size(25, 17);
            rIDLabel.TabIndex = 2;
            rIDLabel.Text = "ID:";
            // 
            // eIDLabel
            // 
            eIDLabel.AutoSize = true;
            eIDLabel.Location = new System.Drawing.Point(14, 147);
            eIDLabel.Name = "eIDLabel";
            eIDLabel.Size = new System.Drawing.Size(90, 17);
            eIDLabel.TabIndex = 4;
            eIDLabel.Text = "Responsible:";
            // 
            // pIDLabel
            // 
            pIDLabel.AutoSize = true;
            pIDLabel.Location = new System.Drawing.Point(23, 192);
            pIDLabel.Name = "pIDLabel";
            pIDLabel.Size = new System.Drawing.Size(81, 17);
            pIDLabel.TabIndex = 6;
            pIDLabel.Text = "Product\' ID:";
            // 
            // rQuantityLabel
            // 
            rQuantityLabel.AutoSize = true;
            rQuantityLabel.Location = new System.Drawing.Point(39, 238);
            rQuantityLabel.Name = "rQuantityLabel";
            rQuantityLabel.Size = new System.Drawing.Size(65, 17);
            rQuantityLabel.TabIndex = 8;
            rQuantityLabel.Text = "Quantity:";
            // 
            // rDateLabel
            // 
            rDateLabel.AutoSize = true;
            rDateLabel.Location = new System.Drawing.Point(62, 285);
            rDateLabel.Name = "rDateLabel";
            rDateLabel.Size = new System.Drawing.Size(42, 17);
            rDateLabel.TabIndex = 10;
            rDateLabel.Text = "Date:";
            // 
            // rPriceLabel
            // 
            rPriceLabel.AutoSize = true;
            rPriceLabel.Location = new System.Drawing.Point(60, 328);
            rPriceLabel.Name = "rPriceLabel";
            rPriceLabel.Size = new System.Drawing.Size(44, 17);
            rPriceLabel.TabIndex = 12;
            rPriceLabel.Text = "Price:";
            // 
            // rDiscountLabel
            // 
            rDiscountLabel.AutoSize = true;
            rDiscountLabel.Location = new System.Drawing.Point(37, 373);
            rDiscountLabel.Name = "rDiscountLabel";
            rDiscountLabel.Size = new System.Drawing.Size(67, 17);
            rDiscountLabel.TabIndex = 14;
            rDiscountLabel.Text = "Discount:";
            // 
            // rToPayLabel
            // 
            rToPayLabel.AutoSize = true;
            rToPayLabel.Location = new System.Drawing.Point(60, 418);
            rToPayLabel.Name = "rToPayLabel";
            rToPayLabel.Size = new System.Drawing.Size(44, 17);
            rToPayLabel.TabIndex = 16;
            rToPayLabel.Text = "Total:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Realization";
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "inventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realizationBindingSource
            // 
            this.realizationBindingSource.DataMember = "realization";
            this.realizationBindingSource.DataSource = this.inventoryDataSet;
            // 
            // realizationTableAdapter
            // 
            this.realizationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.realizationTableAdapter = this.realizationTableAdapter;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.suppliersTableAdapter = null;
            this.tableAdapterManager.suppliesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Inventory.inventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // realizationBindingNavigator
            // 
            this.realizationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.realizationBindingNavigator.BindingSource = this.realizationBindingSource;
            this.realizationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.realizationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.realizationBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.realizationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.realizationBindingNavigatorSaveItem});
            this.realizationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.realizationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.realizationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.realizationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.realizationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.realizationBindingNavigator.Name = "realizationBindingNavigator";
            this.realizationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.realizationBindingNavigator.Size = new System.Drawing.Size(482, 27);
            this.realizationBindingNavigator.TabIndex = 2;
            this.realizationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // realizationBindingNavigatorSaveItem
            // 
            this.realizationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.realizationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("realizationBindingNavigatorSaveItem.Image")));
            this.realizationBindingNavigatorSaveItem.Name = "realizationBindingNavigatorSaveItem";
            this.realizationBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.realizationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.realizationBindingNavigatorSaveItem.Click += new System.EventHandler(this.realizationBindingNavigatorSaveItem_Click);
            // 
            // rIDNumericUpDown
            // 
            this.rIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.realizationBindingSource, "RID", true));
            this.rIDNumericUpDown.Location = new System.Drawing.Point(110, 100);
            this.rIDNumericUpDown.Name = "rIDNumericUpDown";
            this.rIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.rIDNumericUpDown.TabIndex = 3;
            // 
            // eIDNumericUpDown
            // 
            this.eIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.realizationBindingSource, "EID", true));
            this.eIDNumericUpDown.Location = new System.Drawing.Point(110, 145);
            this.eIDNumericUpDown.Name = "eIDNumericUpDown";
            this.eIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.eIDNumericUpDown.TabIndex = 5;
            // 
            // pIDNumericUpDown
            // 
            this.pIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.realizationBindingSource, "PID", true));
            this.pIDNumericUpDown.Location = new System.Drawing.Point(110, 190);
            this.pIDNumericUpDown.Name = "pIDNumericUpDown";
            this.pIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.pIDNumericUpDown.TabIndex = 7;
            // 
            // rQuantityTextBox
            // 
            this.rQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.realizationBindingSource, "RQuantity", true));
            this.rQuantityTextBox.Location = new System.Drawing.Point(110, 235);
            this.rQuantityTextBox.Name = "rQuantityTextBox";
            this.rQuantityTextBox.Size = new System.Drawing.Size(305, 22);
            this.rQuantityTextBox.TabIndex = 9;
            // 
            // rDateDateTimePicker
            // 
            this.rDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.realizationBindingSource, "RDate", true));
            this.rDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rDateDateTimePicker.Location = new System.Drawing.Point(110, 280);
            this.rDateDateTimePicker.Name = "rDateDateTimePicker";
            this.rDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.rDateDateTimePicker.TabIndex = 11;
            // 
            // rPriceTextBox
            // 
            this.rPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.realizationBindingSource, "RPrice", true));
            this.rPriceTextBox.Location = new System.Drawing.Point(110, 325);
            this.rPriceTextBox.Name = "rPriceTextBox";
            this.rPriceTextBox.Size = new System.Drawing.Size(200, 22);
            this.rPriceTextBox.TabIndex = 13;
            // 
            // rDiscountTextBox
            // 
            this.rDiscountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.realizationBindingSource, "RDiscount", true));
            this.rDiscountTextBox.Location = new System.Drawing.Point(110, 370);
            this.rDiscountTextBox.Name = "rDiscountTextBox";
            this.rDiscountTextBox.Size = new System.Drawing.Size(305, 22);
            this.rDiscountTextBox.TabIndex = 15;
            // 
            // rToPayTextBox
            // 
            this.rToPayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.realizationBindingSource, "RToPay", true));
            this.rToPayTextBox.Location = new System.Drawing.Point(110, 415);
            this.rToPayTextBox.Name = "rToPayTextBox";
            this.rToPayTextBox.Size = new System.Drawing.Size(200, 22);
            this.rToPayTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "First";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 40);
            this.button3.TabIndex = 20;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(330, 473);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 40);
            this.button4.TabIndex = 21;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(330, 533);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 40);
            this.button5.TabIndex = 24;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(185, 533);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 40);
            this.button6.TabIndex = 23;
            this.button6.Text = "Next";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(40, 533);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 40);
            this.button7.TabIndex = 22;
            this.button7.Text = "Last";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(185, 593);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 40);
            this.button8.TabIndex = 25;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(325, 325);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 23);
            this.button9.TabIndex = 26;
            this.button9.Text = "Calculate";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.inventoryDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(rToPayLabel);
            this.Controls.Add(this.rToPayTextBox);
            this.Controls.Add(rDiscountLabel);
            this.Controls.Add(this.rDiscountTextBox);
            this.Controls.Add(rPriceLabel);
            this.Controls.Add(this.rPriceTextBox);
            this.Controls.Add(rDateLabel);
            this.Controls.Add(this.rDateDateTimePicker);
            this.Controls.Add(rQuantityLabel);
            this.Controls.Add(this.rQuantityTextBox);
            this.Controls.Add(pIDLabel);
            this.Controls.Add(this.pIDNumericUpDown);
            this.Controls.Add(eIDLabel);
            this.Controls.Add(this.eIDNumericUpDown);
            this.Controls.Add(rIDLabel);
            this.Controls.Add(this.rIDNumericUpDown);
            this.Controls.Add(this.realizationBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Realization";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realizationBindingNavigator)).EndInit();
            this.realizationBindingNavigator.ResumeLayout(false);
            this.realizationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private inventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource realizationBindingSource;
        private inventoryDataSetTableAdapters.realizationTableAdapter realizationTableAdapter;
        private inventoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator realizationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton realizationBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown rIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown eIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown pIDNumericUpDown;
        private System.Windows.Forms.TextBox rQuantityTextBox;
        private System.Windows.Forms.DateTimePicker rDateDateTimePicker;
        private System.Windows.Forms.TextBox rPriceTextBox;
        private System.Windows.Forms.TextBox rDiscountTextBox;
        private System.Windows.Forms.TextBox rToPayTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private inventoryDataSetTableAdapters.productsTableAdapter productsTableAdapter;
    }
}