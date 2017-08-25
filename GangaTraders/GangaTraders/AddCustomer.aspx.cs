using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CoreProject.DA;
using CoreProject.DO;
namespace GangaTraders
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        CustomerMaster CM = new CustomerMaster();
        CustomerMasterDA CA = new CustomerMasterDA();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                CM.intCustomerID = hdfCustomerID.Value == "" || hdfCustomerID.Value == "0" ? -1 : Convert.ToInt32(hdfCustomerID.Value);
                CM._strCustomerName = txtCustomerName.Text;
                //CM.st = txtLastName.Text;
                //CM.Gender = rbtnGender.SelectedValue;
                //CM.BirthDate = Convert.ToDateTime(txtBirthDate.Text);
                //CM.Address = txtAddress.Text;
                //CM.EmailAddress = txtEmailAddress.Text;
                //CM.MobileNumber = txtMobileNumber.Text;
                //CM.DepartmentID = Convert.ToInt32(ddlDepartment.SelectedValue);
                //CM.Designation = ddlDesignation.SelectedValue;
                //CM.Salary = Convert.ToDecimal(txtSalary.Text);
                //CM.CountryID = Convert.ToInt32(ddlCountry.SelectedValue);
                //CM.StateID = Convert.ToInt32(ddlState.SelectedValue);
                //CM.CityID = Convert.ToInt32(ddlCity.SelectedValue);
                string profileImagePath = "";

                //if (fileProfile.HasFile)
                //profileImagePath = ConfigurationManager.AppSettings["ProfilePicPath"].ToString() + "/" + fileProfile.FileName;
                //employee.ProfilePic = profileImagePath;

                //if (dbEmployee.SaveEmployee(employee))
                //{
                //    if (true)
                //    {
                //        profileImagePath = Server.MapPath(ConfigurationManager.AppSettings["ProfilePicPath"].ToString());
                //        if (!Directory.Exists(profileImagePath))
                //            Directory.CreateDirectory(profileImagePath);
                //        fileProfile.SaveAs(profileImagePath + "/" + fileProfile.FileName);
                //    }
                //    ClearControls();
                //    BindEmployeeGrid();
                //    lblMessage.Text = "Employee saved sucessfully.";
                //}
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        } 

        public void ClearControls()
        {
            //hdfEmployeeID.Value = "";
            //txtFirstName.Text = "";
            //txtLastName.Text = "";
            //rbtnGender.Items[0].Selected = true;
            //txtBirthDate.Text = "";
            //txtAddress.Text = "";
            //txtEmailAddress.Text = "";
            //txtMobileNumber.Text = "";
            //txtSalary.Text = "";
            //BindControls(0, 0);
        }
    }
}