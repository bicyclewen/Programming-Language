import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int num1 = Integer.parseInt(br.readLine());
		int num2 = Integer.parseInt(br.readLine());
		boolean find = false;
		
		int min = Math.min(num1,num2);
		int max = Math.max(num1,num2);
		
		for(int i=max; i>=min; i--){ //範圍內的數字
			if(i<=1){
				continue;
			}
			
			int count=0;
			for(int j=2; j<=Math.sqrt(i); j++){ //某數的因數
				if(i%j==0){
					count++;
					break;
				}
			}
			if(count==0){
				System.out.println(i);
				find=true;
			}
		}
		if(!find){
			System.out.print("None");
		}
	}
}
