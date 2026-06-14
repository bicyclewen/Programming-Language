https://www.mathworks.com/help/deeplearning/gs/create-simple-deep-learning-classification-network.html

~網路架構微調與自動化~
a) 自動化計算
  numClasses = numel(categories(imdsTrain.Labels));
  categories()取類別,numel()算數量
b) 增加網路架構~加深卷積層、maxPooling
  %參考 Create Simple Deep Learning Neural Network for Classification
  https://www.mathworks.com/help/deeplearning/ug/create-simple-deep-learning-network-for-classification.html?s_tid=srchtitle_support_results_1_simple+deeplearning
  layers = [
      imageInputLayer(inputSize)
      
      convolution2dLayer(3,16,Padding="same")
      batchNormalizationLayer
      reluLayer
      
      maxPooling2dLayer(2,Stride=2)
  
      convolution2dLayer(3,32,Padding="same")
      batchNormalizationLayer
      reluLayer
      
      maxPooling2dLayer(2,Stride=2)
      
      convolution2dLayer(3,64,Padding="same")
      batchNormalizationLayer
      reluLayer
  
      fullyConnectedLayer(numClasses)
      softmaxLayer];
