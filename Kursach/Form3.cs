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
using MetroFramework.Fonts;
using MetroFramework.Animation;

namespace Kursach
{
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.kursachDataSet.Категории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Каталог_товаров". При необходимости она может быть перемещена или удалена.
            this.каталог_товаровTableAdapter.Fill(this.kursachDataSet.Каталог_товаров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursachDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.kursachDataSet.Заказы);
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


        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            // вызываем главную форму приложения, которая открыла текущую форму Form3, главная форма всегда = 0
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            var date = DateTime.Today;
            //DateTime date = new DateTime();
            int index = 0;
            foreach (DataGridViewRow item in каталог_товаровDataGridView.SelectedRows)
            {
                index = item.Index;
            }
            string name = каталог_товаровDataGridView.Rows[index].Cells[1].Value.ToString();
            int price = int.Parse(каталог_товаровDataGridView.Rows[index].Cells[0].Value.ToString());

            if (metroTextBox1.Text == "")
            {
                MessageBox.Show("Не введено количество товара");
            }
            else
            {
                this.заказыTableAdapter.orders((int)price, name, date, int.Parse(metroTextBox1.Text), price * int.Parse(metroTextBox1.Text));
                this.заказыTableAdapter.Fill(this.kursachDataSet.Заказы);
            }
        }


        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ввод только цифр в textbox
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

    }
}
