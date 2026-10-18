### Data Preprocessing
- 數值型 ~ num_pl，最常做遺漏值&標準化處理
- 類別型 ~ cat_pl
- 整合起來的資料管道 ~ data_pl

----

### 這章節出現過這些工具
#管道器
make_pipeline : 串接多個處理步驟的管道器
```
from sklearn.pipeline import make_pipeline
```

#轉換器
SimpleImputer : 處理遺漏值
```
from sklearn.impute import SimpleImputer
```
StandardScaler : 數據標準化 aka Z-score標準化，將資料減去平均值，再除以標準差。
MinMaxScaler : 將數據做線性壓縮至[0,1]區間。適合圖像處理或文字多0、1編碼時。
OneHotEncoder : 將類別型資料轉成0、1數字。類別型資料獨熱編碼。
KBinsDiscretizer : 處理極端值，連續數值離散化/分箱
```
from sklearn.preprocessing import StandardScaler, MinMaxScaler, KBinsDiscretizer, OneHotEncoder
```

#合併器
ColumnTransformer : 水平合併器，水平結合不同轉換器或管道器。
```
from sklearn.compose import ColumnTransformer
```

----
- 數值型資料的預處理
### 遺漏值處理
資料集經常帶有遺失值。在進行模型訓練前，必須先將數值欄位與類別欄位分開處理。
```
X_col_num = ['price', 'quantity']
X_num = X[X_col_num]
```
利用 sklearn 的 SimpleImputer 自動填補空值。
```
from sklearn.impute import SimpleImputer
si = SimpleImputer(strategy='mean')     # 用平均值來填補
X_num_impute = si.fit_transform(X_num)  # 學習並轉換 : fit_transform()
print(si.statistics_0)                  # 查看各欄位算出的平均值

其實用 X_num.fillna(X_num.mean())
```

### 標準化處理/正規化
將資料轉換成平均數為 0、標準差為 1 的分佈，避免不同欄位間的單位尺度差距過大影響模型表現。
```
from sklearn.preprocessing import StandardScaler
ss = StandardScaler()
X_num_impute_ss = ss.fit_transform(X_num_impute)
```

**把上述兩個步驟合在一起~pipeline**
```
from sklearn.pipeline import make_pipeline
num_pl = make_pipeline(SimpleImputer(strategy='mean'), StandardScaler())
num_pl.fit_transform(X_num)
```

----
- 類別型資料的預處理
### 遺漏值處理
類別欄位無法計算平均數，通常改用眾數。
```
cat_si = SimpleImputer(strategy='most_frequent')
X_cat_impute = cat_si.fit_transform(X_cat)
```
機器學習模型看不懂文字，需透過 One-Hot Encoding 將其轉為 0 和 1 的二進位欄位。
```
from sklearn.preprocessing import OneHotEncoder
oh = OneHotEncoder(sparse=False)
X_cat_impute_oh = oh.fit_transform(X_cat_impute)
```
**把上述兩個步驟合在一起~pipeline**
```
cat_pl = make_pipeline(SimpleImputer(strategy='most_frequent'), 
                       OneHotEncoder(sparse=False))
cat_pl.fit_transform(X_cat)

oh_in_pl = cat_pl.named_steps['onehotencoder']
oh_in_pl.get_feature_names(['size','color'])
```
----
### ColumnTransformer 整合多種處理流程
可以針對不同欄位、不同資料類型套用不同的處理策略。
```
from sklearn.compose import ColumnTransformer
data_pl = ColumnTransformer([
    ('num_pl', num_pl, X_col_num),  # 對數值欄位套用 num_pl
    ('cat_pl', cat_pl, X_col_cat)   # 對類別欄位套用 cat_pl
])
final_data = data_pl.fit_transform(X)
```
```
其餘欄位參數 (remainder)：
- remainder='drop'（預設）：未指定的欄位直接丟棄。
- remainder='passthrough'：未指定的欄位直接保留原樣通過。
```

**取出結果**
```
# 第一步：取得cat_pl管道器
data_pl.named_transformers_['cat_pl']

# 第二步：取得onehotencoder欄位對應結果
data_pl.named_transformers_['cat_pl'].\
named_steps['onehotencoder'].get_feature_names()

data_pl.named_transformers_['cat_pl'].named_steps.keys()

# 第三步：將所有欄位整理到DataFrame裡
X_col_cat_oh = data_pl.named_transformers_['cat_pl'].\
named_steps['onehotencoder'].get_feature_names(X_col_cat)
columns = X_col_num + X_col_cat_oh.tolist()
print('整合後的欄位資料：',columns)
pd.DataFrame(data_pl.fit_transform(X), columns=columns)
```

----

### 數值離散化/極端值 ~ KBinsDiscretizer
將連續型的數值切成固定的區間（Bins），轉成類別標籤，常用於特徵工程。
```
from sklearn.preprocessing import KBinsDiscretizer
kb = KBinsDiscretizer(n_bins=3, encode='ordinal')
kb.fit_transform(df_full)
```

### 用固定值取代遺漏值
```
si = SimpleImputer(strategy='constant', fill_value='Missing')
X_cat_impute = si.fit_transform(X_cat)
X_cat_impute
```

### 動態調整管線參數
當管線建立好後，如果想臨時抽換裡面的演算法或取消某個步驟，不需要重新寫一個管線，直接用 .set_params() 即可。
```
# 將標準化步驟設為 None（等於跳過不做）
num_pl.set_params(standardscaler=None)

# 或者直接把 StandardScaler 換成 MinMaxScaler
from sklearn.preprocessing import MinMaxScaler
num_pl.set_params(standardscaler=MinMaxScaler())
```
