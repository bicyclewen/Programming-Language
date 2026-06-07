import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int year = Integer.parseInt(br.readLine());
		int day = Integer.parseInt(br.readLine());
		
		int FEB;
		if(year%400==0 || (year%4==0&&year%100!=0)){
			FEB = 29;
		}else{
			FEB = 28;
		}
		
		int[] month={0,31,FEB,31,30,31,30,31,31,30,31,30,31};
		int count=0, last=0;
		
		//1/13的星期代碼
		int M13 = (day+13-1)%7;
		
		for(int i=1; i<=12; i++){
			if(M13==5){
				count++;
				last=i;
			}
			
			if(i<12){
				M13 = (M13 + month[i])%7;
			}
		}
		System.out.print(count+"\n"+last);
	}
}
