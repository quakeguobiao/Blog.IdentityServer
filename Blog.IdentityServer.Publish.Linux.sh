rm -rf .PublishFiles;
dotnet build;
dotnet publish -o Blog.IdentityServer/bin/Debug/netcoreapp;
cp -r Blog.IdentityServer/bin/Debug/netcoreapp .PublishFiles;
echo "Successfully!!!! ^ please see the file .PublishFiles";