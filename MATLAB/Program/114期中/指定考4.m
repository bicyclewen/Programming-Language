G = [100  95  50  80  90
      95  65  93 100  40
      99  50  90  80  70
      90  83  83  64  99
      85  70  83  75  80];
G(G == 80) = 85;

disp('The number of passed students is');
sum( G(:) >= 60)
disp('The mean of the grades of all students is');
mean(G(:))
disp('The variance of the grades of all students is');
var(G(:))
