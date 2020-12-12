using System;
using System.Drawing;
using System.Windows.Forms;


namespace DataBase
{
    public partial class MenuConnect : Form
    {
        ConnectS          Server; // Класс для соединения с сервером.
        Tuple             <string, string, string, string> User;
        public bool       AvailableExists = false;
                       
        public MenuConnect()
        {
            InitializeComponent();                      
        }
                
        private void button_connect_Click(object sender, EventArgs e)
        {
            Server = new ConnectS();

            User = new Tuple<string, string, string, string>(textBox_host.Text, textBox_un.Text, textBox_db.Text, textBox_psw.Text);
           
            Server.ServerConnect(User); // Соединение 

            textBox_port.Text = Convert.ToString(Server.getPort());
           
            try
            {
                Server.openConnection(); // Открываем соединение
                AvailableExists = true;
                label_off.Text = "On";
                label_led.ForeColor = Color.LimeGreen;
                MessageBox.Show("Подключение с сервером установлено.");

                Server.closeConnection();
            }
            catch (Exception ex)
            {
                textBox_port.Text = null;
                MessageBox.Show(ex.Message, "Ошибка подключения.");
            }
        }

        
        private void button_exit_Click(object sender, EventArgs e)
        {
            if (AvailableExists)
            {
                Close();
            }
            else Application.Exit();
                          
        }


        private void button_discon_Click(object sender, EventArgs e)
        {
            if (AvailableExists)
            {
                textBox_port.Text = null;
                label_off.Text = "Off";
                label_led.ForeColor = Color.Red;
                AvailableExists = false;
                MessageBox.Show("Подключение с сервером завершено.");
            }

            else MessageBox.Show("Подключение с сервером не установлено.");
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (AvailableExists)
            {
                Аction Form2 = new Аction(User);
                Form2.Show();               
            }
            else MessageBox.Show("Выполните подключение!");
        }

    }
       
}
