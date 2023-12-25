if ("%ShouldRunTests%" -eq "true") {
    dotnet test YourProject.Tests\YourProject.Tests.csproj
} else {
    Write-Host "Tests are skipped as ShouldRunTests is set to false."
}
