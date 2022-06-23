import java.util.Arrays;

// Symmetric worker thread
public class SymWorker extends Thread {
	
	// Create instance of job when initialised
	SymJob activeJob;
	
	public SymWorker(SymJob job) {
		this.activeJob = job;
	}
	
	// On start, execute and set job to finished
	public void start() {
		if (!activeJob.finished) {
			activeJob.finished = true;
			// System.out.println("Job finished.");
		}
	}
}
