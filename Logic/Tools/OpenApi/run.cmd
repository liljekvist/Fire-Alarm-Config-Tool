@echo off
:: Backend https://openapi-generator.tech/docs/generators/aspnetcore
java -jar openapi-generator-cli.jar generate -i ./APIConfiguration.yaml -g aspnetcore -o ../../FireAlarmConfigTool.Logic.Api --additional-properties=aspnetCoreVersion=8.0,buildTarget=program,packageName=FireAlarmConfigTool.Logic.Api,packageTitle=FireAlarmConfigTool.Logic.Api,pocoModels=true

:: Frontend https://openapi-generator.tech/docs/generators/csharp/
java -jar openapi-generator-cli.jar generate -i ./APIConfiguration.yaml -g csharp -o ../../FireAlarmConfigTool.Logic.Http.Client --additional-properties=apiName=HttpClient,packageName=FireAlarmConfigTool.Logic.Http.Client,packageTitle=FireAlarmConfigTool.Http.Client,apiName=ConfigToolApi
pause