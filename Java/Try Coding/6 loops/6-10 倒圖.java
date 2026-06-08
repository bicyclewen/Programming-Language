import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int n = Integer.parseInt(br.readLine());
		int h = Integer.parseInt(br.readLine());
		
		for(int i=1; i<=h; i++){ //層數
			for(int j=1; j<=i-1; j++){ //空白
				System.out.print(" ");
			}
			
			int time = n-2*(i-1);
			for(int j=0; j<time; j++){
				System.out.print("8");
			}
			System.out.print("\n");
		}
	}
}
