info = dicominfo('file.dcm');
img = double(dicomread('file.dcm'));

img = img*info.RescaleSlope + info.RescaleIntercept %斜率跟截距

figure(1)
subplot(1, 2, 1); imshow(img, [-1550 50]);
subplot(1, 2, 2); imshow(img, [-185 265]);

%國際標準window: 中心點-600, 寬度1600
