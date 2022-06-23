import java.util.Arrays;

// Master-Slave master thread
public class MSMaster {
	
	int threadCount;
	
	// Constructor pulls variable x from Main
	public MSMaster(int x, int[][] firstMatrix, int[][] secondMatrix, int[][] resultMatrix) {
		
		// Create one thread for each cell in the result matrix
		this.threadCount = x * x;
		int[][] MSResult = new int[x][x];
		
		// Initialise the workers
		MSWorker[] workers = new MSWorker[threadCount];
		for (int i = 0; i < threadCount; i++) {
			workers[i] = new MSWorker();
		}
		
		// Initialise two interim arrays to help pass info to worker threads (horizontal, vertical)
		int[] hArray = new int[x];
		int[] vArray = new int[x];
		
		// Counter to iterate through threads
		int count = 0;
		// Build both arrays at different speeds so as to properly conduct matrix multiplication
		for (int i = 0; i < x; i++) {
			for (int j = 0; j < x; j++) {
				for (int l = 0; l < x; l++) {
					hArray[l] = firstMatrix[i][l];
					vArray[l] = secondMatrix[l][j];
				}
				
				// Start each worker with its own set of info
				workers[count].start(hArray, vArray, x);
				// System.out.println("MS " + workers[count].getName() + " has started. My hArray is " + Arrays.toString(hArray) + " and my vArray is " + Arrays.toString(vArray));
				count++;
			}
		}
		
		// Reset the counter for pulling data from the threads
		count = 0;
		for (int j = 0; j < x; j++) {
			for (int k = 0; k < x; k++) {
				// getCell() is a method that returns the result of the math conducted
				// Get difference from result and resultMatrix and store
				MSResult[j][k] = (workers[count].getCell() - resultMatrix[j][k]);
				// System.out.println(workers[count].getCell());
				count++;
			}
		}
		
		// Record when each worker dies
		for (int i = 0; i < threadCount; i++) {
			try {
				// Waiting state until the thread terminates
				workers[i].join();
			}
			catch(InterruptedException ie) {
				System.err.println(ie.getMessage());
			}
			finally {
				// MSWorker x is finished
				// System.out.println("MS " + workers[i].getName() + " is finished");
			}
		}
		
		// Print result
		// System.out.println("Master-Slave result:");
		// for (int i = 0; i < MSResult.length; i++) {
		// 	 System.out.println(Arrays.toString(MSResult[i]));
		// }
		
		// Print result of subtraction
		System.out.println("Master-Slave model subtraction:");
		for (int i = 0; i < x; i++) {
			System.out.println(Arrays.toString(MSResult[i]));
		}
		System.out.println("Master-Slave model finished.");
		System.out.println();
	}
}
