## POC 內容規劃

microservice 要求幾個方面配合才能有較佳的效果，包含開發架構，coding 技巧, API 相關, 佈署管理,
錯誤排除, 多服務管理；同時由於系統相對關係較複雜，開發流程是否成熟影響會比一般的開發來的重要。
需要搭配 (git) release management / daily build / continuous deployment / unit test 等等。

POC 重點我擺在開發相關的部分，以及最 min 的配合流程為主。其餘當作進階的應用，視情況補充:

## POC scenario(s):

實作分散式驗證，兩個服務無法直接溝通時，B 服務能信任 A 服務傳遞過來的資訊 (授權、點數等等關鍵機密資訊))
- 建置 1 service + 1 web app, 用 token 實作跨越 service 的 authentication / authorization.
- 建置 kong api gateway, 整合兩個 api site, client app (exe) 透過 api gateway 取用後端服務
- API / SDK 相容機制實作
- 兩個團隊同時開發 - 需要有獨立的 branch 控制, 要有 script 自動完成: git pull > build > deploy dev-site
- 展示手動 CI (+ unit test)
- 展示手動 CD (continuous deployment)
- 展示手動 CD (continuous delivery), non stop upgrade 

課後會交付完整的 source code & script.

