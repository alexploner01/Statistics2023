# Cheat Sheet

## JS

### Arrays

**Declaration**
```js
const numbers = [10, 20, 30];
const array = Array(5);
```

**Add element**
```js
numbers.push(40);
```

**Remove element**
```js
const indexToRemove = 1;
numbers.splice(indexToRemove, 1);
```

**Get element**
```js
numbers[i]
```

**iterate throught element**
```js
for (const number of numbers) {
  console.log(number);
}
```

**Sorting**
```js
const months = ['March', 'Jan', 'Feb', 'Dec'];
months.sort();
```


### Dictionary

**Declaration**
```js
const dictionary = {
  "apple": 10,
  "banana": 20,
  "cherry": 30
};
```
**Add element**
```js
dictionary["date"] = 40;
```
**Remove element**
```js
delete dictionary["banana"];
```
**Get element**
```js
dictionary["date"]
```
**iterate throught element**
```js
for (const key in dictionary) {
  if (dictionary.hasOwnProperty(key)) {
    console.log(`${key}: ${dictionary[key]}`);
  }
}
```

### Set

**Declaration**
```js
const set = new Set();
```
**Add element**
```js
set.add("apple");
set.add("banana");
set.add("cherry");

```
**Remove element**
```js
set.delete("banana");
```
**Check if element present**
```js
set.has("apple")
```
**iterate throught element**
```js
for (const item of set) {
  console.log(item);
}
```
**sort**
```js
const newSet = new Set([...myset].sort());
```

### Stack

**Declaration**
```js
var stack = [];
```
**Add element**
```js
stack.push(2);
```
**Remove element**
```js
var i = stack.pop();
```
**Get element**
```js
var i = stack.pop();
```
**iterate throught element**
```js
for (const number of stack) {
  console.log(number);
}
```

### Queue

**Declaration**
```js
var queue = [];
```
**Add element**
```js
queue.push(2);
```
**Remove element**
```js
var i = queue.shift();
```
**Get element**
```js
var i = queue.shift();
```
**iterate throught element**
```js
for (const number of queue) {
  console.log(number);
}
```


## C#

### Arrays

**Declaration**
```c#
int[] numbers = { 10, 20, 30 };
int[] array = new int[5];
```
**Add element**
```c#
numbers[-1] = 40;
```
**Remove element**
```c#
int indexToRemove = 1;
int[] newArray = new int[numbers.Length - 1];
Array.Copy(numbers, 0, newArray, 0, indexToRemove);
Array.Copy(numbers, indexToRemove + 1, newArray, indexToRemove, numbers.Length - indexToRemove - 1);
numbers = newArray;
```
**Get element**
```c#
int element = numbers[i];
```
**iterate throught element**
```c#
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```
**Sorting**
```c#
string[] months = { "March", "Jan", "Feb", "Dec" };
Array.Sort(months);
```


### List

**Declaration**
```c#
List<int> list = new List<int>();
```
**Add element**
```c#
numbers.Add(40);
```
**Remove element**
```c#
numbers.RemoveAt(indexToRemove);
```
**Get element**
```c#
int element = numbers[i];
```
**iterate throught element**
```c#
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

### SortedList

**Declaration**
```c#
SortedList<int, int> sortedList = new SortedList<int, int>();
```
**Add element**
```c#
numbers.Add(4, 40);
```
**Remove element**
```c#
numbers.Remove(2);
```
**Get element**
```c#
int value = numbers[key];
```
**iterate throught element**
```c#
foreach (var pair in numbers)
{
    int key = pair.Key;
    int value = pair.Value;
    Console.WriteLine($"{key}: {value}");
}
```

### Dictionary

**Declaration**
```c#
Dictionary<int, int> dictionary = new Dictionary<int, int>();
```
**Add element**
```c#
numbers.Add(4, 40);
```
**Remove element**
```c#
numbers.Remove(2);
```
**Get element**
```c#
if (numbers.TryGetValue(key, out value))
{
    Console.WriteLine($"{key}: {value}");
}
```
**iterate throught element**
```c#
foreach (var pair in numbers)
{
    int key = pair.Key;
    int value = pair.Value;
    Console.WriteLine($"{key}: {value}");
}
```

### Sorted Set

**Declaration**
```c#
SortedSet<int> sortedSet = new SortedSet<int>();
```
**Add element**
```c#
numbers.Add(40);
```
**Remove element**
```c#
numbers.Remove(20);
```
**Get element**
```c#
bool exists = numbers.Contains(10); // Check if an element exists
int firstElement = numbers.Min;   // Get the minimum element
int lastElement = numbers.Max;    // Get the maximum element
```
**iterate throught element**
```c#
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

```

### Queue

**Declaration**
```c#
Queue<int> numbers = new Queue<int>();
```
**Add element**
```c#
numbers.Enqueue(40);
```
**Remove element**
```c#
int removedElement = numbers.Dequeue();
```
**Get element**
```c#
int frontElement = numbers.Peek();
```
**iterate throught element**
```c#
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

### Stack

**Declaration**
```c#
Stack<int> numbers = new Stack<int>();
```
**Add element**
```c#
numbers.Push(40);
```
**Remove element**
```c#
int removedElement = numbers.Pop();
```
**Get element**
```c#
int topElement = numbers.Peek();
```
**iterate throught element**
```c#
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

### LinkedList

**Declaration**
```c#
LinkedList<int> numbers = new LinkedList<int>();
```
**Add element**
```c#
numbers.AddLast(40);
```
**Remove element**
```c#
LinkedListNode<int> nodeToRemove = numbers.Find(20); // Find the node to remove
numbers.Remove(nodeToRemove);
```
**Get element**
```c#
LinkedListNode<int> node = numbers.First; // Access the first node
int element = node.Value;
```
**iterate throught element**
```c#
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```