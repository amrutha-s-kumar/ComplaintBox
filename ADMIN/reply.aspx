﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/admin.Master" AutoEventWireup="true" CodeBehind="reply.aspx.cs" Inherits="ComplaintBox.ADMIN.reply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table bgcolor="white" align="center" class="auto-style1">


     <h1><center>Reply</center></h1> 
                
                
                <tr>  
                    <td>Query :</td>  
                    <td> 
                      <asp:TextBox ID="query" runat="server"></asp:TextBox>
                         
                    </td>  
                </tr>
                 
                        
                <tr>  
                    <td class="auto-style1">  
                      <center> <asp:Button   ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />  </center> 
                    </td>  
                </tr>
</asp:Content>
