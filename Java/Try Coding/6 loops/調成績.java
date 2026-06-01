import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String line;
		double total=0, count=0;
		
		while((line=br.readLine())!=null){
			if(line.isEmpty()){
				break;
			}
			try{
				double grade = Double.parseDouble(line);
				if(grade<0 || grade>100){
					System.out.println("Invalid value");
					return;
				}
				grade = Math.sqrt(grade)*10;
				total += grade;
				count++;
			}catch(NumberFormatException e){
				System.out.println("Invalid value");
				return;
			}
		}
		if(count>0){
			System.out.printf("%.0f", total/count);
		}
	}
}
