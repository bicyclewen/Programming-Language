本篇透過波士頓房價資料集來示範資料載入、探索性數據分析（EDA）、模型訓練、殘差驗證到進階多項式特徵與過擬合。

**線性回歸**
目的: 估算 y = a0 + a1x 中的兩參數a0和a1

**使用 sklearn.datasets 內建的 load_boston**
- keys() 了解資料有哪些索引鍵
- DESCR 介紹資料來源

### 資料探索
- 目標變數分佈：透過直方圖 (hist) 觀察房價 (target) 的資料分佈情形。
```
df['target'].plot(kind='hist', bins=30, alpha=0.5)
```
- 相關係數排序：計算全資料集的相關係數矩陣 df.corr()，並將與房價相關性最高的特徵進行排序。
```
corr = df.corr().round(2)
corr['target'].sort_values(ascending=False)
```
- 熱力圖視覺化：繪製相關係數熱力圖，並透過篩選條件只顯示絕對值大於 0.6 的關聯性。
```
plt.figure(figsize=(8, 6))
corr[np.abs(corr) < 0.6] = 0
sns.heatmap(corr, annot=True, cmap='coolwarm');
```
![pic](https://github.com/user-attachments/assets/52160010-734f-491f-86ab-334a801c91d2)

- 特徵與目標散布圖：以房間數量 (RM) 對房價 (target) 繪製散布圖，直觀觀察兩者的正向線性關係。
```
df.plot(kind='scatter', x='RM', y='target', alpha=0.5, figsize=(8,4));
```
![pic](https://github.com/user-attachments/assets/da3a0fe6-1322-4f67-8266-0c9ae0c393b7)

### 資料切割
- 自變數X: 二維資料；應變數y: 一維資料
- 切割出訓練與測試集 : 使用 train_test_split 將資料依 33% 比例切分為測試集，並設定 random_state=42 確保隨機結果可重現。
```
from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, 
                                                   test_size=0.33, random_state=42)
```
```
print('訓練集的筆數：',len(X_train))
print('測試集的筆數：',len(X_test))
print('測試集所佔全部資料的百分比：',len(X_test)/len(X))
```
畫在散布圖上
```
fig, ax = plt.subplots(figsize=(10, 4))
ax.scatter(X_train, y_train, color='blue', alpha=0.4, label='訓練集')
ax.scatter(X_test, y_test, color='red', alpha=0.4, label='測試集')
ax.set_xlabel('房間數量')
ax.set_ylabel('房價')
ax.legend()
```
![pic](https://github.com/user-attachments/assets/67e60c29-29f9-46eb-bbf2-44586ec5a386)

### 簡單性迴歸模型
建立預測器的步驟 : 初始物件>>>機器學習>>>機器預測
```
from sklearn.linear_model import LinearRegression
model = LinearRegression()

model.fit(X_train, y_train) # 只使用訓練集

print(model.intercept_, model.coef_) # 檢視模型參數：截距 (intercept_) 與迴歸係數 (coef_)。
```
### 分析預測結果
評估訓練模型的好壞 ~ 殘差值
y_pred 是預測值，y_test 是實際值(真實的房價)。殘差值就是這兩個的落差。

- 散布圖
```
y_pred = model.predict(X_test)

plt.figure(figsize=(8,4))
plt.scatter(X_test, y_test-y_pred)
plt.axhline(0, c='r', ls='--');
```
- 直方圖
```
plt.hist(y_test-y_pred, bins=30);
```
除了用圖形觀察，也可以用「殘差值的總和」來看
- mean_squared_error : 先平方再相加，越小越好
- mean_absolute_error : 先取絕對值再相加，越小越好
- R^2 : 解釋變異量，越大越好，值會在 [0,1]

### 手動 or PolynomialFeatures 管線處理

手動一次方:
```
model.predict([[6]])

同 model.intercept_+ model.coef_*6
```

自動二次方:
```
from sklearn.preprocessing import PolynomialFeatures
polynomial = PolynomialFeatures(degree=2)
x_poly = polynomial.fit_transform(X_train)
x_poly[:5]

from sklearn.pipeline import make_pipeline
model_pl_2 = make_pipeline(PolynomialFeatures(degree=2), LinearRegression())
model_pl_2.fit(X_train, y_train)
y_pred = model_pl_2.predict(X_test)
print('Mean Squred Error:',mean_squared_error(y_test, y_pred))
print('Mean Absolute Error:', mean_absolute_error(y_test, y_pred))
print('R2 Score:', r2_score(y_test, y_pred))
```
自動一到九次方:
```
fig, ax = plt.subplots(figsize=(10, 4))
errors_train = []
errors_test = []
for order in range(1, 10):
    model_pl_o = make_pipeline(PolynomialFeatures(degree=order), LinearRegression())
    model_pl_o.fit(X_train, y_train)
    y_pred = model_pl_o.predict(X_train)
    errors_train.append(mean_squared_error(y_train, y_pred))
    y_pred = model_pl_o.predict(X_test)
    errors_test.append(mean_squared_error(y_test, y_pred))
    
plt.plot(range(1,10),errors_train, marker='.', ls = '--', label='訓練集')
plt.plot(range(1,10),errors_test, marker='o', label='測試集')
plt.legend();
# plot_chinese(ax)
```
![pic](https://github.com/user-attachments/assets/e7704558-e37c-4147-a387-467736a1d4de)
