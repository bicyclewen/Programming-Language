import java.io.*;
import java.time.LocalDate;
import java.time.DayOfWeek;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int y = Integer.parseInt(br.readLine());
		double p = Double.parseDouble(br.readLine());
		int d = Integer.parseInt(br.readLine());
		
		LocalDate start = LocalDate.of(y,2,1);
		LocalDate end = start.plusDays(d);
		LocalDate remove = LocalDate.of(y+1,1,1);
		if(!end.isBefore(remove)){
			System.out.print("Removed");
			return;
		}
		
		double price = p-3*d;
		if(end.getDayOfMonth()==15){ //十五號
			price *= 0.9;
		}
		if(end.getDayOfMonth()==end.lengthOfMonth()){ //月底(即明天是一號)
			price *= 0.8;
		}
		if(end.getDayOfMonth()==13 && end.getDayOfWeek()==DayOfWeek.FRIDAY){
			price *= 0.5;
		}
		int p1 = (int)Math.floor(price);
		int p2 = (int)Math.floor(p*0.1);
		if(p1<p2){
			p1=p2;
		}
		System.out.print(p1);
	}
}
