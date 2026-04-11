weight = 45 + (120-45).*rand(1,10);
height = (140 + (220-140).*rand(1,10))/100;
BMI = weight./(height.^2);

disp('BMI =');
fprintf('\n');
disp(BMI) %不加分號，讓MATLAB自己噴出"ans ="還有空行
disp('The minimum is');
min(BMI)
disp('The mean is');
mean(BMI)
disp('The maximum is');
max(BMI)
