任意找 : 黑白圖、灰階圖、彩色圖，決定此三個圖
1. image type
2. spatial resolution
3. file size
4. intensity resolution
5. 讀入並顯示其圖
6. 互動式查看游標所在之pixel value

color.png
```
img_color = imread('cat_3.jpg');

imwrite(img_color, 'color.png');
imshow(img_color), impixelinfo
imfinfo('color.png')
```

gray.png
```
img_color = imread('cat_3.jpg');
img_gray = im2gray(img_color);

imwrite(img_gray, 'gray.png');
imshow(img_gray), impixelinfo
imfinfo('gray.png')
```
