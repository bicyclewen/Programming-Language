結構化資料處理、維度轉換、缺失值處理、資料選取（loc/iloc）、apply 函式。
```
# 以下兩行是畫圖用
%matplotlib inline
import matplotlib.pyplot as plt 
# 載入pandas套件
import pandas as pd
import numpy as np
```
```
scores = {'Math': [90, 50, 70, 80],
          'English': [60, 70, 90, 50],
          'History': [33, 75, 88, 60]}
df = pd.DataFrame(scores)
df.index = ['Simon', 'Allen', 'Jimmy', 'Peter']  # 自訂列索引
```

----

### 維度&形狀轉換 ~Series、DataFrame、NumPy
- s.to_frame()：將一維的 Series 轉成二維的 DataFrame。
- d.T：矩陣轉置（行列互換，Transpose）。
- np_a.reshape()：改變 NumPy 陣列的形狀。
  - -1 代表「自動計算該維度的大小」。例如 np_a.reshape(-1, 1) 會變成直行向量。
  - ravel() 或 .reshape(-1) 可以將多維陣列「攤平」為一維。
- 或直接在 [1,2,3] 外面再加 []

### NaN
用來代表遺漏值，在Python中只能用函數來檢查，不能用等號 (即 np.NaN == np.NaN 為 False)
```
# 檢查方式~用內建函式
pd.isnull(value)、df.isnull() : 檢查是否為缺失值
pd.notnull(value)：檢查是否「不是」缺失值
```
```
df.isnull().sum()：計算各欄有幾個 NaN。
df.isnull().sum().sum()：計算整張表格總共有幾個 NaN。
df.isnull().any(axis=1)：檢查每一列（Row）是否有任何 NaN。
df[df.isnull().any(axis=1)] 將有遺漏值的資料取出
```

### 定位及讀取DataFrame
預設之取值以欄為單位
```
- df['English'] 或 df.English：選取單一欄位（回傳 Series）。
- df[['English', 'Math']]：選取多個欄位（需用雙括號 [[]]，回傳 DataFrame）。
```
### loc vs. iloc

```
.loc['標籤名']：根據文字索引來抓取資料。
.iloc[數字]：根據整數位置（從 0 開始）來抓取資料。

切片範圍（Slicing）差異：
- .loc 的範圍是包含終點
- .iloc 的範圍是不包含終點
```

### axis
**axis=0** : 往下沿著列索引鍵走
**axis=1** : 往右沿著欄索引鍵走
```
df['個人平均'] = df.mean(axis=1)  # 新增個人平均欄位
df.loc['各科平均'] = df.mean(axis=0)  # 新增各科平均列
```

### 篩選資料~boolean
將想取的列設為True，即可取得
```
bool_v = [True,True,False,False,False] 
df[bool_v]
```
判斷條件的話，則是
```
bool_v = df['Math'] >= 60
df[bool_v]
```

### apply()、lambda
```
# 對 Series 每個元素進行條件判斷運算
s.apply(lambda x: x + 1 if (x % 2) == 1 else x - 1)

# 對 DataFrame 進行跨列或跨欄的最大值計算
df.apply(max, axis=1)
```



