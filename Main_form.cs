using System.Data.SqlClient;
using S7.Net;
using S7.Net.Types;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;


namespace EngineNum_match_validator
{
    public partial class Main_form : Form
    {
        Logger my_logger = new Logger();

        Plc PLC_M1 = new Plc(CpuType.S7300, "172.16.1.51", 0, 2); //MY PC IP ADDRESS: 140.100.101.9 
        //Plc PLC_M1 = new Plc(CpuType.S7300, "140.100.101.1", 0, 2); //MY PC IP ADDRESS: 140.100.101.9 
        //Plc PLC_M1 = new Plc(CpuType.S7300, "172.16.30.51", 0, 2); //MY PC IP ADDRESS: 140.100.101.9 

        //Plc PLC_M1 = new Plc(CpuType.S7300, "172.16.30.51", 0, 2);


        System.Windows.Forms.Timer MyTimer = new System.Windows.Forms.Timer();


        string CurrentEngNo = "000";
        string CurrentEngNoCompl = "";
        bool AssemblyRunning = false;

        public List<PLC_DB> PLC_DBs { get; set; }

        public Main_form()
        {
            PLC_DBs = GetData();

            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIsClosing);
            my_logger.Log("Eng_No Opened!");
        }

        public static List<PLC_DB>? GetData()
        {
            var list = new List<PLC_DB>();
            list.Add(new PLC_DB() { DBAdress = "180.0", Content = "1", Type = "ASCII", Purpose = "Heartbit-TMS" });
            list.Add(new PLC_DB() { DBAdress = "180.1", Content = "B", Type = "ASCII", Purpose = "Block or Head" });
            list.Add(new PLC_DB() { DBAdress = "180.2", Content = "0", Type = "ASCII", Purpose = "Read Request" });
            list.Add(new PLC_DB() { DBAdress = "180.5", Content = "0", Type = "ASCII", Purpose = "Work complete" });
            list.Add(new PLC_DB() { DBAdress = "180.6", Content = "1", Type = "ASCII", Purpose = "Work result" });
            list.Add(new PLC_DB() { DBAdress = "180.10", Content = "B", Type = "ASCII", Purpose = "ENGINE NO.01" });
            list.Add(new PLC_DB() { DBAdress = "180.11", Content = "B", Type = "ASCII", Purpose = "ENGINE NO.02" });
            list.Add(new PLC_DB() { DBAdress = "180.12", Content = "4", Type = "ASCII", Purpose = "ENGINE NO.03" });
            list.Add(new PLC_DB() { DBAdress = "180.13", Content = "1", Type = "ASCII", Purpose = "ENGINE NO.04" });
            list.Add(new PLC_DB() { DBAdress = "180.14", Content = "F", Type = "ASCII", Purpose = "ENGINE NO.05" });
            list.Add(new PLC_DB() { DBAdress = "180.15", Content = "3", Type = "ASCII", Purpose = "ENGINE NO.06" });
            list.Add(new PLC_DB() { DBAdress = "180.16", Content = "L", Type = "ASCII", Purpose = "ENGINE NO.07" });
            list.Add(new PLC_DB() { DBAdress = "180.17", Content = "A", Type = "ASCII", Purpose = "ENGINE NO.08" });
            list.Add(new PLC_DB() { DBAdress = "180.18", Content = "P", Type = "ASCII", Purpose = "ENGINE NO.09" });
            list.Add(new PLC_DB() { DBAdress = "180.19", Content = "L", Type = "ASCII", Purpose = "ENGINE NO.10" });
            list.Add(new PLC_DB() { DBAdress = "180.20", Content = "1", Type = "ASCII", Purpose = "ENGINE NO.11" });
            list.Add(new PLC_DB() { DBAdress = "180.21", Content = "1", Type = "ASCII", Purpose = "ENGINE NO.12" });
            list.Add(new PLC_DB() { DBAdress = "180.22", Content = "0", Type = "ASCII", Purpose = "ENGINE NO.13" });
            list.Add(new PLC_DB() { DBAdress = "180.23", Content = "2", Type = "ASCII", Purpose = "ENGINE NO.14" });
            list.Add(new PLC_DB() { DBAdress = "180.24", Content = "9", Type = "ASCII", Purpose = "ENGINE NO.15" });
            list.Add(new PLC_DB() { DBAdress = "180.25", Content = "8", Type = "ASCII", Purpose = "ENGINE NO.16" });
            return list;
        }


