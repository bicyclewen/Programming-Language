img = imread('.jpg');
img2 = im2gray(img); %變一層

%撒點鹽跟胡椒
img3 = imnoise(img2, 'salt', 0.15);
img4 = imnoise(img2, 'salt & pepper', 0.05);
img5 = imnoise(img2, 'salt & pepper', 0.9);

%基本原則 : 二分法
bw = img4>5;
bw = img4<5; %小於5的挑出來，小於5的密度範圍留著 ~ uint8 選黑0~255白

