import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int n = Integer.parseInt(br.readLine());
		int c = Integer.parseInt(br.readLine());
		int w = Integer.parseInt(br.readLine());
		if(n<1||c<1||w<1||c>n||w>n){
			System.out.print("Invalid value");
			return;
		}
		
		int d1 = Math.abs(w-c);
		int d2 = n-d1;
		int d = Math.min(d1,d2);
		System.out.print(d);
	}
}
