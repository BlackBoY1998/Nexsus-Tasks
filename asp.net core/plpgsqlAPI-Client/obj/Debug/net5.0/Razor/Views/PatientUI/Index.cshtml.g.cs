#pragma checksum "D:\akash\study\asp.net core\plpgsqlAPI-Client\Views\PatientUI\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29b674ce541ba66b329f7b9a7369377ba28ed8e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PatientUI_Index), @"mvc.1.0.view", @"/Views/PatientUI/Index.cshtml")]
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
#line 1 "D:\akash\study\asp.net core\plpgsqlAPI-Client\Views\_ViewImports.cshtml"
using plpgsqlAPI_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\akash\study\asp.net core\plpgsqlAPI-Client\Views\_ViewImports.cshtml"
using plpgsqlAPI_Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29b674ce541ba66b329f7b9a7369377ba28ed8e4", @"/Views/PatientUI/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c55c16fb919fe5e2f08e6ee8cb32977b1db49aa", @"/Views/_ViewImports.cshtml")]
    public class Views_PatientUI_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29b674ce541ba66b329f7b9a7369377ba28ed8e43471", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h2> Add Customer </h2>
<div class=""form-group"" style=""display:none;"">
    <input id=""txtid"" class=""form-control"" name=""pid"" />
</div>
<div class=""form-group"">
    <label for=""PatientName""> Name:</label>
    <input id=""txtName"" class=""form-control"" name=""pname"" />
</div>
<div>
    <label for=""patientaddress"">address:</label>
    <input id=""txtaddress"" class=""form-control"" name=""paddress"" />
</div>
<div>
    <label for=""patientCity"">city:</label>
    <input id=""txtcity"" class=""form-control"" name=""pcity"" />
</div>
<div>
    <label for=""patientAge"">Age:</label>
    <input id=""txtage"" class=""form-control"" name=""page"" />
</div>
<div>
    <label for=""patientGender"">Gender:</label>
    <input id=""txtgender"" class=""form-control"" name=""pgender"" />
</div>
<br />

<div class=""text-center panel-body"">
    <button id=""btnSave"" class=""btn btn-primary"" style=""width:100px"">Save</button>
</div>

<h2> List Of Data</h2>
<table id=""tblCust"" class=""table table-sm table-striped table-bordered m-2");
            WriteLiteral(@""">
    <thead>
        <tr>
            <th>PatientName</th>
            <th>Patientaddress</th>
            <th>PatientCity</th>
            <th>PatientAge</th>
            <th>PatientGender</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
    </tbody>

</table>
<script type=""text/javascript"">
    $(document).ready(function () {
        getAllData();
    });
    $(""#btnSave"").click(function () {
        debugger;
        var PatientID = $(""#txtid"").val();
        if (PatientID == 0) {
            var data = {
                pid: $(""#txtid"").val(),
                pname: $(""#txtName"").val(),
                paddress: $(""#txtaddress"").val(),
                pcity: $(""#txtcity"").val(),
                page: $(""#txtage"").val(),
                pgender: $(""#txtgender"").val(),

            };
            $.post(""/PatientUI/AddUpdatePatient"", data).done(function (data) {
                getAllData();
            });
        }
        else {
            U");
            WriteLiteral(@"pdateCustomer(PatientID)
        }
    });
    function getAllData() {
        debugger;
        $.getJSON(""/PatientUI/GetAllPatients"", function (patients) {
            $(""#tblCust  tbody tr"").remove();
            $.map(patients, function (patient) {
                $(""#tblCust tbody"").append(""<tr>""
                    + ""<td>"" + patient.name + ""</td>""
                    + ""<td>"" + patient.address + ""</td>""
                    + ""<td>"" + patient.city + ""</td>""
                    + ""<td>"" + patient.age + ""</td>""
                    + ""<td>"" + patient.gender + ""</td>""
                    + ""<td>""
                    + "" <button  class='btn btn-primary' Onclick='EditCustomer("" + patient.id + "")' style='margin-right:5px;'>Edit</button>""
                    + "" <button  class='btn btn-danger' Onclick='DeleteCustomer("" + patient.id + "")'>Delete</button>""
                    + ""</td>""
                    + ""<tr>"")
            });
        });
    }


    function EditCustomer(PatientID) {
            WriteLiteral(@"

        if (PatientID > 0) {
            debugger;
            $.getJSON(""/PatientUI/GetPatientById?id="" + PatientID, function (patient) {

                $(""#txtid"").val(patient.id);
                $(""#txtName"").val(patient.name);
                $(""#txtaddress"").val(patient.address);
                $(""#txtcity"").val(patient.city);
                $(""#txtage"").val(patient.age);
                $(""#txtgender"").val(patient.gender);
            });
        }
    }
    function UpdateCustomer(patientID) {
        debugger;
        if (patientID > 0) {
            $.ajax({
                url: '/PatientUI/AddUpdatePatient?id=' + patientID,
                type: 'POST',
                dataType: 'JSON',
                success: function (data) {
                    getAllData();
                },
                error: function (ex) {
                    alert(ex);
                }
            });

        }
    }
    function DeleteCustomer(patientID) {
        if (patientID");
            WriteLiteral(@" > 0) {
            $.ajax({
                url: '/PatientUI/Deletepatient?id=' + patientID,
                type: 'DELETE',
                dataType: 'JSON',
                success: function (data) {
                    getAllData
                },
                error: function (ex) {
                    alert(ex);
                }
            });
        }
    }
</script>
");
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