        //private string Sql_query(string query)
        //{
        //    string connetionString;
        //    SqlConnection cnn;
        //    connetionString = @"Data Source=127.0.0.1;Initial Catalog=HMB;User ID=sa;Password=T00lsNetPwd; Trusted_Connection=true ";
        //    //connetionString = @"Data Source=172.16.0.1;Initial Catalog=HMB;User ID=sa;Password=T00lsNetPwd";
        //    cnn = new SqlConnection(connetionString);
        //    cnn.Open();
        //    SqlCommand command;
        //    SqlDataReader reader;

        //    command = new SqlCommand(query, cnn);
        //    reader = command.ExecuteReader();

        //    string[] values = new string[6];
        //    //var fieldCount = reader.GetValues(values);


        //    while (reader.Read())
        //    {
        //        values reader.GetValue(1);
        //    }

        //    reader.Close();
        //    command.Dispose();
        //    cnn.Close();

        //    return values;
        //}

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            my_logger.Log("Eng_No app Closed!");
        }




        private void button1_Click(object sender, EventArgs e)
        {

            // string query = "SELECT TOP (3) * FROM [HMB].[SQS].[ENG_BUILD_DATA] ORDER BY ID DESC";

            // string connetionString;
            // SqlConnection cnn;
            //// connetionString = @"Data Source=localhost;Initial Catalog=HMB;User ID=sa;Password=T00lsNetPwd; Trusted_Connection=true";
            // connetionString = @"Data Source=172.16.0.1;Initial Catalog=HMB;User ID=sa;Password=T00lsNetPwd";
            // cnn = new SqlConnection(connetionString);
            // cnn.Open();
            // SqlCommand command;
            // SqlDataReader reader;

            // command = new SqlCommand(query, cnn);
            // reader = command.ExecuteReader();

            // object[] values = new object[51];

            // while (reader.Read())
            // {
            //     reader.GetSqlValues(values);
            // }

            // reader.Close();
            // command.Dispose();
            // cnn.Close();

            // textBox1.Text = values[51].ToString();

            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=172.16.0.1;Initial Catalog=HMB;User ID=sa;Password=T00lsNetPwd";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command;
                SqlDataReader reader;
                string query, Output = "";


                query = "SELECT TOP (3) [ID]" +
                    ",[ENG_CODE]" +
                    ",[ENG_TYPE]" +
                    ",[ENG_SN]" +
                    ",[BLK_NO]" +
                    ",[HEAD_NO]" +
                    " FROM [HMB].[SQS].[ENG_BUILD_DATA]" +
                    "ORDER BY ID DESC";
                //"WHERE ENG_SN = '029563'";

                command = new SqlCommand(query, cnn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Output += reader.GetValue(0) + " - " + reader.GetValue(1) + " - " + reader.GetValue(2) + " - " + reader.GetValue(3) + " - " + reader.GetValue(4) + " - " + reader.GetValue(5) + "\n\n";
                }

                MessageBox.Show(Output);


                reader.Close();
                command.Dispose();
                cnn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PLC_M1.Open();

            if (PLC_M1.IsConnected == true)
            {
                //MessageBox.Show("PLC CONNECTED!");
                label1.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("FAIL!");
                label1.BackColor = Color.Red;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PLC_M1.Close();
            if (PLC_M1.IsConnected == false)
            {
                //MessageBox.Show("Disconnected");
                label1.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Fail to disconnect!");
                label1.BackColor = Color.Green;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            short indexCount = 50;

            var bytes = PLC_M1.ReadBytes(DataType.DataBlock, 180, 0, indexCount);

            string message = "";

            for (int i = 0; i < indexCount; i++)
            {
                //message += "DB: " + i.ToString() + " -> " + (Convert.ToChar(bytes[i]).ToString()) + "\r\n";

                message += (Convert.ToChar(bytes[i]).ToString());
                //if (i == 9 || i == 26 || i == 44)
                //{
                //    message += "\r\n\r\n";
                //}
            }

            //textBox1.Text = message;
        }

        private void bt_StartTimer_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            MyTimer.Start();
            my_logger.Log("Timer started");
            //MessageBox.Show("Timer started");
            //textBox1.Text = "TIMER STARTED!";
        }

        private void bt_StopTimer_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
            my_logger.Log("Timer stopped");
            //  MessageBox.Show("Timer stopped");
            //textBox1.Text = "TIMER STOPPED!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var plc_dbs = this.PLC_DBs;
            DGW_Main.DataSource = plc_dbs;

        }

        private void bt_testeLOG_Click_1(object sender, EventArgs e)
        {
            my_logger.Log("log test pressed");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}