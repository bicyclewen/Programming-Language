import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int bl = Integer.parseInt(br.readLine());
		int gr = Integer.parseInt(br.readLine());
		int bubl = Integer.parseInt(br.readLine());
		int bugr = Integer.parseInt(br.readLine());
		double bl$=20, gr$=25, bubl$=25, bugr$=30;
		
		int plan1 = (int)Math.floor((bl*bl$+gr*gr$+bubl*bubl$+bugr*bugr$)*0.7);
		
		double bl$$ = (bl/3*2 + bl%3)*bl$;
		double gr$$ = (gr/3*2 + gr%3)*gr$;
		double bubl$$ = (bubl/3*2 + bubl%3)*bubl$;
		double bugr$$ = (bugr/3*2 + bugr%3)*bugr$;
		int plan2 = (int)Math.floor(bl$$+gr$$+bubl$$+bugr$$);
		
		boolean result = (plan1<plan2);
		if(result){
			System.out.printf("%b\n%d", result, plan1);
		}else{
			System.out.printf("%b\n%d", result, plan2);
		}
		
	}
}
