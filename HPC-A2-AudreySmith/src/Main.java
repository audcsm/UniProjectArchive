import java.util.Arrays;
import java.util.Random;

public class Main {
	public static void main(String[] args) {
		Random rand = new Random();
		// Change the value of x to influence the size of the gold standard matrices
		int x = 1000;
		
		int[][] firstMatrix = new int[x][x];
		int[][] secondMatrix = new int[x][x];
		int[][] resultMatrix = new int[x][x];
		
		// Random gen first matrix using nested for loops.
		// The loops move across columns and rows, respectively.
		for (int i = 0; i < x; i++) {
			for (int j = 0; j < x; j++) {
				firstMatrix[i][j] = rand.nextInt(10);
			}
		}
		
		// Random gen second matrix using nested for loops.
		// The loops move across columns and rows, respectively.
		for (int i = 0; i < x; i++) {
			for (int j = 0; j < x; j++) {
				secondMatrix[i][j] = rand.nextInt(10);
			}
		}
		
		/* 
		 * Multiply first and second matrices together and apply to third, resulting matrix.
		 * i and j loop through the empty third matrix, x is used for matrix multiplication equation.
		 */
		for (int i = 0; i < x; i++) {
			for (int j = 0; j < x; j++) {
				resultMatrix[i][j] = 0;
				for (int k = 0; k < x; k++) {
					resultMatrix[i][j] += firstMatrix[i][k] * secondMatrix[k][j];
				}
			}
		}
		
		/* 
		 * Prints matrices in horizontal format on a single line.
		 * Alternatively, replace with commented out code to print in visually accurate format.
		 */
		System.out.println("First random gen matrix:");
		// System.out.println(Arrays.deepToString(firstMatrix)); 
		for (int i = 0; i < firstMatrix.length; i++) {
			System.out.println(Arrays.toString(firstMatrix[i]));
		}
		System.out.println("Second random gen matrix:");
		// System.out.println(Arrays.deepToString(secondMatrix)); 
		for (int i = 0; i < secondMatrix.length; i++) {
			System.out.println(Arrays.toString(secondMatrix[i]));
		} 
		System.out.println("Multiplication result matrix:");
		// System.out.println(Arrays.deepToString(resultMatrix)); 
		for (int i = 0; i < resultMatrix.length; i++) {
			System.out.println(Arrays.toString(resultMatrix[i]));
		} 
		
		// MSMaster msmaster = new MSMaster(x, firstMatrix, secondMatrix, resultMatrix);
		LCMaster lcmaster = new LCMaster(x, firstMatrix, secondMatrix, resultMatrix);
		// SymMaster symmaster = new SymMaster(x, firstMatrix, secondMatrix, resultMatrix);
	}
}
