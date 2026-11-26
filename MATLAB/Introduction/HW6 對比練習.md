分別找一太亮,太暗,對比差之images，分別以
1. 自行設計數學方程式
2. imadjust() 來提升image的清晰度（即contrast變高）

太暗的
```
img = rgb2gray(imread('cat.jpg'));
imshow(img), figure, imhist(img), axis tight;

%1
i1 = 0; i2 = 100;
j1 = 0; j2 = 255;

img_d = double(img);
img_math = zeros(size(img_d));

idx1 = (img_d >= i1) & (img_d <= i2);
img_math(idx1) = ((j2 - j1) / (i2 - i1)) * (img_d(idx1) - i1) + j1;

idx2 = img_d > i2;
img_math(idx2) = 255;

img_math = uint8(img_math);

figure, imshow(img_math);
figure, imhist(img_math), axis tight;

%2
img_adj = imadjust(img, [0/255, 100/255], [0, 1], 1);

imshow(img_adj), figure, imhist(img_adj), axis tight;
```
