import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		//紅茶、奶綠、珍珠紅、珍珠奶綠 //珍珠加五塊
    int bl = Integer.parseInt(br.readLine());
		int gr = Integer.parseInt(br.readLine());
		int bubl = Integer.parseInt(br.readLine());
		int bugr = Integer.parseInt(br.readLine());
		//價錢
    int m_bl=20, m_gr=25, m_bubl=m_bl+5, m_bugr=m_gr+5;
		
    System.out.print(m_bl*(bl-bl/3)+m_gr*(gr-gr/3)+m_bubl*(bubl-bubl/3)+m_bugr*(bugr-bugr/3));
	}
}
