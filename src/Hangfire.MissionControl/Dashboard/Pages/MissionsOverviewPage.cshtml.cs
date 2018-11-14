#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.MissionControl.Dashboard.Pages
{
    using System;
    using System.Collections.Generic;
    
    #line 2 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 3 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using Hangfire.MissionControl;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using Hangfire.MissionControl.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
    using Hangfire.MissionControl.Dashboard.Pages.Controls;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class MissionsOverviewPage : Hangfire.Dashboard.RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








            
            #line 8 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
  
    string selectedCategory = this.SelectedCategory;
    MissionMap missionMap = this.MissionMap;
    Layout = new LayoutPage(Title);
    var availableMissions = missionMap.Missions.Where(x => x.Value.CategoryName == selectedCategory).Select(x => x.Value).ToArray();


            
            #line default
            #line hidden
WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
            #line 15 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                        Write(Url.To("/mission-control/cssstyles"));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n<script>\r\n    var baseUrl = \"");


            
            #line 17 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
              Write(Url.To("/mission/launch"));

            
            #line default
            #line hidden
WriteLiteral("\";\r\n    var idFieldName = \"");


            
            #line 18 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                  Write(Mission.IdField);

            
            #line default
            #line hidden
WriteLiteral("\";\r\n</script>\r\n<script type=\"text/javascript\" src=\"");


            
            #line 20 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                               Write(Url.To("/mission-control/jspage"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 24 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
   Write(CategoriesSidebar.Render(Html, selectedCategory, missionMap));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">");


            
            #line 27 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                           Write(selectedCategory);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");


            
            #line 28 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
         foreach (var mission in availableMissions)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"panel panel-default\">\r\n                <div class=\"panel-" +
"heading\">\r\n                    <h3 class=\"panel-title\">");


            
            #line 32 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                       Write(mission.Name);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"panel-body\">\r\n");


            
            #line 35 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                     if (!string.IsNullOrWhiteSpace(mission.Description))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <p>");


            
            #line 37 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                      Write(mission.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");


            
            #line 38 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <form id=\"");


            
            #line 40 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                         Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 41 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                         foreach (var parameter in mission.MethodInfo.GetParameters())
                        {
                            var control = ControlFactory.CreateControl(parameter, mission);
                            if (control is NullControl) { continue; }


            
            #line default
            #line hidden
WriteLiteral("                            <div class=\"form-group\">\r\n                           " +
"     ");


            
            #line 47 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                           Write(Html.RenderPartial(control));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n");


            
            #line 49 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-info\" onclick=\"onM" +
"issionStart(event, \'");


            
            #line 51 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                                                                                              Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("\');return false;\">Enqueue</button>\r\n                    </form>\r\n                " +
"</div>\r\n                <div id=\"");


            
            #line 54 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                    Write(mission.Id);

            
            #line default
            #line hidden
WriteLiteral("-alerts\" class=\"panel-footer\"></div>\r\n            </div>\r\n");


            
            #line 56 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
