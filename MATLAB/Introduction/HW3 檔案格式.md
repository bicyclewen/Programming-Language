分別找一 : 灰階、黑白、彩色 image
1. 顯示出來
2. 各將其以 imwrite() 函數寫成 : JPEG、PNG、BMP 格式之檔案
3. 比較其 file 大小(各占多少 bytes)，不同格式是否一定之關係? (如:哪種最大?哪種最小?)

```
img_color = imread('sheep1.jpg');
img_gray = rgb2gray(img_color);
img_bw = imbinarize(img_gray);


%彩色的三種檔案格式
imwrite(img_color, 'color1.jpg');
imwrite(img_color, 'color2.png');
imwrite(img_color, 'color3.bmp');

%灰階的三種檔案格式
imwrite(img_gray, 'gray1.jpg');
imwrite(img_gray, 'gray2.png');
imwrite(img_gray, 'gray3.bmp');

%黑白的三種檔案格式
imwrite(img_bw, 'bw1.jpg');
imwrite(img_bw, 'bw2.png');
imwrite(img_bw, 'bw3.bmp');


%迴圈~列出3*3張圖片的檔案大小
file = {'color1.jpg', 'color2.png', 'color3.bmp', ...
        'gray1.jpg', 'gray2.png', 'gray3.bmp',...
        'bw1.jpg', 'bw2.png', 'bw3.bmp'};
for i = 1:length(file)
    info = imfinfo(file{i});
    fprintf('%s | %d\n', file{i}, info.FileSize);
end
```
<img width="119" height="144" alt="image" src="https://github.com/user-attachments/assets/ffeded7d-22ee-4ded-b40e-f4a22b4ec086" />
