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
    public partial class Form6 : MetroForm
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void поставщикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.kursachDataSet.Поставщики);

        }

        private void поставщикиDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных, проверьте корректность введенны данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void поставщикиDataGridView_Validated(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }
    }
}
