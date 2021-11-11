// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MarathonTutorialWebsite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using MarathonTutorialWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using MarathonTutorialWebsite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Pages\TestForm.razor"
using MarathonTutorialWebsite.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Pages\TestForm.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Pages\TestForm.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/test_form")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/test_form/{title}")]
    public partial class TestForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 202 "C:\Users\Jmorrow\Desktop\code\work-code\blazor\MarathonTutorialWebsite\Pages\TestForm.razor"
       
    [Parameter]
    public string Title { get; set; }
    private List<Question> Questions { get; set; }
    private FormDataEntry Entry { get; set; }
    private bool isSubmitted { get; set; } = false;
    private bool isPassed { get; set; } = false;
    private int totalPossible { get => Questions.Count; }
    private int totalCorrect { get; set; } = 0;
    private int Percentage { get; set; } = 0;
    private string UniqueCode { get; set; }
    private ElementReference formRef { get; set; }
    private ElementReference confirmationRef { get; set; }

    protected override void OnParametersSet()
    {
        Title = Title ?? "";
        formDataService.LoadFormDataFromJson(Title);
        Entry = formDataService.Entry;

        var selected_language = CultureInfo.CurrentCulture.Name;
        if (selected_language == "en-US")
        {
            Questions = formDataService.Entry.English.Questions;
        }
        else if (selected_language == "es-ES")
        {
            Questions = formDataService.Entry.Spanish.Questions;
        }
    }

    private async void GoToVideo()
    {
        await JSRuntime.InvokeVoidAsync("thisAppFunctions.HistoryGoBack", null);
    }

    private void GoToVideoList()
    {
        navigationManager.NavigateTo("/");
    }

    public void SubmitForm()
    {
        isSubmitted = true;
        CalculateScore();

        if (Percentage >= 70)
            SendEmail();
    }

    private void CalculateScore()
    {
        foreach (var q in Questions)
        {
            if (q.SelectedAnswer == null) continue;

            if (q.Answers.A == null) continue;
            if (q.Answers.A.IsCorrect && q.SelectedAnswer.Equals(q.Answers.A.AnswerText))
            {
                totalCorrect++;
                continue;
            }

            if (q.Answers.B == null) continue;
            if (q.Answers.B.IsCorrect && q.SelectedAnswer.Equals(q.Answers.B.AnswerText))
            {
                totalCorrect++;
                continue;
            }

            if (q.Answers.C == null) continue;
            if (q.Answers.C.IsCorrect && q.SelectedAnswer.Equals(q.Answers.C.AnswerText))
            {
                totalCorrect++;
                continue;
            }

            if (q.Answers.D == null) continue;
            if (q.Answers.D.IsCorrect && q.SelectedAnswer.Equals(q.Answers.D.AnswerText))
            {
                totalCorrect++;
                continue;
            }
        }

        Percentage = (int)Math.Round(((float)totalCorrect / (float)totalPossible) * 100.0);

        if (Percentage >= 70)
        {
            isPassed = true;
            UniqueCode = RandomString(6);
        }

    }

    public static string RandomString(int length)
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    private void SendEmail()
    {
        var email = "safetytests@marathonelectrical.com";
        var onboard_email = "safetyonboarding@marathonelectrical.com";

        MailMessage msg = new MailMessage();
        msg.From = new MailAddress(email);
        msg.To.Add(email);
        msg.To.Add(onboard_email);
        msg.Subject = GetMessageSubject();
        msg.IsBodyHtml = true;
        msg.Body = GetMessageBody();

        var creds = new System.Net.NetworkCredential();
        creds.UserName = email;
        creds.Password = @"Rm@n2021*!";

        SmtpClient client = new SmtpClient("smtp.office365.com", 587);
        client.UseDefaultCredentials = false;
        client.Credentials = creds;
        client.EnableSsl = true;

        client.Send(msg);
    }

    private string GetMessageSubject()
    {
        var subject = "";
        if (string.IsNullOrWhiteSpace(Entry.FullName))
        {
            subject += "An Employee ";
        }
        else
        {
            subject += Entry.FullName + " ";
        }
        subject += "has completed the " + Title + " Test";
        return subject;
    }

    private string GetMessageBody()
    {
        var body = "<h1>Score: " + totalCorrect + "/" + totalPossible + " -> " + Percentage + "%" + "</h1><!--!-->" +
        "<h1>Unique Code: " + UniqueCode + "</h1><!--!-->";

        var email = string.IsNullOrWhiteSpace(Entry.EmailAddress) ? "No Email Address Provided" : Entry.EmailAddress;
        var fname = string.IsNullOrWhiteSpace(Entry.FullName) ? "No Name Provided" : Entry.FullName;

        body += "<h1>Test Name: " + Title + "</h1><!--!-->";
        body += "<h1>Full Employee Name: " + fname + "</h1><!--!-->";
        body += "<h1>Employee Email: " + email + "</h1><!--!--><hr /><!--!-->";

        foreach (var q in Questions)
        {
            body += "<h3>Question: " + q.Text + "</h3><!--!-->";
            body += "<p>Answer: " + q.SelectedAnswer + "</p><!--!-->";
        }

        return body;
    }

    private void Test(string text)
    {
        JSRuntime.InvokeVoidAsync("alert", text);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FormDataService formDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> localizer { get; set; }
    }
}
#pragma warning restore 1591
