$solutionName = "AutorestTest"
$apiProject = "AutorestTest.Api"
$clientProject = "AutorestTest.Client"

# Build solution
dotnet build $solutionName.sln

# Generate swagger.json
Set-Location $apiProject
dotnet swagger tofile --output "../swagger.json" "bin/Debug/net6.0/$apiProject.dll" v1
Set-Location ..

# Generate client files
autorest `
    --input-file="swagger.json" `
    --output-folder="$clientProject/Generated" `
    --clear-output-folder `
    --namespace="$clientProject" `
    --csharp

Remove-Item "swagger.json"