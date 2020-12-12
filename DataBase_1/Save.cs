using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBase
{
    public partial class Save : Form
    {
        private MySqlConnection connect;

        private MySqlDataAdapter mySqlDataAdapter;

        Tuple<string, string, string, string> User;

        public Save(Tuple<string, string, string, string> User)
        {
            InitializeComponent();
            this.User = User;

        }

        public void SelectData(string stringSelect)
        {
            connect = ConnectS.Connection; // Запрос к соединению   

            try
            {
              
            dataGridView1.DataSource = null;
            mySqlDataAdapter = new MySqlDataAdapter(stringSelect, connect);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка операции.");
            }
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e) // Подзапрос 1
        {
            SelectData("SELECT * FROM  contract WHERE contract_price_ts_rub IN (SELECT contract_price_ts_rub FROM contract WHERE contract_price_ts_rub > 100);");            
        }

        private void button2_Click(object sender, EventArgs e) // Подзапрос 2
        {
            SelectData("SELECT * FROM contract WHERE EXISTS (SELECT * FROM ownership WHERE ownership.contract_id = contract.contract_code);");
        }

        private void button3_Click(object sender, EventArgs e) // Навигация 1
        {
            SelectData("SELECT program_name AS 'Название программы',contract_price_ts_rub AS 'Стоимость контракта тыс/ рубл', client_id AS 'Номер клиента' FROM contract INNER JOIN program ON program_program_code = program_code;");
        }

        private void button4_Click(object sender, EventArgs e) // Навигация 2
        {
            SelectData("SELECT client_fio AS 'ФИО',client_data AS 'Дата рождения',contract_price_ts_rub AS 'Стоимость контракта тыс/ рубл' FROM client INNER JOIN contract ON client_code = client_id; ");
        }

        private void button7_Click(object sender, EventArgs e) // Агрегация 1
        {
            SelectData("SELECT program_program_code AS 'Номер программы страхования',COUNT(*) AS 'Кол-во контрактов',AVG(contract_price_ts_rub) AS 'Средняя стоимость контракта тыс/руб' FROM contract GROUP BY program_program_code;");
        }

        private void button8_Click(object sender, EventArgs e) // Агрегация 2
        {
            SelectData("SELECT owner_adress AS 'Адресс',COUNT(*) AS count,AVG(owner_price_mln_rub) AS 'Средняя стоимость квартиры млн/руб' FROM ownership GROUP BY owner_adress HAVING count > 1;");
        }

        private void button_zClick(object sender, EventArgs e)
        {   
            SelectData("call get_program('" + textBox_pro.Text + "')");
        }

        private void button_oClick(object sender, EventArgs e)
        {
            SelectData("call get_otchet");
        }
    }
}