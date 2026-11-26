分別找一太亮,太暗,對比差之images，分別以
1. 自行設計數學方程式
2. imadjust() 來提升image的清晰度（即contrast變高）

太暗的
```
img = rgb2gray(imread('cat.jpg'));
imshow(img), figure, imhist(img), axis tight;
```
<img width="500" height="317" alt="image" src="https://github.com/user-attachments/assets/7895f7a6-c21f-4bb3-abe7-202314502a08" />
<img width="488" height="301" alt="image" src="https://github.com/user-attachments/assets/9cf54cd2-f06c-42a2-baca-270da8defc3d" />
