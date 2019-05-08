using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework.Fonts;
using MetroFramework.Animation;

namespace Kursach
{
    public partial class Form1 : MetroForm
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Kursach.accdb;";
        private OleDbConnection myConnection;


        public Form1()
        {
            InitializeComponent();
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);
            // открываем соединение с БД
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.Show();
        }

    }
}
