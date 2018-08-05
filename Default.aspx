<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <h1 class="page-header">
                    Home
                    <small></small>
                </h1>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <h2>
                    <asp:HyperLink runat="server" NavigateUrl='<%# string.Format("ViewPost.aspx?id={0}", Eval("Id")) %>' ID="post_title" ><%# Eval("post_title") %></asp:HyperLink> 
                   
                </h2>

                 <p class="lead">
                    by <a href="index.php">Start Bootstrap</a>
                </p>

                <p><span class="glyphicon glyphicon-time"></span> Posted on:   <%# Eval("post_date") %></p>
                <hr>
               <img class="img-responsive" src="http://placehold.it/900x300" alt="">
                <hr>
                  <p><%# Eval("post_description") %></p>
                <a class="btn btn-primary" href="#">Read More <span class="glyphicon glyphicon-chevron-right"></span></a>

                <hr>
            </ItemTemplate>
        </asp:Repeater>
        
       


                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [posts]"></asp:SqlDataSource>
              
</form>
</asp:Content>

