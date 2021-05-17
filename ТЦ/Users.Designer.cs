
namespace ТЦ
{
    partial class Users
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label рольLabel;
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.номер_телефонаMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.рольComboBox = new System.Windows.Forms.ComboBox();
            фИОLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            рольLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(124, 88);
            фИОLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(42, 20);
            фИОLabel.TabIndex = 1;
            фИОLabel.Text = "ФИО:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(119, 125);
            логинLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(49, 20);
            логинLabel.TabIndex = 3;
            логинLabel.Text = "Логин:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(109, 161);
            парольLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(60, 20);
            парольLabel.TabIndex = 5;
            парольLabel.Text = "Пароль:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(133, 196);
            полLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(38, 20);
            полLabel.TabIndex = 7;
            полLabel.Text = "Пол:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(54, 265);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(121, 20);
            номер_телефонаLabel.TabIndex = 14;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(181, 84);
            this.фИОTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(215, 26);
            this.фИОTextBox.TabIndex = 2;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataSource = typeof(ТЦ.Сотрудники);
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(181, 120);
            this.логинTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(215, 26);
            this.логинTextBox.TabIndex = 4;
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(181, 156);
            this.парольTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(215, 26);
            this.парольTextBox.TabIndex = 6;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(181, 192);
            this.полTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(215, 26);
            this.полTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // номер_телефонаMaskedTextBox
            // 
            this.номер_телефонаMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Номер_телефона", true));
            this.номер_телефонаMaskedTextBox.Location = new System.Drawing.Point(181, 262);
            this.номер_телефонаMaskedTextBox.Name = "номер_телефонаMaskedTextBox";
            this.номер_телефонаMaskedTextBox.Size = new System.Drawing.Size(215, 26);
            this.номер_телефонаMaskedTextBox.TabIndex = 15;
            // 
            // рольLabel
            // 
            рольLabel.AutoSize = true;
            рольLabel.Location = new System.Drawing.Point(130, 229);
            рольLabel.Name = "рольLabel";
            рольLabel.Size = new System.Drawing.Size(45, 20);
            рольLabel.TabIndex = 15;
            рольLabel.Text = "Роль:";
            // 
            // рольComboBox
            // 
            this.рольComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Роль", true));
            this.рольComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.рольComboBox.FormattingEnabled = true;
            this.рольComboBox.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер А",
            "Менеджер С"});
            this.рольComboBox.Location = new System.Drawing.Point(181, 226);
            this.рольComboBox.Name = "рольComboBox";
            this.рольComboBox.Size = new System.Drawing.Size(215, 28);
            this.рольComboBox.TabIndex = 16;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 415);
            this.Controls.Add(рольLabel);
            this.Controls.Add(this.рольComboBox);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(this.номер_телефонаMaskedTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox номер_телефонаMaskedTextBox;
        private System.Windows.Forms.ComboBox рольComboBox;
    }
}