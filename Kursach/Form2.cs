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
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void каталог_товаровBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_товаровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.kursachDataSet.Категории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Каталог_товаров". При необходимости она может быть перемещена или удалена.
            this.каталог_товаровTableAdapter.Fill(this.kursachDataSet.Каталог_товаров);

        }

        private void каталог_товаровDataGridView_Validated(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_товаровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);
        }

        private void каталог_товаровDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных, проверьте корректность введенны данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // вызываем главную форму приложения, которая открыла текущую форму Form2, главная форма всегда = 0
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.каталог_товаровTableAdapter.SearchCatalog(this.kursachDataSet.Каталог_товаров, metroTextBox1.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            this.Hide();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
