分別找一太亮,太暗,對比差之images，分別以
1. 自行設計數學方程式
2. imadjust() 來提升image的清晰度（即contrast變高）

太暗的
```
img = rgb2gray(imread('cat.jpg'));

%1
i1 = 0; i2 = 100;
j1 = 0; j2 = 255;
img_math = ((j2 - j1) / (i2 - i1)) * (img - i1) + j1;

%2
img_adj = imadjust(img, [0/255, 100/255], [0, 1], 1);


figure;
subplot(3, 2, 1), imshow(img), title('原圖');
subplot(3, 2, 2), imhist(img), axis tight, title('原圖直方圖');

subplot(3, 2, 3), imshow(img_math), title('方法1：自訂公式');
subplot(3, 2, 4), imhist(img_math), axis tight, title('方法1 直方圖');

subplot(3, 2, 5), imshow(img_adj), title('方法2：imadjust');
subplot(3, 2, 6), imhist(img_adj), axis tight, title('方法2 直方圖');
```
<img width="688" height="347" alt="螢幕擷取畫面 2026-11-26 204808" src="https://github.com/user-attachments/assets/8d63154a-69e7-4dd8-8bde-5ef6242eaa42" />

太亮的
```
img = rgb2gray(imread('peacock.jpg'));

%1
i1 = 130; i2 = 255;
j1 = 0;   j2 = 255;
img_math = ((j2 - j1) / (i2 - i1)) * (img - i1) + j1;

%2
img_adj = imadjust(img, [130/255, 255/255], [0, 1], 1);

figure;
subplot(3, 2, 1), imshow(img), title('原圖');
subplot(3, 2, 2), imhist(img), axis tight, title('原圖直方圖');

subplot(3, 2, 3), imshow(img_math), title('方法1：自訂公式');
subplot(3, 2, 4), imhist(img_math), axis tight, title('方法1 直方圖');

subplot(3, 2, 5), imshow(img_adj), title('方法2：imadjust');
subplot(3, 2, 6), imhist(img_adj), axis tight, title('方法2 直方圖');
```

對比度差的
```
img = rgb2gray(imread('images.jpg'));

%1
i1 = 75;  i2 = 195;
j1 = 0;   j2 = 255;
img_math = ((j2 - j1) / (i2 - i1)) * (img - i1) + j1;

%2
img_adj = imadjust(img, [75/255, 195/255], [0, 1], 1);


figure;
subplot(3, 2, 1), imshow(img), title('原圖');
subplot(3, 2, 2), imhist(img), axis tight, title('原圖直方圖');

subplot(3, 2, 3), imshow(img_math), title('方法1：自訂公式');
subplot(3, 2, 4), imhist(img_math), axis tight, title('方法1 直方圖');

subplot(3, 2, 5), imshow(img_adj), title('方法2：imadjust');
subplot(3, 2, 6), imhist(img_adj), axis tight, title('方法2 直方圖');
```
