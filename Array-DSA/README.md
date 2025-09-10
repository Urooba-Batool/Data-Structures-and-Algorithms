# Arrays in DSA 📚

This folder contains programs, examples, and exercises related to **Arrays** – one of the most fundamental data structures in Software Engineering.

---

## 📖 What is an Array?
An **array** is a collection of elements stored in **contiguous memory locations**.  
Each element can be accessed directly using an **index**, which makes arrays one of the fastest data structures for **random access**.

---

## 🧠 Key Concepts

### 1. Indexing
- Arrays use **zero-based indexing** in most programming languages.
- Example:  
  `arr[0]` → first element,  
  `arr[n-1]` → last element (if array has `n` elements)

### 2. Static Size
- The size of an array is usually **fixed** at the time of creation.
- Cannot grow or shrink dynamically.

### 3. Operations
Some of the most common operations on arrays:

| Operation   | Description                  | Time Complexity |
|------------|-----------------------------|----------------|
| Traversal  | Visit each element once      | O(n) |
| Access     | Get element at index i       | O(1) |
| Insertion  | Add element (shifting needed)| O(n) |
| Deletion   | Remove element (shifting)    | O(n) |
| Searching  | Find element value           | O(n) (Linear) / O(log n) (Binary on sorted array) |

### 4. Memory Layout
- All elements are stored **next to each other** in memory.
- This makes accessing elements by index extremely fast (direct address calculation).

### 5. Types of Arrays
- **1D Arrays** → Simple list of elements  
- **2D Arrays (Matrices)** → Grid-like structure, useful for matrix operations  
- **Multidimensional Arrays** → Arrays with more than 2 dimensions (used in advanced problems)

---

## 🛠 Examples Included in This Folder
- Basic Array Input & Output
- 2D Array Operations (Matrix Addition, Subtraction, Multiplication)
- Practice Problems 

---

## 📑 Additional Resources in This Folder  
Along with the source code files, this folder also contains:  
- **PDF File** → Contains all the task problems with detailed statements.  
- **Source Code with Screenshots** → Each problem has its source code along with output screenshots for better understanding.  

---

## 💡 Why Arrays Are Important
Arrays form the foundation of many advanced data structures such as:
- Strings
- Stacks & Queues
- Heaps
- Hash Tables

Understanding arrays is crucial before moving on to **Linked Lists**, **Trees**, and **Graphs**.

---

## 📂 Structure of This Folder
```Array-DSA/
├── README.md
├── 1D-Arrays-1/
│   └── Program.cs
├── 1D-Arrays-2/
│   └── Program.cs
└── 2D-Arrays-1/
    └── Program.cs
```
---

## 🚀 How to Run
1. Clone the repository:
   git clone [https://github.com/Urooba-Batool/DSA.git](https://github.com/Urooba-Batool/Data-Structures-and-Algorithms)

2. Open the `Arrays` folder in your IDE (Visual Studio or VS Code)

3. Compile and run the desired program:
   dotnet run

---

## ✅ Learning Goals
By going through this folder, you will learn:
- How to store and access data efficiently.
- How to perform common array operations.
- How to implement basic searching and sorting.
- How to work with 2D arrays for matrix operations.

---

## 📌 Next Step  
Once you are comfortable with arrays, move to **Recursion-DSA** to learn problem-solving using recursive techniques, which will help in understanding advanced concepts like divide and conquer, dynamic programming, and tree/graph traversals.  

---

✍ Author: *Urooba Batool*  
📅 Topic: Arrays (DSA)  
🎯 Goal: To master array operations and prepare for advanced data structures.
