import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String line;
		//第一行 處理n個數
		if((line=br.readLine())==null){
			return;
		}
		int n = Integer.parseInt(line);
		int valid = 0;
		
		//後幾行的數值
		while((line=br.readLine())!=null){
			//忽略空白行
			if(line.isEmpty()){ 
				continue;
			}
			//要求之數值數
			if(valid>=n){
				System.out.println("Invalid value");
				continue;
			}
			//先檢查小數點
			if(line.contains(".")){
				System.out.println("Invalid value");
				continue;
			}

			try{	
				long test = Long.parseLong(line);//輸入之內容
				if(test<=0 || test>=Math.pow(2,31)){
					System.out.println("Invalid value");
					continue;
				}
				
				long result=1;
				long temp = test;
				while(temp>0){
					result *= (temp%10);
					temp /= 10;
				}
				System.out.println(result);
				valid++;
			}catch(NumberFormatException e){ //小數、非數字
				System.out.println("Invalid value");
			}
		}
	}
}
