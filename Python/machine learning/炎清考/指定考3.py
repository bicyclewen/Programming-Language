import pandas as pd
import numpy as np
from sklearn.impute import SimpleImputer
from sklearn.preprocessing import MinMaxScaler, OneHotEncoder
from sklearn.pipeline import make_pipeline
from sklearn.compose import ColumnTransformer

data = {
'size': ['S','M',np.nan,'XL','XL'],
'color': ['red', 'blue', 'blue', 'black', np.nan],
'price': [2100, np.nan, 4500, 7300, 3200],
'quantity': [np.nan, 350, np.nan, 200, 10]
}
df = pd.DataFrame(data)
print('原始資料')
df


#(1) 請用 ColumnTransformer水平合併器，將數值和類別管道器結合起來。
#其中數值管道器要做遺漏值處理，用中位數 median 再做 MinMaxScaler轉換。類別管道器的遺漏值用眾數處理後，再做獨熱編碼。
col_num = ['price','quantity']
col_cat = ['size','color']

num_pl = make_pipeline(SimpleImputer(strategy='median'), 
                       MinMaxScaler())
cat_pl = make_pipeline(SimpleImputer(strategy='most_frequent'), 
                       OneHotEncoder(sparse=False))
data_pl = ColumnTransformer([
    ('num_pl', num_pl, col_num),
    ('cat_pl', cat_pl, col_cat)
])

trans_data = data_pl.fit_transform(df)
print('轉換後資料')
trans_data

#(2) 請將獨熱編碼的欄位和數值型資料欄位取出，並整合到 DataFrame裡。
oh = data_pl.named_transformers_['cat_pl'].named_steps['onehotencoder'].get_feature_names(col_cat)
columns = col_num + oh.tolist()

pd.DataFrame(trans_data.round(2), columns=columns)

