import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String line = br.readLine();
		int m = Integer.parseInt(br.readLine());
		long x = Long.parseLong(line);
		int k = line.length();

		int lengthA = k-(m-1), lengthB = m-1;
		long cut = (long)Math.pow(10,lengthB);
		long partA = x/cut;
		long partB = x%cut;
		
		long revA=0;
		for(int i=1; i<=lengthA; i++){
			revA = revA*10 + partA%10;
			partA /= 10;
		}
		long revB=0;
		for(int i=1; i<=lengthB; i++){
			revB = revB*10 + partB%10;
			partB /= 10;
		}
		
		if(lengthB==0){
			System.out.printf("%0"+lengthA+"d", revA);
		}else{
			System.out.printf("%0"+lengthA+"d%d", revA, revB);
		}
	}
}
