#pragma checksum "C:\src\goose2s\Components\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b493dc69dc30c3da05055fe257b22ab6b1320817"
// <auto-generated/>
#pragma warning disable 1591
namespace goose2s.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\src\goose2s\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\src\goose2s\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\src\goose2s\_Imports.razor"
using goose2s;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\src\goose2s\_Imports.razor"
using goose2s.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\src\goose2s\Components\Search.razor"
using goose2s.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\goose2s\Components\Search.razor"
using goose2s.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\goose2s\Components\Search.razor"
using goose2s.Models;

#line default
#line hidden
#nullable disable
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 28 "C:\src\goose2s\Components\Search.razor"
 if (spotify.CurrentContext == null || spotify.CurrentContext.Auth.Failure)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Not logged in</em></p>\r\n");
#nullable restore
#line 31 "C:\src\goose2s\Components\Search.razor"
}
else if (results == null) 
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\src\goose2s\Components\Search.razor"
                                  SearchChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<p><em>No results</em></p>\r\n");
#nullable restore
#line 38 "C:\src\goose2s\Components\Search.razor"
}
else if (results.Failure) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "    ");
            __builder.AddMarkupContent(11, "<div>\r\n        Please try again, there was an error with the Search.\r\n    </div>\r\n");
#nullable restore
#line 43 "C:\src\goose2s\Components\Search.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 47 "C:\src\goose2s\Components\Search.razor"
                                  SearchChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "core");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<thead>\r\n            <tr>\r\n                <th>...</th>\r\n                <th>Image</th>\r\n                <th>Name</th>\r\n                <th>Artist</th>\r\n                <th>Popularity</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(25, "tbody");
            __builder.AddMarkupContent(26, "            \r\n");
#nullable restore
#line 61 "C:\src\goose2s\Components\Search.razor"
     foreach (var result in results.tracks.items)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "            ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "id", 
#nullable restore
#line 64 "C:\src\goose2s\Components\Search.razor"
                                 result.id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\src\goose2s\Components\Search.razor"
                                                        e => Add(e, result)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "+");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "img");
            __builder.AddAttribute(38, "src", 
#nullable restore
#line 65 "C:\src\goose2s\Components\Search.razor"
                               result.album?.images.OrderBy(i=>i.width).First().url

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 66 "C:\src\goose2s\Components\Search.razor"
                     result.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 67 "C:\src\goose2s\Components\Search.razor"
                     result.artists[0].name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "  \r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenComponent<goose2s.Components.Meter>(48);
            __builder.AddAttribute(49, "Level", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 69 "C:\src\goose2s\Components\Search.razor"
                                   result.popularity

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "      \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 72 "C:\src\goose2s\Components\Search.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 76 "C:\src\goose2s\Components\Search.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\src\goose2s\Components\Search.razor"
       
    [CascadingParameter]
    private SpotifyStateProvider spotify { get; set; }
    private SearchResults results { get; set; }
    private async Task SearchChanged(ChangeEventArgs e)
    {
        results = await search.SearchTrack(e.Value.ToString(), spotify.CurrentContext.Auth.access_token);
    }
    private void Add(MouseEventArgs e, SpotifyItem item) {
        try {
            spotify.Enqueue("static", item);
            StateHasChanged();
        }
        catch (Exception ex)
        {
            //why you stoppy
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SearchService search { get; set; }
    }
}
#pragma warning restore 1591
