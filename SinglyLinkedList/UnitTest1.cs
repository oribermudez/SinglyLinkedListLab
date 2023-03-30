namespace SinglyLinkedList
{
    public class Tests
    {
        private LinkedList sll;
        [SetUp]
        public void Setup()
        {
            sll = new LinkedList();
        }

        [Test]
        public void TestPrepending()
        {
            string name = "Joe Blow";

            sll.AddFirst(name);

            // Assert that it was added or the SLL is bigger
            Assert.IsNotNull(sll.Head);
            Assert.AreEqual(1, sll.Count);

            // Assert that the first node value is "Joe Blow"
            Node first = sll.Head;
            string value = first.Value;
            Assert.AreEqual(name, value);

            // Assert there is no next of first node
            Assert.IsNull(first.Next);

            string secondName = "Joe Schmoe";
            sll.AddFirst(secondName);

            // Assert SLL is bigger
            Assert.AreEqual(2, sll.Count);

            // Assert that the first node value is "Joe Schmoe"
            Node newFirst = sll.Head;
            string secondValue = newFirst.Value;
            Assert.AreEqual(secondName, secondValue);

            Assert.Pass();
        }

        [Test]
        public void TestAppending()
        {
            string firstName = "Joe Blow";

            sll.AddLast(firstName);

            // Assert that it was added or the SLL is bigger
            Assert.IsNotNull(sll.Head);
            Assert.AreEqual(1, sll.Count);

            // Assert that the first node value is "Joe Blow"
            Node first = sll.Head;
            string firstValue = first.Value;
            Assert.AreEqual(firstName, firstValue);

            // Assert there is no next of first node
            Assert.IsNull(first.Next);

            string secondName = "Joe Schmoe";
            sll.AddLast(secondName);

            // Assert SLL is bigger
            Assert.AreEqual(2, sll.Count);

            // Assert that the second node value is "Joe Schmoe"
            Node second = sll.Head.Next;
            string secondValue = second.Value;
            Assert.AreEqual(secondName, secondValue);

            Assert.Pass();
        }

        [Test]
        public void TestRemoveFirst()
        {
            string firstName = "Joe Blow";
            string secondName = "Joe Schmoe";
            
            // Attempt to remove node in empty SLL
            bool result = sll.RemoveFirst();

            // Assert the method returns false if SLL is empty
            Assert.IsFalse(result);

            // Add one node and remove it
            sll.AddLast(firstName);
            sll.RemoveFirst();

            // Assert the SLL is empty after deleting the only node it contained
            Assert.IsNull(sll.Head);

            // Add two nodes and remove the first
            sll.AddLast(firstName);
            sll.AddLast(secondName);
            sll.RemoveFirst();

            // Assert the SLL is not empty
            Assert.IsNotNull(sll.Head);

            // Assert the SLL is smaller
            Assert.AreEqual(1, sll.Count);

            // Assert that the first node value is "Joe Schmoe"
            Node first = sll.Head;
            string firstValue = first.Value;
            Assert.AreEqual(secondName, firstValue);

            Assert.Pass();
        }

        [Test]
        public void TestRemoveLast()
        {
            string firstName = "Joe Blow";
            string secondName = "Joe Schmoe";

            // Attempt to remove node in empty SLL
            bool result = sll.RemoveFirst();

            // Assert the method returns false if SLL is empty
            Assert.IsFalse(result);

            // Add one node and remove it
            sll.AddLast(firstName);
            sll.RemoveLast();

            // Assert the SLL is empty after deleting the only node it contained
            Assert.IsNull(sll.Head);

            // Add two nodes and remove the last
            sll.AddLast(firstName);
            sll.AddLast(secondName);
            sll.RemoveLast();

            // Assert the SLL is not empty
            Assert.IsNotNull(sll.Head);

            // Assert the SLL is smaller
            Assert.AreEqual(1, sll.Count);

            // Assert that the first node value is "Joe Blow"
            Node first = sll.Head;
            string firstValue = first.Value;
            Assert.AreEqual(firstName, firstValue);

            Assert.Pass();
        }

        [Test]
        public void TestGetValue()
        {
            // Attempt to remove node in empty SLL
            string result = sll.GetValue(1);

            // Assert the method returns false if SLL is empty
            Assert.AreEqual(result, "-1");

            // Add two nodes and remove the last
            string firstName = "Joe Blow";
            string secondName = "Joe Schmoe";
            string thirdName = "Joe Smith";
            string fourthName = "Jane Doe";
            string fifthName = "Bob Bobberson";
            string sixthName = "Sam Sammerson";
            string seventhName = "Dave Daverson";

            sll.AddLast(firstName);
            sll.AddLast(secondName);
            sll.AddLast(thirdName);
            sll.AddLast(fourthName);
            sll.AddLast(fifthName);
            sll.AddLast(sixthName);
            sll.AddLast(seventhName);

            // Attempt to get the value of index 3
            string value = sll.GetValue(5);

            // Assert the mothod returns the right value
            Assert.AreEqual(value, fifthName);

            Assert.Pass();
        }
    }
}