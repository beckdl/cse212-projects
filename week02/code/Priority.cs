/* 
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Sam", 5);
        priorityQueue.Enqueue("Tom", 3);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 

        Console.WriteLine("Priority is not having an effect on the Dequeue process.");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Sam", 5);
        priorityQueue.Enqueue("Tom", 3);
        priorityQueue.Enqueue("Phil", 5);
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("Enqueue Is not correctly adding people with priorities to the queue.");

        // Add more Test Cases As Needed Below
        for(int i = 1; i < 5; i++){
            priorityQueue.Dequeue();
        }
        // Test 3
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Sam", 5);
        priorityQueue.Enqueue("Tom", 3);
        priorityQueue.Enqueue("Phil", 5);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue(); 
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("Error message is not correctly showing up.");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Sam", 5);
        priorityQueue.Enqueue("Tom", 3);
        priorityQueue.Enqueue("Phil", 5);
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("Multiple of same high priority is not affecting the flow for dequeuing.");
    }
}