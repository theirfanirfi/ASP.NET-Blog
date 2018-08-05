<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <form id="form1" runat="server">
          <h1 class="page-header">
                   Admin
                    <small>Panel</small>
                </h1>

    <asp:GridView  CssClass="table table-hover table-condensed table-bordered table-responsive" ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowUpdated="updateRowRecord" DataKeyNames="Id">
        <Columns>
           
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" Visible="false" />
            <asp:BoundField DataField="post_title" HeaderText="POST TITLE" SortExpression="post_title" />
            <asp:BoundField DataField="post_description" HeaderText="DESCRIPTION" SortExpression="post_description" />
              <asp:BoundField DataField="post_date" HeaderText="DATE" SortExpression="post_date" />
                
              <asp:CommandField ShowEditButton="true" />  
              <asp:CommandField ShowDeleteButton="true" />
        </Columns>
          </asp:GridView>
          <asp:Button CssClass="btn btn-success" ID="btnAddRow" runat="server" OnClick="btnAddRow_Click" Text="Add Row" />
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
              SelectCommand="SELECT [Id], [post_title], [post_description], [post_date] FROM [posts]"
              UpdateCommand="UPDATE posts SET post_title = @post_title, post_description = @post_description WHERE Id = @Id"
              DeleteCommand="DELETE FROM posts WHERE Id = @Id"
              OnUpdating="SqlDataSource1_Updating"
             
              ></asp:SqlDataSource>
      </form>
</asp:Content>

