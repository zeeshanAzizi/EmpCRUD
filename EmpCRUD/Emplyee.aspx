<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Emplyee.aspx.cs" Inherits="EmpCRUD.Emplyee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt_empname" runat="server" placeholder="Name"></asp:TextBox>
            <asp:TextBox ID="txt_email" runat="server" placeholder="email"></asp:TextBox>
            <asp:TextBox ID="txt_mobile" runat="server" placeholder="mobile"></asp:TextBox>
            <asp:TextBox ID="txt_salary" runat="server" placeholder="salary"></asp:TextBox>
            <asp:TextBox ID="txt_address" runat="server" placeholder="address"></asp:TextBox>
            <asp:DropDownList ID="ddl_country" runat="server"></asp:DropDownList>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <%--<asp:CheckBox ID="CheckBox1" runat="server" text="C#"/>
            <asp:CheckBox ID="CheckBox3" runat="server" Text="C"/>
            <asp:CheckBox ID="CheckBox2" runat="server" Text="java"/>--%>
            <asp:Button ID="btn_save" runat="server" Text="Save" OnClick="btn_save_Click" />
        </div>
    </form>
</body>
</html>
