public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
        // Enqueue items with different priorities
        priorityQueue.Enqueue("Apple", 2);
        priorityQueue.Enqueue("Banana", 1);
        priorityQueue.Enqueue("Orange", 3);

        // Dequeue and check if items are returned in expected order
        Console.WriteLine("Priority Queue before Dequeue: " + priorityQueue);
        Console.WriteLine("Dequeue result: " + priorityQueue.Dequeue()); // Expected output: "Orange"
        Console.WriteLine("Priority Queue after Dequeue: " + priorityQueue); // Expected output: [Apple (Pri:2), Banana (Pri:1)]


        // Defect(s) Found: The for loop is only searching to the second to last item in the queue, I removed the -1.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        var priorityQueue2 = new PriorityQueue();

        // Enqueue items with different priorities
        priorityQueue2.Enqueue("Grapes", 3);
        priorityQueue2.Enqueue("Mango", 2);
        priorityQueue2.Enqueue("Peach", 1);

        // Dequeue and check if item with highest priority is removed
        Console.WriteLine("Priority Queue before Dequeue: " + priorityQueue2);
        Console.WriteLine("Dequeue result: " + priorityQueue2.Dequeue()); // Expected output: "Grapes"
        Console.WriteLine("Priority Queue after Dequeue: " + priorityQueue2); // Expected output: [Mango (Pri:2), Peach (Pri:1)]


        // Defect(s) Found: I found that the item with the highest priority was never removed from the queue. 

        Console.WriteLine("---------");
        Console.WriteLine("Test 3");



        // Enqueue items with different priorities
        priorityQueue.Enqueue("Apple", 2);
        priorityQueue.Enqueue("Banana", 1);
        priorityQueue.Enqueue("Orange", 3);
        priorityQueue.Enqueue("Watermelon", 0); // Add an item with priority 0
        priorityQueue.Enqueue("Grapes", -1); // Add an item with negative priority

        // Dequeue and check if item with highest priority is removed
        Console.WriteLine("Priority Queue before Dequeue: " + priorityQueue);
        Console.WriteLine("Dequeue result: " + priorityQueue.Dequeue()); // Expected output: "Orange"
        Console.WriteLine("Priority Queue after Dequeue: " + priorityQueue); // Expected output: [Apple (Pri:2), Banana (Pri:1), Watermelon (Pri:0), Grapes (Pri:-1)]

        Console.WriteLine("---------");

    }
}