import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String line;
		int total=0, count=0;
		
		while((line=br.readLine())!=null){
			if(line.isEmpty()){
				break;
			}
			int money=0;
			int num = Integer.parseInt(line);
			if(num<=10){
				money += 1200*num;
			}else if(num>10){
				money += 15000;
				if(num>40){
					money += 420*num;
					money += (num/10)*1500;
				}else if(num>20){
					money += 420*num;
				}else if(num>10){
					money += 380*num;
				}
			}
			count++;
			total += money;
		}
		System.out.print(total/count);
	}
}
