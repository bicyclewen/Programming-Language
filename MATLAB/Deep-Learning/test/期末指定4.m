https://www.mathworks.com/help/deeplearning/gs/classify-image-using-pretrained-network.html
~預訓練模型~
a) 更換網路模型
[net,classNames] = imagePretrainedNetwork("squeezenet");

b) 準備照片
inputSize = net.Layers(1).InputSize;
image = {"llama.jpg","football.jpg","sherlock.jpg"};

c) 讀取並調整照片
for i=1:3
  I = imread(image{i});
  I = imresize(I,inputSize(1:2));
  
  scores = predict(net,single(I));
  label = scores2label(scores,classNames);
  figure
  imshow(I)
  title(string(label))
end
