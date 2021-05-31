using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace TBDAgency
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        private void procedure(string str)
        {
            SqlCommand command = new SqlCommand(str, sqlConnection);
            if (command.ExecuteNonQuery().ToString() == "-1")
                MessageBox.Show("Ошибка");
            else
                MessageBox.Show("Успешно");
            command.Dispose();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AgencyDB"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
                MessageBox.Show("Connected");
        }

       // private void newPosBtn_Click(object sender, EventArgs e)
       // {
       //     procedure($"EXECUTE pPositions @Name = N'{posNameTb.Text}', @Salary = '{posSalaryTb.Text}';");
       // }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            procedure($"EXECUTE pCustomer @FIO = N'{customerFIOTb.Text}', @Passport = '{customerPassportTb.Text}'," +
                $"@Address = N'{customerAddressTb.Text}',@PhoneNumber = '{customerPNTb.Text}',@Email = '{customerEmailTb.Text}', " +
                $"@Birthdate = '{customerBDTb.Text}';");
        }

        private void emplPosCb_DropDown(object sender, EventArgs e)
        {
            string query = "select Name, ID from Positions";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Position");
            emplPosCb.DisplayMember = "Name";
            emplPosCb.ValueMember = "ID";
            emplPosCb.DataSource = ds.Tables["Position"];
            //string x = emplPosCb.;
        }

        private void newEmplBtn_Click(object sender, EventArgs e)
        {
            DataRowView drv = emplPosCb.SelectedItem as DataRowView;

            procedure($"EXECUTE pEmployee @FIO = N'{employeeFIOTb.Text}',@Position = '{drv.Row["ID"].ToString()}',@DateAccepted = '{emplDateTb.Text}';");
        }

        private void propTypeCb_DropDown(object sender, EventArgs e)
        {
            string query = "select Name, ID from PropertyType";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "PropType");
            propTypeCb.DisplayMember = "Name";
            propTypeCb.ValueMember = "ID";
            propTypeCb.DataSource = ds.Tables["PropType"];
        }

        private void propOwnerCb_DropDown(object sender, EventArgs e)
        {
            string query = "select FIO, ID from Owner";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "PropOwner");
            propOwnerCb.DisplayMember = "FIO";
            propOwnerCb.ValueMember = "ID";
            var newR = ds.Tables[0].NewRow();
            newR[0] = "";
            ds.Tables[0].Rows.InsertAt(newR,0);
            propOwnerCb.DataSource = ds.Tables["PropOwner"];
            //propOwnerCb.Items.Add("");
        }

        private void prophouseTypeCb_DropDown(object sender, EventArgs e)
        {
            string query = "select Name, ID from HouseType";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "HouseType");
            prophouseTypeCb.DisplayMember = "Name";
            prophouseTypeCb.ValueMember = "ID";
            prophouseTypeCb.DataSource = ds.Tables["HouseType"];
        }

        private void propDistrictCb_DropDown(object sender, EventArgs e)
        {
            string query = "select Name, ID from Districts";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "PropDistrict");
            propDistrictCb.DisplayMember = "Name";
            propDistrictCb.ValueMember = "ID";
            propDistrictCb.DataSource = ds.Tables["PropDistrict"];
        }

        private void addNewPropBtn_Click(object sender, EventArgs e)
        {
            DataRowView drv = propTypeCb.SelectedItem as DataRowView;
            DataRowView drv1 = propOwnerCb.SelectedItem as DataRowView;
            DataRowView drv2 = prophouseTypeCb.SelectedItem as DataRowView;
            DataRowView drv3 = propDistrictCb.SelectedItem as DataRowView;
            if (drv1 == null || propOwnerCb.Text=="")
            {
                procedure($"EXECUTE pNewProperty @Price = '{propPriceTb.Text}',@PropertyType = '{drv.Row["ID"].ToString()}'," +
                $"@HouseType = '{drv2.Row["ID"].ToString()}',@Rooms = '{propRoomsTb.Text}'," +
                $"@Area = '{propAreaTb.Text}',@Floor = '{propFloorTb.Text}',@Address = N'{propAddressTb.Text}',@District = '{drv3.Row["ID"].ToString()}';");
            }
            else
                procedure($"EXECUTE pNewProperty @Price = '{propPriceTb.Text}',@PropertyType = '{drv.Row["ID"].ToString()}'," +
                $"@Owner = '{drv1.Row["ID"].ToString()}',@HouseType = '{drv2.Row["ID"].ToString()}',@Rooms = '{propRoomsTb.Text}'," +
                $"@Area = '{propAreaTb.Text}',@Floor = '{propFloorTb.Text}',@Address = N'{propAddressTb.Text}',@District = '{drv3.Row["ID"].ToString()}';");
        }

        private void employeeViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vEmployees";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void houseTypeViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vHouseType";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void propertyViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vPropertyType";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void citiesViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vCities";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void districtsViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vDistricts";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void positionsViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vPositions";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void customerViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vCustomer";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ownerViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vOwner";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void housingFundViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vHousingFund";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void transactionViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vTransactionType";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void cardViewBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vCard";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void cardEmployeeCb_DropDown(object sender, EventArgs e)
        {
            string query = "select FIO, ID from Employees";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "CardEmployees");
            cardEmployeeCb.DisplayMember = "FIO";
            cardEmployeeCb.ValueMember = "ID";
            cardEmployeeCb.DataSource = ds.Tables["CardEmployees"];
        }

        private void cardCustomerCb_DropDown(object sender, EventArgs e)
        {
            string query = "select FIO, ID from Customer";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "CardCustomer");
            cardCustomerCb.DisplayMember = "FIO";
            cardCustomerCb.ValueMember = "ID";
            cardCustomerCb.DataSource = ds.Tables["CardCustomer"];
        }

        private void cardPropertyCb_DropDown(object sender, EventArgs e)
        {
            string query = "select ID from HousingFund";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "CardProperty");
            cardPropertyCb.DisplayMember = "ID";
            cardPropertyCb.ValueMember = "ID";
            cardPropertyCb.DataSource = ds.Tables["CardProperty"];
        }

        private void cardTransactionTypeCb_DropDown(object sender, EventArgs e)
        {
            string query = "select Name,ID from TransactionType";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "CardTransaction");
            cardTransactionTypeCb.DisplayMember = "NAME";
            cardTransactionTypeCb.ValueMember = "ID";
            cardTransactionTypeCb.DataSource = ds.Tables["CardTransaction"];
        }

        private void addNewCardBtn_Click(object sender, EventArgs e)
        {
            DataRowView drv = cardEmployeeCb.SelectedItem as DataRowView;
            DataRowView drv1 = cardCustomerCb.SelectedItem as DataRowView;
            DataRowView drv2 = cardPropertyCb.SelectedItem as DataRowView;
            DataRowView drv3 = cardTransactionTypeCb.SelectedItem as DataRowView;
            procedure($"EXECUTE pCard @Date = '{cardDateTb.Text}',@Employee = '{drv.Row["ID"].ToString()}'," +
            $"@Customer = '{drv1.Row["ID"].ToString()}',@Property = '{drv2.Row["ID"].ToString()}',@TransactionTypeID = '{drv3.Row["ID"].ToString()}';");
        }

        private void PropOwnersBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from vPropOwners";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
