# 停止容器
docker stop idscontainer
# 删除容器
docker rm idscontainer
# 删除镜像
docker rmi quakeguobiao/idsimg
# 切换目录
#cd /home/Blog.IdentityServer
# 发布项目
chmod +x Blog.Core.Publish.Linux.sh
./Blog.IdentityServer.Publish.Linux.sh
# 进入目录
cd .PublishFiles/
# 编译镜像
docker build -t quakeguobiao/idsimg .


docker push quakeguobiao/idsimg:latest
# 生成容器
docker run --name=idscontainer -d -v /home/identityserver/appsettings.json:/app/appsettings.json -v /home/identityserver/Log/:/app/Logs -v /etc/localtime:/etc/localtime -it -p 5004:5004 quakeguobiao/idsimg
# 启动容器
#docker start idscontainer
