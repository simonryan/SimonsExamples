<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MvcFundamentals.Movie>" %>
<tr>
    <td>
        <%: Html.DisplayFor(modelItem => Model.Title) %>
    </td>
    <td>
        <%: Html.DisplayFor(modelItem => Model.ReleaseDate) %>
    </td>
    <td>
        <%= Html.Image(Model.Image, Model.Title) %>
    </td>
    <td>
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.Id }) %> |
        <%: Html.ActionLink("Details", "Details", new { id=Model.Id }) %> |
        <%: Html.ActionLink("Delete", "Delete", new { id=Model.Id }) %>
    </td>
</tr>

