using System;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Аction : Form
    {
        
        View       FormV;
        Create     FormC;
        Save       FormS;

        public Аction(Tuple<string, string, string, string> User)
        {  
            InitializeComponent();             
             FormV = new View(User);
             FormC = new Create(User);
             FormS = new Save(User);
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            FormV.Show();
            Close();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            FormC.Show();
            Close();
        }
        
        private void button_view_Click(object sender, EventArgs e)
        {             
            FormS.Show();
            Close();
        }
    }
}
