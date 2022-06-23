// Master-Slave worker thread
public class MSWorker extends Thread {
	// Worker thread receives instructions from the master
	int result = 0;
	
	// start() carries hArray, vArray, and x from master
	public void start(int[] hArray, int[] vArray, int x) {
		boolean finished = false;
		// call run()
		run(finished, hArray, vArray, x);
	}
	
	// run() carries the same variables plus finished
	public void run(boolean finished, int[] hArray, int[] vArray, int x) {
		// While unfinished...
		while (!finished) {
			// ...call multiply()
			try {
				finished = multiply(hArray, vArray, x);
			}
			catch(Exception e) {}
		}
	}
	
	// multiply() carries the same variables from master
	boolean multiply(int[] hArray, int[] vArray, int x) {
		// Grab arrays for multiplication and store locally
		int[] horizontal = new int[x];
		int[] vertical = new int[x];
		horizontal = hArray;
		vertical = vArray;
		// Variable result is the total sum of the multiplication of each set of values
		for (int i = 0; i < x; i++) {
			result += horizontal[i] * vertical[i];
		}
		return true;
	}
	
	// Return the resulting value to the Master thread
	public int getCell() {
		return result;
	}
}
