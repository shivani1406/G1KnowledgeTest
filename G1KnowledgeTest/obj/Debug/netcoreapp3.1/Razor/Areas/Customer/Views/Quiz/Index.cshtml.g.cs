#pragma checksum "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4619808def2c3d5db10a6e8e0396075c74e53629"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Quiz_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Quiz/Index.cshtml")]
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
#nullable restore
#line 1 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\_ViewImports.cshtml"
using G1KnowledgeTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\_ViewImports.cshtml"
using G1KnowledgeTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4619808def2c3d5db10a6e8e0396075c74e53629", @"/Areas/Customer/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"388bb964798c5d399f6b0423ddaef7df32fc8b07", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<G1KnowledgeTest.Models.ViewModel.StudyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
   var count = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
   var correct = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n");
#nullable restore
#line 13 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
 foreach (var item in Model.QuestionsList)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n   \r\n    <tr>\r\n        <td>\r\n");
#nullable restore
#line 20 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
              
                var base64 = Convert.ToBase64String(item.Picture);
                var imgSrc = string.Format("data:image/jpg;base64,{0}", base64);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 565, "\"", 578, 1);
#nullable restore
#line 24 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 571, imgSrc, 571, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" />\r\n        </td>\r\n        <td>");
#nullable restore
#line 26 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
       Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 26 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
                 Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            <input id=\"1\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 737, "\"", 752, 1);
#nullable restore
#line 30 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 744, item.id, 744, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"custom-radio\"");
            BeginWriteAttribute("value", " value=\"", 774, "\"", 795, 1);
#nullable restore
#line 30 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 782, item.Option1, 782, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 30 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
                                                                                               Write(item.Option1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>    <input id=\"2\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 871, "\"", 886, 1);
#nullable restore
#line 32 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 878, item.id, 878, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"custom-radio\"");
            BeginWriteAttribute("value", " value=\"", 908, "\"", 929, 1);
#nullable restore
#line 32 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 916, item.Option2, 916, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 32 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
                                                                                                   Write(item.Option2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>  <input id=\"3\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 1014, "\"", 1029, 1);
#nullable restore
#line 35 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1021, item.id, 1021, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"custom-radio\"");
            BeginWriteAttribute("value", " value=\"", 1051, "\"", 1072, 1);
#nullable restore
#line 35 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1059, item.Option3, 1059, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 35 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
                                                                                                 Write(item.Option3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            <input id=\"4\" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 1148, "\"", 1163, 1);
#nullable restore
#line 37 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1155, item.id, 1155, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"custom-radio\"");
            BeginWriteAttribute("value", " value=\"", 1185, "\"", 1206, 1);
#nullable restore
#line 37 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1193, item.Option4, 1193, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 37 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
                                                                                               Write(item.Option4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n       \r\n        </td>\r\n    </tr>\r\n    <tr><td>\r\n       <label");
            BeginWriteAttribute("name", " name=", 1300, "", 1318, 1);
#nullable restore
#line 43 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1306, item.Answer, 1306, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\" id=\"cc\"></label>\r\n    <label");
            BeginWriteAttribute("name", " name=\"", 1368, "\"", 1383, 1);
#nullable restore
#line 44 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 1375, item.id, 1375, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\" style=\"display:none; color:forestgreen; font:bold;\" id=\"rb\"> Ans) \r\n");
#nullable restore
#line 45 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
           var Ans = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
         if (@item.Answer == 1)
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
     Write(Ans = @item.Option1);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
                               
        }
        else if (@item.Answer == 2)
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
     Write(Ans = @item.Option2);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
                               
        }
        else if (@item.Answer == 3)
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
     Write(Ans = @item.Option3);

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
                               
        }
        else
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
     Write(Ans = @item.Option4);

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"
                               
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </label>\r\n</td></tr>\r\n</table>\r\n");
#nullable restore
#line 62 "D:\ASP.NET Core ppt\ASP.NET Core Project\G1KnowledgeTest\G1KnowledgeTest\Areas\Customer\Views\Quiz\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(" <button id=\"but1\" type=\"button\" value=\"Submit\" class=\"btn-success\" onclick=\"displayresults();\">Submit</button>\r\n<div><label id=\"lbluseranswer\"></label></div>\r\n<div><label id=\"lblcorrectanswer\"></label></div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    \r\n    <script type=\"text/javascript\" src=\"https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.3/sweetalert.min.js\"></script>\r\n");
            }
            );
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#but1"").click(function () {
            //var x = document.getElementById(""rb"");
            //if (x.style.display === ""none"") {
            //    x.style.display = ""block"";
            //}
            $("".rb"").show();
            $("".rb"").attr(""disabled"", true);
        });
    });

    function displayresults() {
        document.getElementById(""lbluseranswer"").innerHTML = """";
        var x = document.getElementById(""rb"");
        if (x.style.display === ""none"") {
            x.style.display = ""block"";
        }
        var result = document.getElementsByTagName(""input"");
        
        var a = document.getElementById(""Answer"");
        for (i = 0; i < result.length; i++) {
            if (result[i].type == ""radio"") {
                
                    if (result[i].checked) {
                        document.get");
            WriteLiteral("ElementById(\"lbluseranswer\").innerHTML += \"Q \" + result[i].name + \")\" + \" Your Selected Answer Is\" + result[i].value + \"<br\\>\"  ;\r\n");
            WriteLiteral("                    }\r\n                \r\n            }\r\n        }\r\n");
            WriteLiteral(@"    }

    //document.getElementById(""opt"").onclick = function () {

    //    document.getElementById(""divMsg"").style.display = ""none"";

    //}
    //function showHideDiv(ele) {
    //    var srcElement = document.getElementById(ele);
    //    if (srcElement != null) {
    //        if (srcElement.style.display == ""block"") {
    //            //srcElement.style.display = 'none';
    //        }
    //        else {
    //            srcElement.style.display = 'block';
    //        }
    //        return false;
    //    }
    //}
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<G1KnowledgeTest.Models.ViewModel.StudyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591