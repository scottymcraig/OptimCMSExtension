# OptimCMS Extension

OptimCMS is a Pure HTML headless CMS designed in ASP.net Core.  OptimCMS's Headless Pure HTML approach allows you to build sites with rapidly changing content without all of the overhead. We allow you to develop and your content creators to create content.

OptimCMS Extension allows you to easily integrate OptimCMS into your project.

### Prerequisites

ASP.Net Core 2.1

### Installing

1)  Install the package via Nuget or manually
2)  Reference the package in your using statement
2)  Implement as shown below

## Implementation

For the new API, you will use the following:

```csharp
using OptimCMSExtension;

public async Task<IActionResult> MyController()
{
    var optimConfig = new OptimApiConfig("Project", "Schema", "MyApiKey");
    ViewBag.MyData = await OptimCMS.OptimApiData(optimConfig);

    return View();
}
```

If you are using the old API, you will need to use the following code:

```csharp
using OptimCMSExtension;

public async Task<IActionResult> MyController()
{
    var optimConfig = new OptimOldApiConfig("Group", "SubGroup", "MyApiKey");
    ViewBag.MyData = await OptimCMS.OptimOldApiData(optimConfig);

    return View();
}
```