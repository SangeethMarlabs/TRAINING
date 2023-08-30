using System;
using System.Data;
using System.Data.SqlClient;

namespace Marlabs_Crud_Assgn_Ex1
{
    class Program
    {
        static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Marlabs;Integrated Security=True";
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Please select a option");
            Console.WriteLine("1.Select, 2.Insert, 3.Update, 4.Delete");
            int usrInput = Convert.ToInt32(Console.ReadLine());

            switch (usrInput)
            {
                case 1:
                    Select();
                    break;
                case 2:
                    Insert();
                    break;
                case 3:
                    Update();
                    break;
                case 4:
                    Delete();
                    break;
                default:
                    Console.WriteLine("Please select a valid option!");
                    break;
            }
            Console.WriteLine("Do you want to continue ? Y/N");
            string strYesNo = Console.ReadLine();
            if (strYesNo == "N" || strYesNo == "n")
            {
                System.Environment.Exit(1);
            }
            goto start;

       
        }

        public static void Insert()
        {
            Console.WriteLine("Fill the customer data");
            Console.WriteLine("Enter Customer Name::");
            string custName = Console.ReadLine();

            Console.WriteLine("Enter Customer Address1::");
            string custAddress1 = Console.ReadLine();

            Console.WriteLine("Enter Customer Address2::");
            string custAddress2 = Console.ReadLine();

            Console.WriteLine("Enter Customer Email::");
            string custEmail = Console.ReadLine();

            Console.WriteLine("Enter Customer Phone::");
            string custPhone = Console.ReadLine();
 
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                string strInsert = $"insert into tbl_customer values('{custName}','{custAddress1}','{custAddress2}','{custEmail}','{custPhone}')";
                SqlCommand com = new SqlCommand(strInsert);
                com.Connection = con;
                con.Open();
                int inserted = com.ExecuteNonQuery();
                if (inserted != 0)
                {
                    Console.WriteLine(inserted + "-customer data inserted");
                }
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error\n {ex.Message}");
            }




        }
        public static void Select()
        {
            Console.WriteLine("The customer information...");
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com = new SqlCommand("select * from tbl_customer", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds, "customer");



            if (ds != null && ds.Tables.Count > 0 && ds.Tables["customer"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["customer"].Rows)
                {
                    Console.WriteLine($"------------{row["custName"]}-------------");
                    Console.WriteLine($"{row[0]}");
                    Console.WriteLine($"{row[1]}");
                    Console.WriteLine($"{row[2]}");
                    Console.WriteLine($"{row[3]}");
                    Console.WriteLine($"{row[4]}");
                    Console.WriteLine($"{row[5]}");
                    Console.WriteLine($"------------------------------------------");
                }
            }
        }



        public static void SelectcustById(int custId)
        {
            Console.WriteLine("The customer information...");
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand com = new SqlCommand($"select * from tbl_customer where CustId = {custId}", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds, "tbl_customer");



            if (ds != null && ds.Tables.Count > 0 && ds.Tables["tbl_customer"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["tbl_customer"].Rows)
                {
                    Console.WriteLine($"cust Id : {row["CustId"]}");
                    Console.WriteLine($"cust Name : {row["CustName"]}");
                    Console.WriteLine($"cust Address1 : {row["CustAddress1"]}");
                    Console.WriteLine($"cust Address2 : {row["CustAddress2"]}");
                    Console.WriteLine($"cust Phone: {row["CustPhone"]}");
                    Console.WriteLine($"cust Email : {row["CustEmail"]}");
                }
            }
        }
        public static void Update()
        {
            Console.WriteLine("Input the customer id to update");
            int custId = Convert.ToInt32(Console.ReadLine());



            SelectcustById(custId);



            Console.WriteLine("Fill the customer update data");
            
            Console.WriteLine("Enter Cust Name to be updated::");
            string custName = Console.ReadLine();    
            
            Console.WriteLine("Enter Cust Address1 to be updated::");
            string custAddress1 = Console.ReadLine(); 
            
            Console.WriteLine("Enter Cust Address2 to be updated::");
            string custAddress2 = Console.ReadLine(); 
            
            Console.WriteLine("Enter Cust Email to be updated::");
            string custEmail = Console.ReadLine();   

            Console.WriteLine("Enter cust Phone to be updated::");
            string custPhone = Console.ReadLine();
 
            Console.WriteLine("Are you sure to update ? Y/N ");
           
            string strUserResp = Console.ReadLine();
            if (strUserResp == "Y" || strUserResp == "y")
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
                    string strUpdate = $"update tbl_customer set custName='{custName}',custAddress1='{custAddress1}',custAddress2='{custAddress2}',custEmail='{custEmail}',custPhone='{custPhone}' where CustId = {custId}";
                    SqlCommand com = new SqlCommand(strUpdate);
                    com.Connection = con;
                    con.Open();
                    com.ExecuteNonQuery();
                    Console.WriteLine("customer info updated");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error - " + ex.Message);
                }
            }



        }
        public static void Delete()
        {
            Console.WriteLine("Input the customer id to delete");
            int custId = Convert.ToInt32(Console.ReadLine());



            SelectcustById(custId);



            Console.WriteLine("Are you sure to delete ? Y/N ");
            string strUserResp = Console.ReadLine();
            if (strUserResp == "Y" || strUserResp == "y")
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
                    string strDelete = $"delete from tbl_customer where CustId ={custId}";
                    SqlCommand com = new SqlCommand(strDelete);
                    com.Connection = con;
                    con.Open();
                    int num = com.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("customer deleted-records::" + num);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error - " + ex.Message);
                }
            }
        }
            
    }
}
