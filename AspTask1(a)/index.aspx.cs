using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspTask1_a_
{
    public partial class index : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnDelete.Enabled = true;
                dal.fillGridView();
                Contact.DataSource = dt;
                Contact.DataBind();
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";
            btnUpdate.Text = "Save";
            btnDelete.Enabled = false;
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string msg = dal.insert(txtID.Text, txtName.Text, txtMobile.Text, txtAddress.Text);
            if (msg == null)
            {
                Label5.Text = "added successfully";
            }
            else
            {
                Label5.Text = "error";
            }
            Clear();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string msg = dal.update(txtID.Text, txtName.Text, txtMobile.Text, txtAddress.Text);
            if(msg == null)
            {
                Label5.Text = "updated successfully"; 
            }
            else
            {
                Label5.Text = "error";
            }
            Clear();
        }



        protected void lnk_OnClick(object sender, EventArgs e)
        {
            dal.view("e");
            txtID.Text = dt.Rows[0]["Contact"].ToString();
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtMobile.Text = dt.Rows[0]["Mobile"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            btnUpdate.Text = "Update";
            btnDelete.Enabled = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = dal.delete(txtID.Text);
            Clear();
        }

       

        protected void btnview_Click(object sender, EventArgs e)
        {

            Contact.DataSource = dal.fillGridView();
            Contact.DataBind();
        }
    }
}