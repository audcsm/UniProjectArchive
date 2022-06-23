import java.util.Arrays;

// Master thread for Loose Coupling model
public class LCMaster {
	
	int threadCount;

	public LCMaster(int x, int[][] firstMatrix, int[][] secondMatrix, int[][] resultMatrix) {
		
		threadCount = x * x;
		int[][] LCResult = new int[x][x];
		int[] hArray = new int[x];
		int[] vArray = new int[x];
		
		// Start up the jobs and threads
		LCJob[] jobs = new LCJob[threadCount];
		LCWorker[] workers = new LCWorker[threadCount];
		
		// Counter to iterate through threads
		int count = 0;
		// Build both arrays at different speeds so as to properly conduct matrix multiplication
		for (int i = 0; i < x; i++) {
			for (int j = 0; j < x; j++) {
				for (int l = 0; l < x; l++) {
					hArray[l] = firstMatrix[i][l];
					vArray[l] = secondMatrix[l][j];
				}
				
				// Initiate each job with its own set of info
				jobs[count] = new LCJob(count, hArray, vArray, resultMatrix);
				// System.out.println("LC job created. Arrays: " + Arrays.toString(hArray) + " and " + Arrays.toString(vArray));
				count++;
			}
		}
		
		// Initiate threads with job data
		for (int i = 0; i < threadCount; i++) {
			workers[i] = new LCWorker(jobs[i]);
			workers[i].start();
		}
		
		// Counter to iterate through jobs
		count = 0;
		// Iterate through empty result matrix and verify results with gold standard
		for (int i = 0; i < x; i++) {
			for (int j = 0; j < x; j++) {
				LCResult[i][j] = jobs[count].getCell();
				// System.out.println(jobs[count].getCell());
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
				// System.out.println("LC " + workers[i].getName() + " is finished");
			}
		}
		
		// Print the verification of the model vs gold standard
		System.out.println("Loose Coupling model subtraction:");
		for (int i = 0; i < x; i++) {
			System.out.println(Arrays.toString(LCResult[i]));
		}
		System.out.println("Loose Coupling model finished.");
		System.out.println();
	}	
}
