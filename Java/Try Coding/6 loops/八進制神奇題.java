import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String line;
		int N = Integer.parseInt(br.readLine()); //加上的值
		while((line=br.readLine())!=null){
			if(line.isEmpty()){
				break;
			}
			int m = Integer.parseInt(line);
			int n=N; //確保"加上的值"不被洗掉
			
			int time=0, i=0;
			while(n>0 || m>0 || i>0){
				int tempN = n%8;
				int tempM = m%8;
				int sum = tempN+tempM+i;
				
				if(sum>=8){
					time++; //進位次數
					i=1;
				}else{
					i=0; //不能再進位了
				}
				m /= 8;
				n /= 8;
			}
			System.out.println(time);
		}
	}
}
