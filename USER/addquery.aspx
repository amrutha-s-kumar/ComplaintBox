<%@ Page Title="" Language="C#" MasterPageFile="~/USER/userdesign.Master" AutoEventWireup="true" CodeBehind="addquery.aspx.cs" Inherits="ComplaintBox.USER.addquery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table bgcolor="white" align="center" class="auto-style1">


     <h1><center>QUERY REGISTRATION</center></h1> 
                
                 <tr>
                     
                         <td>Product Name :</td>
                     <td>
                         <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                     </td>
                 </tr>
                <tr>  
                    <td>query :</td>  
                    <td> 
                      <asp:TextBox ID="query" runat="server"></asp:TextBox>
                         
                    </td>  
                </tr>
                 
                        
                <tr>  
                    <td class="auto-style1">  
                      <center> <asp:Button   ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click"/>  </center> 
                    </td>  
                </tr>
           
</asp:Content>
