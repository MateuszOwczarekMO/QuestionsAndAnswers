using QuestionsAndAnswers.Web.Services;
using QuestionsAndAnswers.Web.Settings;

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: false)
        .Build();

var apiSettings = config.GetSection(nameof(ApiSettings)).Get<ApiSettings>();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddHttpClient<IQnAService, QnAService>(client =>
{
    client.BaseAddress = new Uri(apiSettings.Host);
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
