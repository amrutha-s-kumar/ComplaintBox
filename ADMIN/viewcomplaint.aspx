<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/admin.Master" AutoEventWireup="true" CodeBehind="viewcomplaint.aspx.cs" Inherits="ComplaintBox.ADMIN.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h1>View Complaint</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting1" DataKeyNames="Id" >
        <Columns>
             <asp:BoundField DataField="name" HeaderText="Product Name" />
            <asp:BoundField DataField="pname" HeaderText="Complaint" />
            <asp:BoundField DataField="complaint" HeaderText="Customer Name" />
           
            <asp:BoundField DataField="status" HeaderText="status" />
            <asp:BoundField DataField="date" HeaderText="date" />
          
            <asp:CommandField DeleteText="Confirm" HeaderText="Confirmation" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>



</asp:Content>
