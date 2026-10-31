#假設有一筆資料 
# scores = {'Math':[90,np.nan,70,80],'English':[60,70,'90',50], 'History':[33,np.nan,188,60]}
#請先將它匯入至 df = pd.DataFrame(scores, index=['Simon','Allen','Jimmy','Peter'])

import pandas as pd
import numpy as np

scores = {'Math':[90,np.nan,70,80],
          'English':[60,70,'90',50], 
          'History':[33,np.nan,188,60]}
df = pd.DataFrame(scores, index=['Simon','Allen','Jimmy','Peter'])

#(1)請將 English裡有問題的 '90' 改為數字 90
df['English'] = df['English'].apply(int)
print('答案1')
print(df['English'])

#(2)請將 History裡的 188，改成 88
df.loc[df['History'] == 188 , 'History'] = 88
print('答案2')
print(df['History'])

#(3)請將遺漏值 nan，設為各自欄位的平均值範例
df = df.fillna(df.mean())
print('答案3')
df
