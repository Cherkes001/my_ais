using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace Kursach
{
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void складBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.складBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.kursachDataSet.Склад);

        }

        private void складDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных, проверьте корректность введенны данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void складDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.складBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);
        }

        private void складBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.складBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }
    }
}
