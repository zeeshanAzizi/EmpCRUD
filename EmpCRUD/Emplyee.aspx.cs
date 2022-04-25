using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EmpCRUD
{
    public partial class Emplyee : System.Web.UI.Page
    {
        Class1 mod = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "SELECT * from tbl_country";
                DataSet ds = mod.FillDs(sel);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ddl_country.Items.Add(ds.Tables[0].Rows[i]["country"].ToString());
                }

                string sel1 = "select * from tbl_skill";
                DataSet ds1 = mod.FillDs(sel1);
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    CheckBoxList1.Items.Add(ds1.Tables[0].Rows[i]["skill"].ToString());
                }
            }
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            string str3 = "";
            for (int i=0; i<=CheckBoxList1.Items.Count-1; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    if (str3 == "")
                    {
                        str3 = CheckBoxList1.Items[i].Text;
                    }
                    else
                    {
                        str3 += "," + CheckBoxList1.Items[i].Text;
                    }
                }
            }
            string str = "insert into tblemp(name,email,mobile,address,salary,country,skill) values('" + txt_empname.Text + "','" + txt_email.Text + "','" + txt_mobile.Text + "','" + txt_address.Text + "','" + txt_salary.Text + "','" + ddl_country.Text + "','" + str3 + "')";
            mod.InsDelUp(str);
        }
    }
}