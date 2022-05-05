FROM mcr.microsoft.com/dotnet/aspnet:6.0-bullseye-slim
# AS baseswr.cn-south-1.myhuaweicloud.com/mcr/aspnet:3.1-alpine
WORKDIR /app
COPY . . 
EXPOSE 5004 
ENTRYPOINT ["dotnet", "Blog.IdentityServer.dll","-b","0.0.0.0"]