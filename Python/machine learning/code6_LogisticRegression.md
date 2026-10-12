數字預測
類別預測

# 羅吉斯回歸
處理二元分類: x>0或y>0.5，判斷為1; 反之則為0; 切割點是x=0或y=0.5
f(x) = 1/(1+e^-x) ; x∈(-∞,∞) y∈(0,1)
![image](https://github.com/user-attachments/assets/6b9ae769-3a9f-4675-80d2-f12d94ab0493)



# 評估預測結果的好壞
準確率高不一定好
accuracy_score : 正確率，顯示整體正確率
confusion_matrix : 混亂矩陣，顯示實際和預測的結果組合
classification_report : 綜合報告，顯示更多預測結果的細節(例:召回率、精確率)

## 精確率 vs. 召回率

## 敏感度、特異度
