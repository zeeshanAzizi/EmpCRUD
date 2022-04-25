﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{

    public SqlConnection con;

    public Class1()
    {
        con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\source\repos\EmpCRUD\EmpCRUD\App_Data\Database1.mdf;Integrated Security=True");

    }
    public void InsDelUp(string Str)
    {
        SqlCommand cmd = new SqlCommand(Str, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public DataSet FillDs(string Str)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(Str, con);
        da.Fill(ds);
        return ds;
    }
    public DropDownList fillddl(DropDownList ddl, string str)
    {
        SqlDataAdapter da = new SqlDataAdapter(str, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        ddl.DataSource = ds;
        ddl.DataMember = ds.Tables[0].ToString();
        ddl.DataTextField = ds.Tables[0].Columns[0].ToString();
        ddl.DataBind();
        return ddl;
    }

    public GridView fillgrid(GridView ddl, string str)
    {
        SqlDataAdapter da = new SqlDataAdapter(str, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        ddl.DataSource = ds;

        ddl.DataBind();

        return ddl;
    }

    public Repeater fillrepeater(Repeater rep, string str)
    {
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        rep.DataSource = cmd.ExecuteReader();
        rep.DataBind();
        con.Close();
        return rep;
    }
}
