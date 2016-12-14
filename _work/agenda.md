# AGENDA

了解導入 microservice 的目的
了解 microservice 要解決什麼問題
best practice (開發流程，使用工具，搭配的管理系統)
best practice (開發架構，開發技術，搭配的套件、函式庫等)


# TARGET

有基本 coding 與技術能力, 3 年以上經歷的工程師
需要接觸後端 (server side code) 的人
技術決策者，負責決定團隊工作方式及流程，使用技術，使用元件的人 (team leader, architect)

其他上述角色的 canditates



# TOPICS

分成四週，每次 3hr (講課 + demo )。上課內容我規畫三週，最後一週進行 POC case study，
會拿一個適合 ALLWIN 實際狀況的案例做 POC，從系統架構、範例程式與操作流程，完整的實作一次。


## WEEK #1, Microservice Concepts

0. 業界趨勢: 為何業界會推崇 microservices?
  - cloud service 當道，分散式、大規模需求提高
  - agile / scrum / devops 等等以 developer 為主的開發流程當道
  - container 技術成熟，降低 microservices 佈署的難度

1. 應用程式的架構選擇
- microservices?
- monolithic?
- compare (優缺點比較，使用時機比較)
- 轉移到 microservices 會有那些困難?

## development issues

2. Reuse of codes
- use source code (search sample code, code snipples)
- use binary code (library, component)
- use service (microservices, SOA)

## deployment issues

3. Deployment and operation
- 開發與測試
- 有效率的佈署 (containerized)
- 組態管理
- 系統更新 (update code & reconfiguration? immutable server?)
- 監控
- 界定 & 隔離問題
- 延展
- 安全

## security and management issues


4. Migration from monolithic to microservice


## WEEK #2 開發團隊導入微服務架構前的準備 (Pre-requirement, Related technologies)

0. Distance between Monolithic and Microservices?
* multiple project
* remote API call is necessary
* API contract, versioning, backward compabitility
* cross service authentication and authorization
* cross service debugging
* deployment issues

