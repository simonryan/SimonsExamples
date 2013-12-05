<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcFundamentals.Models.MovieListModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            Title
        </th>
        <th>
            ReleaseDate
        </th>
        <th>Image</th>
        <th></th>
    </tr>

<% foreach (var item in Model.Movies) { %>
    <% Html.RenderPartial("MovieItem", item); %>
<% } %>

</table>

</asp:Content>
