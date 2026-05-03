import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		double per = Double.parseDouble(br.readLine());
		double A4 = 0.03*Math.pow(100,3)/25;
		int paper = (int)(A4*per/100);
		System.out.print(paper);
	}
}
