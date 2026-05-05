Volume = uigetdir(pwd, 'Volume');
dcmFiles = dir(fullfile(Volume, '*.dcm'));
z = length(dcmFiles);
dcmFiles(1).name
info = dicominfo(dcmFiles(1).name);
info.Height
info.Width
info.InstanceNumber %輸出順序!=切片順序
volume = zeros(info.Height, info.Width, z);

for i=1:z
    info2 = dicominfo(dcmFiles(1).name);
    img = dicomread(dcmFiles(1).name);
    volume(:,:,info2.InstanceNumber)=img;
end
volume = volume*info.RescaleSlope + info.RescaleIntercept;
for i=1:1:z
    figure(1), imshow(volume(:,:,i), [-1200 200]);
    pause(0.1);
end
