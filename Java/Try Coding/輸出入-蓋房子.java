import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int tall = Integer.parseInt(br.readLine());
		int wide = Integer.parseInt(br.readLine());
		
		double day = 8*30 + (tall-5)*15 + Math.ceil((wide-50)/10.0)*9*tall;
		int month = (int)Math.ceil(day/30.0);
		System.out.print(month);
	}
}
