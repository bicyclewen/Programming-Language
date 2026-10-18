數字預測 & 類別預測

### 羅吉斯回歸
處理二元分類: x>0或y>0.5，判斷為1; 反之則為0; 切割點是x=0或y=0.5
f(x) = 1/(1+e^-x) ; x∈(-∞,∞) y∈(0,1)
![image](https://github.com/user-attachments/assets/6b9ae769-3a9f-4675-80d2-f12d94ab0493)

```
x = np.linspace(-10, 10, 1000)
y = 1 / (1 + np.exp(-x))  # Sigmoid 公式
```

### 鳶尾花資料集
取得資料並進行前置過濾，將原本的「三分類」簡化成好消化的「二元分類」。
```
from sklearn.datasets import load_iris
iris = load_iris()
df = pd.DataFrame(iris['data'], columns=iris['feature_names'])
df['target'] = iris['target']

# 只取特定兩欄特徵，並透過 iloc[50:] 過濾掉類別 0，只留類別 1 與類別 2 進行二元分類
df = df[['sepal width (cm)', 'petal length (cm)', 'target']]
df = df.iloc[50:]
```[cite: 5]
```
用 seaborn 的 pairplot 檢視變數關係
```
sns.pairplot(df,hue='target', vars=['sepal width (cm)', 'petal length (cm)'], size=2);
```
```
sns.pairplot(df, hue='target', vars=['sepal width (cm)', 'petal length (cm)'])
df.corr().round(2)['target']  # 計算與目標變數的相關係數
```[cite: 5]
* 透過 `pairplot` 和散布圖（`plot(kind='scatter')`）觀察不同類別在特徵空間中能否被清楚區隔[cite: 5]。
```
**精確率 vs. 召回率**

### 建構羅吉斯迴歸模型
初始物件>>>機器學習>>>模型預測
```
from sklearn.model_selection import train_test_split
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.33, random_state=42)

from sklearn.linear_model import LogisticRegression
model = LogisticRegression(solver='liblinear')
model.fit(X_train, y_train)  # 訓練模型
y_pred = model.predict(X_test)  # 進行預測
```[cite: 5]
* `model.coef_` 可以查看模型學到的各特徵權重（斜率）[cite: 5]。
```


### 評估預測結果的好壞
準確率高不一定好
accuracy_score : 正確率，顯示整體正確率
confusion_matrix : 混亂矩陣，顯示實際和預測的結果組合
classification_report : 綜合報告，顯示更多預測結果的細節(例:召回率、精確率)
## 敏感度、特異度
