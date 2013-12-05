﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcFundamentals.Data.Movie>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary("Edit failed") %>
    <fieldset>
        <legend>Movie</legend>
        
        <%: Html.HiddenFor(model => model.Id) %>
        
        <div>
            <%=Html.Image(Model.Image, Model.Title) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Title) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Title) %>
            <%: Html.ValidationMessageFor(model => model.Title, "*") %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ReleaseDate) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ReleaseDate) %>
            <%: Html.ValidationMessageFor(model => model.ReleaseDate, "*") %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
