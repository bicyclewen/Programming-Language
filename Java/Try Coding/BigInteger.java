/*宣告適當型別的變數data，設定其內容為 123456789098765432101234567890
輸出範例:
123456789098765432101234567890 */

import java.math.BigInteger; //先匯入工具
public class Main {
	public static void main(String[] args) {
		BigInteger data = new BigInteger("123456789098765432101234567890");
		System.out.print(data);
	}

}
