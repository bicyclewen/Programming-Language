import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		double h = Double.parseDouble(br.readLine());
		double m = Double.parseDouble(br.readLine());
		if(h%1!=0||m%1!=0){
			System.out.print("Invalid value");
		}else if(h>=24||h<0||m>=60||m<0){
			System.out.print("Invalid value");
		}else{
			double dday = h*60+m;
			if(dday>=0&&dday<=12*60){
				dday = 12*60-dday;
			}else{
				dday = (24*60-dday)+12*60;
			}
			int hh = (int)(dday/60);
			int mm = (int)(dday%60);
			System.out.printf("%d\n",hh);
			System.out.printf("%d",mm);
		}
	}
}
