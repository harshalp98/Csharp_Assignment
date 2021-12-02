using System;
using System.Data.SqlClient;

namespace ADOConnectedEx
{
    class EmployeeDAL {
        SqlConnection con;
        SqlCommand cmd;

        public EmployeeDAL()
        {
            try
            {
                con = new SqlConnection("Server=.;Database=EmployeeDetails;trusted_connection=true");
                con.Open();
            }
            catch (SqlException s)
            {
                Console.WriteLine(s.Message);
            }
           
        }
        public SqlDataReader getEmpDetails()
        {
            SqlDataReader reader = null;
            
            try
            {
                cmd = new SqlCommand("select*from Employee", con);
                cmd.CommandType = System.Data.CommandType.Text;
                reader= cmd.ExecuteReader();
            }
            catch (SqlException s)
            {
                Console.WriteLine(s.Message);

            }
            
            return reader;
        }
        public SqlDataReader getEmpUsingId(int EmpId)
        {
            SqlDataReader reader=null;
            

            try
            {
                cmd = new SqlCommand("GetEmpUsingEmpno", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("EmpId",EmpId);
                cmd.Parameters.Add(p1);
                reader = cmd.ExecuteReader();
            }
            catch (SqlException s)
            {
                Console.WriteLine(s.Message);

            }          
            return reader;
        }
        public int insertEmpDetails(int EmpId,string EmpName,int DeptId)
        {
            
            int res = 0;
            try
            {
                cmd = new SqlCommand("InsertEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("EmpId",EmpId);
                SqlParameter p2 = new SqlParameter("EmpName", EmpName);
                SqlParameter p3= new SqlParameter("DeptId", DeptId);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
              res =cmd.ExecuteNonQuery();
            }
            catch (SqlException s)
            {
                Console.WriteLine(s.Message);
            }
            return res;
        }
        public int updateEmpDetails(int EmpId, string EmpName, int DeptId)
        {
            int res = 0;
            
            try
            {
                cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("EmpId", EmpId);
                SqlParameter p2 = new SqlParameter("EmpName", EmpName);
                SqlParameter p3 = new SqlParameter("DeptId", DeptId);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                res = cmd.ExecuteNonQuery();
            }
            catch (SqlException s)
            {
                Console.WriteLine(s.Message);
            }
            return res;
        }
        public int deleteEmployee(int EmpId)
        {
            int res=0;
          
            try
            {
                cmd = new SqlCommand("DeleteEmpUsingEmpno", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("EmpId", EmpId);
                cmd.Parameters.Add(p1);
                res = cmd.ExecuteNonQuery();
            }
            catch (SqlException s)
            {
                Console.WriteLine(s.Message);
            }
            return res;
        }
        public void printEmployeeDetails(SqlDataReader reader)
        {
            
            Console.WriteLine("EmpId\t"+"EmpName\t"+"DeptId");
            while (reader.Read())
            {
                
                Console.WriteLine(reader[0]+"\t"+ reader[1] +"\t"+ reader[2]);
               
            }
            reader.Close();
                        

        }
        ~EmployeeDAL()
        {
            con.Close();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAL d = new EmployeeDAL();
            int choice;
            char ch;
            do
            {
                Console.WriteLine("1.Get Employee Details");
                Console.WriteLine("2.Get Employee Details using EmpId");
                Console.WriteLine("3.Insert Employee Details");
                Console.WriteLine("4.Update Employee Details");
                Console.WriteLine("5.Delete Employee Details");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("!!Enter your choice!!");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                            d.printEmployeeDetails(d.getEmpDetails());
                            break;
                    case 2:
                            Console.WriteLine("Enter EmpId");
                            int EmpId = Convert.ToInt32(Console.ReadLine());
                            d.printEmployeeDetails(d.getEmpUsingId(EmpId));
                             break;
                    case 3:
                            Console.WriteLine("Enter EmpId");
                            int EmpId1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter EmpName");
                            string EmpName =Console.ReadLine();
                            Console.WriteLine("Enter DeptId");
                            int DeptId = Convert.ToInt32(Console.ReadLine());
                            int r = d.insertEmpDetails(EmpId1,EmpName,DeptId);
                            Console.WriteLine("***Record inserted successfully***");
                            break;
                    case 4:
                            Console.WriteLine("Enter EmpId");
                            int EmpId2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter EmpName");
                            string EmpName1 = Console.ReadLine();
                            Console.WriteLine("Enter DeptId");
                            int DeptId1 = Convert.ToInt32(Console.ReadLine());
                            int r1 = d.updateEmpDetails(EmpId2, EmpName1, DeptId1);
                            Console.WriteLine("***Record Updated successfully***");
                            break;
                    case 5:
                            Console.WriteLine("Enter EmpId");
                            int EmpId3 = Convert.ToInt32(Console.ReadLine());
                            int r2= d.deleteEmployee(EmpId3);
                            Console.WriteLine("***Record Deleted successfully***");
                            break;
                    default:
                            Console.WriteLine("!!**Invalid Choice**!!");
                            break;
                }
                Console.WriteLine("--Enter y or Y to Continue--");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');



        }
    }
}
