using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;


//John Morrissey Lab 2
/*
 * TO DO:
 * CHANGE THE IF STATEMENTS SO THAT IF THE FIELDS ARE EMPTY THAT THEY BECOME NULL
 * COMPLETE THE VALIDATION AND CONSIDER ANY FURTHER VALIDATION WITH THE NEW STUFF
 * CREATE THE BRIDGE INSERT STATEMENTS
 * DOES EACH CONSTRUCTOR NEED A SELECT STATEMENT?
 * ENSURE THAT THE SELECTED INDEX GETS THE RIGHT NUMBER
 * EMPLOYEEPROJECTSTARTDATE/EMPLOYEEPROJECTENDDATE - WHERE DOES THE USER INPUT THESE NUMBERS
 *      AND ON WHICH FORM IS THIS DONE
  */
public partial class EmployeeDefault : System.Web.UI.Page
{
    private static int selectSkill;
    private static int selectProject;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Set the variables for the users selections
        selectSkill = skillDropDown.SelectedIndex - 1;
        selectProject = projectDropDown.SelectedIndex - 1;

        //Select from the database and add that to the drop down
        projectDropDown.Items.Clear();
        projectDropDown.Items.Add("(No Project)");
        skillDropDown.Items.Clear();
        skillDropDown.Items.Add("(No Project)");
        selectFromDB("SKILL","SkillName", projectDropDown);
        selectFromDB("PROJECT", "ProjectName", skillDropDown);

        
    }

    protected void btnCommitEmployee_Click(object sender, EventArgs e)
    {
        
        Boolean ensureDB = true;

        try
        {
            //Perform validation to ensure that all user entries are correct
            if (true)
            {
                //check to ensure that all textboxes values can be parsed
            }
            if (true)
            {
                //check the hire date against the termination date
            }
            if (true)
            {
                //check to ensure that the user doesnt already exist
            }
            if (true)
            {
                //check to ensure that all users are atleast 18 years old
            }
            if (true)
            {
                //check that the user entered a state in the United States
            }
            if (true)
            {
                //check to see if the user ID already exists in the DB
            }
            if (true)
            {
                //check to see if the manager ID already exists
            }
            if (true)
            {
                //check to ensure all number entries are positive numbers
            }
            if (ensureDB) //if the boolean passes all the checks then it is valid and can be entered
            {
                if(true)
                {
                    //middle initial null?
                }
                if(true)
                {
                    //state null?
                }
                if(true)
                {
                    //termination date null?
                }
                if(true)
                {
                    //manager ID null?
                }

                //Create the new Employee i.e. send to constructor
                Employee newEmployee = new Employee(txtFirstName.Text, txtLastName.Text, txtMiddleInitial.Text,
                    txtHouseNum.Text, txtStreet.Text, txtCity.Text, txtState.Text, txtCountry.Text, txtZip.Text,
                    DateTime.Parse(txtDateOfBirth.Text), DateTime.Parse(txtHireDate.Text), DateTime.Parse(txtTerminationDate.Text),
                    double.Parse(txtSalary.Text), int.Parse(txtManagerID.Text), (string)Session["user"], System.DateTime.Now);

                //Insert the user into the database


                resultMessage.Text = "User Created: ID# " + findMaxID() + " " + newEmployee.FirstName + " "
                    + newEmployee.LastName;
            }
        }
        catch (Exception c)
        {

        }


        

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Fields are cleared')", true);
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtMiddleInitial.Text = "";
        txtDateOfBirth.Text = "";
        txtHouseNum.Text = "";
        txtStreet.Text = "";
        txtCity.Text = "";
        txtState.Text = "";
        txtCountry.Text = "";
        txtZip.Text = "";
        txtHireDate.Text = "";
        txtTerminationDate.Text = "";
        txtSalary.Text = "";
        txtManagerID.Text = "";
        txtFirstName.Focus();
    }

    protected void btnExit_Click(object sender, EventArgs e)
    {
        
        //Exits the web application

    }

    private void selectFromDB(string table, string column, Control cntrl)
    {
        try
        {
            //Connect to the DB
            System.Data.SqlClient.SqlConnection sqlc = connectToDB();

            //Creates a new sql select command to select the data from the skills table
            System.Data.SqlClient.SqlCommand select = new System.Data.SqlClient.SqlCommand();
            select.Connection = sqlc;
            select.CommandText = "select " + column + " from [dbo].[" + table + "]";
            System.Data.SqlClient.SqlDataReader reader;

            reader = select.ExecuteReader();


            while (reader.Read())
            {
                (cntrl as DropDownList).Items.Add(reader.GetString(0));
                
            }
            sqlc.Close();
        }
        catch (Exception c)
        {
            //Shows an error message if there is a problem connecting to the database
            resultMessage.Text += "DROP DOWN ERROR";
            resultMessage.Text += c.Message;
        }
    }

    protected System.Data.SqlClient.SqlConnection connectToDB()
    {
        try
        {
            //Connects to the database and returns the connection
            System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
            sc.ConnectionString = @"Server =Localhost; Database=Lab2;Trusted_Connection=Yes";
            sc.Open();
            return sc;
        }
        catch (Exception)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertmessage", "alert('There was an error connecting to the Database')", true);
            return null;
        }
    }

    private void insertBridge(int id, Employee person)
    {
        try
        {
            //Connect to the DB
            System.Data.SqlClient.SqlConnection sqlc = connectToDB();

            //Creates a new sql insert statement to insert into the bridge table
            System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
            insert.Connection = sqlc;
            insert.CommandText = "insert into [dbo].[EMPLOYEESKILL] values (" + findMaxID() + ","
                + selectSkill + ",'" + (string)Session["user"] + "','" + System.DateTime.Now + "')";

            insert.ExecuteNonQuery();
            sqlc.Close();
        }
        catch (Exception c)
        {

            errorMessage.Text += c;
        }
    }

    private int findMaxID()
    {
        try
        {
            System.Data.SqlClient.SqlConnection sqlc = connectToDB();

            //Creates the sql select statement
            System.Data.SqlClient.SqlCommand select = new System.Data.SqlClient.SqlCommand();
            select.Connection = sqlc;

            select.CommandText += "SELECT MAX(EMPLOYEEID) FROM [DBO].[EMPLOYEE]";

            int i = (int)select.ExecuteScalar();
            
            sqlc.Close();
            return i;
        }
        catch (Exception c)
        {
            errorMessage.Text += c;
            return -1;
        }
    }

    private void commitEmployeeToDB(Employee person)
    {
        try
        {
            System.Data.SqlClient.SqlConnection sqlc = connectToDB();

            //Creates the employee insert statement
            System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
            insert.Connection = sqlc;

            //After the objects attributes are set to their values this will run and insert nulls where applicable

            insert.CommandText += "insert into [dbo].[EMPLOYEE] values ('" + person.FirstName + "','" + person.LastName;
            if (person.MiddleName == "NULL")
            {
                insert.CommandText += "',NULL,'";
            }
            else
            {
                insert.CommandText += "','" + person.MiddleName + "','";
            }

            insert.CommandText += person.HouseNum + "','" + person.Street + "','" + person.County;
            if (person.State == "NULL")
            {
                insert.CommandText += "',NULL,'";
            }
            else
            {
                insert.CommandText += "','" + person.State + "','";
            }

            insert.CommandText += person.Country + "','" + person.Zip + "','" + person.DateOfBirth + "','" + person.HireDate;
            if (person.TerminationDate == DateTime.MinValue)
            {
                insert.CommandText += "',NULL,";
            }
            else
            {
                insert.CommandText += "','" + person.TerminationDate + "',";
            }

            insert.CommandText += person.Salary;

            if (person.ManagerID == -1)
            {
                insert.CommandText += ",NULL,'";
            }
            else
            {
                insert.CommandText += "," + person.ManagerID + ",'";
            }
            insert.CommandText += person.LastUpdatedBy + "','" + person.LastUpdated + "')";
        }
        catch (Exception c)
        {
            errorMessage.Text += c;
        }
    }




}