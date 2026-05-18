import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		String G = br.readLine();
		double height = Double.parseDouble(br.readLine());
		double weight;
		if(height<0){
			System.out.print("Invalid value");
			return;
		}else if("M".equals(G)||"m".equals(G)){
			weight=(height-80)*0.7;
		}else if("F".equals(G)||"f".equals(G)){
			weight=(height-70)*0.6;
		}else{
			System.out.print("Invalid value");
			return;
		}
		System.out.printf("%.1f", weight);
	}
}
