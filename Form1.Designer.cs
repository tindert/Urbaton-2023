namespace WindowsFormsApp1CRUD
{
    partial class Form1
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
            this.AddItemButton = new System.Windows.Forms.Button();
            this.NickNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemCountButton = new System.Windows.Forms.Button();
            this.DeleteAllItemsButton = new System.Windows.Forms.Button();
            this.ShowAllTextBox = new System.Windows.Forms.TextBox();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoadItemButton = new System.Windows.Forms.Button();
            this.LoadItemTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadItemLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(211, 329);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(175, 50);
            this.AddItemButton.TabIndex = 0;
            this.AddItemButton.Text = "Добавить в БД";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NickNameTextBox
            // 
            this.NickNameTextBox.Location = new System.Drawing.Point(286, 179);
            this.NickNameTextBox.Name = "NickNameTextBox";
            this.NickNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.NickNameTextBox.TabIndex = 4;
            this.NickNameTextBox.Text = "Dima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NickName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(286, 224);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(100, 103);
            this.MessageTextBox.TabIndex = 6;
            this.MessageTextBox.Text = "testing message";
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сообщение";
            // 
            // ItemCountButton
            // 
            this.ItemCountButton.Location = new System.Drawing.Point(22, 416);
            this.ItemCountButton.Name = "ItemCountButton";
            this.ItemCountButton.Size = new System.Drawing.Size(210, 43);
            this.ItemCountButton.TabIndex = 11;
            this.ItemCountButton.Text = "ItemCount";
            this.ItemCountButton.UseVisualStyleBackColor = true;
            this.ItemCountButton.Click += new System.EventHandler(this.ItemCountButton_Click);
            // 
            // DeleteAllItemsButton
            // 
            this.DeleteAllItemsButton.Location = new System.Drawing.Point(22, 474);
            this.DeleteAllItemsButton.Name = "DeleteAllItemsButton";
            this.DeleteAllItemsButton.Size = new System.Drawing.Size(210, 43);
            this.DeleteAllItemsButton.TabIndex = 12;
            this.DeleteAllItemsButton.Text = "Delete All Items";
            this.DeleteAllItemsButton.UseVisualStyleBackColor = true;
            this.DeleteAllItemsButton.Click += new System.EventHandler(this.DeleteAllItemsButton_Click);
            // 
            // ShowAllTextBox
            // 
            this.ShowAllTextBox.Location = new System.Drawing.Point(496, 18);
            this.ShowAllTextBox.Multiline = true;
            this.ShowAllTextBox.Name = "ShowAllTextBox";
            this.ShowAllTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowAllTextBox.Size = new System.Drawing.Size(413, 233);
            this.ShowAllTextBox.TabIndex = 13;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(496, 275);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(413, 43);
            this.ShowAllButton.TabIndex = 14;
            this.ShowAllButton.Text = "Show All Items";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(286, 135);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.Text = "testName";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(286, 91);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(100, 26);
            this.IDtextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "номер";
            // 
            // LoadItemButton
            // 
            this.LoadItemButton.Location = new System.Drawing.Point(565, 382);
            this.LoadItemButton.Name = "LoadItemButton";
            this.LoadItemButton.Size = new System.Drawing.Size(157, 38);
            this.LoadItemButton.TabIndex = 17;
            this.LoadItemButton.Text = "Load Item";
            this.LoadItemButton.UseVisualStyleBackColor = true;
            this.LoadItemButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // LoadItemTextBox
            // 
            this.LoadItemTextBox.Location = new System.Drawing.Point(728, 388);
            this.LoadItemTextBox.Name = "LoadItemTextBox";
            this.LoadItemTextBox.Size = new System.Drawing.Size(125, 26);
            this.LoadItemTextBox.TabIndex = 18;
            this.LoadItemTextBox.Text = "0 номер записи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Суперадминские привилении";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoadItemLabel
            // 
            this.LoadItemLabel.AutoSize = true;
            this.LoadItemLabel.Location = new System.Drawing.Point(564, 434);
            this.LoadItemLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.LoadItemLabel.Name = "LoadItemLabel";
            this.LoadItemLabel.Size = new System.Drawing.Size(289, 40);
            this.LoadItemLabel.TabIndex = 20;
            this.LoadItemLabel.Text = "Нажмите на кнопку, чтобы получить информацию о записи";
            this.LoadItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1CRUD.Properties.Resources.хакатонОбложка;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1CRUD.Properties.Resources.цирк;
            this.pictureBox2.Location = new System.Drawing.Point(238, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ввод новых данных";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadItemLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoadItemTextBox);
            this.Controls.Add(this.LoadItemButton);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.ShowAllTextBox);
            this.Controls.Add(this.DeleteAllItemsButton);
            this.Controls.Add(this.ItemCountButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NickNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddItemButton);
            this.Name = "Form1";
            this.Text = "УрбанХакатон";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TextBox NickNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ItemCountButton;
        private System.Windows.Forms.Button DeleteAllItemsButton;
        private System.Windows.Forms.TextBox ShowAllTextBox;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LoadItemButton;
        private System.Windows.Forms.TextBox LoadItemTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LoadItemLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

