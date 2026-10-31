#請將自變數 X的欄位用'LSTAT'，再用線性迴歸模型估算。
import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
plt.rcParams['font.sans-serif'] = ['DFKai-sb']

from sklearn.datasets import load_boston
boston = load_boston()

df = pd.DataFrame(boston['data'], columns=boston['feature_names'])
df['target']=boston['target']

#(1) 預測係數。
X = df[['LSTAT']]
y = df['target']
from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.33, random_state=42)

from sklearn.linear_model import LinearRegression
model = LinearRegression()
model.fit(X_train, y_train)
print('模型預測的係數', model.intercept_, model.coef_)


#(2) 繪製預測結果和實際結果的散布圖。
y_pred = model.predict(X_test)
plt.figure(figsize=(10, 4))
plt.scatter(X_test, y_test, label='實際資料')
plt.scatter(X_test, y_pred, c='r', label='預測結果')
plt.legend()

#(3) 整體預測結果分析。
from sklearn.metrics import mean_squared_error, mean_absolute_error, r2_score
print('Mean Squred Error: ', mean_squared_error(y_test, y_pred))
print('Mean Absolute Error: ', mean_absolute_error(y_test, y_pred))
print('R2 Score: ', r2_score(y_test, y_pred))
