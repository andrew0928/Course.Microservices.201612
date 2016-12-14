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



# DEMO

1. build my mvc-demo docker image (using script) - @PC
```powershell
# 編譯 ASP.NET 指令
"c:\Windows\Microsoft.NET\Framework\v4.0.30319\aspnet_compiler.exe" -v / -p ..\..\DemoWeb -u -f -c WebAPP

# BUILD image
docker build --force-rm -t=andrew0928/mvcdemo:latest -t=andrew0928/mvcdemo:1.0 .

# PUBLISH image
docker push andrew0928/mvcdemo:1.0

```


1. deploy my mvc-demo:
```powershell
docker run -d --name demo8001 -v c:\Demo\App_Data:c:\Inetpub\wwwroot\App_Data -p 8001:80 andrew0928/mvcdemo
```

2. deploy 2 instances of mvc-demo
```
```