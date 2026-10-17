# 字串 
s = f'我是文字{變數:.0f}喔' 
上面的「:.0f」可以將數值四捨五入並去除小數位數


# 自訂函式
## 使用 def 關鍵字定義，透過 return 回傳結果。
```
def cal_price(k_cost):
  rate=0.03
  nt_cost=k_cost*rate
  inc=0.2
  nt_price=nt_cost*(1+inc)
  return nt_cost, nt_price
```
## 呼叫函式
nt_cost, nt_price = cal_price(45000)
=> 接收>回傳 : ValueError: too many values to unpack
=> 接收<回傳 : 會打包成一個Tuple (可以用index指定取資料)


# 串列、迴圈
有大量資料（如多筆成本）時，會放在 List [] 中，再用 for 迴圈逐一取出處理。
```
list_k_cost = [30000, 500, 45000, 50000]
for k_cost in list_k_cost:
  nt_cost, nt_price = cal_price(kcost)
```

