# Microservices, 2017/01/12, Session #3

* 投影片 [下載](M03.pptx)

----

## Docker Compose

VM [網址](http://andrewvm2016.southeastasia.cloudapp.azure.com/): http://andrewvm2016.southeastasia.cloudapp.azure.com/



```
docker-compose build
```
> 建置 application (所有有指定 dockerfile 的 containers)

```
docker-compose pull | push
```
> PULL | PUSH 所有的 container images

```
docker-compose up -d --build --force-recreate [service name] --remove-orphans
docker-compose down
```
> 啟動 (create + start) 或是停用 (stop + remove) 所有的 containers


```
docker-compose scale webapp=3
```
> 調整 services 的 instance count






---- 


## Service Token

* [Source Code](https://github.com/andrew0928/MeetUp.ApiTokenDemo)

### 測試網站

展示用的兩個 web app, 我也在 Azure 上面佈署了一份。
要測試的可以直接連這邊:

- **AUTH**: 執行認證與授權  
http://andrewtokenauth.azurewebsites.net/swagger/ui/index


- **API**: 存取服務  
http://andrewtokenapi.azurewebsites.net/swagger/ui/index


### 產生 APIKEY 的指令

```
C:\> ApiKeyGenerator.exe AndrewWu VIP CTO MVP

jgAAAAJDbGllbnRJRAAJAAAAQW5kcmV3V3UABFRhZ3MAJgAAAAIwAAQAAABWSVAAAjEABAAAAENUTwACMgAEAAAATVZQAAACVHlwZU5hbWUAJAAAAE1lZXRVcC5BcGlUb2tlbkRlbW8uU0RLLkFwaUtleVRva2VuAAlFeHBpcmVEYXRlALpyu8NfAQAAAA==|X56LXzXG3sAJgzEz7RSMGdcWBDroHNdu+6gpXluhoP0JZAxurzgpYPrwZ64ycCyIv0xiYoAjSj8Afz3CGW6HL1O/3N6c2as7OPNYUgOD6MGvHw5KXaZQ0WK4Y44TQn3kRzk7+55UlwMM2/ztSzM0o/XkL/wqstLwrTU3EHX/PeY=

C:\> ApiKeyGenerator.exe AndrewWu

bQAAAAJDbGllbnRJRAAJAAAAQW5kcmV3V3UABFRhZ3MABQAAAAACVHlwZU5hbWUAJAAAAE1lZXRVcC5BcGlUb2tlbkRlbW8uU0RLLkFwaUtleVRva2VuAAlFeHBpcmVEYXRlALBPqMRfAQAAAA==|unZq3Np1y38a4zws4OMT+is8rIoysFi7AvaKHRERFc6HLFVcyrbK3hocrSGhLo8HbTgrf1lIwCa7Ix5EtRhtJknoovAZ/79D5V32RAJXdKpVccm+oeuUaF1FL0zfAk6hRnBrTHULV9QwN0csIcBjnlVVyucVQZ15N0B79z43mio=


C:\> ApiKeyGenerator.exe AndrewWu BAD

eAAAAAJDbGllbnRJRAAJAAAAQW5kcmV3V3UABFRhZ3MAEAAAAAIwAAQAAABCQUQAAAJUeXBlTmFtZQAkAAAATWVldFVwLkFwaVRva2VuRGVtby5TREsuQXBpS2V5VG9rZW4ACUV4cGlyZURhdGUAzV+pxF8BAAAA|s6PTwIN0YmTN2DzQ9qQRLsKXaX7cYRvsV9CeR7ggGWZ6j4Rv+6KCI6WdfPQDCRcmkoDXkzIJ1ydmuLgTvTAUbcfJtkIzIf8Fx8IK/pkV4/78bKAPt0sUZqSyP5sFc4bbLiLfZSJL0e1pvAleNMda1vpc1KaJ4+CbJTw+hY1jcWo=

```




## References

* [Container Network](https://docs.microsoft.com/en-us/virtualization/windowscontainers/manage-containers/container-networking#transparent-network)
* [Rancher Upgrade](https://github.com/rancher/rancher/issues/2188)
* [Using Nginx as Http loadbalancer](http://nginx.org/en/docs/http/load_balancing.html)
* [NGINX LOAD BALANCING – TCP AND UDP LOAD BALANCER](https://www.nginx.com/resources/admin-guide/tcp-load-balancing/)
* [谈一下关于CQRS架构如何实现高性能](http://www.cnblogs.com/netfocus/p/4055346.html)
* [Kubernetes、Mesos和Swarm：Rancher编排引擎的比较](http://dockone.io/article/1882)
* [容器现状：Docker之外的选择、容器编排以及它们对微服务的影响](http://www.infoq.com/cn/articles/container-landscape-2016)
* [2017年DevOps的5大发展预测](http://www.infoq.com/cn/news/2016/12/2017-DevOps-5-predict)
* [一次搞懂oAuth與SSO在幹什麼?](http://studyhost.blogspot.tw/2017/01/oauthsso.html)
* [一种新的进入容器的方式： WebSocket + Docker Remote API](http://dockone.io/article/1920)