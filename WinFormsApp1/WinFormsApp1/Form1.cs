using Microsoft.Data.SqlClient;
using System.Data;
using System.Management;
using System.Net;
using System.Net.Sockets;



namespace WinFormsApp1



{
    public partial class Form1 : Form
    {
        private object systemType;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getSystemInfo_Click(object sender, EventArgs e)
        {

            //Get system name using Environment class https://learn.microsoft.com/en-us/dotnet/api/system.environment?view=net-9.0
            txtSystemName.Text = Environment.MachineName;


            //Query system info for model, manufacturer, type using WMI class https://learn.microsoft.com/en-us/windows/win32/cimwin32prov/win32-computersystem
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");

            foreach (ManagementObject obj in searcher.Get())
            {
                //Display model and manufacturer details
                txtModel.Text = obj["Model"]?.ToString();
                txtManufacturer.Text = obj["Manufacturer"]?.ToString();

                //Store value for switch case
                systemType = obj["PCSystemType"];

            }


            //Convert systemType to int
            //https://learn.microsoft.com/en-us/dotnet/api/microsoft.powershell.commands.pcsystemtype?view=powershellsdk-7.4.0
            systemType = Convert.ToInt32(systemType);

            //Convert systemType to readable string and display
            switch (systemType)
            {
                case 0:
                    txtType.Text = "Unspecified";
                    break;

                case 1:
                    txtType.Text = "Desktop";
                    break;

                case 2:
                    txtType.Text = "Mobile/Laptop";
                    break;

                case 3:
                    txtType.Text = "Workstation";
                    break;

                case 4:
                    txtType.Text = "EnterpriseServer";
                    break;

                case 5:
                    txtType.Text = "SOHOServer";
                    break;

                case 6:
                    txtType.Text = "AppliancePC";
                    break;

                case 7:
                    txtType.Text = "PerformanceServer";
                    break;

                default:
                    txtType.Text = "Unknown";
                    break;
            }

            GetIPAddress(Dns.GetHostName());

        }




        //IP https://learn.microsoft.com/en-us/dotnet/api/system.net.ipaddress?view=net-9.0
        // https://learn.microsoft.com/en-us/dotnet/api/system.net.dns.gethostaddresses?view=net-9.0#system-net-dns-gethostaddresses(system-string)
        public void GetIPAddress(string hostname)
        {

            //Retrieve all IP addresses
            IPAddress[] addresses = Dns.GetHostAddresses(hostname);


            //Loop through each returned IP address
            foreach (IPAddress address in addresses)

                //Only get IPv4
                if (address.AddressFamily.ToString() == ProtocolFamily.InterNetwork.ToString())
                {
                    //Display IP in textBox
                    txtIPAddress.Text = address.ToString();
                }
        }






        private void AddAsset_Click(object sender, EventArgs e)
        {

            connectDB();
            MessageBox.Show("Asset Added!");


        }

        private void connectDB()
        {
            //Connect to Database
            string connectionString = "Server=tolmount.abertay.ac.uk;Database=mssql2504618;User Id=mssql2504618;Password=9v7QGxugyt;Encrypt=True;TrustServerCertificate=True;";

            //SQL Statement to insert new asset
            string saveAsset = "INSERT into dbo.ScottishGlenDB (SystemName, Model, Manufacturer, Type, IPAddress, PurchaseDate, Notes) VALUES (@SystemName, @Model, @Manufacturer, @Type, @IPAddress, @PurchaseDate, @Notes)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(saveAsset, conn))
                {
                    cmd.Parameters.AddWithValue("@SystemName", txtSystemName.Text);
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text);
                    cmd.Parameters.AddWithValue("@Type", txtType.Text);
                    cmd.Parameters.AddWithValue("@IPAddress", txtIPAddress.Text);
                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);

                    if (DTP.CustomFormat == " ")
                    {
                        cmd.Parameters.AddWithValue("@PurchaseDate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@PurchaseDate", SqlDbType.Date).Value = DTP.Value.Date;
                    }


                    //Open connection and execute
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving asset: {ex.Message}");
                    }
                    

                }
            }
        }


        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void DTP_ValueChanged(object sender, EventArgs e)
        {

            DTP.CustomFormat = "dd MM yyyy";



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all fields in form
            txtSystemName.Clear();
            txtModel.Clear();
            txtManufacturer.Clear();
            txtType.Clear();
            txtIPAddress.Clear();
            txtNotes.Clear();

            //Set Date picker to blank
            DTP.CustomFormat = " ";
        }
    }
}
