using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Assessment_1   
{
  public class Program
  {
    public static SqlConnection connection = null;
    public static SqlCommand cmd = null;
    public static IDataReader reader = null;
    void Operations()
    {
        
        connection = new SqlConnection("Data Source=ICS-LT-D244D6BX;Initial Catalog=ADO_Assessment;" +
                    "Integrated Security=true;");
       
        connection.Open();
       
        cmd = new SqlCommand("sp_productdetails", connection);
        cmd.CommandType = CommandType.StoredProcedure;

        Console.WriteLine("Enter the product id:");
        int ProductId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Product_name:");
        String ProductName = Console.ReadLine();
        Console.WriteLine("Enter the Product price:");
        float Price = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the discounted Price:");
        float DiscountedPrice = Convert.ToSingle(Console.ReadLine());
        DiscountedPrice = Price - 0.10f;


        
        cmd.Parameters.Add(new SqlParameter("@productId", SqlDbType.Int)).Value = ProductId;
        cmd.Parameters.Add(new SqlParameter("@productName", SqlDbType.VarChar, 40)).Value = ProductName;
        cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float)).Value = Price;
        cmd.Parameters.Add(new SqlParameter("@DiscountedPrice", SqlDbType.Float)).Value = DiscountedPrice;


        int result = cmd.ExecuteNonQuery();
        if (result > 0)
        {
            Console.WriteLine("Success:");
        }
        else
        {
            Console.WriteLine("Fail:");
        }
        connection.Close();

    }
    void select()
    {
        connection = new SqlConnection("Data Source=ICS-LT-D244D6BX;Initial Catalog=ADO_Assessment; trusted_connection = true;");
        Console.WriteLine("Successfully connected:");
       
        connection.Open();

        cmd = new SqlCommand("sp_productdetails", connection);
        cmd.CommandType = CommandType.StoredProcedure;
        Console.WriteLine("Enter the product id:");
        int ProductId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Product_name:");
        String ProductName = Console.ReadLine();
        Console.WriteLine("Enter the Product price:");
        float Price = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the discounted Price:");
        float DiscountedPrice = Convert.ToSingle(Console.ReadLine());

        cmd.Parameters.Add(new SqlParameter("@productId", SqlDbType.Int)).Value = ProductId;
        cmd.Parameters.Add(new SqlParameter("@productName", SqlDbType.VarChar, 40)).Value = ProductName;
        cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Float)).Value = Price;
        cmd.Parameters.Add(new SqlParameter("@DiscountedPrice", SqlDbType.Float)).Value = DiscountedPrice;



        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine("ProductId is:" + reader[0] + "ProductName is:" + reader[1] + "Price:" + reader[2] + "DiscountedPrice:" + reader[3]);
        }
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        p.Operations();
        p.select();
        Console.Read();
    }
  }
}
