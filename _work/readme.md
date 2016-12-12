# notes @ 2016/12/02

Reference:

- William's Post:
http://school.soft-arch.net/blog/291088/api-design-reading-list

- API Design - When to buck the trend?
http://www.slideshare.net/apigee/api-design-when-to-buck-the-trend

- RAML 介紹, spec driven development, API design
Building Yout API for Longevity
http://www.slideshare.net/mulesoft/building-your-api-for-longevity

- Intro to RAML - API Spec Driven Development
http://blog.xdite.net/posts/2016/05/12/raml-api-spec-driven-development/


# notes @ 2016/11/28

1. 課程內容確認
1. POC 的進行方式討論
1. 上課的其他細節確認 (可再本公司上課)如下:  
    * 可於本公司上課(大會議室)
        > 可以。若能大約讓我知道人數及這些人的經驗與平常負責的任務會更好。

    * 請先確認共幾堂課、每次課程時數、一週一次?
        > 我內容安排三堂上課，一堂 Lab 來講解 POC (內容待確認)。
        > 每次 3 小時。一周一次。確切日期週三確認。

    * 若為每週一堂課，每堂3小時，可安排於平日下午上課
        > 可以。時間週三確認。我建議安排在下午下班前的 3hr 進行。這類課程可能會有較多的討論
        > 與實際的 demo, 我希望能讓大家充分了解上課的內容為主，若需要視情況延長時間我沒問題。

    * 是否課前有電子檔課程內容可先給予參考?
    * 學員是否需先備電筆?環境?
        > 相關素材，還有相關的 sample code, 我都會一起放到 GitHub 給大家下載。
        > 第一堂課以觀念為主，我會搭配 demo & code 解說。第二及第三堂課會需要學員自備 notebook.
        > 需要有 visual studio 開發環境。
        > 確切內容我需要確認完 POC 方式之後才能定案。因為需要花一些時間準備，第一堂課的內容
        > 會在上課前提供，之後的內容都會提前 3 ~ 5 天先提供給大家參考。



# ntoes @ 2016/11/25

1. 善用現成的微服務 (不依定都要自己開發)
 - 因為不屬方式改善，你可以挑選最佳 solution, 不用受限 .net or windows

2. 導入流程及系統前，先用最陽春的方式 (ex: CI -> msbuild + script + schedule), 能夠了解 why and how, 再來選系統
   可以避免挑錯系統後的轉移成本



# 需求訪談 (2016/11/10)

Attendees:
- Gary Yeh, CTO
- Shaofan Li, Assistant Director, RD1
- Ann Hsu, HR Manager

導入 Microservice 的目的:
- 架構重整
- 易於維護
- 前台輕量，後台海量

現況:
- 單體式 APP，前端及邏輯都混在同一個大型 project
- 難以 refactory, 包含 code + database (large query, join many tables)
- 2016/08 曾經碰過駭客，上版機制重新規畫過

- NO daily build, RD team 人工上版
- 版本控制: Git (過去用 TFS)
- 解決傳輸 (remote call) 不穩定問題
- DEPLOY to 實體機器


