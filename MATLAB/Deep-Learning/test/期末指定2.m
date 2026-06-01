https://www.mathworks.com/help/deeplearning/gs/create-simple-deep-learning-classification-network.html

~網路架構微調與自動化~
a) 自動化計算
  numClasses = numel(categories(imdsTrain.Labels));
b) 增加網路架構
  inputSize = [28 28 1];
  numClasses = numel(categories(imdsTrain.Labels));
  
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
