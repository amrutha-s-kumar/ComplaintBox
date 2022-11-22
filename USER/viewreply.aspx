<%@ Page Title="" Language="C#" MasterPageFile="~/USER/userdesign.Master" AutoEventWireup="true" CodeBehind="viewreply.aspx.cs" Inherits="ComplaintBox.USER.viewreply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1  style="background:white"> Query Reply</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="pname" HeaderText="Product-Name" />
            <asp:BoundField DataField="queries" HeaderText="Your Querry" />
            <asp:BoundField DataField="reply" HeaderText="Admin Reply" />
        </Columns>
    </asp:GridView>
</asp:Content>
