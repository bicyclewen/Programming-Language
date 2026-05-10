import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int k = Integer.parseInt(br.readLine());
		double m=10000, rate=0.12/1, interest=0;
		if(k>5){k=5;}
		for(int i=1; i<=k; i++){
			interest = m*rate;
			m *= (1+rate);
		}
		System.out.printf("%.0f\n%.0f", interest, m);
	}
}
