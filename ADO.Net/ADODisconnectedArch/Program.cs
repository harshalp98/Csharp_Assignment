using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;



namespace ADODisconnectedArch
{
    internal class Program
    {   

        static void Main(string[] args)
        {
            try
            {
                
                SqlConnection con = new SqlConnection("Server=.;Database=EmployeeDetails;trusted_connection=true");
                SqlCommand cmd = new SqlCommand("select * from Employee", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder ccb=new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds,"Employee");
                DataTable dt = ds.Tables["Employee"];
                
                int choice;
                char ch;
                do
                {
                    Console.WriteLine("1.Display Details");
                    Console.WriteLine("2.Insert Details");
                    Console.WriteLine("3.Update Details");
                    Console.WriteLine("4.Delete Details");
                    Console.WriteLine("***Enter your choice***");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("ID\t"+"NAME\t"+"DEPT ID");
                                foreach (DataRow row in dt.Rows)
                                {
                                    Console.WriteLine(row[0].ToString() + "\t" + row[1].ToString() + "\t" + row[2].ToString());
                                }
                                break;
                        case 2:
                                Console.WriteLine("Enter Emp Id");
                                int eid=Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Emp Name");
                                string enm=Console.ReadLine();
                                Console.WriteLine("Enter Emp Dept Id");
                                int did = Convert.ToInt32(Console.ReadLine());
                                DataRow rw = dt.NewRow();
                                rw[0] = eid;
                                rw[1] = enm;
                                rw[2] = did;
                                dt.Rows.Add(rw);
                                adapter.Update(dt);
                                Console.WriteLine("!!Details are Inserted Successfully!!");
                                break;

                        case 3:
                                Console.WriteLine("Enter Emp Id");
                                int eid1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Emp Name");
                                string enm1 = Console.ReadLine();
                                Console.WriteLine("Enter Emp Dept Id");
                                int did1 = Convert.ToInt32(Console.ReadLine());
                                DataRow[] dr = dt.Select("EmpId=" + eid1);
                                DataRow rw1=dr[0];
                                rw1[1] = enm1;
                                rw1[2] = did1;
                                adapter.Update(dt);
                                Console.WriteLine("!!Details are Updated Successfully!!");
                                break;

                        case 4:
                                Console.WriteLine("Enter Emp Id");
                                int eid2 = Convert.ToInt32(Console.ReadLine());
                                DataRow[] dr1 = dt.Select("EmpId=" + eid2);
                                DataRow rw2=dr1[0];
                                rw2.Delete();
                                adapter.Update(dt);
                                Console.WriteLine("!!Details are Deleted Successfully!!");
                                break;

                        default:
                                Console.WriteLine("!!*****Invalid choice*****!!");
                                break;


                    }
                    Console.WriteLine("***To Continue Enter Y or y***");
                    ch = Convert.ToChar(Console.ReadLine());
                }while(ch=='y' || ch=='Y');
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.ReadKey();
        }
    }
}
