#pragma checksum "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f6d769d21657c7f1b6057bdf1f00a08f831ddf6"
// <auto-generated/>
#pragma warning disable 1591
namespace SEPCSTier1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using SEPCSTier1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using SEPCSTier1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
using BlazorTailwind.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignUp")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-6solt7yd44>SignUp</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container rounded bg-white mt-5 mb-5");
            __builder.AddAttribute(3, "b-6solt7yd44");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddAttribute(6, "b-6solt7yd44");
            __builder.AddMarkupContent(7, @"<div class=""col-md-3 border-right"" b-6solt7yd44><div class=""d-flex flex-column align-items-center text-center p-3 py-5"" b-6solt7yd44><img class=""rounded-circle mt-5"" width=""150px"" src=""https://st3.depositphotos.com/15648834/17930/v/600/depositphotos_179308454-stock-illustration-unknown-person-silhouette-glasses-profile.jpg"" b-6solt7yd44><span class=""font-weight-bold"" b-6solt7yd44>Welcome</span><span class=""text-black-50"" b-6solt7yd44>To CSGO Trading</span><span b-6solt7yd44></span></div></div>
        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-5 border-right");
            __builder.AddAttribute(10, "b-6solt7yd44");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "p-3 py-5");
            __builder.AddAttribute(13, "b-6solt7yd44");
            __builder.AddMarkupContent(14, "<div class=\"d-flex justify-content-between align-items-center mb-3\" b-6solt7yd44><h4 class=\"text-right\" b-6solt7yd44>Profile Settings</h4></div>\r\n                ");
            __builder.AddMarkupContent(15, @"<div class=""row mt-2"" b-6solt7yd44><div class=""col-md-6"" b-6solt7yd44><label class=""labels"" b-6solt7yd44>Name</label><input type=""text"" class=""form-control"" placeholder=""first name"" value b-6solt7yd44></div>
                    <div class=""col-md-6"" b-6solt7yd44><label class=""labels"" b-6solt7yd44>Surname</label><input type=""text"" class=""form-control"" value placeholder=""surname"" b-6solt7yd44></div></div>
                ");
            __builder.AddMarkupContent(16, "<div class=\"row mt-3\" b-6solt7yd44><div class=\"col-md-12\" b-6solt7yd44><label class=\"labels\" b-6solt7yd44>Mobile Number</label>\r\n                        <input type=\"text\" class=\"form-control\" placeholder=\"enter phone number\" bind-value=\"phone\" b-6solt7yd44></div>\r\n                    <div class=\"col-md-12\" b-6solt7yd44><label class=\"labels\" b-6solt7yd44>Address Line 1</label><input type=\"text\" class=\"form-control\" placeholder=\"enter address line 1\" value b-6solt7yd44></div>\r\n                    <div class=\"col-md-12\" b-6solt7yd44><label class=\"labels\" b-6solt7yd44>Address Line 2</label><input type=\"text\" class=\"form-control\" placeholder=\"enter address line 2\" value b-6solt7yd44></div>\r\n                    <div class=\"col-md-12\" b-6solt7yd44><label class=\"labels\" b-6solt7yd44>Postcode</label><input type=\"text\" class=\"form-control\" placeholder=\"enter address line 2\" value b-6solt7yd44></div>\r\n                    <div class=\"col-md-12\" b-6solt7yd44><label class=\"labels\" b-6solt7yd44>State</label><input type=\"text\" class=\"form-control\" placeholder=\"enter address line 2\" value b-6solt7yd44></div>\r\n                    <div class=\"col-md-12\" b-6solt7yd44><label class=\"labels\" b-6solt7yd44>Area</label><input type=\"text\" class=\"form-control\" placeholder=\"enter address line 2\" value b-6solt7yd44></div>\r\n                    <div class=\"col-md-12\" b-6solt7yd44><label class=\"labels\" b-6solt7yd44>Email ID</label><input type=\"text\" class=\"form-control\" placeholder=\"enter email id\" value b-6solt7yd44></div>\r\n                    <div class=\"col-md-12\" b-6solt7yd44><label class=\"labels\" b-6solt7yd44>Password</label><input type=\"password\" class=\"form-control\" placeholder=\"Password\" value b-6solt7yd44></div></div>\r\n                ");
            __builder.AddMarkupContent(17, @"<div class=""row mt-3"" b-6solt7yd44><div class=""col-md-6"" b-6solt7yd44><label class=""labels"" b-6solt7yd44>Country</label><input type=""text"" class=""form-control"" placeholder=""country"" value b-6solt7yd44></div>
                    <div class=""col-md-6"" b-6solt7yd44><label class=""labels"" b-6solt7yd44>State/Region</label><input type=""text"" class=""form-control"" value placeholder=""state"" b-6solt7yd44></div></div>
                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "mt-5 text-center");
            __builder.AddAttribute(20, "b-6solt7yd44");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
                                                                newUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-primary profile-button");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "b-6solt7yd44");
            __builder.AddContent(26, "Sign Up");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\markh\RiderProjects\SEPCSTier1\SEPCSTier1\Pages\SignUp.razor"
       
    private string password;
    private string firstName;
    private string lastName;
    private string phone; 

    public async Task newUser()
    {
        Console.WriteLine("HEj " + phone );
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
