﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TemplateSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    public partial class PreProcessedTemplate : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

        #line 3 "D:\Code\CodePlex\RazorGenerator\samples\TemplateSample\PreProcessedTemplate.cshtml"

    public IEnumerable<TemplateSample.TestResult> TestResults { get; set; }

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n\r\n");


WriteLiteral("\r\n\r\n<?xml version=\"1.0\" ?>\r\n<tests>\r\n");


            
            #line 9 "D:\Code\CodePlex\RazorGenerator\samples\TemplateSample\PreProcessedTemplate.cshtml"
     foreach (var result in TestResults) { 

            
            #line default
            #line hidden
WriteLiteral("        <test id=\"");


            
            #line 10 "D:\Code\CodePlex\RazorGenerator\samples\TemplateSample\PreProcessedTemplate.cshtml"
             Write(result.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            <name>");


            
            #line 11 "D:\Code\CodePlex\RazorGenerator\samples\TemplateSample\PreProcessedTemplate.cshtml"
             Write(result.Name);

            
            #line default
            #line hidden
WriteLiteral("</name>\r\n            <result>\r\n");


            
            #line 13 "D:\Code\CodePlex\RazorGenerator\samples\TemplateSample\PreProcessedTemplate.cshtml"
             if(result.Passed) {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral(" Success\r\n");


            
            #line 15 "D:\Code\CodePlex\RazorGenerator\samples\TemplateSample\PreProcessedTemplate.cshtml"
            }
            else{

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral(" Failed\r\n");


            
            #line 18 "D:\Code\CodePlex\RazorGenerator\samples\TemplateSample\PreProcessedTemplate.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            </result>\r\n        </test>\r\n");


            
            #line 21 "D:\Code\CodePlex\RazorGenerator\samples\TemplateSample\PreProcessedTemplate.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</test>\r\n");


        }
    }
}
#pragma warning restore 1591
