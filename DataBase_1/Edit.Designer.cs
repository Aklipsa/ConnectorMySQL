namespace DataBase
{
    partial class Create
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_born = new System.Windows.Forms.TextBox();
            this.button_in = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_del = new System.Windows.Forms.Button();
            this.button_sh = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Код PK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 6.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(216, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Паспорт:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label5.Location = new System.Drawing.Point(228, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата рождения:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(91, 128);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(113, 20);
            this.textBox_id.TabIndex = 12;
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(91, 58);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(379, 20);
            this.textBox_fio.TabIndex = 13;
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(91, 93);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(113, 20);
            this.textBox_p.TabIndex = 14;
            // 
            // textBox_born
            // 
            this.textBox_born.Location = new System.Drawing.Point(357, 93);
            this.textBox_born.Name = "textBox_born";
            this.textBox_born.Size = new System.Drawing.Size(113, 20);
            this.textBox_born.TabIndex = 15;
            // 
            // button_in
            // 
            this.button_in.BackColor = System.Drawing.Color.Honeydew;
            this.button_in.Location = new System.Drawing.Point(318, 128);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(67, 23);
            this.button_in.TabIndex = 18;
            this.button_in.Text = "Insert";
            this.button_in.UseVisualStyleBackColor = false;
            this.button_in.Click += new System.EventHandler(this.button_i_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 212);
            this.dataGridView1.TabIndex = 19;
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.Color.Honeydew;
            this.button_del.Location = new System.Drawing.Point(232, 128);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(67, 23);
            this.button_del.TabIndex = 20;
            this.button_del.Text = "Delete";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_sh
            // 
            this.button_sh.BackColor = System.Drawing.Color.Honeydew;
            this.button_sh.Location = new System.Drawing.Point(403, 128);
            this.button_sh.Name = "button_sh";
            this.button_sh.Size = new System.Drawing.Size(67, 23);
            this.button_sh.TabIndex = 21;
            this.button_sh.Text = "Show table";
            this.button_sh.UseVisualStyleBackColor = false;
            this.button_sh.Click += new System.EventHandler(this.button_sh_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label14.Location = new System.Drawing.Point(13, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Результат запроса";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 391);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button_sh);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_in);
            this.Controls.Add(this.textBox_born);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.textBox_fio);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create";
            this.Text = "Create";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_born;
        private System.Windows.Forms.Button button_in;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_sh;
        private System.Windows.Forms.Label label14;
    }
}