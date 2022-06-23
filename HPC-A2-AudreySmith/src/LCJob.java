import java.util.Arrays;

public class LCJob {
	
	int result;
	int goldStandardComparison;
	public boolean finished;
	
	// Given harray, varray, i from master
	public LCJob(int count, int[] hArray, int[] vArray, int[][] resultMatrix) {
		
		int i = count;
		
		finished = false;
		
		// Interim result holds ending value before subtraction occurs
		int interimResult = 0;
		
		// Do the mult/add process
		for (int j = 0; j < hArray.length; j++) {
			interimResult += hArray[j] * vArray[j];
		} 
		
		// Print result value
		// System.out.println("Result: " + interimResult);
		
		// Find job's matching cell in resultMatrix using counter
		int count1 = 0;
		// Iterate through resultMatrix 
		for (int j = 0; j < resultMatrix.length; j++) {
			for (int k = 0; k < resultMatrix.length; k++) {
				if (count1 == i) {
					goldStandardComparison = resultMatrix[j][k];
					// System.out.println(goldStandardComparison);
				}
				count1++;
			}
		}
		
		// Subtract gold standard from result to verify accuracy
		result = interimResult - goldStandardComparison;
	}
	
	// Return the resulting value to the Master thread
	public int getCell() {
		return result;
	}
}
