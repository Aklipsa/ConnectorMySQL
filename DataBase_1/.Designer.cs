namespace DataBase
{
    partial class MenuConnect
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_host = new System.Windows.Forms.TextBox();
            this.textBox_db = new System.Windows.Forms.TextBox();
            this.textBox_un = new System.Windows.Forms.TextBox();
            this.textBox_psw = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_off = new System.Windows.Forms.Label();
            this.label_led = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 6.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server connection MySQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "СУБД";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.3F);
            this.button1.Location = new System.Drawing.Point(20, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hostname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label4.Location = new System.Drawing.Point(258, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label5.Location = new System.Drawing.Point(16, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Database:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label6.Location = new System.Drawing.Point(16, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label7.Location = new System.Drawing.Point(16, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Username:";
            // 
            // textBox_host
            // 
            this.textBox_host.Location = new System.Drawing.Point(101, 88);
            this.textBox_host.Name = "textBox_host";
            this.textBox_host.Size = new System.Drawing.Size(144, 20);
            this.textBox_host.TabIndex = 9;
            // 
            // textBox_db
            // 
            this.textBox_db.Location = new System.Drawing.Point(101, 118);
            this.textBox_db.Name = "textBox_db";
            this.textBox_db.Size = new System.Drawing.Size(144, 20);
            this.textBox_db.TabIndex = 10;
            // 
            // textBox_un
            // 
            this.textBox_un.Location = new System.Drawing.Point(101, 148);
            this.textBox_un.Name = "textBox_un";
            this.textBox_un.Size = new System.Drawing.Size(144, 20);
            this.textBox_un.TabIndex = 12;
            // 
            // textBox_psw
            // 
            this.textBox_psw.Location = new System.Drawing.Point(101, 178);
            this.textBox_psw.Name = "textBox_psw";
            this.textBox_psw.PasswordChar = '●';
            this.textBox_psw.Size = new System.Drawing.Size(144, 20);
            this.textBox_psw.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.3F);
            this.button2.Location = new System.Drawing.Point(314, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "Disable";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_discon_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.3F);
            this.button3.Location = new System.Drawing.Point(314, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 24);
            this.button3.TabIndex = 15;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // textBox_port
            // 
            this.textBox_port.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_port.Location = new System.Drawing.Point(302, 88);
            this.textBox_port.Multiline = true;
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.ReadOnly = true;
            this.textBox_port.Size = new System.Drawing.Size(84, 20);
            this.textBox_port.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Connect server:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Honeydew;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.3F);
            this.button4.Location = new System.Drawing.Point(314, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 24);
            this.button4.TabIndex = 17;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_next_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_off);
            this.panel1.Controls.Add(this.label_led);
            this.panel1.Location = new System.Drawing.Point(348, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 22);
            this.panel1.TabIndex = 18;
            // 
            // label_off
            // 
            this.label_off.AutoSize = true;
            this.label_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.label_off.Location = new System.Drawing.Point(16, 5);
            this.label_off.Margin = new System.Windows.Forms.Padding(0);
            this.label_off.Name = "label_off";
            this.label_off.Size = new System.Drawing.Size(18, 12);
            this.label_off.TabIndex = 20;
            this.label_off.Text = "Off";
            // 
            // label_led
            // 
            this.label_led.AutoSize = true;
            this.label_led.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.label_led.ForeColor = System.Drawing.Color.Red;
            this.label_led.Location = new System.Drawing.Point(3, 5);
            this.label_led.Name = "label_led";
            this.label_led.Size = new System.Drawing.Size(10, 12);
            this.label_led.TabIndex = 19;
            this.label_led.Text = "●";
            // 
            // MenuConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 267);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_psw);
            this.Controls.Add(this.textBox_un);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_db);
            this.Controls.Add(this.textBox_host);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MenuConnect";
            this.Text = "Аuthorization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_host;
        private System.Windows.Forms.TextBox textBox_db;
        private System.Windows.Forms.TextBox textBox_un;
        private System.Windows.Forms.TextBox textBox_psw;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_off;
        private System.Windows.Forms.Label label_led;
    }
}

