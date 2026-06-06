https://www.mathworks.com/help/deeplearning/gs/create-simple-deep-learning-classification-network.html
https://www.mathworks.com/help/deeplearning/ug/create-simple-deep-learning-network-for-classification.html?s_tid=srchtitle_support_results_1_create%2520simple%2520deep%2520learning%2520classification%2520network

~confusion matrix~
a) 切割資料
[imdsTrain,imdsValidation, imdsTest] = splitEachLabel(imds,0.7,0.15,0.15,"randomized");

b) 
scores = minibatchpredict(net,imdsTest);
YTest = scores2label(scores,classNames);
TTest = imdsTest.Labels;
accuracy = mean(YTest == TTest)*100

figure;
confusionchart(TTest,YTest);
