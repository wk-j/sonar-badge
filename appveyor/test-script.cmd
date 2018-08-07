dotnet-sonarscanner begin /k:"sonar-badge" /d:sonar.organization="wk-j-github" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login=%token% /d:sonar.cs.opencover.reportsPaths=%reportPath%
dotnet test %testProject% /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
dotnet-sonarscanner end /d:sonar.login=%token%