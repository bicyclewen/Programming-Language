import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String line;
		int minus=50, day=20, target=54000;
		while((line=br.readLine())!=null){
			int temp = Integer.parseInt(line);
			int total=0;
			for(int i=1; i<=day; i++){
				total += temp;
				temp -= minus;
			}
			
			if(total<target){
				System.out.printf("%d: Yes\n", total);
			}else{
				System.out.printf("%d: No\n", total);
			}
		}
	}
}
