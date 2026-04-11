x = linspace(-pi,pi,1000);
y1 = zeros(size(x));
y2 = zeros(size(x));
 
for i = 1:5
    n = 2*i-1;
    y = 4/pi*sin(n*x)/n;

    if i<= 4
       y1 = y1 + y;
    end
    y2 = y2 + y;
end

plot(x,y1,'b'); hold on
plot(x,y2,'r')

xlabel('x'); ylabel('y'); title('Approximate sin');
legend('series1', 'series2')
grid on %淺灰格線
