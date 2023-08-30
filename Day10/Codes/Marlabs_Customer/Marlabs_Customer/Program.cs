using System;
using System.Data;
using System.Data.SqlClient;

namespace Marlabs_Customer
{
    class Program
    {
        static string strCon = "Server=sangeeth;Initial Catalog=Marlabs;Integrated Security=True";



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
            Console.WriteLine("Enter customer Name::");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter customer Contact::");
            string customerContact = Console.ReadLine();

            Console.WriteLine("Enter customer Salary::");
            int customerSalary = Convert.ToInt32(Console.ReadLine());
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                string strInsert = $"insert into customer values('{customerName}','{customerContact}',{customerSalary})";
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
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand com = new SqlCommand("select * from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds, "customer");



            if (ds != null && ds.Tables.Count > 0 && ds.Tables["customer"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["customer"].Rows)
                {
                    Console.WriteLine($"------------{row["customerName"]}-------------");
                    Console.WriteLine($"{row["customerId"]}");
                    Console.WriteLine($"{row["customerName"]}");
                    Console.WriteLine($"{row["customerContact"]}");
                    Console.WriteLine($"{row["customerSalary"]}");
                    Console.WriteLine($"------------------------------------------");
                }
            }
        }



        public static void SelectcustomerById(int customerId)
        {
            Console.WriteLine("The customer information...");
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand com = new SqlCommand($"select * from customer where customerId = {customerId}", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds, "customer");



            if (ds != null && ds.Tables.Count > 0 && ds.Tables["customer"].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables["customer"].Rows)
                {
                    Console.WriteLine($"customer Id : {row["customerId"]}");
                    Console.WriteLine($"customer Name : {row["customerName"]}");
                    Console.WriteLine($"customer Contact: {row["customerContact"]}");
                    Console.WriteLine($"customer Salary : {row["customerSalary"]}");



                }
            }
        }
        public static void Update()
        {
            Console.WriteLine("Input the customer id to update");
            int customerId = Convert.ToInt32(Console.ReadLine());



            SelectcustomerById(customerId);



            Console.WriteLine("Fill the customer update data");
            Console.WriteLine("Enter customer Name to be updated::");
            string customerName = Console.ReadLine();



            Console.WriteLine("Enter customer Contact to be updated::");
            string customerContact = Console.ReadLine();



            Console.WriteLine("Enter customer Salary to be updated::");
            int customerSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you sure to update ? Y/N ");
            string strUserResp = Console.ReadLine();
            if (strUserResp == "Y" || strUserResp == "y")
            {
                try
                {
                    SqlConnection con = new SqlConnection(strCon);
                    string strUpdate = $"update customer set customerName='{customerName}',customerContact='{customerContact}',customerSalary={customerSalary} where customerId = {customerId}";
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
            int customerId = Convert.ToInt32(Console.ReadLine());



            SelectcustomerById(customerId);



            Console.WriteLine("Are you sure to delete ? Y/N ");
            string strUserResp = Console.ReadLine();
            if (strUserResp == "Y" || strUserResp == "y")
            {
                try
                {
                    SqlConnection con = new SqlConnection(strCon);
                    string strDelete = $"delete from customer where customerId ={customerId}";
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
