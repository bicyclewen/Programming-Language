unzip("__.zip");
imds = imageDatastore("DigitsData", ... %連接符號
       IncludeSubfolders=true, ...
       LabelSource="foldernames"); %貼標籤
classNames = categories(imds.Labels); %類別化
[imdsTrain,imdsValidation,imdsTest] = splitEachLabel(imds,0.7,0.15,0.15,"randomized"); %[訓練集,驗證集,測試集]


