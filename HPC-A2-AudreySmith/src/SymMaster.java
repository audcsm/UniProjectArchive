import java.util.Arrays;

// Symmetric master class
public class SymMaster {
	
	int threadCount;
	
	public SymMaster(int x, int[][] firstMatrix, int[][] secondMatrix, int[][] resultMatrix) {
		
		threadCount = x * x;
		int[][] SymResult = new int[x][x];
		
		// Start up the jobs and threads
		SymJob[] jobs = new SymJob[threadCount];
		SymWorker[] workers = new SymWorker[threadCount];
		
		// Initiate jobs with information needed to conduct
		for (int i = 0; i < threadCount; i++) {
			// System.out.println("Creating job " + i);
			jobs[i] = new SymJob(i, firstMatrix, secondMatrix, resultMatrix);
		}
		
		// Initiate threads with job data
		for (int i = 0; i < threadCount; i++) {
			workers[i] = new SymWorker(jobs[i]);
			workers[i].start();
		}
		
		// Counter to iterate through jobs
		int count = 0;
		// Iterate through empty result matrix and verify results with gold standard
		for (int i = 0; i < x; i++) {
			for (int j = 0; j < x; j++) {
				SymResult[i][j] = jobs[count].getCell() - resultMatrix[i][j];
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
				// SymWorker x is finished
				// System.out.println("Sym " + workers[i].getName() + " is finished");
			}
		}
		
		// Print the verification of the model vs gold standard
		System.out.println("Symmetric model subtraction:");
		for (int i = 0; i < x; i++) {
			System.out.println(Arrays.toString(SymResult[i]));
		}
		System.out.println("Symmetric model finished.");
		System.out.println();
	}
}
