import java.io.*;
import java.time.LocalDate;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int y = Integer.parseInt(br.readLine());
		double price = Double.parseDouble(br.readLine());
		int d = Integer.parseInt(br.readLine());
		
		LocalDate start = LocalDate.of(y,1,1);
		LocalDate end = start.plusDays(d);
		
		if(end.getYear()>y){
			System.out.print("Removed");
			return;
		}
		
		price -= 3*d;
		if(end.getDayOfMonth()==15){ //十五號
			price *= 0.9;
		}
		if(end.plusDays(1).getDayOfMonth()==1){ //月底(即明天是一號)
			price *= 0.8;
		}
		if(price<=0){
			price = 0;
		}
		int p =(int)price;
		System.out.print(p);
	}
}
