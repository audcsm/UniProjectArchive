import java.util.Arrays;

public class SymJob {
	
	int result;
	public boolean finished;

	public SymJob(int i, int[][] firstMatrix, int[][] secondMatrix, int[][] resultMatrix) {
		
		finished = false;
		
		// Grab the section that matches the value of i
		int[] hArray = new int[firstMatrix.length];
		int[] vArray = new int[firstMatrix.length];
		
		// Using a counter to parse until the thread number matches the set of data it needs
		int count = 0;
		
		// Iterate through sets of data
		for (int j = 0; j < firstMatrix.length; j++) {
			for (int k = 0; k < firstMatrix.length; k++) {
				if (count == i) {
					for (int l = 0; l < firstMatrix.length; l++) {
							// Take a row from firstMatrix and a column from secondMatrix
							hArray[l] = firstMatrix[j][l];
							vArray[l] = secondMatrix[l][k];
					}
				}
				count++;
			}
		}
		// System.out.println(Arrays.toString(hArray));
		// System.out.println(Arrays.toString(vArray));
		
		// Do the mult/add process
		for (int j = 0; j < firstMatrix.length; j++) {
			result += hArray[j] * vArray[j];
		} 
		// System.out.println("Result: " + result);
	}
	// Return the resulting value to the Master thread
	public int getCell() {
		return result;
	}
}
