import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int floor = Integer.parseInt(br.readLine())-1;
		int x = Integer.parseInt(br.readLine());
		int y = Integer.parseInt(br.readLine());
		
		int timeA = 23*floor;
		int timeB = x + 15*floor;
		int timeC = x + y + 7*floor;
		
		int[] time = {timeA,timeB,timeC};
		char[] name = {'A','B','C'};
		
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2 - i; j++) {
                if (time[j] > time[j+1]) {
                    int temp = time[j];
                    time[j] = time[j + 1];
                    time[j+1] = temp;
					
					char tempp = name[j];
					name[j] = name[j+1];
					name[j+1] = tempp;
                }
            }
        }
		System.out.print(""+name[0]+name[1]+name[2]);
		
	}
}
