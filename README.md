# 二手車交易管理系統


## 表單介面

![image](https://user-images.githubusercontent.com/75149212/139467713-5a235362-ded1-43a3-b9e6-6103048a3664.png)

此介面為二手車交易系統的主視窗，存取資料庫的目前在售二手車目錄後，並將載入至數據列表。透過數據列表瀏覽目前販售的各式車種，依照廠牌、車款及車型分類，個別顯示每部車子的資訊，包括車門數量、可承載乘客的數量、變速系統、排氣量、車色、車齡及目前所在的地區，賣家編號及販售價格。

![image](https://user-images.githubusercontent.com/75149212/139468204-542766c3-25dc-427c-80e8-6fde776b8e97.png)

搜尋系統採用SQL模糊查詢的方式運作，輸入任意長度的字元，便會依照選擇的類型與輸入的關鍵字進行查詢，並回傳結果餘下方數據列表內。使用者可依照想要的車型特徵進行搜索，選擇或輸入特定數值及字元，如廠牌名稱、車款車型、車門數、乘客數、車齡、價格範圍等等資料。

* 會員系統

![image](https://user-images.githubusercontent.com/75149212/139468803-4a368800-684a-489b-beab-4da8145f6b00.png)
![image](https://user-images.githubusercontent.com/75149212/139468811-5286c654-397c-4936-ad60-10c897c9fa6b.png)

會員系統可依照身分類別進行註冊，分為買家及賣家兩種身分。註冊採用簡易註冊，不須輸入過多資料。在對應的欄位輸入使用者的資料後，點選註冊確認資料無誤後，便會將此帳戶新增至資料庫儲存。


## 買家介面

![image](https://user-images.githubusercontent.com/75149212/139469521-413d6cbc-ef52-4137-8a9a-c0dadd0c7124.png)

買家登入後，除了基本主視窗功能外，可以進行購買動作、訂單交易與買賣家評價查詢。

![image](https://user-images.githubusercontent.com/75149212/139469550-9c8bdf38-1576-4d06-98ff-129a2f807c96.png)

  選購完心儀的二手車後，可在欄位旁點選「買車Go」按鈕，將會跳出是否訂單完成畫面，顯示訂單編號及二手車的相關資訊。可選擇「完成購買」、「稍後購買」、及「取消購買」。
  選擇「完成購買」即完成交易，訂單資訊更新為完成狀態，此部二手車的購買選項將會從資料庫移除，僅供買賣家雙方進行查詢作用。
 選擇「稍後處理」即不需即刻完成交易，訂單資訊將會新增至對應資料庫表單，若是想完成交易，點選主視窗的「訂單交易」頁面後即可看到目前下訂的二手車訂單，並進行對應的操作。

* 訂單交易

![image](https://user-images.githubusercontent.com/75149212/139469623-b34a2774-d8f7-40e2-83f5-1767378fa39f.png)

此頁為買家的「目前訂單」頁面，買家若是在選擇「稍後處理」，訂單資訊將會顯示在此處，在數據列表中點選該筆訂單或下拉選單中，選擇該筆訂單後，點選右側按鈕便可進行對應的操作。

![image](https://user-images.githubusercontent.com/75149212/139469652-94c7edce-d7d1-4f3a-a97e-1cca15929a3e.png)

此頁為買家的「完成訂單」頁面，買家可在此頁查看曾經購買二手車之歷史紀錄，資訊包括二手車資訊與賣家編號及買家給予對方的評價。買家可在完成訂單七天之內修改給予的賣家評價。

* 查詢評價

![image](https://user-images.githubusercontent.com/75149212/139469701-365f705c-e817-4e9b-b1e6-ab2984d01955.png)

此頁為「我的評價」頁面，買家可在此頁查看對應訂單的二手車資訊、賣家給予的交易評價，並且可得知目前獲得評價之總評價。

![image](https://user-images.githubusercontent.com/75149212/139469719-7e02db6b-74fc-4974-b4e4-651ae0c97aa9.png)

此頁為「賣家的評價」頁面，買家可透過此頁面查詢想要購買之二手車賣家的評價，顯示資訊包括此筆訂單之二手車資訊及給予之賣家評價。

## 賣家介面

![image](https://user-images.githubusercontent.com/75149212/139469776-df483b5e-6020-4d22-870f-44c05e40df3a.png)

賣家登入後，除了基本主視窗功能外，可以進行賣車Go、訂單交易與買賣家評價查詢。

* 賣車Go

![image](https://user-images.githubusercontent.com/75149212/139469808-4c319799-342d-4c9f-83f1-7e7128461f21.png)

此頁為「新增車子」頁面，賣家在此頁刊登想要出售的二手車資訊，可對照數據表內的車子詳細資訊進行填寫。完成填寫資料後點選新增車子，系統將會自動新增此筆二手車資訊至目前販售二手車之資料表中。

![image](https://user-images.githubusercontent.com/75149212/139469837-2628cbc4-65fd-4c75-8590-330854fa3172.png)

此頁為「在售車子」頁面，可在此頁查看該賣家目前上架販售的二手車資訊，包括額外資訊的車牌與價格部分。賣家在此頁進行取消販售的動作。

* 訂單交易

![image](https://user-images.githubusercontent.com/75149212/139469877-b509261e-ff82-4be6-b54c-e93c4afec9ed.png)

此頁為賣家的「目前訂單」頁面，賣家可在此頁查看目前買家下訂的訂單狀況，包括下訂日期與買家編號。在數據列表中點選該筆訂單或下拉選單中，選擇該筆訂單後，點選右側按鈕便可進行對應的操作。

![image](https://user-images.githubusercontent.com/75149212/139470061-5790ac92-2942-4190-a309-98064965bdbd.png)

  此頁為賣家的「完成訂單」頁面，賣家可在此頁查看曾經販售二手車之歷史紀錄，可查看資訊包括二手車資訊與買家編號及賣家給予對方的評價，賣家可在完成訂單七天之內修改給予的買家評價。


* 查詢評價

![image](https://user-images.githubusercontent.com/75149212/139470101-bba84847-62ca-4239-9a16-b4f1e95c999d.png)

此頁為「我的評價」頁面，賣家可在此頁查看對應訂單的二手車資訊、買家給予此筆交易的評價，並且可得知目前獲得評價之總評價。

![image](https://user-images.githubusercontent.com/75149212/139470123-dc493ece-18c1-4bb3-bad8-40264144b355.png)

此頁為「買家的評價」頁面，賣家可透過此頁面查詢該位買家購買之二手車之紀錄，顯示資訊包括該筆訂單的二手車資訊及買家的總評價。







