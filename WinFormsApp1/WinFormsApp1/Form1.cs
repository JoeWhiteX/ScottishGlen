using System.Management;


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



        }







        private void AddAsset_Click(object sender, EventArgs e)
        {

        }


        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
