# dotnetcore-build

Sample build system for a dotnetcore library using cake and gitversion

[![Build Status][build-badge]][build]
[![License][license-badge]][license]

## Getting started

    > build.bat

This will execute the following tasks

* `Clean` - Cleans the artifact directory and bin / obj folder
* `Restore` - Runs dotnet restore
* *`UpdateAssemblyVersionInformation` - uses GitVersion to update the `AssemblyFileVersion`, `AssemblyFileVersion` and `AssemblyInformationalVersion` attributes in `GlobalAssemblyInfo.cs`
* `Build` - Runs dotnet build
* `Test` - Runs dotnet test
* *`UpdateProjectJsonVersion` - Updates the version setting in the `project.json` of the project being packed with version information from GitVersion 
* `Pack` - Runs dotnet pack and outputs the the `artifacts` directory

> *These steps modify files so are only executed when running in a CI environment (as detected by Cake). This allows you to execute the build locally without modifiying git tracked files.

## Packages

Every commit will produce an auto incrementing CI package (ie. DotNetCoreBuild.0.1.0-ci0000.nupkg) which you can configure appveyor to automatically publish to MyGet.

When your ready to release a stable version, tag the repo with a stable version number (ie. 1.0.0) which will produce DotNetCoreBuild.1.0.0.nupkg. You can configure appveyor to automatically publish all stable versions to nuget (tell appveyor to only publish tagged commits to nuget).

See  the following links for more info on setting up appveyor.

* https://lostechies.com/jimmybogard/2016/05/24/my-oss-cicd-pipeline/
* http://andrewlock.net/publishing-your-first-nuget-package-with-appveyor-and-myget/ 

[build-badge]: https://img.shields.io/appveyor/ci/michael-wolfenden/dotnetcore-build.svg?style=flat-square
[build]: https://ci.appveyor.com/project/michael-wolfenden/dotnetcore-build
[license-badge]: https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square
[license]: https://github.com/michael-wolfenden/dotnetcore-build/raw/master/LICENSE
