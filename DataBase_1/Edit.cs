using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBase
{
    public partial class Create : Form
    {
        private MySqlConnection     connect;
        private MySqlDataAdapter    mySqlDataAdapter;
        Tuple                       <string, string, string, string> User;

        public Create(Tuple<string, string, string, string> User)
        {
            InitializeComponent();
            this.User = User;
            textBox_id.Text = "0";
            textBox_fio.Text = "Фамилия Имя Отчество";
            textBox_p.Text = "000001";
            textBox_born.Text = "2000-12-31";

        }

        public void EditData(string stringInsert)
        {
            try
            {
                connect = ConnectS.Connection;                
                mySqlDataAdapter = new MySqlDataAdapter(stringInsert, connect);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);             
                connect.Close();
            }

            catch (Exception ex)
            {               
                MessageBox.Show(ex.Message, "Ошибка операции");
            }
        }
        public void SelectData(string stringSelect)
        {
            try
            {
                connect = ConnectS.Connection;  
                dataGridView1.DataSource = null;
                mySqlDataAdapter = new MySqlDataAdapter(stringSelect, connect);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                connect.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Соблюдайте синтаксис SQL");
            }

        }

        private void button_sh_Click(object sender, EventArgs e)
        {
            SelectData("SELECT * FROM client;");
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            EditData("DELETE FROM `mydb`.`client` WHERE `client_code`='" + textBox_id.Text + "'");
            SelectData("SELECT * FROM client;");
        }

        private void button_i_Click(object sender, EventArgs e)
        {            
            EditData("INSERT INTO `mydb`.`client` (`client_code`, `client_fio`, `client_pasport`, `client_data`) VALUES ('" + textBox_id.Text + "', '" + textBox_fio.Text + "', '" + textBox_p.Text + "', '" + textBox_born.Text + "');");
            SelectData("SELECT * FROM client;");          
        }
               
    }
}
