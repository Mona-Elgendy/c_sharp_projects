using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.econtactClasses
{
    class contactClass
    {
        //getter setter properties 
        //act as data carrier in our application
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myConnString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //step 1: database connection
            SqlConnection conn = new SqlConnection(myConnString);
            DataTable dt = new DataTable();
            try
            {
                //step 2: writing sql query 
                string sql = "SELECT * FROM tbl_contact ";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql,conn);
                //creating sql dataadapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        //inserting data into database
        public bool Insert(contactClass c)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;
            // step1 :connect to database
            SqlConnection conn = new SqlConnection(myConnString);
            try
            {
                //step 2: creat sql query to insert data
                string sql = "INSERT INTO tbl_contact(FirstName , LastName , ContactNo , Address , Gender) VALUES (@FirstName , @LastName , @ContactNo , @Address , @Gender) ";
                //creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@FirstName",c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                // if the query executes successfully then the values of rows will be greater than zero else rows=0
               if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        //method to update data in database from our application
        public bool Update(contactClass c)
        {
            //create a  return type and set its default value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnString);
            try
            {
                //sql to update
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName , LastName=@LastName , ContactNo=@ContactNo , Address=@Address , Gender=@Gender WHERE ContactID=@ContactID ";
                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                // create paramters to add values
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows >0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        //method to delete data from database

        public bool Delete(contactClass c)
        {
            //create a default return=false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnString);
            try
            {
                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }


            return isSuccess;
        }



    }
}
