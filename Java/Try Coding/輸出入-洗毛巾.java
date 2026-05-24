import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		double cus = Double.parseDouble(br.readLine());
		if(cus%1!=0||cus<0||cus>8){
			System.out.print("Invalid value");
		}else{
			double towel = cus*4;
			double time = (towel+8-1)/8;
			System.out.printf("%.0f",time);
		}
	}
}
