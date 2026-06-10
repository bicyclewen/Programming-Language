import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String line;
		double old = Double.parseDouble(br.readLine());
		double max = old;
		while((line=br.readLine())!=null){
			if(line.isEmpty()){
				break;
			}
			double challenger = Double.parseDouble(line);
			double king = Math.max(max, challenger);
			max = king;
		}
		if(max%1==0){ //整數
			System.out.printf("%.0f", max); 
		}else{
			System.out.print(max);
		}
	}
}
