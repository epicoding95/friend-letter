#pragma checksum "/Users/Guest/Desktop/friend-letter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8ae7bdae29a67a5ac13bafdc4f2f58fa3509cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Postcard), @"mvc.1.0.view", @"/Views/Home/Postcard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Postcard.cshtml", typeof(AspNetCore.Views_Home_Postcard))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff8ae7bdae29a67a5ac13bafdc4f2f58fa3509cf", @"/Views/Home/Postcard.cshtml")]
    public class Views_Home_Postcard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<h1>Hello From Afar</h1>\n<p>Dear ");
            EndContext();
            BeginContext(34, 15, false);
#line 2 "/Users/Guest/Desktop/friend-letter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
   Write(Model.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(49, 88, true);
            WriteLiteral(",</p>\n<p>How are you? I hope that you are having a nice weekend. I\'m vacationing in the ");
            EndContext();
            BeginContext(138, 14, false);
#line 3 "/Users/Guest/Desktop/friend-letter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                                                                             Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(152, 36, true);
            WriteLiteral(" while I learn programming! </p>\n<p>");
            EndContext();
            BeginContext(189, 15, false);
#line 4 "/Users/Guest/Desktop/friend-letter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
Write(Model.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(204, 217, true);
            WriteLiteral(", you would not believe how cold it is here. I should have gone to Hawaii instead.</p>\n<p>But I like programming a lot, so I\'ve got that going for me. </p>\n<p>Looking forward to seeing you soon. I\'ll bring you back a ");
            EndContext();
            BeginContext(422, 11, false);
#line 6 "/Users/Guest/Desktop/friend-letter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                                                        Write(Model.Items);

#line default
#line hidden
            EndContext();
            BeginContext(433, 44, true);
            WriteLiteral(" . </p>\n<p>Cheers,</p>\n<p>Travel Enthusiast ");
            EndContext();
            BeginContext(478, 12, false);
#line 8 "/Users/Guest/Desktop/friend-letter/FriendLetter.Solution/FriendLetter/Views/Home/Postcard.cshtml"
                Write(Model.Sender);

#line default
#line hidden
            EndContext();
            BeginContext(490, 4, true);
            WriteLiteral("</p>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
