import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String line = br.readLine();
		int target=6000, run=700, rope=115;
		boolean reachTarget = false;
		
		double c = Double.parseDouble(line);
		int circle = (int)Math.floor(c);
		target -= circle*run;
		if(target<=0){
			target=0;
			reachTarget=true;
		}
		System.out.println(target);
		
		while((line=br.readLine())!=null){
			if(line.isEmpty()){
				break;
			}
			double t = Double.parseDouble(line);
			int time = (int)Math.floor(t/10.0); //十次才算數
			
			target -= rope*time;
			if(reachTarget==false){
				if(target<=0){
					target=0;	
					reachTarget=true;
				}
				System.out.println(target);
			}else{
				target=0;
				continue;
			}
		}
		
		if(target==0){
			System.out.print("Yes");
		}else{
			System.out.print("No");
		}
	}
}
