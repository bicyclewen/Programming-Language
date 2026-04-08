cover = imread("forest.jpg"); //載體圖
secret = imread("p.bmp"); //浮水印 (沈老: 朴寶英♡)

secret = imresize(secret, [size(cover,1) size(cover,2)]); //size一樣大

cover_high = bitand(cover, uint8(240));
secret_high = bitand(secret, uint8(240));
secret_shift = bitshift(secret_high, -4);

img = cover_high + secret_shift;

figure(1);
subplot(1,2,1); imshow(cover); title("原圖");
subplot(1,2,2); imshow(img); title("有藏圖的");

imwrite(img, "img.bmp"); //匯出圖片(會跑到桌面)
