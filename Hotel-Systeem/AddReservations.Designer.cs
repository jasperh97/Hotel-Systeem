namespace Hotel_Systeem
{
    partial class AddReservations
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
            this.CalendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.CalendarEndDate = new System.Windows.Forms.MonthCalendar();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.tbMobileNr = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.groupBoxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.Sex = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblSelectedStartDate = new System.Windows.Forms.Label();
            this.lblSelectedEndDate = new System.Windows.Forms.Label();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.lblFreeRooms = new System.Windows.Forms.Label();
            this.comboboxFreeRooms = new System.Windows.Forms.ComboBox();
            this.lblNudPersons = new System.Windows.Forms.Label();
            this.nudPersons = new System.Windows.Forms.NumericUpDown();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.clbCurrentCustomerList = new System.Windows.Forms.CheckedListBox();
            this.groupBoxCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarStartDate
            // 
            this.CalendarStartDate.Location = new System.Drawing.Point(14, 31);
            this.CalendarStartDate.Name = "CalendarStartDate";
            this.CalendarStartDate.TabIndex = 1;
            this.CalendarStartDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarStartDate_DateChanged);
            // 
            // CalendarEndDate
            // 
            this.CalendarEndDate.Location = new System.Drawing.Point(259, 31);
            this.CalendarEndDate.Name = "CalendarEndDate";
            this.CalendarEndDate.TabIndex = 2;
            this.CalendarEndDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarEndDate_DateChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(58, 9);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(53, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start date";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Location = new System.Drawing.Point(305, 9);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(50, 13);
            this.EndDate.TabIndex = 5;
            this.EndDate.Text = "End date";
            // 
            // tbMobileNr
            // 
            this.tbMobileNr.Location = new System.Drawing.Point(311, 109);
            this.tbMobileNr.Name = "tbMobileNr";
            this.tbMobileNr.Size = new System.Drawing.Size(100, 20);
            this.tbMobileNr.TabIndex = 11;
            this.tbMobileNr.Text = "default";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(85, 64);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 12;
            this.tbLastName.Text = "default";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(85, 24);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 20);
            this.tbSurname.TabIndex = 13;
            this.tbSurname.Text = "default";
            // 
            // groupBoxCustomerInfo
            // 
            this.groupBoxCustomerInfo.Controls.Add(this.btnAddCustomer);
            this.groupBoxCustomerInfo.Controls.Add(this.tbPostalCode);
            this.groupBoxCustomerInfo.Controls.Add(this.tbMobileNr);
            this.groupBoxCustomerInfo.Controls.Add(this.tbAddress);
            this.groupBoxCustomerInfo.Controls.Add(this.label1);
            this.groupBoxCustomerInfo.Controls.Add(this.lblPostalCode);
            this.groupBoxCustomerInfo.Controls.Add(this.lblAddress);
            this.groupBoxCustomerInfo.Controls.Add(this.nudAge);
            this.groupBoxCustomerInfo.Controls.Add(this.lblAge);
            this.groupBoxCustomerInfo.Controls.Add(this.comboBoxSex);
            this.groupBoxCustomerInfo.Controls.Add(this.tbLastName);
            this.groupBoxCustomerInfo.Controls.Add(this.tbSurname);
            this.groupBoxCustomerInfo.Controls.Add(this.Sex);
            this.groupBoxCustomerInfo.Controls.Add(this.lblLastName);
            this.groupBoxCustomerInfo.Controls.Add(this.lblSurname);
            this.groupBoxCustomerInfo.Location = new System.Drawing.Point(14, 268);
            this.groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            this.groupBoxCustomerInfo.Size = new System.Drawing.Size(472, 170);
            this.groupBoxCustomerInfo.TabIndex = 14;
            this.groupBoxCustomerInfo.TabStop = false;
            this.groupBoxCustomerInfo.Text = "Customer Info";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(311, 141);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 23);
            this.btnAddCustomer.TabIndex = 25;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(311, 64);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(100, 20);
            this.tbPostalCode.TabIndex = 19;
            this.tbPostalCode.Text = "default";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(311, 24);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 20;
            this.tbAddress.Text = "default";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "MobileNr:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(242, 67);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 23;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(242, 27);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address:";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(85, 144);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(100, 20);
            this.nudAge.TabIndex = 15;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(16, 146);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 18;
            this.lblAge.Text = "Age:";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Man",
            "Woman",
            "Other"});
            this.comboBoxSex.Location = new System.Drawing.Point(85, 104);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSex.TabIndex = 15;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Location = new System.Drawing.Point(16, 112);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(28, 13);
            this.Sex.TabIndex = 17;
            this.Sex.Text = "Sex:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(16, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "Lastname:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(16, 27);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Surname:";
            // 
            // lblSelectedStartDate
            // 
            this.lblSelectedStartDate.AutoSize = true;
            this.lblSelectedStartDate.Location = new System.Drawing.Point(117, 9);
            this.lblSelectedStartDate.Name = "lblSelectedStartDate";
            this.lblSelectedStartDate.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedStartDate.TabIndex = 16;
            // 
            // lblSelectedEndDate
            // 
            this.lblSelectedEndDate.AutoSize = true;
            this.lblSelectedEndDate.Location = new System.Drawing.Point(361, 9);
            this.lblSelectedEndDate.Name = "lblSelectedEndDate";
            this.lblSelectedEndDate.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedEndDate.TabIndex = 17;
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Location = new System.Drawing.Point(764, 191);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(179, 49);
            this.deleteCustomer.TabIndex = 25;
            this.deleteCustomer.Text = "Delete selected customers";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // lblFreeRooms
            // 
            this.lblFreeRooms.AutoSize = true;
            this.lblFreeRooms.Location = new System.Drawing.Point(724, 314);
            this.lblFreeRooms.Name = "lblFreeRooms";
            this.lblFreeRooms.Size = new System.Drawing.Size(62, 13);
            this.lblFreeRooms.TabIndex = 24;
            this.lblFreeRooms.Text = "Free rooms:";
            // 
            // comboboxFreeRooms
            // 
            this.comboboxFreeRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxFreeRooms.FormattingEnabled = true;
            this.comboboxFreeRooms.Location = new System.Drawing.Point(822, 306);
            this.comboboxFreeRooms.Name = "comboboxFreeRooms";
            this.comboboxFreeRooms.Size = new System.Drawing.Size(121, 21);
            this.comboboxFreeRooms.TabIndex = 23;
            // 
            // lblNudPersons
            // 
            this.lblNudPersons.AutoSize = true;
            this.lblNudPersons.Location = new System.Drawing.Point(724, 270);
            this.lblNudPersons.Name = "lblNudPersons";
            this.lblNudPersons.Size = new System.Drawing.Size(93, 13);
            this.lblNudPersons.TabIndex = 22;
            this.lblNudPersons.Text = "Amount of people:";
            // 
            // nudPersons
            // 
            this.nudPersons.Location = new System.Drawing.Point(823, 268);
            this.nudPersons.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPersons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPersons.Name = "nudPersons";
            this.nudPersons.Size = new System.Drawing.Size(120, 20);
            this.nudPersons.TabIndex = 21;
            this.nudPersons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPersons.ValueChanged += new System.EventHandler(this.nudPersons_ValueChanged_1);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(823, 333);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(121, 23);
            this.btnAddReservation.TabIndex = 20;
            this.btnAddReservation.Text = "Add reservation";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            // 
            // clbCurrentCustomerList
            // 
            this.clbCurrentCustomerList.FormattingEnabled = true;
            this.clbCurrentCustomerList.Location = new System.Drawing.Point(516, 31);
            this.clbCurrentCustomerList.Name = "clbCurrentCustomerList";
            this.clbCurrentCustomerList.Size = new System.Drawing.Size(427, 154);
            this.clbCurrentCustomerList.TabIndex = 27;
            // 
            // AddReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.clbCurrentCustomerList);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.lblFreeRooms);
            this.Controls.Add(this.comboboxFreeRooms);
            this.Controls.Add(this.lblNudPersons);
            this.Controls.Add(this.nudPersons);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.lblSelectedEndDate);
            this.Controls.Add(this.lblSelectedStartDate);
            this.Controls.Add(this.groupBoxCustomerInfo);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.CalendarEndDate);
            this.Controls.Add(this.CalendarStartDate);
            this.Name = "AddReservations";
            this.Text = "Reservations";
            this.groupBoxCustomerInfo.ResumeLayout(false);
            this.groupBoxCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar CalendarStartDate;
        private System.Windows.Forms.MonthCalendar CalendarEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.TextBox tbMobileNr;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.GroupBox groupBoxCustomerInfo;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblSelectedStartDate;
        private System.Windows.Forms.Label lblSelectedEndDate;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Label lblFreeRooms;
        private System.Windows.Forms.ComboBox comboboxFreeRooms;
        private System.Windows.Forms.Label lblNudPersons;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.NumericUpDown nudPersons;
        private System.Windows.Forms.CheckedListBox clbCurrentCustomerList;
    }
}