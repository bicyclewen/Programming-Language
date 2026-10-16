任意找 : 黑白圖、灰階圖、彩色圖，決定此三個圖
1. image type
2. spatial resolution
3. file size
4. intensity resolution
5. 讀入並顯示其圖
6. 互動式查看游標所在之pixel value

bk_cat.png
```
img = imread('cat_1.jpg');
img3 = im2gray(img);
img2 = imbinarize(img3);

imshow(img2), impixelinfo
```
