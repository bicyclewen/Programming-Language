import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int pre = Integer.parseInt(br.readLine());
		int lat = Integer.parseInt(br.readLine());
		int next = (lat-pre+100)%100;
		System.out.print(next);
	}
}
