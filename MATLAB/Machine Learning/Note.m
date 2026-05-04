unzip("__.zip");
imds = imageDatastore("DigitsData", ... %連接符號
       IncludeSubfolders=true, ...
       LabelSource="foldernames"); %貼標籤
classNames = categories(imds.Labels);
