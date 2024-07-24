using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "data source = ICS-LT-91J9R73; initial catalog = Employeemanagement;" +
                "integrated security = true;";

        string empName = "Sakthi";
        float empsal = 50000f;
        char emptype = 'P'; 

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("sp_InsertEmployeeDetails", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@EmpName", SqlDbType.VarChar, 50)).Value = empName;
                    cmd.Parameters.Add(new SqlParameter("@Empsal", SqlDbType.Float)).Value = empsal;
                    cmd.Parameters.Add(new SqlParameter("@Emptype", SqlDbType.Char, 1)).Value = emptype;

                    int empnoGenerated = (int)cmd.ExecuteScalar();

                    Console.WriteLine("Employee inserted successfully with Empno: " + empnoGenerated);
                }
            }

            Console.WriteLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT Empno, EmpName, Empsal, Emptype FROM Employee_Details", connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"Empno: {reader["Empno"]}, EmpName: {reader["EmpName"]}, Empsal: {reader["Empsal"]}, Emptype: {reader["Emptype"]}");
                    }

                    reader.Close();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine();
    }
}

