%【前情提要】
load ovariancancer.mat;
whos
  Name        Size                Bytes  Class     Attributes

  grp       216x1                 28512  cell                
  obs       216x4000            3456000  single              
%將兩變數合成一個table
obs2 = array2table(obs);
obs2(:,4001)=grp;
whos
  Name        Size                Bytes  Class     Attributes

  grp       216x1                 28512  cell                
  obs       216x4000            3456000  single              
  obs2      216x4001            4499287  table 



%【更改欄位名稱】
