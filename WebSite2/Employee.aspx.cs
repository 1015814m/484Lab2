using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;


//John Morrissey Lab 1

public partial class EmployeeDefault : System.Web.UI.Page
{
    public static int count = 0;
    public static string[,] returnArray = new string[1000, 2];

    protected void Page_Load(object sender, EventArgs e)
    {
        //Select information from the database and input it into the drop downs
    }






    protected void btnCommitEmployee_Click(object sender, EventArgs e)
    {

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Fields are cleared')", true);
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

    private Boolean checkState(string stateAbb)
    {
        string[] stateArray = new string[] {"AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA",
            "HI","ID","IL","IN","IA","KS","KY","LA","ME","MD","MA","MI","MN","MS","MO","MT","NE",
            "NV","NH","NJ","NM","NY","NC","ND","OH","OK","OR","PA","RI","SC","SD","TN","TX","UT",
            "VT","VA","WA","WV","WI","WY"};

        for (int i = 0; i < stateArray.Length; i++)
        {
            if (stateAbb.ToUpper() == stateArray[i])
            {
                return true;
            }

        }

        return false;
    }

    private Boolean checkEntries()
    {
        try
        {
            DateTime.Parse(txtDateOfBirth.Text);
            DateTime.Parse(txtHireDate.Text);
            if (txtTerminationDate.Text != "")
            {
                DateTime.Parse(txtTerminationDate.Text);
            }

            Double.Parse(txtSalary.Text);
            if (txtManagerID.Text != "")
            {
                Int32.Parse(txtManagerID.Text);
            }
            

        }
        catch (Exception)
        {

            return false;
        }
        return true;


    }

    private Boolean checkManagerID(int managerID)
    {
        // Check that the ManagerID entered by the user exists in the Database
        //    if (count != 0)
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            if (managerID != employeeArray[i].EmployeeID)
        //            {
        //                continue;
        //            }
        //            else
        //            {
        //                return false;
        //            }

        //        }
        //    }
        //    else if (count == 0)
        //    {
        //        if (int.Parse(txtEmployeeID.Value) == int.Parse(txtManagerID.Value))
        //        {
        //            return false;
        //        }
        //        else if (txtManagerID.Value == "")
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }

        //    return true;
        return true;

        }

    private Boolean checkAge(DateTime dateOfBirth)
    {
        if ((dateOfBirth.AddYears(18) <= DateTime.Now))
        {
            if (dateOfBirth.AddYears(18) <= DateTime.Parse(txtHireDate.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        else
        {
            return false;
        }
    }

    private Boolean checkDate(DateTime firstDate, DateTime secondDate)
    {
        int i = secondDate.CompareTo(firstDate);
        //Is the second date past the first date
        if (i < 0)
        {
            return false;
        }
        else if (i == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private Boolean checkID(int id)
    {
        //This checks whether the ID number exists in the array
        for (int i = 0; i < count; i++)
        {
            if (id == employeeArray[i].EmployeeID)
            {
                return true;
            }
        }
        return false;
    }

    private Boolean checkName(string firstName, string lastName)
    {
        if (count == 0)
        {
            return false;
        }

        //this checks whether the name already exists in the array
        string arrayName = "";
        string txtBoxName = "";
        txtBoxName = firstName.ToUpper() + lastName.ToUpper();
        Boolean result;

        for (int i = 0; i < count; i++)
        {
            arrayName = employeeArray[i].FirstName.ToUpper() + employeeArray[i].LastName.ToUpper();
            if (arrayName == txtBoxName)
            {
                result = true;
                return result;
            }

        }

        return false;


    }


}