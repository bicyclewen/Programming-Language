對應作業~ 13、14
函數 : 將程式中常用的共同程式碼獨立成程式區塊，以能重複呼叫這些函數之程式碼 (Functions Call)
((課本將其比喻成黑盒子~函數:Interface, 實際程式碼:Implementation))
-
~~~建立C#函數~~~
修飾子 Modifiers ~ public、private (預設是private)
  修飾子 void 函數名稱(){
    程式敘述;
  }

#有傳回值~functions
[public|private] 傳回值型別 函數名稱(參數1, 參數2, ...){
  程式敘述;
  return值|運算式;
}

#沒有傳回值~procedures
[public|private] void 函數名稱(){
  程式敘述;
}
==========================================================
#函數參數傳遞方式
call by value : //預設
  void byVal(int v){...}
call by address : 
  void byRef(ref int v){...}
call by out : 
  void byOut(out int v){...}
#具名參數 Named Parameters
public int sum(int a, int b, int c){
  return a+b+c;
}
result = sum(b: 2, c: 3, a: 1);
#選擇性參數 Optional Parameters

==========================================================
#變數範圍
Local scope
Global scope

==========================================================
#遞迴
public int factorial(int n){
  if(n==1) return 1;
  else return n*factorial(n-1);
  
}


