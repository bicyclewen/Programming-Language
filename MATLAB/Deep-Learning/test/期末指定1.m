https://www.mathworks.com/help/deeplearning/gs/create-simple-deep-learning-classification-network.html
~基礎模型訓練與參數配置~
a) Load Data 分割資料
[imdsTrain,imdsValidation,imdsTest] = splitEachLabel(imds,0.7,0.1,0.2,"randomized");
-
b) Specify Training Option 訓練參數
options = trainingOptions("adam", ... %solver從sgdm改成adam
                          MaxEpochs=3, ... %最大訓練輪數從4改成3
-
c) Test Neural Network
accuracy = testnet(net,imdsValidation,"accuracy") %確認準確率函數
-
按Run
