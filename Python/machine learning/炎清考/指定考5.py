#用鳶尾花全部的欄位來做羅吉斯迴歸模型預測。
import pandas as pd
import numpy as np
from sklearn.datasets import load_iris
iris = load_iris()
df = pd.DataFrame(iris['data'], columns=iris['feature_names'])
df['target']=iris['target']

#(1) 請將資料做標準化，並輸出正確率、混亂矩陣和綜合報告。請注意，全部資料裡一共有三個類別的花朵。
X = df[iris['feature_names']]
y = df['target']

from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.33, random_state=42)


from sklearn.preprocessing import StandardScaler
from sklearn.linear_model import LogisticRegression
from sklearn.pipeline import make_pipeline
model_pl = make_pipeline(StandardScaler(),
                         LogisticRegression(C=0.1)) # 記得調整正規化強度!!!!
model_pl.fit(X_train, y_train)

from sklearn.metrics import accuracy_score, confusion_matrix, classification_report
y_pred = model_pl.predict(X_test)
print('整體正確率: ', accuracy_score(y_test, y_pred))

cm = confusion_matrix(y_test, y_pred)
print(pd.DataFrame(cm, index=['實際1','實際2','實際3'], columns=['預測1','預測2','預測3']))

print(classification_report(y_test, y_pred))

#(2) 請預測這筆資料的結果是什麼？ [2,1,3,3]。（提示：請注意資料維度問題。）
print('預測的資料類別為', model_pl.predict([[2,1,3,3]]))

#(3) 請預測這兩筆資料的結果是什麼？ [2,1,3,3],[4,5,7,8]。（提示：請注意資料維度問題。）
print('預測的資料類別為', model_pl.predict([[2,1,3,3],[4,5,7,8]]))

#(4) 請依照上例的預測結果，自己寫程式來製作混亂矩陣。（提示：用groupby。）
df_eval = pd.DataFrame({'true':y_test, 'pred':y_pred})
my_cm = df_eval.groupby(['true','pred']).size().unstack(fill_value=0.0)
my_cm
