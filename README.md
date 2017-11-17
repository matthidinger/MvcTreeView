# MvcTreeView Helper

This fluent MVC TreeView helper makes it easy to build and customize an HTML unordered-list tree from a recursive model.

[Check out the associated blog post](http://matthidinger.com/archive/2011/11/27/Writing-a-Fluent-ASP-NET-MVC-Recursive-TreeView-Helper)

## Usage

```csharp
@model List<MvcTreeView.Models.Location>

@(Html.TreeView(Model)
    .EmptyContent("No locations have been defined yet!")    
    .Children(m => m.ChildLocations)
    .HtmlAttributes(new { id = "tree"})
    .ChildrenHtmlAttributes(new { @class = "subItem"})
    .ItemText(m => m.Name)
    .ItemTemplate(
        @<text>
            <a href="#@item.Id">@item.Name</a>
        </text>)
)
```
