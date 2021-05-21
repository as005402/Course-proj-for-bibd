
namespace Inventory
{
    partial class Form4
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
            System.Windows.Forms.Label supIDLabel;
            System.Windows.Forms.Label sIDLabel;
            System.Windows.Forms.Label pIDLabel;
            System.Windows.Forms.Label supPriceLabel;
            System.Windows.Forms.Label supDateLabel;
            System.Windows.Forms.Label supQuantityLabel;
            System.Windows.Forms.Label eIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryDataSet = new Inventory.inventoryDataSet();
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliesTableAdapter = new Inventory.inventoryDataSetTableAdapters.suppliesTableAdapter();
            this.tableAdapterManager = new Inventory.inventoryDataSetTableAdapters.TableAdapterManager();
            this.suppliesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.suppliesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.supIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.supPriceTextBox = new System.Windows.Forms.TextBox();
            this.supDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.supQuantityTextBox = new System.Windows.Forms.TextBox();
            this.eIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            supIDLabel = new System.Windows.Forms.Label();
            sIDLabel = new System.Windows.Forms.Label();
            pIDLabel = new System.Windows.Forms.Label();
            supPriceLabel = new System.Windows.Forms.Label();
            supDateLabel = new System.Windows.Forms.Label();
            supQuantityLabel = new System.Windows.Forms.Label();
            eIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingNavigator)).BeginInit();
            this.suppliesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIDNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // supIDLabel
            // 
            supIDLabel.AutoSize = true;
            supIDLabel.Location = new System.Drawing.Point(79, 102);
            supIDLabel.Name = "supIDLabel";
            supIDLabel.Size = new System.Drawing.Size(25, 17);
            supIDLabel.TabIndex = 3;
            supIDLabel.Text = "ID:";
            // 
            // sIDLabel
            // 
            sIDLabel.AutoSize = true;
            sIDLabel.Location = new System.Drawing.Point(20, 147);
            sIDLabel.Name = "sIDLabel";
            sIDLabel.Size = new System.Drawing.Size(84, 17);
            sIDLabel.TabIndex = 4;
            sIDLabel.Text = "Supplier\' ID:";
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
            // supPriceLabel
            // 
            supPriceLabel.AutoSize = true;
            supPriceLabel.Location = new System.Drawing.Point(60, 238);
            supPriceLabel.Name = "supPriceLabel";
            supPriceLabel.Size = new System.Drawing.Size(44, 17);
            supPriceLabel.TabIndex = 8;
            supPriceLabel.Text = "Price:";
            // 
            // supDateLabel
            // 
            supDateLabel.AutoSize = true;
            supDateLabel.Location = new System.Drawing.Point(58, 285);
            supDateLabel.Name = "supDateLabel";
            supDateLabel.Size = new System.Drawing.Size(46, 17);
            supDateLabel.TabIndex = 10;
            supDateLabel.Text = " Date:";
            // 
            // supQuantityLabel
            // 
            supQuantityLabel.AutoSize = true;
            supQuantityLabel.Location = new System.Drawing.Point(39, 328);
            supQuantityLabel.Name = "supQuantityLabel";
            supQuantityLabel.Size = new System.Drawing.Size(65, 17);
            supQuantityLabel.TabIndex = 12;
            supQuantityLabel.Text = "Quantity:";
            // 
            // eIDLabel
            // 
            eIDLabel.AutoSize = true;
            eIDLabel.Location = new System.Drawing.Point(14, 372);
            eIDLabel.Name = "eIDLabel";
            eIDLabel.Size = new System.Drawing.Size(90, 17);
            eIDLabel.TabIndex = 14;
            eIDLabel.Text = "Responsible:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplies";
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "inventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "supplies";
            this.suppliesBindingSource.DataSource = this.inventoryDataSet;
            // 
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.realizationTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.suppliersTableAdapter = null;
            this.tableAdapterManager.suppliesTableAdapter = this.suppliesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Inventory.inventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // suppliesBindingNavigator
            // 
            this.suppliesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.suppliesBindingNavigator.BindingSource = this.suppliesBindingSource;
            this.suppliesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.suppliesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.suppliesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.suppliesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.suppliesBindingNavigatorSaveItem});
            this.suppliesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.suppliesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.suppliesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.suppliesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.suppliesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.suppliesBindingNavigator.Name = "suppliesBindingNavigator";
            this.suppliesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.suppliesBindingNavigator.Size = new System.Drawing.Size(482, 27);
            this.suppliesBindingNavigator.TabIndex = 3;
            this.suppliesBindingNavigator.Text = "bindingNavigator1";
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
            // suppliesBindingNavigatorSaveItem
            // 
            this.suppliesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.suppliesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("suppliesBindingNavigatorSaveItem.Image")));
            this.suppliesBindingNavigatorSaveItem.Name = "suppliesBindingNavigatorSaveItem";
            this.suppliesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.suppliesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.suppliesBindingNavigatorSaveItem.Click += new System.EventHandler(this.suppliesBindingNavigatorSaveItem_Click);
            // 
            // supIDNumericUpDown
            // 
            this.supIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.suppliesBindingSource, "SupID", true));
            this.supIDNumericUpDown.Location = new System.Drawing.Point(110, 100);
            this.supIDNumericUpDown.Name = "supIDNumericUpDown";
            this.supIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.supIDNumericUpDown.TabIndex = 4;
            // 
            // sIDNumericUpDown
            // 
            this.sIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.suppliesBindingSource, "SID", true));
            this.sIDNumericUpDown.Location = new System.Drawing.Point(110, 145);
            this.sIDNumericUpDown.Name = "sIDNumericUpDown";
            this.sIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.sIDNumericUpDown.TabIndex = 5;
            // 
            // pIDNumericUpDown
            // 
            this.pIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.suppliesBindingSource, "PID", true));
            this.pIDNumericUpDown.Location = new System.Drawing.Point(110, 190);
            this.pIDNumericUpDown.Name = "pIDNumericUpDown";
            this.pIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.pIDNumericUpDown.TabIndex = 7;
            // 
            // supPriceTextBox
            // 
            this.supPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "SupPrice", true));
            this.supPriceTextBox.Location = new System.Drawing.Point(110, 235);
            this.supPriceTextBox.Name = "supPriceTextBox";
            this.supPriceTextBox.Size = new System.Drawing.Size(305, 22);
            this.supPriceTextBox.TabIndex = 9;
            // 
            // supDateDateTimePicker
            // 
            this.supDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.suppliesBindingSource, "SupDate", true));
            this.supDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.supDateDateTimePicker.Location = new System.Drawing.Point(110, 280);
            this.supDateDateTimePicker.Name = "supDateDateTimePicker";
            this.supDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.supDateDateTimePicker.TabIndex = 11;
            // 
            // supQuantityTextBox
            // 
            this.supQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "SupQuantity", true));
            this.supQuantityTextBox.Location = new System.Drawing.Point(110, 325);
            this.supQuantityTextBox.Name = "supQuantityTextBox";
            this.supQuantityTextBox.Size = new System.Drawing.Size(305, 22);
            this.supQuantityTextBox.TabIndex = 13;
            // 
            // eIDNumericUpDown
            // 
            this.eIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.suppliesBindingSource, "EID", true));
            this.eIDNumericUpDown.Location = new System.Drawing.Point(110, 370);
            this.eIDNumericUpDown.Name = "eIDNumericUpDown";
            this.eIDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.eIDNumericUpDown.TabIndex = 15;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(185, 551);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 40);
            this.button8.TabIndex = 32;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(330, 491);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 40);
            this.button5.TabIndex = 31;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(185, 491);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 40);
            this.button6.TabIndex = 30;
            this.button6.Text = "Next";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(40, 491);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 40);
            this.button7.TabIndex = 29;
            this.button7.Text = "Last";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(330, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 40);
            this.button4.TabIndex = 28;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 40);
            this.button3.TabIndex = 27;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 26;
            this.button2.Text = "First";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(482, 608);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(eIDLabel);
            this.Controls.Add(this.eIDNumericUpDown);
            this.Controls.Add(supQuantityLabel);
            this.Controls.Add(this.supQuantityTextBox);
            this.Controls.Add(supDateLabel);
            this.Controls.Add(this.supDateDateTimePicker);
            this.Controls.Add(supPriceLabel);
            this.Controls.Add(this.supPriceTextBox);
            this.Controls.Add(pIDLabel);
            this.Controls.Add(this.pIDNumericUpDown);
            this.Controls.Add(sIDLabel);
            this.Controls.Add(this.sIDNumericUpDown);
            this.Controls.Add(supIDLabel);
            this.Controls.Add(this.supIDNumericUpDown);
            this.Controls.Add(this.suppliesBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Supplies";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingNavigator)).EndInit();
            this.suppliesBindingNavigator.ResumeLayout(false);
            this.suppliesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eIDNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private inventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource suppliesBindingSource;
        private inventoryDataSetTableAdapters.suppliesTableAdapter suppliesTableAdapter;
        private inventoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator suppliesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton suppliesBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown supIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown sIDNumericUpDown;
        private System.Windows.Forms.NumericUpDown pIDNumericUpDown;
        private System.Windows.Forms.TextBox supPriceTextBox;
        private System.Windows.Forms.DateTimePicker supDateDateTimePicker;
        private System.Windows.Forms.TextBox supQuantityTextBox;
        private System.Windows.Forms.NumericUpDown eIDNumericUpDown;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}