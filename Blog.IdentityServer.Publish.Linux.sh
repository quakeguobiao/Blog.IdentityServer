git pull;
rm -rf .PublishFiles;
dotnet build;
dotnet publish -o /home/Blog.IdentityServer/Blog.IdentityServer/bin/Debug/netcoreapp;
cp -r /home/Blog.IdentityServer/Blog.IdentityServer/bin/Debug/netcoreapp .PublishFiles;
echo "Successfully!!!! ^ please see the file .PublishFiles";