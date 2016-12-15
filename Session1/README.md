# Course Of Microservices



# 課程簡介

說明微服務的開發，構建，佈署與維運等議題，讓學員了解微服務的核心概念，以及實戰
過程中會碰到的挑戰與應對方式。

課程分成四次進行:

1. **overview**  
介紹微服務的觀念，以及重要的相關技術 (參考: [Microservices Skill Tree](http://read.html5.qq.com/image?src=forum&q=5&r=0&imgflag=7&imageUrl=http://mmbiz.qpic.cn/mmbiz/MOwlO0INfQqYYBwOC1siaHRwxElHuDybkztrnIvSdDy3UFPDDu3fr5sicBbJoNNwo0bia3iaWZTEpV4SA9QqBa6ong/0?wx_fmt=jpeg))
1. **coding**  
介紹開發 "microservices ready" 系統的關鍵技能: API
1. **process**  
介紹微服務架構從開發到佈署、維運等的流程
1. **proof of concept**  
實際的案例，從頭開始一步一步進行，完整的示範微服務從開發到上線維運的過程


# 課程大綱 (session 1)


時間與地點: 2016/12/15 17:00 ~ 20:00, 會議室



# 注意事項

課程開始到全部結束前，有任何相關的問題，歡迎使用 GitHub 的 Issues 功能來發問討論!



# 參考資料

* [課程講義](M01.pptx)
* [Microservices Skill Tree](http://read.html5.qq.com/image?src=forum&q=5&r=0&imgflag=7&imageUrl=http://mmbiz.qpic.cn/mmbiz/MOwlO0INfQqYYBwOC1siaHRwxElHuDybkztrnIvSdDy3UFPDDu3fr5sicBbJoNNwo0bia3iaWZTEpV4SA9QqBa6ong/0?wx_fmt=jpeg)





# DEMO Scripts (container)

## Local Part (NB)

1. build my mvc-demo docker image (using script) - @PC
```powershell
# 編譯 ASP.NET 指令
"c:\Windows\Microsoft.NET\Framework\v4.0.30319\aspnet_compiler.exe" -v / -p ..\..\DemoWeb -u -f -c WebAPP

# BUILD image
docker build --force-rm -t andrew0928/mvcdemo:latest -t andrew0928/mvcdemo:1.0 .

# RUN local
docker run -d --name demo81 -p 81:80 andrew0928/mvcdemo

# TEST [LINK]
docker run -t -i --rm microsoft/windowsservercore cmd.exe
ping demo81
set

docker run -t -i --rm --link demo81 -e DEMO_ENV=20161215 microsoft/windowsservercore cmd.exe
ping demo81
set

# PUBLISH image
docker push andrew0928/mvcdemo:1.0

```

RUN: 



## Cloud Part (Azure)


1. deploy my mvc-demo:
```powershell
docker run -d --name demo8001 -v c:\Demo\App_Data:c:\Inetpub\wwwroot\App_Data -p 8001:80 andrew0928/mvcdemo
```

RUN: http://andrewvm2016.southeastasia.cloudapp.azure.com:8001


2. deploy 2nd instance
```
docker run -d --name demo8002 -v c:\Demo\App_Data:c:\Inetpub\wwwroot\App_Data -p 8002:80 andrew0928/mvcdemo
```

RUN: http://andrewvm2016.southeastasia.cloudapp.azure.com:8002

3. update files in data volume
```
copy /y logo.jpg App_Data\
```
RUN: http://andrewvm2016.southeastasia.cloudapp.azure.com:8001
RUN: http://andrewvm2016.southeastasia.cloudapp.azure.com:8002


4. setup nginx reverse-proxy
```
# edit nginx.conf

start nginx.exe
nginx.exe -s reload | quit | stop

```

5. APP upgrade, update DEMOWEB to V1.1, keep local changes (logo)
```
# REBUILD & REPUBLISH image
build.cmd
```

6. UPGRADE demo8001, and test (modify nginx if need)

7. UPGRADE demo8002



















-----
# Course Of Microservice Demo


## Demo Scripts

#### step 1, build beta image of demoweb
```
docker build --no-cache -t andrew/demoweb:1.0-beta -t andrew/demoweb:latest .
```

#### step 2, run beta demoweb
map http(80) to port 81, map c:/inetpub/wwwroot/app_date to c:/demovol
```
md c:\demovol
docker run --name demo81 -d -p 81:80 -v c:\demovol:c:\inetpub\wwwroot\app_data andrew/demoweb:latest
```
> go to website about page, see beta version, and default logo

#### step 3, put custom logo
```
copy e:\DemoWeb\App_Data\logo.png c:\demovol
```
> go to website 'about' page, see 'community open camp' logo

#### step 4, update code
change version to 1.0-rtm, clean, build, publish, build image, run
```
docker build --no-cache -t andrew/demoweb:1.0-rtm -t andrew/demoweb:latest .
docker run --name demo82 -d -p 82:80 -v c:\demovol:c:\inetpub\wwwroot\app_data andrew/demoweb:latest
```
> go to website demo81 [about] page, see beta version
> go to website demo82 [about] page, see rtm version

#### step 5, re-deploy demo81
```
docker rm -f demo81
docker run --name demo81 -d -p 81:80 -v c:\demovol:c:\inetpub\wwwroot\app_data andrew/demoweb:latest
```
> go to website demo81 [about] page, see rtm version
> go to website demo82 [about] page, see rtm version


## Bad Guys Demo

in win2016 host, try to kill process inside containers.
```
tasklist /fi "imagename eq ping.exe"
taskkill /pid 9999

docker ps -a
```

in container, can not see all process on this host
```
docker run --rm -t -i microsoft/iis cmd.exe
tasklist
```

in host, can see all process
```
tasklist
```

solution: hyper-v isolation (not run under vm)
```
docker run --name demo83 -d -p 83:80 --isolation hyperv -v c:\demovol:c:\inetpub\wwwroot\app_data andrew/demoweb:latest
```




windows container setup (8/18 update) procedure:
https://msdn.microsoft.com/en-us/virtualization/windowscontainers/quick_start/quick_start_windows_10
