//媽咪我在截止前終於通過了TAT
import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int a = Integer.parseInt(br.readLine());
		int b = Integer.parseInt(br.readLine());
		int c = Integer.parseInt(br.readLine());
		int d = Integer.parseInt(br.readLine());
		int y = 19;
		if(a<0||b<0||c<0||d<0){
			return;
		}else if(y<15){
			return;
		}

		int salary1 = 200*c, salary2 = 200*(c+d);
		int subsidy1=0, subsidy2=0;
		
		if(a<75000 && b<352 && salary1<13084){
			subsidy1 = 50000;
		}else if(a<112500 && b<528 && salary1<19626){
			subsidy1 = 30000;
		}
		
		if(a<75000 && b<352 && salary2<13084){
			subsidy2 = 50000;
		}else if(a<112500 && b<528 && salary2<19626){
			subsidy2 = 30000;
		}
		
		int total1 = salary1*6+subsidy1;
		int total2 = salary2*6+subsidy2;
		
		if(total1<total2){
			System.out.print("Yes");
		}else{
			System.out.print("No");
		}
	}
}