1. Advantage of microservices
![software development: productive vs complexity](http://martinfowler.com/bliki/images/microservice-verdict/productivity.png)
* 切割大型應用為幾個獨立的服務，降低複雜度 (服務之內)
* 服務可以獨立團隊開發
* 服務可以獨立佈署
* 服務可以獨立擴展

(TBD: 挑出 ALLWIN 關注的項目)
- [ ] single response rules, easy development and testing
- [ ] one service, one team
- [X] native to cloud service (saas)
- [ ] use computing resource efficentive
- [X] more stable (每個服務都可以備援, 可以隔離單一失敗的服務)
- [ ] easy to testing (single service)
- [ ] native to devops
- [X] native to database partition / shard (seperate database for each service)

> ? 如何放大微服務架構的優點?
> 針對微服務規畫你的應用程式架構
> 微服務是 "過程"，不是 "目的"，可同時尋求其他可行的方式，或是分階段進行

2. Disadvantage of microservices
* 註定必須是分散式系統，複雜度較高 (複雜性存在於服務之間，包含呼叫失敗，或是狀態一致性問題，API 相容問題，新舊版本兼容問題)
* 資料庫架構的挑戰，通常非正規化，無法支援交易。維護資料的一致性、正確性、即時查詢報表的難度高
* 測試的複雜度高 (系統運作必須依賴其他服務)
* 商務需求異動時，可能會影響多個服務的設計
* 佈署架構與系統更新的複雜度高

(TBD: 挑出 ALLWIN 關注的項目)
- [X] 額外維護 API / SDK 的成本
- [ ] 維持版本相容問題的成本
- [ ] one service, one team (必須配合組織的架構)
- [X] inter-process or inter-service communication cost
- [X] hard to deploy, maintain, monitor
- [ ] hard to testing (whole system with many services)
- [ ] native to devops (必須配合組織及流程調整)
- [ ] 必須建立 cross service security 跨服務的安全及認證機制
- [X] **must** database partition / shard

> ? 如何減少微服務架構缺點的衝擊?
> 善用 PaaS, 或是容器化的佈署
> 採用 SCRUM + DevOps
> 架構調整的同時，用現有且成熟的其他服務取代

(TBD: 挑出 ALLWIN 關注的項目)
3. Development process requirement
- [X] Source code management (branch)
- [ ] API (contracts)  management
- [ ] API compabitility testing 
- [ ] API testing (unit test, load test, DX)
- [X] CI: continueous integration (or daily / nightly build)
- [X] CD: continueous deployment (daily build -> container or virtual machine image -> auto deployment)
- [ ] API documentation management
- [ ] SCRUM or AGILE, DevOps



## WEEK #3, 架構移轉的進行方式 (Guidelines for System Architecture, API management, POC and case study)

**簡化系統的佈署方式**
> 善用 container 簡化佈署方式，你就更有機會選用最佳的服務。不用所有服務
> 都自己寫，挑選適合的現有服務 (ex: redis, elastic search...)
> 個別佈署及升級的挑戰

**改善系統的開發到上線的流程**
> 因為佈署很複雜，問題很難追查，所以開發流程很重要! (比單體式架構更重要)。
> 挑錯系統很麻煩，寧可先土砲 (手寫 build script), 了解需求後才有能力
> 比較各種系統的優缺點

**定義服務邊界，決定切割服務的方式**
- 要切多小?
- 怎麼找出邊界?
- 怎麼切?
    重構，將 source code reuse -> binary (library) reuse -> service reuse
- 團隊的搭配?

**API developement**
API vs Library / Component ?
分散式系統的挑戰
- 可靠度 (call fail)
- 一致性 (transaction)
- 跨服務的認證與授權 (api key / session management)
資料庫 (SQL? NOSQL? storage?) - (TBD)

**DEV process**
(TBD)





# References

* [微服务实战（一）：微服务架构的优势与不足](http://dockone.io/article/394)
* [微服务：Java EE的掘墓人](http://www.infoq.com/cn/news/2016/11/Micro-service-java-EE)
* [瓶頸處理九原則](http://www.slideshare.net/williamyeh/ss-69296400)
* [DockOne微信分享( 九十二）：如何使用 Node.js 和 Docker 构建高质量的微服务](http://dockone.io/article/1803)
* [每个架构师都应该研究下康威定律](http://www.infoq.com/cn/articles/every-architect-should-study-conway-law)
* [微服务的漫长历史](http://www.infoq.com/cn/news/2016/11/microservices-history)
* [Kong Docs: Adding your API](https://getkong.org/docs/0.9.x/getting-started/adding-your-api/)
* [Kong Docker Images](https://hub.docker.com/_/kong/)
* [從不同的角度看 Microservices](http://blog.maxkit.com.tw/2015/07/microservices_27.html)  
* [康威定律 Conway's Law](http://blog.maxkit.com.tw/2016/06/conways-law.html)  
* [Securing Microservices](https://medium.facilelogin.com/securing-microservices-with-oauth-2-0-jwt-and-xacml-d03770a9a838#.d0wus2d1h)
* [Microservices Series: A Quick Look At Service Discovery Patterns](https://www.javacodegeeks.com/2016/11/microservices-series-quick-look-service-discovery-patterns.html)
* [Definition: canary (canary test, canary deployment)](http://whatis.techtarget.com/definition/canary-canary-testing)
* [Windows Containers 微服務架構實戰](http://www.accupass.com/go/DCT_105032)
* [TFS 2015: Branch strategically](https://www.visualstudio.com/en-us/docs/tfvc/branch-strategically)
* [MSDN: Learn Git](https://www.visualstudio.com/learn-git/)
* [恰如其分的 MySQL 設計技巧](http://s.itho.me/modernweb/2016/tracka/Ant_ModernWeb-%E6%81%B0%E5%A6%82%E5%85%B6%E5%88%86%E7%9A%84MySQL%E8%A8%AD%E8%A8%88%E6%8A%80%E5%B7%A7_%E4%BF%AE.pdf)
* [STUQ小班課《微服務架構與實踐》｜尚度元科技CTO王磊主講](http://www.gegugu.com/2016/10/05/13052.html)

# Schedule
* 12/15 17:00 ~ 20:00
* 12/29 17:00 ~ 20:00
* 01/12 17:00 ~ 20:00
* 01/19 17:00 ~ 20:00