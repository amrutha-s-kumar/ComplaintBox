<%@ Page Title="" Language="C#" MasterPageFile="~/USER/userdesign.Master" AutoEventWireup="true" CodeBehind="viewstatus.aspx.cs" Inherits="ComplaintBox.USER.viewstatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 align="left">Complaint Status</h1>
    
    <table align="center"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="pname" HeaderText="Product Name" />
            <asp:BoundField DataField="complaint" HeaderText="Your Complaint" />
            <asp:BoundField DataField="date" HeaderText="Date" />
            <asp:BoundField DataField="status" HeaderText="Admin Status" />
       
          </Columns>
    </asp:GridView>
        </table>



</asp:Content>
