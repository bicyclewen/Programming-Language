https://www.mathworks.com/help/deeplearning/gs/create-simple-image-classification-network-using-deep-network-designer.html
unzip("__.zip");
imds = imageDatastore("DigitsData", ... %連接符號
       IncludeSubfolders=true, ...
       LabelSource="foldernames"); %貼標籤
classNames = categories(imds.Labels); %類別化
[imdsTrain,imdsValidation,imdsTest] = splitEachLabel(imds,0.7,0.15,0.15,"randomized"); %[訓練集,驗證集,測試集]


softmax 
 1. 數值範圍 [0,1]
 2. 
trainnet
