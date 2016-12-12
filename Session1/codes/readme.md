# Course Of Microservice Demo


## Setup Scripts

#### step 0, build microsoft/iis-aspnet45 base image

```dos
net use e: \\TSCLIENT\C\Users\chicken\Source\Repos\CommunityOpenCampDemo
cd /d e:\containers\iis-aspnet45
docker build -t microsoft/iis-aspnet45:latest .
```

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
