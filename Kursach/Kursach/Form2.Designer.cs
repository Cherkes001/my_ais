namespace Kursach
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.kursachDataSet = new Kursach.KursachDataSet();
            this.каталог_товаровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.категорииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталог_товаровTableAdapter = new Kursach.KursachDataSetTableAdapters.Каталог_товаровTableAdapter();
            this.tableAdapterManager = new Kursach.KursachDataSetTableAdapters.TableAdapterManager();
            this.заказыTableAdapter1 = new Kursach.KursachDataSetTableAdapters.ЗаказыTableAdapter();
            this.категорииTableAdapter = new Kursach.KursachDataSetTableAdapters.КатегорииTableAdapter();
            this.каталог_товаровBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.каталог_товаровBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.каталог_товаровDataGridView = new System.Windows.Forms.DataGridView();
            this.idТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_товаровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_товаровBindingNavigator)).BeginInit();
            this.каталог_товаровBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_товаровDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kursachDataSet
            // 
            this.kursachDataSet.DataSetName = "KursachDataSet";
            this.kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каталог_товаровBindingSource
            // 
            this.каталог_товаровBindingSource.DataMember = "КатегорииКаталог товаров";
            this.каталог_товаровBindingSource.DataSource = this.категорииBindingSource;
            // 
            // категорииBindingSource
            // 
            this.категорииBindingSource.DataMember = "Категории";
            this.категорииBindingSource.DataSource = this.kursachDataSet;
            // 
            // каталог_товаровTableAdapter
            // 
            this.каталог_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kursach.KursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter1;
            this.tableAdapterManager.Каталог_товаровTableAdapter = this.каталог_товаровTableAdapter;
            this.tableAdapterManager.КатегорииTableAdapter = this.категорииTableAdapter;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.СкладTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ШтатTableAdapter = null;
            // 
            // заказыTableAdapter1
            // 
            this.заказыTableAdapter1.ClearBeforeFill = true;
            // 
            // категорииTableAdapter
            // 
            this.категорииTableAdapter.ClearBeforeFill = true;
            // 
            // каталог_товаровBindingNavigator
            // 
            this.каталог_товаровBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.каталог_товаровBindingNavigator.BackColor = System.Drawing.Color.White;
            this.каталог_товаровBindingNavigator.BindingSource = this.каталог_товаровBindingSource;
            this.каталог_товаровBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.каталог_товаровBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.каталог_товаровBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.каталог_товаровBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.каталог_товаровBindingNavigatorSaveItem});
            this.каталог_товаровBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.каталог_товаровBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.каталог_товаровBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.каталог_товаровBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.каталог_товаровBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.каталог_товаровBindingNavigator.Name = "каталог_товаровBindingNavigator";
            this.каталог_товаровBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.каталог_товаровBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.каталог_товаровBindingNavigator.Size = new System.Drawing.Size(870, 25);
            this.каталог_товаровBindingNavigator.TabIndex = 0;
            this.каталог_товаровBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // каталог_товаровBindingNavigatorSaveItem
            // 
            this.каталог_товаровBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.каталог_товаровBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("каталог_товаровBindingNavigatorSaveItem.Image")));
            this.каталог_товаровBindingNavigatorSaveItem.Name = "каталог_товаровBindingNavigatorSaveItem";
            this.каталог_товаровBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.каталог_товаровBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.каталог_товаровBindingNavigatorSaveItem.Click += new System.EventHandler(this.каталог_товаровBindingNavigatorSaveItem_Click);
            // 
            // каталог_товаровDataGridView
            // 
            this.каталог_товаровDataGridView.AutoGenerateColumns = false;
            this.каталог_товаровDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.каталог_товаровDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idТовараDataGridViewTextBoxColumn,
            this.имяТовараDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn});
            this.каталог_товаровDataGridView.DataSource = this.каталог_товаровBindingSource;
            this.каталог_товаровDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.каталог_товаровDataGridView.Location = new System.Drawing.Point(0, 0);
            this.каталог_товаровDataGridView.Name = "каталог_товаровDataGridView";
            this.каталог_товаровDataGridView.Size = new System.Drawing.Size(864, 495);
            this.каталог_товаровDataGridView.TabIndex = 1;
            this.каталог_товаровDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.каталог_товаровDataGridView_DataError);
            this.каталог_товаровDataGridView.Validated += new System.EventHandler(this.каталог_товаровDataGridView_Validated);
            // 
            // idТовараDataGridViewTextBoxColumn
            // 
            this.idТовараDataGridViewTextBoxColumn.DataPropertyName = "id товара";
            this.idТовараDataGridViewTextBoxColumn.HeaderText = "id товара";
            this.idТовараDataGridViewTextBoxColumn.Name = "idТовараDataGridViewTextBoxColumn";
            this.idТовараDataGridViewTextBoxColumn.Visible = false;
            // 
            // имяТовараDataGridViewTextBoxColumn
            // 
            this.имяТовараDataGridViewTextBoxColumn.DataPropertyName = "Имя товара";
            this.имяТовараDataGridViewTextBoxColumn.HeaderText = "Имя товара";
            this.имяТовараDataGridViewTextBoxColumn.Name = "имяТовараDataGridViewTextBoxColumn";
            this.имяТовараDataGridViewTextBoxColumn.Width = 250;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 150;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.Width = 300;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.19512F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.7378F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.21951F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 656);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.каталог_товаровDataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(864, 495);
            this.panel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 73);
            this.panel1.TabIndex = 2;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.категорииBindingSource;
            this.metroComboBox1.DisplayMember = "Имя категории";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(15, 37);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(292, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox1.ValueMember = "id категории";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(12, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(131, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Категория товаров:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroTextBox1);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(422, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 73);
            this.panel2.TabIndex = 3;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.CustomBackground = true;
            this.metroTextBox1.CustomForeColor = true;
            this.metroTextBox1.Location = new System.Drawing.Point(12, 37);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(292, 29);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(12, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(180, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Поиск в текущем каталоге:";
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.metroLabel3);
            this.panel3.Controls.Add(this.metroButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 70);
            this.panel3.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(134, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Оформление заказа";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(15, 32);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(227, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Оформить заказ";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.каталог_товаровBindingNavigator);
            this.Name = "Form2";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Каталог товаров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_товаровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категорииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_товаровBindingNavigator)).EndInit();
            this.каталог_товаровBindingNavigator.ResumeLayout(false);
            this.каталог_товаровBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_товаровDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursachDataSet kursachDataSet;
        private System.Windows.Forms.BindingSource каталог_товаровBindingSource;
        private KursachDataSetTableAdapters.Каталог_товаровTableAdapter каталог_товаровTableAdapter;
        private KursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator каталог_товаровBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton каталог_товаровBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView каталог_товаровDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private KursachDataSetTableAdapters.КатегорииTableAdapter категорииTableAdapter;
        private System.Windows.Forms.BindingSource категорииBindingSource;
        private KursachDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}