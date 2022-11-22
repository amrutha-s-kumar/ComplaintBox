<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/admin.Master" AutoEventWireup="true" CodeBehind="viewquery.aspx.cs" Inherits="ComplaintBox.ADMIN.viewquery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"  >
     <h1 style="background-color:white"><center>View Query</center></h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="qid">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="Customer Name" />
            <asp:BoundField DataField="pname" HeaderText="Product Name" />
            
            <asp:BoundField DataField="queries" HeaderText="Query" />
            <asp:BoundField DataField="status" HeaderText="Status" />
            <asp:BoundField DataField="date" HeaderText="Date" />
            <asp:HyperLinkField DataNavigateUrlFields="qid" DataNavigateUrlFormatString="reply.aspx?Qid={0}" HeaderText="Reply" Text="Go" />
            
        </Columns>
    </asp:GridView>
</asp:Content>
