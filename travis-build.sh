#!/bin/bash
dotnet restore ./AMI.AlexaAPI/AMI.AlexaAPI.csproj
dotnet restore ./AMI.AlexaAPI.Tests/AMI.AlexaAPI.Tests.csproj
dotnet build ./AMI.AlexaAPI/AMI.AlexaAPI.csproj
dotnet build ./AMI.AlexaAPI.Tests/AMI.AlexaAPI.Tests.csproj
