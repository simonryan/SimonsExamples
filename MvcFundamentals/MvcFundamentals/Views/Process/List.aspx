<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<List<System.Diagnostics.Process>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>List</h2>
<%
    foreach (var process in Model)
    {%>
    <%= Html.ActionLink(process.ProcessName, "Details", new {id = process.Id}) %><br/>
<% }
     %>
</asp:Content>
