# Recursion in DSA 🔁  

This folder contains programs, examples, and exercises related to **Recursion** – one of the most important problem-solving techniques in Data Structures and Algorithms.  

---

## 📖 What is Recursion?  
Recursion is a programming technique where a function **calls itself** to solve smaller sub-problems of the original problem.  
It is widely used in algorithms that can be broken down into repetitive sub-tasks.  

---

## 🧠 Key Concepts  

### 1. Base Case  
- Every recursive function must have a **base case** that stops further recursive calls.  
- Without a base case, recursion will go into an infinite loop.  

Example (Factorial Base Case):  
```csharp
if (n == 0 || n == 1)
    return 1;
```

### 2. Recursive Case
- Defines how the problem is broken into smaller sub-problems.
- The function keeps calling itself until it reaches the base case.

Example (Factorial Recursive Case):
```csharp
return n * Factorial(n - 1);
```

### 3. Stack Memory & Call Stack
- Each recursive call is stored on the function call stack in memory.
- When the base case is reached, the calls are resolved in reverse order (LIFO – Last In, First Out).

### 4. Types of Recursion
- Direct Recursion → A function calls itself directly.
- Indirect Recursion → Function A calls Function B, which then calls Function A.
- Tail Recursion → The recursive call is the last operation in the function.
- Non-Tail Recursion → The recursive call is followed by other operations.

### 5. Common Examples of Recursion
- Factorial of a number
- Fibonacci series
- Sum of array elements
- Printing numbers in forward/reverse order
- Tower of Hanoi
- Binary Search
- Tree Traversals (Inorder, Preorder, Postorder)

---

## 🛠 Examples Included in This Folder
- Odd/Even series using recursion

---

## 📑 Additional Resources in This Folder
Along with the source code files, this folder also contains:
- PDF File → Contains all the task problems with detailed statements.
- Source Code with Screenshots → Each problem has its source code along with output screenshots for better understanding.

---

## 💡 Why Recursion is Important
- Simplifies complex problems by breaking them into smaller sub-problems.
- Forms the basis of many algorithms such as:
- - Divide and Conquer (Merge Sort, Quick Sort)
- - Dynamic Programming (Recursive relations + Memoization)
- - Graph and Tree traversals
- - Essential for understanding time complexity trade-offs and stack memory usage.

---

## 📂 Structure of This Folder
```Recursion-DSA/
├── README.md
├── Problems.pdf              
├── Factorial/
│   └── Program.cs
└── OddEvenSeries.cs
    └── Program.cs
```
---

## 🚀 How to Run
1. Clone the repository:
   git clone [https://github.com/Urooba-Batool/DSA.git](https://github.com/Urooba-Batool/Data-Structures-and-Algorithms)

2. Open the `Recursion` folder in your IDE (Visual Studio or VS Code).

3. Compile and run the desired program:
   dotnet run

---

## ✅ Learning Goals
By going through this folder, you will learn:
- How recursion works with base and recursive cases.
- How the call stack manages recursive calls.
- How to solve classical recursion problems.
- How recursion is applied in searching, sorting, and tree/graph problems.

---

## 📌 Next Step
Once you are comfortable with recursion, move to **Linked Lists** to understand dynamic memory allocation and flexible data storage.  
Linked Lists are the foundation for implementing more advanced data structures such as stacks, queues, graphs, and hash tables.  

--- 

✍ Author: *Urooba Batool*  
📅 Topic: Recursion (DSA)  
🎯 Goal: To master recursion and prepare for solving advanced problems using Divide & Conquer and Dynamic Programming.
