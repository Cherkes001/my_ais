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
    public partial class Form8 : MetroForm
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void штатBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.штатBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Штат". При необходимости она может быть перемещена или удалена.
            this.штатTableAdapter.Fill(this.kursachDataSet.Штат);

        }

        private void штатDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных, проверьте корректность введенны данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void штатDataGridView_Validated(object sender, EventArgs e)
        {
            this.Validate();
            this.штатBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);
        }
    }
}
