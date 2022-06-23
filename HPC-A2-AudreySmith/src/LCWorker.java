import java.util.Arrays;

// Primary class for the Loose Coupling method
public class LCWorker extends Thread {
	// Threads pull from job
	// Work independently
	// Very similar to SymWorker
	
	LCJob activeJob;
		
	// Create instance of job when initialised
	public LCWorker(LCJob job) {
		this.activeJob = job;
	}
	
	// On start, execute and set job to finished
	public void start() {
		if (!activeJob.finished) {
			activeJob.finished = true;
			System.out.println("Job finished.");
		}
	}
	
}
