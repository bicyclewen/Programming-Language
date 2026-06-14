https://www.mathworks.com/help/deeplearning/gs/create-simple-deep-learning-classification-network.html
https://www.mathworks.com/help/deeplearning/gs/get-started-with-transfer-learning.html

~混淆矩陣confusion matrix~
a) 切割資料
[imdsTrain,imdsValidation, imdsTest] = splitEachLabel(imds,0.7,0.15,"randomized");

b) 
inputSize = net.Layers(1).InputSize(1:2); %可省略(因為不用調照片)
Ypred = minibatchpredict(net,imdsValidation);
Ypred = scores2label(YTest,classNames);

TTarget = imdsTest.Labels;
figure
confusionchart(TTarget,Ypred);
