
namespace TBDAgency
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tables = new System.Windows.Forms.TabPage();
            this.cardViewBtn = new System.Windows.Forms.Button();
            this.transactionViewBtn = new System.Windows.Forms.Button();
            this.housingFundViewBtn = new System.Windows.Forms.Button();
            this.ownerViewBtn = new System.Windows.Forms.Button();
            this.customerViewBtn = new System.Windows.Forms.Button();
            this.positionsViewBtn = new System.Windows.Forms.Button();
            this.districtsViewBtn = new System.Windows.Forms.Button();
            this.citiesViewBtn = new System.Windows.Forms.Button();
            this.propertyViewBtn = new System.Windows.Forms.Button();
            this.houseTypeViewBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeViewBtn = new System.Windows.Forms.Button();
            this.adding = new System.Windows.Forms.TabPage();
            this.propertyTB = new System.Windows.Forms.GroupBox();
            this.propDistrictCb = new System.Windows.Forms.ComboBox();
            this.propDistrictLbl = new System.Windows.Forms.Label();
            this.propAddressLbl = new System.Windows.Forms.Label();
            this.propAddressTb = new System.Windows.Forms.TextBox();
            this.propFloorLbl = new System.Windows.Forms.Label();
            this.propFloorTb = new System.Windows.Forms.TextBox();
            this.prophouseTypeCb = new System.Windows.Forms.ComboBox();
            this.propOwnerCb = new System.Windows.Forms.ComboBox();
            this.propTypeCb = new System.Windows.Forms.ComboBox();
            this.propAreaLbl = new System.Windows.Forms.Label();
            this.propAreaTb = new System.Windows.Forms.TextBox();
            this.propRoomsLbl = new System.Windows.Forms.Label();
            this.propRoomsTb = new System.Windows.Forms.TextBox();
            this.houseTypeLbl = new System.Windows.Forms.Label();
            this.propOwnerLbl = new System.Windows.Forms.Label();
            this.addNewPropBtn = new System.Windows.Forms.Button();
            this.propTypelbl = new System.Windows.Forms.Label();
            this.propPriceLbl = new System.Windows.Forms.Label();
            this.propPriceTb = new System.Windows.Forms.TextBox();
            this.newEmplGb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emplDateTb = new System.Windows.Forms.TextBox();
            this.emplPosCb = new System.Windows.Forms.ComboBox();
            this.newEmplBtn = new System.Windows.Forms.Button();
            this.emplPosLbl = new System.Windows.Forms.Label();
            this.employeeFIOLbl = new System.Windows.Forms.Label();
            this.employeeFIOTb = new System.Windows.Forms.TextBox();
            this.customerGb = new System.Windows.Forms.GroupBox();
            this.customerBDlbl = new System.Windows.Forms.Label();
            this.customerBDTb = new System.Windows.Forms.TextBox();
            this.customerEmailLbl = new System.Windows.Forms.Label();
            this.customerEmailTb = new System.Windows.Forms.TextBox();
            this.customerPNlbl = new System.Windows.Forms.Label();
            this.customerPNTb = new System.Windows.Forms.TextBox();
            this.customerAddresslbl = new System.Windows.Forms.Label();
            this.customerAddressTb = new System.Windows.Forms.TextBox();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.customerPassportLbl = new System.Windows.Forms.Label();
            this.customerPassportTb = new System.Windows.Forms.TextBox();
            this.customerFiolbl = new System.Windows.Forms.Label();
            this.customerFIOTb = new System.Windows.Forms.TextBox();
            this.newTransactionGb = new System.Windows.Forms.GroupBox();
            this.cardTranscationTypeLbl = new System.Windows.Forms.Label();
            this.cardPropertyLbl = new System.Windows.Forms.Label();
            this.cardCustomerLbl = new System.Windows.Forms.Label();
            this.addNewCardBtn = new System.Windows.Forms.Button();
            this.cardEmployeeLbl = new System.Windows.Forms.Label();
            this.cardDateLbl = new System.Windows.Forms.Label();
            this.cardDateTb = new System.Windows.Forms.TextBox();
            this.cardEmployeeCb = new System.Windows.Forms.ComboBox();
            this.cardCustomerCb = new System.Windows.Forms.ComboBox();
            this.cardPropertyCb = new System.Windows.Forms.ComboBox();
            this.cardTransactionTypeCb = new System.Windows.Forms.ComboBox();
            this.PropOwnersBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.adding.SuspendLayout();
            this.propertyTB.SuspendLayout();
            this.newEmplGb.SuspendLayout();
            this.customerGb.SuspendLayout();
            this.newTransactionGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tables);
            this.tabControl1.Controls.Add(this.adding);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tables
            // 
            this.tables.BackColor = System.Drawing.Color.LightGray;
            this.tables.Controls.Add(this.PropOwnersBtn);
            this.tables.Controls.Add(this.cardViewBtn);
            this.tables.Controls.Add(this.transactionViewBtn);
            this.tables.Controls.Add(this.housingFundViewBtn);
            this.tables.Controls.Add(this.ownerViewBtn);
            this.tables.Controls.Add(this.customerViewBtn);
            this.tables.Controls.Add(this.positionsViewBtn);
            this.tables.Controls.Add(this.districtsViewBtn);
            this.tables.Controls.Add(this.citiesViewBtn);
            this.tables.Controls.Add(this.propertyViewBtn);
            this.tables.Controls.Add(this.houseTypeViewBtn);
            this.tables.Controls.Add(this.dataGridView1);
            this.tables.Controls.Add(this.employeeViewBtn);
            this.tables.Location = new System.Drawing.Point(4, 22);
            this.tables.Name = "tables";
            this.tables.Padding = new System.Windows.Forms.Padding(3);
            this.tables.Size = new System.Drawing.Size(931, 384);
            this.tables.TabIndex = 0;
            this.tables.Text = "Таблицы";
            // 
            // cardViewBtn
            // 
            this.cardViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cardViewBtn.Location = new System.Drawing.Point(759, 315);
            this.cardViewBtn.Name = "cardViewBtn";
            this.cardViewBtn.Size = new System.Drawing.Size(61, 43);
            this.cardViewBtn.TabIndex = 11;
            this.cardViewBtn.Text = "Карточки";
            this.cardViewBtn.UseVisualStyleBackColor = true;
            this.cardViewBtn.Click += new System.EventHandler(this.cardViewBtn_Click);
            // 
            // transactionViewBtn
            // 
            this.transactionViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.transactionViewBtn.Location = new System.Drawing.Point(682, 315);
            this.transactionViewBtn.Name = "transactionViewBtn";
            this.transactionViewBtn.Size = new System.Drawing.Size(74, 43);
            this.transactionViewBtn.TabIndex = 10;
            this.transactionViewBtn.Text = "Типы сделки";
            this.transactionViewBtn.UseVisualStyleBackColor = true;
            this.transactionViewBtn.Click += new System.EventHandler(this.transactionViewBtn_Click);
            // 
            // housingFundViewBtn
            // 
            this.housingFundViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.housingFundViewBtn.Location = new System.Drawing.Point(605, 315);
            this.housingFundViewBtn.Name = "housingFundViewBtn";
            this.housingFundViewBtn.Size = new System.Drawing.Size(74, 43);
            this.housingFundViewBtn.TabIndex = 9;
            this.housingFundViewBtn.Text = "Жилищный Фонд";
            this.housingFundViewBtn.UseVisualStyleBackColor = true;
            this.housingFundViewBtn.Click += new System.EventHandler(this.housingFundViewBtn_Click);
            // 
            // ownerViewBtn
            // 
            this.ownerViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ownerViewBtn.Location = new System.Drawing.Point(526, 315);
            this.ownerViewBtn.Name = "ownerViewBtn";
            this.ownerViewBtn.Size = new System.Drawing.Size(73, 43);
            this.ownerViewBtn.TabIndex = 8;
            this.ownerViewBtn.Text = "Владельцы";
            this.ownerViewBtn.UseVisualStyleBackColor = true;
            this.ownerViewBtn.Click += new System.EventHandler(this.ownerViewBtn_Click);
            // 
            // customerViewBtn
            // 
            this.customerViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customerViewBtn.Location = new System.Drawing.Point(461, 315);
            this.customerViewBtn.Name = "customerViewBtn";
            this.customerViewBtn.Size = new System.Drawing.Size(59, 43);
            this.customerViewBtn.TabIndex = 7;
            this.customerViewBtn.Text = "Клиенты";
            this.customerViewBtn.UseVisualStyleBackColor = true;
            this.customerViewBtn.Click += new System.EventHandler(this.customerViewBtn_Click);
            // 
            // positionsViewBtn
            // 
            this.positionsViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.positionsViewBtn.Location = new System.Drawing.Point(377, 315);
            this.positionsViewBtn.Name = "positionsViewBtn";
            this.positionsViewBtn.Size = new System.Drawing.Size(78, 43);
            this.positionsViewBtn.TabIndex = 6;
            this.positionsViewBtn.Text = "Должности";
            this.positionsViewBtn.UseVisualStyleBackColor = true;
            this.positionsViewBtn.Click += new System.EventHandler(this.positionsViewBtn_Click);
            // 
            // districtsViewBtn
            // 
            this.districtsViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.districtsViewBtn.Location = new System.Drawing.Point(315, 315);
            this.districtsViewBtn.Name = "districtsViewBtn";
            this.districtsViewBtn.Size = new System.Drawing.Size(56, 43);
            this.districtsViewBtn.TabIndex = 5;
            this.districtsViewBtn.Text = "Районы";
            this.districtsViewBtn.UseVisualStyleBackColor = true;
            this.districtsViewBtn.Click += new System.EventHandler(this.districtsViewBtn_Click);
            // 
            // citiesViewBtn
            // 
            this.citiesViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.citiesViewBtn.Location = new System.Drawing.Point(256, 315);
            this.citiesViewBtn.Name = "citiesViewBtn";
            this.citiesViewBtn.Size = new System.Drawing.Size(53, 43);
            this.citiesViewBtn.TabIndex = 4;
            this.citiesViewBtn.Text = "Города";
            this.citiesViewBtn.UseVisualStyleBackColor = true;
            this.citiesViewBtn.Click += new System.EventHandler(this.citiesViewBtn_Click);
            // 
            // propertyViewBtn
            // 
            this.propertyViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyViewBtn.Location = new System.Drawing.Point(172, 315);
            this.propertyViewBtn.Name = "propertyViewBtn";
            this.propertyViewBtn.Size = new System.Drawing.Size(78, 43);
            this.propertyViewBtn.TabIndex = 3;
            this.propertyViewBtn.Text = "Типы недвижимости";
            this.propertyViewBtn.UseVisualStyleBackColor = true;
            this.propertyViewBtn.Click += new System.EventHandler(this.propertyViewBtn_Click);
            // 
            // houseTypeViewBtn
            // 
            this.houseTypeViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.houseTypeViewBtn.Location = new System.Drawing.Point(88, 315);
            this.houseTypeViewBtn.Name = "houseTypeViewBtn";
            this.houseTypeViewBtn.Size = new System.Drawing.Size(78, 43);
            this.houseTypeViewBtn.TabIndex = 2;
            this.houseTypeViewBtn.Text = "Типы домов";
            this.houseTypeViewBtn.UseVisualStyleBackColor = true;
            this.houseTypeViewBtn.Click += new System.EventHandler(this.houseTypeViewBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(914, 302);
            this.dataGridView1.TabIndex = 1;
            // 
            // employeeViewBtn
            // 
            this.employeeViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeeViewBtn.Location = new System.Drawing.Point(6, 315);
            this.employeeViewBtn.Name = "employeeViewBtn";
            this.employeeViewBtn.Size = new System.Drawing.Size(76, 43);
            this.employeeViewBtn.TabIndex = 0;
            this.employeeViewBtn.Text = "Сотрудники";
            this.employeeViewBtn.UseVisualStyleBackColor = true;
            this.employeeViewBtn.Click += new System.EventHandler(this.employeeViewBtn_Click);
            // 
            // adding
            // 
            this.adding.BackColor = System.Drawing.Color.Cornsilk;
            this.adding.Controls.Add(this.newTransactionGb);
            this.adding.Controls.Add(this.propertyTB);
            this.adding.Controls.Add(this.newEmplGb);
            this.adding.Controls.Add(this.customerGb);
            this.adding.Location = new System.Drawing.Point(4, 22);
            this.adding.Name = "adding";
            this.adding.Padding = new System.Windows.Forms.Padding(3);
            this.adding.Size = new System.Drawing.Size(931, 384);
            this.adding.TabIndex = 1;
            this.adding.Text = "Добавление";
            // 
            // propertyTB
            // 
            this.propertyTB.Controls.Add(this.propDistrictCb);
            this.propertyTB.Controls.Add(this.propDistrictLbl);
            this.propertyTB.Controls.Add(this.propAddressLbl);
            this.propertyTB.Controls.Add(this.propAddressTb);
            this.propertyTB.Controls.Add(this.propFloorLbl);
            this.propertyTB.Controls.Add(this.propFloorTb);
            this.propertyTB.Controls.Add(this.prophouseTypeCb);
            this.propertyTB.Controls.Add(this.propOwnerCb);
            this.propertyTB.Controls.Add(this.propTypeCb);
            this.propertyTB.Controls.Add(this.propAreaLbl);
            this.propertyTB.Controls.Add(this.propAreaTb);
            this.propertyTB.Controls.Add(this.propRoomsLbl);
            this.propertyTB.Controls.Add(this.propRoomsTb);
            this.propertyTB.Controls.Add(this.houseTypeLbl);
            this.propertyTB.Controls.Add(this.propOwnerLbl);
            this.propertyTB.Controls.Add(this.addNewPropBtn);
            this.propertyTB.Controls.Add(this.propTypelbl);
            this.propertyTB.Controls.Add(this.propPriceLbl);
            this.propertyTB.Controls.Add(this.propPriceTb);
            this.propertyTB.Location = new System.Drawing.Point(8, 11);
            this.propertyTB.Name = "propertyTB";
            this.propertyTB.Size = new System.Drawing.Size(223, 357);
            this.propertyTB.TabIndex = 7;
            this.propertyTB.TabStop = false;
            this.propertyTB.Text = "Новая недвижимость";
            // 
            // propDistrictCb
            // 
            this.propDistrictCb.FormattingEnabled = true;
            this.propDistrictCb.Location = new System.Drawing.Point(7, 293);
            this.propDistrictCb.Name = "propDistrictCb";
            this.propDistrictCb.Size = new System.Drawing.Size(100, 21);
            this.propDistrictCb.TabIndex = 21;
            this.propDistrictCb.DropDown += new System.EventHandler(this.propDistrictCb_DropDown);
            // 
            // propDistrictLbl
            // 
            this.propDistrictLbl.AutoSize = true;
            this.propDistrictLbl.Location = new System.Drawing.Point(113, 296);
            this.propDistrictLbl.Name = "propDistrictLbl";
            this.propDistrictLbl.Size = new System.Drawing.Size(38, 13);
            this.propDistrictLbl.TabIndex = 20;
            this.propDistrictLbl.Text = "Район";
            // 
            // propAddressLbl
            // 
            this.propAddressLbl.AutoSize = true;
            this.propAddressLbl.Location = new System.Drawing.Point(113, 264);
            this.propAddressLbl.Name = "propAddressLbl";
            this.propAddressLbl.Size = new System.Drawing.Size(38, 13);
            this.propAddressLbl.TabIndex = 19;
            this.propAddressLbl.Text = "Адрес";
            // 
            // propAddressTb
            // 
            this.propAddressTb.Location = new System.Drawing.Point(7, 261);
            this.propAddressTb.Name = "propAddressTb";
            this.propAddressTb.Size = new System.Drawing.Size(100, 20);
            this.propAddressTb.TabIndex = 18;
            // 
            // propFloorLbl
            // 
            this.propFloorLbl.AutoSize = true;
            this.propFloorLbl.Location = new System.Drawing.Point(113, 233);
            this.propFloorLbl.Name = "propFloorLbl";
            this.propFloorLbl.Size = new System.Drawing.Size(33, 13);
            this.propFloorLbl.TabIndex = 17;
            this.propFloorLbl.Text = "Этаж";
            // 
            // propFloorTb
            // 
            this.propFloorTb.Location = new System.Drawing.Point(7, 230);
            this.propFloorTb.Name = "propFloorTb";
            this.propFloorTb.Size = new System.Drawing.Size(100, 20);
            this.propFloorTb.TabIndex = 16;
            // 
            // prophouseTypeCb
            // 
            this.prophouseTypeCb.FormattingEnabled = true;
            this.prophouseTypeCb.Location = new System.Drawing.Point(7, 126);
            this.prophouseTypeCb.Name = "prophouseTypeCb";
            this.prophouseTypeCb.Size = new System.Drawing.Size(100, 21);
            this.prophouseTypeCb.TabIndex = 15;
            this.prophouseTypeCb.DropDown += new System.EventHandler(this.prophouseTypeCb_DropDown);
            // 
            // propOwnerCb
            // 
            this.propOwnerCb.FormattingEnabled = true;
            this.propOwnerCb.Location = new System.Drawing.Point(7, 91);
            this.propOwnerCb.Name = "propOwnerCb";
            this.propOwnerCb.Size = new System.Drawing.Size(100, 21);
            this.propOwnerCb.TabIndex = 14;
            this.propOwnerCb.DropDown += new System.EventHandler(this.propOwnerCb_DropDown);
            // 
            // propTypeCb
            // 
            this.propTypeCb.FormattingEnabled = true;
            this.propTypeCb.Location = new System.Drawing.Point(7, 56);
            this.propTypeCb.Name = "propTypeCb";
            this.propTypeCb.Size = new System.Drawing.Size(100, 21);
            this.propTypeCb.TabIndex = 13;
            this.propTypeCb.DropDown += new System.EventHandler(this.propTypeCb_DropDown);
            // 
            // propAreaLbl
            // 
            this.propAreaLbl.AutoSize = true;
            this.propAreaLbl.Location = new System.Drawing.Point(113, 200);
            this.propAreaLbl.Name = "propAreaLbl";
            this.propAreaLbl.Size = new System.Drawing.Size(54, 13);
            this.propAreaLbl.TabIndex = 12;
            this.propAreaLbl.Text = "Площадь";
            // 
            // propAreaTb
            // 
            this.propAreaTb.Location = new System.Drawing.Point(7, 197);
            this.propAreaTb.Name = "propAreaTb";
            this.propAreaTb.Size = new System.Drawing.Size(100, 20);
            this.propAreaTb.TabIndex = 11;
            // 
            // propRoomsLbl
            // 
            this.propRoomsLbl.AutoSize = true;
            this.propRoomsLbl.Location = new System.Drawing.Point(113, 164);
            this.propRoomsLbl.Name = "propRoomsLbl";
            this.propRoomsLbl.Size = new System.Drawing.Size(79, 13);
            this.propRoomsLbl.TabIndex = 10;
            this.propRoomsLbl.Text = "Число комнат";
            // 
            // propRoomsTb
            // 
            this.propRoomsTb.Location = new System.Drawing.Point(7, 161);
            this.propRoomsTb.Name = "propRoomsTb";
            this.propRoomsTb.Size = new System.Drawing.Size(100, 20);
            this.propRoomsTb.TabIndex = 9;
            // 
            // houseTypeLbl
            // 
            this.houseTypeLbl.AutoSize = true;
            this.houseTypeLbl.Location = new System.Drawing.Point(113, 129);
            this.houseTypeLbl.Name = "houseTypeLbl";
            this.houseTypeLbl.Size = new System.Drawing.Size(55, 13);
            this.houseTypeLbl.TabIndex = 8;
            this.houseTypeLbl.Text = "Тип дома";
            // 
            // propOwnerLbl
            // 
            this.propOwnerLbl.AutoSize = true;
            this.propOwnerLbl.Location = new System.Drawing.Point(113, 94);
            this.propOwnerLbl.Name = "propOwnerLbl";
            this.propOwnerLbl.Size = new System.Drawing.Size(56, 13);
            this.propOwnerLbl.TabIndex = 6;
            this.propOwnerLbl.Text = "Владелец";
            // 
            // addNewPropBtn
            // 
            this.addNewPropBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addNewPropBtn.Location = new System.Drawing.Point(3, 331);
            this.addNewPropBtn.Name = "addNewPropBtn";
            this.addNewPropBtn.Size = new System.Drawing.Size(217, 23);
            this.addNewPropBtn.TabIndex = 4;
            this.addNewPropBtn.Text = "Добавить";
            this.addNewPropBtn.UseVisualStyleBackColor = true;
            this.addNewPropBtn.Click += new System.EventHandler(this.addNewPropBtn_Click);
            // 
            // propTypelbl
            // 
            this.propTypelbl.AutoSize = true;
            this.propTypelbl.Location = new System.Drawing.Point(113, 59);
            this.propTypelbl.Name = "propTypelbl";
            this.propTypelbl.Size = new System.Drawing.Size(104, 13);
            this.propTypelbl.TabIndex = 3;
            this.propTypelbl.Text = "Тип недвижимости";
            // 
            // propPriceLbl
            // 
            this.propPriceLbl.AutoSize = true;
            this.propPriceLbl.Location = new System.Drawing.Point(113, 23);
            this.propPriceLbl.Name = "propPriceLbl";
            this.propPriceLbl.Size = new System.Drawing.Size(33, 13);
            this.propPriceLbl.TabIndex = 1;
            this.propPriceLbl.Text = "Цена";
            // 
            // propPriceTb
            // 
            this.propPriceTb.Location = new System.Drawing.Point(7, 20);
            this.propPriceTb.Name = "propPriceTb";
            this.propPriceTb.Size = new System.Drawing.Size(100, 20);
            this.propPriceTb.TabIndex = 0;
            // 
            // newEmplGb
            // 
            this.newEmplGb.Controls.Add(this.label1);
            this.newEmplGb.Controls.Add(this.emplDateTb);
            this.newEmplGb.Controls.Add(this.emplPosCb);
            this.newEmplGb.Controls.Add(this.newEmplBtn);
            this.newEmplGb.Controls.Add(this.emplPosLbl);
            this.newEmplGb.Controls.Add(this.employeeFIOLbl);
            this.newEmplGb.Controls.Add(this.employeeFIOTb);
            this.newEmplGb.Location = new System.Drawing.Point(716, 231);
            this.newEmplGb.Name = "newEmplGb";
            this.newEmplGb.Size = new System.Drawing.Size(189, 137);
            this.newEmplGb.TabIndex = 5;
            this.newEmplGb.TabStop = false;
            this.newEmplGb.Text = "Новый сотрудник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата приема";
            // 
            // emplDateTb
            // 
            this.emplDateTb.Location = new System.Drawing.Point(7, 84);
            this.emplDateTb.Name = "emplDateTb";
            this.emplDateTb.Size = new System.Drawing.Size(100, 20);
            this.emplDateTb.TabIndex = 6;
            // 
            // emplPosCb
            // 
            this.emplPosCb.FormattingEnabled = true;
            this.emplPosCb.Location = new System.Drawing.Point(7, 55);
            this.emplPosCb.Name = "emplPosCb";
            this.emplPosCb.Size = new System.Drawing.Size(100, 21);
            this.emplPosCb.TabIndex = 5;
            this.emplPosCb.DropDown += new System.EventHandler(this.emplPosCb_DropDown);
            // 
            // newEmplBtn
            // 
            this.newEmplBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newEmplBtn.Location = new System.Drawing.Point(3, 111);
            this.newEmplBtn.Name = "newEmplBtn";
            this.newEmplBtn.Size = new System.Drawing.Size(183, 23);
            this.newEmplBtn.TabIndex = 4;
            this.newEmplBtn.Text = "Добавить";
            this.newEmplBtn.UseVisualStyleBackColor = true;
            this.newEmplBtn.Click += new System.EventHandler(this.newEmplBtn_Click);
            // 
            // emplPosLbl
            // 
            this.emplPosLbl.AutoSize = true;
            this.emplPosLbl.Location = new System.Drawing.Point(113, 59);
            this.emplPosLbl.Name = "emplPosLbl";
            this.emplPosLbl.Size = new System.Drawing.Size(65, 13);
            this.emplPosLbl.TabIndex = 3;
            this.emplPosLbl.Text = "Должность";
            // 
            // employeeFIOLbl
            // 
            this.employeeFIOLbl.AutoSize = true;
            this.employeeFIOLbl.Location = new System.Drawing.Point(113, 23);
            this.employeeFIOLbl.Name = "employeeFIOLbl";
            this.employeeFIOLbl.Size = new System.Drawing.Size(34, 13);
            this.employeeFIOLbl.TabIndex = 1;
            this.employeeFIOLbl.Text = "ФИО";
            // 
            // employeeFIOTb
            // 
            this.employeeFIOTb.Location = new System.Drawing.Point(7, 20);
            this.employeeFIOTb.Name = "employeeFIOTb";
            this.employeeFIOTb.Size = new System.Drawing.Size(100, 20);
            this.employeeFIOTb.TabIndex = 0;
            // 
            // customerGb
            // 
            this.customerGb.Controls.Add(this.customerBDlbl);
            this.customerGb.Controls.Add(this.customerBDTb);
            this.customerGb.Controls.Add(this.customerEmailLbl);
            this.customerGb.Controls.Add(this.customerEmailTb);
            this.customerGb.Controls.Add(this.customerPNlbl);
            this.customerGb.Controls.Add(this.customerPNTb);
            this.customerGb.Controls.Add(this.customerAddresslbl);
            this.customerGb.Controls.Add(this.customerAddressTb);
            this.customerGb.Controls.Add(this.addCustomerBtn);
            this.customerGb.Controls.Add(this.customerPassportLbl);
            this.customerGb.Controls.Add(this.customerPassportTb);
            this.customerGb.Controls.Add(this.customerFiolbl);
            this.customerGb.Controls.Add(this.customerFIOTb);
            this.customerGb.Location = new System.Drawing.Point(257, 117);
            this.customerGb.Name = "customerGb";
            this.customerGb.Size = new System.Drawing.Size(203, 251);
            this.customerGb.TabIndex = 1;
            this.customerGb.TabStop = false;
            this.customerGb.Text = "Новый клиент";
            // 
            // customerBDlbl
            // 
            this.customerBDlbl.AutoSize = true;
            this.customerBDlbl.Location = new System.Drawing.Point(113, 200);
            this.customerBDlbl.Name = "customerBDlbl";
            this.customerBDlbl.Size = new System.Drawing.Size(86, 13);
            this.customerBDlbl.TabIndex = 12;
            this.customerBDlbl.Text = "Дата рождения";
            // 
            // customerBDTb
            // 
            this.customerBDTb.Location = new System.Drawing.Point(7, 197);
            this.customerBDTb.Name = "customerBDTb";
            this.customerBDTb.Size = new System.Drawing.Size(100, 20);
            this.customerBDTb.TabIndex = 11;
            // 
            // customerEmailLbl
            // 
            this.customerEmailLbl.AutoSize = true;
            this.customerEmailLbl.Location = new System.Drawing.Point(113, 164);
            this.customerEmailLbl.Name = "customerEmailLbl";
            this.customerEmailLbl.Size = new System.Drawing.Size(37, 13);
            this.customerEmailLbl.TabIndex = 10;
            this.customerEmailLbl.Text = "Почта";
            // 
            // customerEmailTb
            // 
            this.customerEmailTb.Location = new System.Drawing.Point(7, 161);
            this.customerEmailTb.Name = "customerEmailTb";
            this.customerEmailTb.Size = new System.Drawing.Size(100, 20);
            this.customerEmailTb.TabIndex = 9;
            // 
            // customerPNlbl
            // 
            this.customerPNlbl.AutoSize = true;
            this.customerPNlbl.Location = new System.Drawing.Point(113, 129);
            this.customerPNlbl.Name = "customerPNlbl";
            this.customerPNlbl.Size = new System.Drawing.Size(52, 13);
            this.customerPNlbl.TabIndex = 8;
            this.customerPNlbl.Text = "Телефон";
            // 
            // customerPNTb
            // 
            this.customerPNTb.Location = new System.Drawing.Point(7, 126);
            this.customerPNTb.MaxLength = 11;
            this.customerPNTb.Name = "customerPNTb";
            this.customerPNTb.Size = new System.Drawing.Size(100, 20);
            this.customerPNTb.TabIndex = 7;
            // 
            // customerAddresslbl
            // 
            this.customerAddresslbl.AutoSize = true;
            this.customerAddresslbl.Location = new System.Drawing.Point(113, 94);
            this.customerAddresslbl.Name = "customerAddresslbl";
            this.customerAddresslbl.Size = new System.Drawing.Size(38, 13);
            this.customerAddresslbl.TabIndex = 6;
            this.customerAddresslbl.Text = "Адрес";
            // 
            // customerAddressTb
            // 
            this.customerAddressTb.Location = new System.Drawing.Point(7, 91);
            this.customerAddressTb.Name = "customerAddressTb";
            this.customerAddressTb.Size = new System.Drawing.Size(100, 20);
            this.customerAddressTb.TabIndex = 5;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addCustomerBtn.Location = new System.Drawing.Point(3, 225);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(197, 23);
            this.addCustomerBtn.TabIndex = 4;
            this.addCustomerBtn.Text = "Добавить";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // customerPassportLbl
            // 
            this.customerPassportLbl.AutoSize = true;
            this.customerPassportLbl.Location = new System.Drawing.Point(113, 59);
            this.customerPassportLbl.Name = "customerPassportLbl";
            this.customerPassportLbl.Size = new System.Drawing.Size(50, 13);
            this.customerPassportLbl.TabIndex = 3;
            this.customerPassportLbl.Text = "Паспорт";
            // 
            // customerPassportTb
            // 
            this.customerPassportTb.Location = new System.Drawing.Point(7, 56);
            this.customerPassportTb.Name = "customerPassportTb";
            this.customerPassportTb.Size = new System.Drawing.Size(100, 20);
            this.customerPassportTb.TabIndex = 2;
            // 
            // customerFiolbl
            // 
            this.customerFiolbl.AutoSize = true;
            this.customerFiolbl.Location = new System.Drawing.Point(113, 23);
            this.customerFiolbl.Name = "customerFiolbl";
            this.customerFiolbl.Size = new System.Drawing.Size(34, 13);
            this.customerFiolbl.TabIndex = 1;
            this.customerFiolbl.Text = "ФИО";
            // 
            // customerFIOTb
            // 
            this.customerFIOTb.Location = new System.Drawing.Point(7, 20);
            this.customerFIOTb.Name = "customerFIOTb";
            this.customerFIOTb.Size = new System.Drawing.Size(100, 20);
            this.customerFIOTb.TabIndex = 0;
            // 
            // newTransactionGb
            // 
            this.newTransactionGb.Controls.Add(this.cardTransactionTypeCb);
            this.newTransactionGb.Controls.Add(this.cardPropertyCb);
            this.newTransactionGb.Controls.Add(this.cardCustomerCb);
            this.newTransactionGb.Controls.Add(this.cardEmployeeCb);
            this.newTransactionGb.Controls.Add(this.cardTranscationTypeLbl);
            this.newTransactionGb.Controls.Add(this.cardPropertyLbl);
            this.newTransactionGb.Controls.Add(this.cardCustomerLbl);
            this.newTransactionGb.Controls.Add(this.addNewCardBtn);
            this.newTransactionGb.Controls.Add(this.cardEmployeeLbl);
            this.newTransactionGb.Controls.Add(this.cardDateLbl);
            this.newTransactionGb.Controls.Add(this.cardDateTb);
            this.newTransactionGb.Location = new System.Drawing.Point(484, 154);
            this.newTransactionGb.Name = "newTransactionGb";
            this.newTransactionGb.Size = new System.Drawing.Size(203, 214);
            this.newTransactionGb.TabIndex = 8;
            this.newTransactionGb.TabStop = false;
            this.newTransactionGb.Text = "Новая сделка";
            // 
            // cardTranscationTypeLbl
            // 
            this.cardTranscationTypeLbl.AutoSize = true;
            this.cardTranscationTypeLbl.Location = new System.Drawing.Point(113, 164);
            this.cardTranscationTypeLbl.Name = "cardTranscationTypeLbl";
            this.cardTranscationTypeLbl.Size = new System.Drawing.Size(65, 13);
            this.cardTranscationTypeLbl.TabIndex = 10;
            this.cardTranscationTypeLbl.Text = "Тип сделки";
            // 
            // cardPropertyLbl
            // 
            this.cardPropertyLbl.AutoSize = true;
            this.cardPropertyLbl.Location = new System.Drawing.Point(113, 129);
            this.cardPropertyLbl.Name = "cardPropertyLbl";
            this.cardPropertyLbl.Size = new System.Drawing.Size(84, 13);
            this.cardPropertyLbl.TabIndex = 8;
            this.cardPropertyLbl.Text = "Недвижимость";
            // 
            // cardCustomerLbl
            // 
            this.cardCustomerLbl.AutoSize = true;
            this.cardCustomerLbl.Location = new System.Drawing.Point(113, 94);
            this.cardCustomerLbl.Name = "cardCustomerLbl";
            this.cardCustomerLbl.Size = new System.Drawing.Size(43, 13);
            this.cardCustomerLbl.TabIndex = 6;
            this.cardCustomerLbl.Text = "Клиент";
            // 
            // addNewCardBtn
            // 
            this.addNewCardBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addNewCardBtn.Location = new System.Drawing.Point(3, 188);
            this.addNewCardBtn.Name = "addNewCardBtn";
            this.addNewCardBtn.Size = new System.Drawing.Size(197, 23);
            this.addNewCardBtn.TabIndex = 4;
            this.addNewCardBtn.Text = "Оформить";
            this.addNewCardBtn.UseVisualStyleBackColor = true;
            this.addNewCardBtn.Click += new System.EventHandler(this.addNewCardBtn_Click);
            // 
            // cardEmployeeLbl
            // 
            this.cardEmployeeLbl.AutoSize = true;
            this.cardEmployeeLbl.Location = new System.Drawing.Point(113, 59);
            this.cardEmployeeLbl.Name = "cardEmployeeLbl";
            this.cardEmployeeLbl.Size = new System.Drawing.Size(60, 13);
            this.cardEmployeeLbl.TabIndex = 3;
            this.cardEmployeeLbl.Text = "Сотрудник";
            // 
            // cardDateLbl
            // 
            this.cardDateLbl.AutoSize = true;
            this.cardDateLbl.Location = new System.Drawing.Point(113, 23);
            this.cardDateLbl.Name = "cardDateLbl";
            this.cardDateLbl.Size = new System.Drawing.Size(33, 13);
            this.cardDateLbl.TabIndex = 1;
            this.cardDateLbl.Text = "Дата";
            // 
            // cardDateTb
            // 
            this.cardDateTb.Location = new System.Drawing.Point(7, 20);
            this.cardDateTb.Name = "cardDateTb";
            this.cardDateTb.Size = new System.Drawing.Size(100, 20);
            this.cardDateTb.TabIndex = 0;
            // 
            // cardEmployeeCb
            // 
            this.cardEmployeeCb.FormattingEnabled = true;
            this.cardEmployeeCb.Location = new System.Drawing.Point(7, 55);
            this.cardEmployeeCb.Name = "cardEmployeeCb";
            this.cardEmployeeCb.Size = new System.Drawing.Size(100, 21);
            this.cardEmployeeCb.TabIndex = 13;
            this.cardEmployeeCb.DropDown += new System.EventHandler(this.cardEmployeeCb_DropDown);
            // 
            // cardCustomerCb
            // 
            this.cardCustomerCb.FormattingEnabled = true;
            this.cardCustomerCb.Location = new System.Drawing.Point(7, 90);
            this.cardCustomerCb.Name = "cardCustomerCb";
            this.cardCustomerCb.Size = new System.Drawing.Size(100, 21);
            this.cardCustomerCb.TabIndex = 14;
            this.cardCustomerCb.DropDown += new System.EventHandler(this.cardCustomerCb_DropDown);
            // 
            // cardPropertyCb
            // 
            this.cardPropertyCb.FormattingEnabled = true;
            this.cardPropertyCb.Location = new System.Drawing.Point(7, 125);
            this.cardPropertyCb.Name = "cardPropertyCb";
            this.cardPropertyCb.Size = new System.Drawing.Size(100, 21);
            this.cardPropertyCb.TabIndex = 15;
            this.cardPropertyCb.DropDown += new System.EventHandler(this.cardPropertyCb_DropDown);
            // 
            // cardTransactionTypeCb
            // 
            this.cardTransactionTypeCb.FormattingEnabled = true;
            this.cardTransactionTypeCb.Location = new System.Drawing.Point(7, 161);
            this.cardTransactionTypeCb.Name = "cardTransactionTypeCb";
            this.cardTransactionTypeCb.Size = new System.Drawing.Size(100, 21);
            this.cardTransactionTypeCb.TabIndex = 16;
            this.cardTransactionTypeCb.DropDown += new System.EventHandler(this.cardTransactionTypeCb_DropDown);
            // 
            // PropOwnersBtn
            // 
            this.PropOwnersBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PropOwnersBtn.Location = new System.Drawing.Point(826, 315);
            this.PropOwnersBtn.Name = "PropOwnersBtn";
            this.PropOwnersBtn.Size = new System.Drawing.Size(61, 43);
            this.PropOwnersBtn.TabIndex = 12;
            this.PropOwnersBtn.Text = "Недвижимость";
            this.PropOwnersBtn.UseVisualStyleBackColor = true;
            this.PropOwnersBtn.Click += new System.EventHandler(this.PropOwnersBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 410);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Агентство недвижимости";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.adding.ResumeLayout(false);
            this.propertyTB.ResumeLayout(false);
            this.propertyTB.PerformLayout();
            this.newEmplGb.ResumeLayout(false);
            this.newEmplGb.PerformLayout();
            this.customerGb.ResumeLayout(false);
            this.customerGb.PerformLayout();
            this.newTransactionGb.ResumeLayout(false);
            this.newTransactionGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tables;
        private System.Windows.Forms.TabPage adding;
        private System.Windows.Forms.GroupBox customerGb;
        private System.Windows.Forms.Label customerBDlbl;
        private System.Windows.Forms.TextBox customerBDTb;
        private System.Windows.Forms.Label customerEmailLbl;
        private System.Windows.Forms.TextBox customerEmailTb;
        private System.Windows.Forms.Label customerPNlbl;
        private System.Windows.Forms.TextBox customerPNTb;
        private System.Windows.Forms.Label customerAddresslbl;
        private System.Windows.Forms.TextBox customerAddressTb;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Label customerPassportLbl;
        private System.Windows.Forms.TextBox customerPassportTb;
        private System.Windows.Forms.Label customerFiolbl;
        private System.Windows.Forms.TextBox customerFIOTb;
        private System.Windows.Forms.GroupBox newEmplGb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emplDateTb;
        private System.Windows.Forms.ComboBox emplPosCb;
        private System.Windows.Forms.Button newEmplBtn;
        private System.Windows.Forms.Label emplPosLbl;
        private System.Windows.Forms.Label employeeFIOLbl;
        private System.Windows.Forms.TextBox employeeFIOTb;
        private System.Windows.Forms.GroupBox propertyTB;
        private System.Windows.Forms.Label propAreaLbl;
        private System.Windows.Forms.TextBox propAreaTb;
        private System.Windows.Forms.Label propRoomsLbl;
        private System.Windows.Forms.TextBox propRoomsTb;
        private System.Windows.Forms.Label houseTypeLbl;
        private System.Windows.Forms.Label propOwnerLbl;
        private System.Windows.Forms.Button addNewPropBtn;
        private System.Windows.Forms.Label propTypelbl;
        private System.Windows.Forms.Label propPriceLbl;
        private System.Windows.Forms.TextBox propPriceTb;
        private System.Windows.Forms.ComboBox propTypeCb;
        private System.Windows.Forms.ComboBox propOwnerCb;
        private System.Windows.Forms.ComboBox prophouseTypeCb;
        private System.Windows.Forms.ComboBox propDistrictCb;
        private System.Windows.Forms.Label propDistrictLbl;
        private System.Windows.Forms.Label propAddressLbl;
        private System.Windows.Forms.TextBox propAddressTb;
        private System.Windows.Forms.Label propFloorLbl;
        private System.Windows.Forms.TextBox propFloorTb;
        private System.Windows.Forms.Button employeeViewBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button houseTypeViewBtn;
        private System.Windows.Forms.Button propertyViewBtn;
        private System.Windows.Forms.Button citiesViewBtn;
        private System.Windows.Forms.Button districtsViewBtn;
        private System.Windows.Forms.Button positionsViewBtn;
        private System.Windows.Forms.Button customerViewBtn;
        private System.Windows.Forms.Button ownerViewBtn;
        private System.Windows.Forms.Button housingFundViewBtn;
        private System.Windows.Forms.Button transactionViewBtn;
        private System.Windows.Forms.Button cardViewBtn;
        private System.Windows.Forms.GroupBox newTransactionGb;
        private System.Windows.Forms.ComboBox cardTransactionTypeCb;
        private System.Windows.Forms.ComboBox cardPropertyCb;
        private System.Windows.Forms.ComboBox cardCustomerCb;
        private System.Windows.Forms.ComboBox cardEmployeeCb;
        private System.Windows.Forms.Label cardTranscationTypeLbl;
        private System.Windows.Forms.Label cardPropertyLbl;
        private System.Windows.Forms.Label cardCustomerLbl;
        private System.Windows.Forms.Button addNewCardBtn;
        private System.Windows.Forms.Label cardEmployeeLbl;
        private System.Windows.Forms.Label cardDateLbl;
        private System.Windows.Forms.TextBox cardDateTb;
        private System.Windows.Forms.Button PropOwnersBtn;
    }
}

