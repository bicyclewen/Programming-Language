x = 0:0.01:2;

u = 2*log(60*x+1)/log(5);
v = 3*x.*sin(cos(6*x));

plot(x,u,'b'); hold on %等紅線
plot(x,v,'r')

xlabel("Distance x (mi)"); ylabel("Speed (mi/hr)");
legend('u','v')
