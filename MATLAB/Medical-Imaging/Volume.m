folderPath = uigetdir(pwd, '選擇包含 DICOM 檔案的資料夾');
if folderPath == 0
    error('未選擇資料夾');
end

dcmFiles = dir(fullfile(folderPath, '*.dcm'));
numSlices = length(dcmFiles);

if numSlices == 0
    error('資料夾內找不到 .dcm 檔案');
end

instanceNumbers = zeros(numSlices, 1);
for k = 1:numSlices
    info = dicominfo(fullfile(folderPath, dcmFiles(k).name));
    instanceNumbers(k) = info.InstanceNumber;
end
[~, sortIdx] = sort(instanceNumbers);
dcmFiles = dcmFiles(sortIdx);

firstInfo = dicominfo(fullfile(folderPath, dcmFiles(1).name));
firstImage = dicomread(firstInfo);
[height, width] = size(firstImage);

imageVolume = zeros(height, width, numSlices, 'double');

slope = 1; intercept = 0;
if isfield(firstInfo, 'RescaleSlope'),     slope = firstInfo.RescaleSlope; end
if isfield(firstInfo, 'RescaleIntercept'), intercept = firstInfo.RescaleIntercept; end
imageVolume(:, :, 1) = double(firstImage) * slope + intercept;

for k = 2:numSlices
    info = dicominfo(fullfile(folderPath, dcmFiles(k).name));
    img = dicomread(info);
    
    slope = 1; intercept = 0;
    if isfield(info, 'RescaleSlope'),     slope = info.RescaleSlope; end
    if isfield(info, 'RescaleIntercept'), intercept = info.RescaleIntercept; end
    
    imageVolume(:, :, k) = double(img) * slope + intercept;
end


for i=1:1:numSlices
    figure(1), imshow(imageVolume(:,:,i), [-1200 200]);
    pause(0.1);
end
