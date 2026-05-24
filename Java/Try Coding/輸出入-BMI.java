import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		double t = Double.parseDouble(br.readLine())/100.0;
		String code = br.readLine();
		double up=-1, low=-1, h=t*t;
		
		if("A".equals(code)){
			up = 18.5;
		}else if("B".equals(code)){
			low = 18.5;
			up=24.0;
		}else if("C".equals(code)){
			low = 24.0;
			up=27.0;
		}else if("D".equals(code)){
			low = 27.0;
			up=30.0;
		}else if("E".equals(code)){
			low = 30.0;
			up=35.0;
		}else if("F".equals(code)){
			low = 35;
		}
	
		if(low==-1){
			System.out.println("None");
		}else{
			low *= h;
			System.out.printf("%.2f\n",low);
		}
		
		if(up==-1){
			System.out.println("None");
		}else{
			up *= h;
			System.out.printf("%.2f\n",up);
		}
	}
}
