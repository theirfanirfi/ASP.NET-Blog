<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddPost.aspx.cs" Inherits="AddPost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="page-header">
                    Add Post
                    <small>New</small>
                </h1>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <form runat="server">
                    <label>Post Title: </label>
                    <asp:TextBox ID="post_title" name="post_tile" runat="server" class="form-control" placeholder="Post Title" style="margin:12px auto;" />
                    <label>Post Description: </label>
                    <asp:TextBox ID="texarea" TextMode="MultiLine" runat="server" CssClass="form-control" Rows="10"></asp:TextBox>

                    <asp:Button ID="Button1" runat="server" Text="Publish Post" CssClass="btn btn-success" style="margin:12px auto; float:right;" OnClick="Button1_Click" />
                
                </form>
            </div>
        </div>
    
    </div>
</asp:Content>

