info = dicominfo('006-225.dcm');
img = dicomread('006-225.dcm');
img = double(dicomread('006-225.dcm'));
img = img*info.RescaleSlope + info.RescaleIntercept;

figure(1), imshow(img, [-1300 150])
figure(2), imshow(img, [-100 250])


img1 = zeros(512, 512);
img2 = zeros(512, 512);

img1 = img(img(:, :)>=-1300);
img1 = img>=-1300;
img2 = img>=-100;

img3 = img1-img2;
figure(3), imshow(img3)
img4 = ~img3;
figure(4), imshow(img4)

p = rand(8, 11)
p = p>0.5



p = zeros(8, 11);
f = [1 1 1];
imdilate(p, f) %1>0
imerode(p, f) %0>1
