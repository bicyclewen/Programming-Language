https://www.mathworks.com/help/deeplearning/gs/create-simple-deep-learning-classification-network.html

~基礎模型訓練與參數配置~
a) 資料分割
[imdsTrain,imdsValidation,imdsTest] = splitEachLabel(imds,0.7,0.1,"randomized");
剩餘之0.2會自動變為imdsTest
b) Specify Training Option 訓練參數
options = trainingOptions("adam", ... %solver從sgdm改成adam
                          MaxEpochs=3, ... %最大訓練輪數從4改成3
c) 修改資料集名稱
accuracy = testnet(net,imdsTest,"accuracy") %確認準確率函數

按Run
