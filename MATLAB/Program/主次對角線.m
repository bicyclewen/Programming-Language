nrows=5;
ncols=5;
A=ones(nrows,ncols);

for r = 1:nrows
    for c = 1:ncols
        if r==c
           A(r,c)=1;
        elseif r-c==1
           A(r,c)=-2;
        elseif r-c==-1
           A(r,c)=-1;
        else
           A(r,c)=0;
        end
    end
end
