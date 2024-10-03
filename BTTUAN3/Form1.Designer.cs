namespace BTTUAN3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_data = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Origin = new DataGridViewTextBoxColumn();
            Expired = new DataGridViewTextBoxColumn();
            input_masp = new TextBox();
            input_name = new TextBox();
            input_capacity = new TextBox();
            input_price = new TextBox();
            input_origin = new TextBox();
            datetime_expired = new DateTimePicker();
            input_max = new TextBox();
            input_min = new TextBox();
            input_check_origin = new TextBox();
            btn_save = new Button();
            btn_delete = new Button();
            button_btw = new Button();
            btn_expired = new Button();
            btn_jp = new Button();
            btn_max_price = new Button();
            btn_check_expired = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_delete_origin = new Button();
            btn_delete_all = new Button();
            btn_delete_expired = new Button();
            dataGridView_query = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_query).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_data
            // 
            dataGridView_data.AllowUserToAddRows = false;
            dataGridView_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_data.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, Capacity, Price, Origin, Expired });
            dataGridView_data.Location = new Point(22, 334);
            dataGridView_data.Name = "dataGridView_data";
            dataGridView_data.RowHeadersVisible = false;
            dataGridView_data.RowHeadersWidth = 51;
            dataGridView_data.Size = new Size(597, 188);
            dataGridView_data.TabIndex = 0;
            // 
            // MaSP
            // 
            MaSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSP.DataPropertyName = "Id";
            MaSP.HeaderText = "Mã SP";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            TenSP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSP.DataPropertyName = "NameProduct";
            TenSP.HeaderText = "Tên SP";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            // 
            // Capacity
            // 
            Capacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Capacity.DataPropertyName = "Capacity";
            Capacity.HeaderText = "Số lượng";
            Capacity.MinimumWidth = 6;
            Capacity.Name = "Capacity";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Đơn giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Origin
            // 
            Origin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Origin.DataPropertyName = "Origin";
            Origin.HeaderText = "Xuất xứ";
            Origin.MinimumWidth = 6;
            Origin.Name = "Origin";
            // 
            // Expired
            // 
            Expired.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Expired.DataPropertyName = "Expired";
            Expired.HeaderText = "Ngày hết hạn";
            Expired.MinimumWidth = 6;
            Expired.Name = "Expired";
            // 
            // input_masp
            // 
            input_masp.Location = new Point(106, 43);
            input_masp.Name = "input_masp";
            input_masp.Size = new Size(205, 27);
            input_masp.TabIndex = 3;
            // 
            // input_name
            // 
            input_name.Location = new Point(106, 76);
            input_name.Name = "input_name";
            input_name.Size = new Size(205, 27);
            input_name.TabIndex = 4;
            // 
            // input_capacity
            // 
            input_capacity.Location = new Point(106, 109);
            input_capacity.Name = "input_capacity";
            input_capacity.Size = new Size(205, 27);
            input_capacity.TabIndex = 5;
            // 
            // input_price
            // 
            input_price.Location = new Point(106, 142);
            input_price.Name = "input_price";
            input_price.Size = new Size(205, 27);
            input_price.TabIndex = 6;
            // 
            // input_origin
            // 
            input_origin.Location = new Point(106, 175);
            input_origin.Name = "input_origin";
            input_origin.Size = new Size(205, 27);
            input_origin.TabIndex = 7;
            // 
            // datetime_expired
            // 
            datetime_expired.Location = new Point(97, 208);
            datetime_expired.Name = "datetime_expired";
            datetime_expired.Size = new Size(214, 27);
            datetime_expired.TabIndex = 8;
            // 
            // input_max
            // 
            input_max.Location = new Point(911, 25);
            input_max.Name = "input_max";
            input_max.Size = new Size(73, 27);
            input_max.TabIndex = 9;
            // 
            // input_min
            // 
            input_min.Location = new Point(832, 24);
            input_min.Name = "input_min";
            input_min.Size = new Size(73, 27);
            input_min.TabIndex = 10;
            // 
            // input_check_origin
            // 
            input_check_origin.Location = new Point(779, 346);
            input_check_origin.Name = "input_check_origin";
            input_check_origin.Size = new Size(73, 27);
            input_check_origin.TabIndex = 11;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(97, 241);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 12;
            btn_save.Text = "Lưu SP";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(217, 241);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Xóa SP";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // button_btw
            // 
            button_btw.AutoSize = true;
            button_btw.Location = new Point(715, 12);
            button_btw.Name = "button_btw";
            button_btw.Size = new Size(100, 50);
            button_btw.TabIndex = 14;
            button_btw.Text = "Xuất các SP \r\ncó ĐG [a...b]";
            button_btw.UseVisualStyleBackColor = true;
            button_btw.Click += button_btw_Click;
            // 
            // btn_expired
            // 
            btn_expired.AutoSize = true;
            btn_expired.Location = new Point(557, 13);
            btn_expired.Name = "btn_expired";
            btn_expired.Size = new Size(109, 50);
            btn_expired.TabIndex = 15;
            btn_expired.Text = "Xuất toàn bộ \r\nSP quá hạn\r\n";
            btn_expired.UseVisualStyleBackColor = true;
            btn_expired.Click += btn_expired_Click;
            // 
            // btn_jp
            // 
            btn_jp.AutoSize = true;
            btn_jp.Location = new Point(448, 13);
            btn_jp.Name = "btn_jp";
            btn_jp.Size = new Size(94, 50);
            btn_jp.TabIndex = 16;
            btn_jp.Text = "1 sp từ \r\nNhật Bản";
            btn_jp.UseVisualStyleBackColor = true;
            btn_jp.Click += btn_jp_Click;
            // 
            // btn_max_price
            // 
            btn_max_price.AutoSize = true;
            btn_max_price.Location = new Point(350, 12);
            btn_max_price.Name = "btn_max_price";
            btn_max_price.Size = new Size(92, 50);
            btn_max_price.TabIndex = 17;
            btn_max_price.Text = "1 SP có ĐG\r\n cao nhất";
            btn_max_price.UseVisualStyleBackColor = true;
            btn_max_price.Click += btn_max_price_Click;
            // 
            // btn_check_expired
            // 
            btn_check_expired.Location = new Point(655, 401);
            btn_check_expired.Name = "btn_check_expired";
            btn_check_expired.Size = new Size(207, 65);
            btn_check_expired.TabIndex = 19;
            btn_check_expired.Text = "Kiểm tra kho có SP quá hạn \r\nhay không ?\r\n";
            btn_check_expired.TextAlign = ContentAlignment.MiddleLeft;
            btn_check_expired.UseVisualStyleBackColor = true;
            btn_check_expired.Click += btn_check_expired_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 43);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 22;
            label1.Text = "Mã SP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 23;
            label2.Text = "Tên SP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 109);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 24;
            label3.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 145);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 25;
            label4.Text = "Đơn giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 175);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 26;
            label5.Text = "Xuất xứ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 208);
            label6.MaximumSize = new Size(70, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 40);
            label6.TabIndex = 27;
            label6.Text = "Ngày hết hạn";
            // 
            // btn_delete_origin
            // 
            btn_delete_origin.AutoSize = true;
            btn_delete_origin.Location = new Point(655, 334);
            btn_delete_origin.Name = "btn_delete_origin";
            btn_delete_origin.Size = new Size(108, 50);
            btn_delete_origin.TabIndex = 28;
            btn_delete_origin.Text = "Xóa SP theo\r\nxuất xứ bất kì\r\n";
            btn_delete_origin.UseVisualStyleBackColor = true;
            btn_delete_origin.Click += btn_delete_origin_Click;
            // 
            // btn_delete_all
            // 
            btn_delete_all.AutoSize = true;
            btn_delete_all.Location = new Point(655, 472);
            btn_delete_all.Name = "btn_delete_all";
            btn_delete_all.Size = new Size(103, 50);
            btn_delete_all.TabIndex = 29;
            btn_delete_all.Text = "Xóa toàn bộ\r\nSP trong kho\r\n";
            btn_delete_all.UseVisualStyleBackColor = true;
            btn_delete_all.Click += btn_delete_all_Click;
            // 
            // btn_delete_expired
            // 
            btn_delete_expired.AutoSize = true;
            btn_delete_expired.Location = new Point(757, 472);
            btn_delete_expired.Name = "btn_delete_expired";
            btn_delete_expired.Size = new Size(105, 50);
            btn_delete_expired.TabIndex = 30;
            btn_delete_expired.Text = "Xóa toàn bộ \r\n SP quá hạn\r\n";
            btn_delete_expired.UseVisualStyleBackColor = true;
            btn_delete_expired.Click += btn_delete_expired_Click;
            // 
            // dataGridView_query
            // 
            dataGridView_query.AllowUserToAddRows = false;
            dataGridView_query.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_query.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView_query.Location = new Point(350, 82);
            dataGridView_query.Name = "dataGridView_query";
            dataGridView_query.RowHeadersVisible = false;
            dataGridView_query.RowHeadersWidth = 51;
            dataGridView_query.Size = new Size(634, 188);
            dataGridView_query.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Mã SP";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "NameProduct";
            dataGridViewTextBoxColumn2.HeaderText = "Tên SP";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "Capacity";
            dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.DataPropertyName = "Origin";
            dataGridViewTextBoxColumn5.HeaderText = "Xuất xứ";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.DataPropertyName = "Expired";
            dataGridViewTextBoxColumn6.HeaderText = "Ngày hết hạn";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 577);
            Controls.Add(dataGridView_query);
            Controls.Add(btn_delete_expired);
            Controls.Add(btn_delete_all);
            Controls.Add(btn_delete_origin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_check_expired);
            Controls.Add(btn_max_price);
            Controls.Add(btn_jp);
            Controls.Add(btn_expired);
            Controls.Add(button_btw);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Controls.Add(input_check_origin);
            Controls.Add(input_min);
            Controls.Add(input_max);
            Controls.Add(datetime_expired);
            Controls.Add(input_origin);
            Controls.Add(input_price);
            Controls.Add(input_capacity);
            Controls.Add(input_name);
            Controls.Add(input_masp);
            Controls.Add(dataGridView_data);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_data).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_query).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_data;
        private TextBox input_masp;
        private TextBox input_name;
        private TextBox input_capacity;
        private TextBox input_price;
        private TextBox input_origin;
        private DateTimePicker datetime_expired;
        private TextBox input_max;
        private TextBox input_min;
        private TextBox input_check_origin;
        private Button btn_save;
        private Button btn_delete;
        private Button button_btw;
        private Button btn_expired;
        private Button btn_jp;
        private Button btn_max_price;
        private Button btn_check_expired;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_delete_origin;
        private Button btn_delete_all;
        private Button btn_delete_expired;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Origin;
        private DataGridViewTextBoxColumn Expired;
        private DataGridView dataGridView_query;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
