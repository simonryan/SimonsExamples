<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>
    <ul>
        <li><%=Html.ActionLink("Async controller", "Index", "AsyncExample") %></li>
        
        <li><%=Html.ActionLink("Link to another area", "Index", "Home", new {area="Admin"}, null) %></li>
        
        <div>
            <%Html.RenderAction("Index", "PartialAction"); %>
        </div>
    </ul>
</asp:Content>
