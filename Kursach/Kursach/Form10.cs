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
    public partial class Form10 : MetroForm
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.kursachDataSet.Заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.kursachDataSet.Заказы);
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }


        private void заказыDataGridView_Validated(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);
        }

        private void заказыDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных, проверьте корректность введенны данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
