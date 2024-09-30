using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Two items added to the list with the same priority 
    // Expected Result: the first item with the higher priority is remove from the queue
    // Defect(s) Found: 
    public void TestPriorityQueue_1_BothPriorities_WithSameValue()
    {   
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Homework", 5);
        priorityQueue.Enqueue("Project", 5);
        // priorityQueue.Enqueue("FinalExam", 7);
        Assert.AreEqual("Homework", priorityQueue.Dequeue());
}

    [TestMethod]
    // Scenario: two items added to the list with different priorities
    // Expected Result: The result I expected was the higher priority to been remove from the queue 
    // Defect(s) Found: I found the bug inside the for loop that was making the test fail. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Homework" , 2);
        priorityQueue.Enqueue("Finale Exam" , 6);
        Assert.AreEqual("Finale Exam", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}