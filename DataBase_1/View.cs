using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBase
{
    public partial class View : Form
    {
        private MySqlConnection           connect;
        private MySqlDataAdapter          mySqlDataAdapter;
        Tuple                             <string, string, string, string> User;        

        public View(Tuple<string, string, string, string> User)
        {
            InitializeComponent();
            this.User = User;
        }
        public void SelectData(string stringSelect)
        {
            try
            {
                connect = ConnectS.Connection; // Запрос к соединению   
                
                dataGridView1.DataSource = null;
                mySqlDataAdapter = new MySqlDataAdapter(stringSelect, connect);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                connect.Close();
            }
            catch (Exception ex)
            { 
                richTextBox_sql.Text = null;
                MessageBox.Show(ex.Message, "Соблюдайте синтаксис SQL");
            }
            
        }

        private void button_rClick(object sender, EventArgs e)
        {
            SelectData(richTextBox_sql.Text);
        }
             
              
        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBox_sql.Text = null;
            dataGridView1.DataSource = null;
        }
    }
}
