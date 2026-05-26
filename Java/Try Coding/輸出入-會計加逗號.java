import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		long k = Long.parseLong(br.readLine());
		if(k==0){
			System.out.print(0);
			return;
		}
		String result="";
		while(k>0){
			if(k>=1000){
				long re = k%1000;
				result = "," + String.format("%03d",re) + result;
				k /= 1000;
			}else{
				result = k + result;
				k=0;
			}
		}
		System.out.print(result);
	}
}
