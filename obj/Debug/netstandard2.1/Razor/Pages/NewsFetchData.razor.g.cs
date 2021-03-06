#pragma checksum "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1903f721f1744bc945d9547ba501eaf43e8bd29"
// <auto-generated/>
#pragma warning disable 1591
namespace CA3_BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using CA3_BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using CA3_BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
using System.Runtime.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newsfetch")]
    public partial class NewsFetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-align:center; font-family:cursive; border:dashed;\">News API</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<style>\r\n    .dot {\r\n        border-style: dotted;\r\n    }\r\n</style>");
#nullable restore
#line 14 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
 if (query.newsData == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading ...</em></p>");
#nullable restore
#line 17 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "<label for=\"name\"><strong>Search Types </strong> (Sports,Bitcoin) :</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "id", "name");
            __builder.AddAttribute(7, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 22 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                                 PressEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(10, " ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                                                                  GetNewsAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(14, "div");
            __builder.OpenElement(15, "form");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group");
            __builder.AddMarkupContent(18, "<label for=\"exampleFormControlSelect1\"><strong>Filter Sources</strong></label>\r\n                ");
            __builder.OpenElement(19, "select");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "id", "exampleFormControlSelect1");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                               query.filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => query.filter = __value, query.filter));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", " ");
            __builder.AddContent(26, "All");
            __builder.CloseElement();
#nullable restore
#line 32 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                     foreach (var item in query.SourceList())
                    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "option");
            __builder.AddContent(28, 
#nullable restore
#line 35 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                 item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 36 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    <br>");
#nullable restore
#line 43 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
     if (found)
    {


        

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
         if (query.newsData.articles.Count == 0)
        {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<p>Nothing found</p>");
#nullable restore
#line 51 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "div");
            __builder.AddMarkupContent(32, "<strong>Total Result : </strong>");
            __builder.AddContent(33, 
#nullable restore
#line 54 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                                  query.newsData.totalResults

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "<br>\r\n            ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                              () => query.SortDateByDateAscending()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Ascending");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                              () => query.SortDateByDateDescending()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Descending");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            <br>");
            __builder.AddMarkupContent(43, "<br>");
#nullable restore
#line 62 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"

            foreach (var article in query.newsData.articles)
            {
                if (article.filterArticle(query.filter))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "dot");
            __builder.OpenElement(46, "div");
            __builder.OpenElement(47, "h5");
            __builder.AddMarkupContent(48, "<strong>Source : </strong> ");
            __builder.AddContent(49, 
#nullable restore
#line 68 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                                             article.source.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "div");
            __builder.OpenElement(52, "h5");
            __builder.AddMarkupContent(53, "<strong>Author : </strong> ");
            __builder.AddContent(54, 
#nullable restore
#line 69 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                                             article.author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "div");
            __builder.OpenElement(57, "h5");
            __builder.AddMarkupContent(58, "<strong>Publish Date : </strong> ");
            __builder.AddContent(59, 
#nullable restore
#line 70 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                                                   article.publishedAt.ToLongDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "div");
            __builder.OpenElement(62, "h5");
            __builder.AddMarkupContent(63, "<strong>Title :</strong> ");
            __builder.AddContent(64, 
#nullable restore
#line 71 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                                            article.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "div");
            __builder.OpenElement(67, "h5");
            __builder.AddMarkupContent(68, "<strong>Description :</strong> ");
            __builder.AddContent(69, 
#nullable restore
#line 72 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                                                 article.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "div");
            __builder.OpenElement(72, "h5");
            __builder.AddMarkupContent(73, "<strong>URLs : </strong>");
            __builder.OpenElement(74, "a");
            __builder.AddAttribute(75, "href", 
#nullable restore
#line 73 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                                                                   article.url

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(76, "Link to Article");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    <br>");
#nullable restore
#line 77 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
                }
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
       

    private string errormessage;
    private bool found;

    NewsQueryData query = new NewsQueryData();

    public string name { get; set; } = "sports";

    public async Task GetNewsAsync()
    {
        found = false;
        try
        {
            string uri = "https://newsapi.org/v2/everything?q=" + name + "&apiKey=f74374b084a74f87a9c6270128e9962e";

            query.newsData = await Http.GetFromJsonAsync<Root>(uri);
            found = true;
            errormessage = String.Empty;
        }
        catch (Exception e)
        {
            errormessage = e.Message;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        await GetNewsAsync();
    }


    public async Task PressEnter(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await GetNewsAsync();
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
