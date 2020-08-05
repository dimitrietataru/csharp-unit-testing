# C# Unit Testing

![Coverage](https://github.com/dimitrietataru/csharp-unit-testing/blob/master/Coverage.png)

## Table of contents

* [NuGet packages](#nuget-packages)
* [Syntax](#syntax)
  * [Given-When-Then](#given-when-then-pattern)
  * [Arrange-Act-Assert](#arrange-act-assert-pattern)
  * [Moq](#moq-setup-and-verify)
  * [Assertions](#assertions)
* [Collect code coverage](#collect-code-coverage)
* [Generate code coverage report](#generate-code-coverage-report)


## NuGet packages
- **Frameworks**
  - [NUnit](https://www.nuget.org/packages/NUnit)
  - [xUnit](https://www.nuget.org/packages/xunit)
- **Mocking**
  - [Moq](https://www.nuget.org/packages/Moq)
- **Code coverage**
  - [coverlet.collector](https://www.nuget.org/packages/coverlet.collector)
  - [ReportGenerator](https://www.nuget.org/packages/ReportGenerator)
- **Utils**
  - [Bogus](https://www.nuget.org/packages/Bogus)
  - [Shouldly](https://www.nuget.org/packages/shouldly)
  - [FluentAssertions](https://www.nuget.org/packages/FluentAssertions)


## Syntax

#### Given-When-Then pattern
[Martin Fowler's blog](https://www.martinfowler.com/bliki/GivenWhenThen.html)

#### Arrange-Act-Assert pattern
[Docs.Microsoft](https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2019#write-your-tests)

#### Moq setup and verify

``` csharp
// Setup async method when it returns data
mockService
    .Setup(_ => _.GetAsync(It.IsAny<int>()))
    .ReturnsAsync(It.IsAny<Data>())
    .Verifiable();

// Setup async method when it executes without a return type
mockService
    .Setup(_ => _.RunAsync())
    .ReturnsAsync(Task.CompletedTask)
    .Verifiable();

// Setup async method when it throws an exception
mockService
    .Setup(_ => _.RunAsync(It.IsAny<int>()))
    .Throws<Exception>()
    .Verifiable();

// Verify all service methods, marked as 'Verifiable'
mockService.VerifyAll();

// Verify individual service method
mockService.Verify(_ => _.GetAsync(It.IsAny<int>()), Times.Once);
mockService.Verify(_ => _.RunAsync(), Times.Exactly(2));
mockService.Verify(_ => _.RunAsync(It.IsAny<int>()), Times.Never);
```

#### Assertions

``` csharp
// NUnit
Assert.That(result, Is.InstanceOf<ObjectResult>());
var apiResponse = result as OkObjectResult;
Assert.That(apiResponse.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));

// xUnit
var apiResponse = Assert.IsType<OkObjectResult>(result);
Assert.Equal((int)HttpStatusCode.OK, apiResponse.StatusCode);

// FluentAssertions
result
    .Should().BeOfType<OkObjectResult>("because we return content")
    .Which.StatusCode.Should().Be((int)HttpStatusCode.OK);
    
// Shouldly
result.ShouldSatisfyAllConditions(
    () => result.ShouldBeOfType<OkObjectResult>(),
    () => (result as OkObjectResult).StatusCode.ShouldBe((int)HttpStatusCode.OK));
```


## Collect code coverage

#### Install *coverlet.collector* NuGet package
``` powershell
PM> Install-Package coverlet.collector -Version 1.3.0
```

#### *TestProject.csproj* configuration
``` xml
<PackageReference Include="coverlet.collector" Version="1.3.0">
  <PrivateAssets>all</PrivateAssets>
  <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
</PackageReference>
```

#### Collector configuration. Add a file (e.g. *runsettings*) anywhere in the solution/project
```  xml
<?xml version="1.0" encoding="utf-8" ?>
<RunSettings>
  <DataCollectionRunSettings>
    <DataCollectors>
      <DataCollector friendlyName="XPlat code coverage">
        <Configuration>
          <Format>json,cobertura</Format>
          <UseSourceLink>true</UseSourceLink>
          <IncludeTestAssembly>false</IncludeTestAssembly>
          <ExcludeByFile>**/**/Program.cs,**/**/Startup.cs,**/Dir/SubDir/*.cs</ExcludeByFile>
        </Configuration>
      </DataCollector>
    </DataCollectors>
  </DataCollectionRunSettings>
  <InProcDataCollectionRunSettings>
    <InProcDataCollectors>
      <InProcDataCollector
        assemblyQualifiedName="Coverlet.Collector.DataCollection.CoverletInProcDataCollector, coverlet.collector, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null"
        friendlyName="XPlat Code Coverage"
        enabled="True"
        codebase="coverlet.collector.dll" />
    </InProcDataCollectors>
  </InProcDataCollectionRunSettings>
</RunSettings>
```

#### Run tests and collect data
``` powershell
PM> dotnet test --collect:"XPlat Code Coverage" --settings .\runsettings

PM> dotnet test .\Specific.Test.Project --collect:"XPlat Code Coverage" --settings .\Specific.Test.Project\runsettings
```


## Generate Code Coverage Report

#### Install *ReportGenerator* NuGet package
``` powershell
PM> Install-Package ReportGenerator -Version 4.6.4
```

#### Generate reports

[ReportGenerator usage page](https://danielpalme.github.io/ReportGenerator/usage.html)

``` powershell
PM> dotnet $(UserProfile)\.nuget\packages\reportgenerator\x.y.z\tools\netcoreapp3.0\ReportGenerator.dll "-reports:coverage.xml" "-targetdir:coveragereport" -reporttypes:Html
PM> dotnet $(UserProfile)\.nuget\packages\reportgenerator\x.y.z\tools\netcoreapp3.0\ReportGenerator.dll "-reports:coverage.xml" "-targetdir:coveragereport" -reporttypes:Badges
```
``` powershell
# CSharp.UnitTesting.Api NUnit
PM> dotnet $(UserProfile)\.nuget\packages\reportgenerator\4.6.4\tools\netcoreapp3.0\ReportGenerator.dll "-reports:CSharp.UnitTesting.Api.Nunit.Test\TestResults\*\coverage.cobertura.xml" "-targetdir:_CoverageReport\Api\NUnit" "-historydir:_CoverageReport\_History\Api\NUnit" -reporttypes:Html

# CSharp.UnitTesting.Api xUnit
PM> dotnet $(UserProfile)\.nuget\packages\reportgenerator\4.6.4\tools\netcoreapp3.0\ReportGenerator.dll "-reports:CSharp.UnitTesting.Api.Xunit.Test\TestResults\*\coverage.cobertura.xml" "-targetdir:_CoverageReport\Api\xUnit" "-historydir:_CoverageReport\_History\Api\xUnit" -reporttypes:Html
```
