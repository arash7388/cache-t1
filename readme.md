# Single Operator Calculator

[![Difficulty](https://img.shields.io/badge/difficulty-easy-brightgreen)]()
[![Languages](https://img.shields.io/badge/languages-C%23-informational)]()
[![Deadline](https://img.shields.io/badge/deadline-2025--10--20-critical)]()

> A simple console-based calculator that takes two numbers from the user and performs addition. Proper error handling and standard output formatting should be implemented.

---

## Table of Contents

* [Requirements](#requirements)
* [Problem Description](#problem-description)
* [Rules and Constraints](#rules-and-constraints)
* [Input/Output and Examples](#inputoutput-and-examples)
* [How to Run and Test](#how-to-run-and-test)
* [How to Submit (PR)](#how-to-submit-pr)
* [Evaluation Criteria](#evaluation-criteria)
* [Timeline](#timeline)
* [Contact](#contact)

---

## Requirements

* Allowed Language: **C#**
* Recommended Version: `.NET 6` or higher
* OS: Any (Windows / Linux / macOS)
* Familiarity with:

  * Basic programming concepts
  * Console input/output
  * Error handling (`try/catch`)

---

## Problem Description

Write a program that:

1. Reads two numbers from the user via console input.
2. Performs **addition** on those two numbers.
3. Displays the result in a properly formatted output.
4. Prints an appropriate error message if invalid input is provided (e.g., text instead of a number).

**Goal:** Practice basic input/output, error handling, and clean coding structure in C#.

---

## Rules and Constraints

* Only one operation is allowed: **Addition**
* Input must be read via **Console.ReadLine()**.
* Exception handling is mandatory (no crashes).
* Do not use any external libraries.
* Code must be compatible with `.NET 6`.
* Code should be readable and well-documented.

---

## Input/Output and Examples

**Sample Input:**

```text
Enter first number: 7
Enter second number: 5
```

**Sample Output:**

```text
Result: 12
```

**Invalid Input:**

```text
Enter first number: abc
```

**Output:**

```text
Invalid input! Please enter numeric values only.
```

---

## How to Run and Test

### 1) Clone the Project

```bash
git clone https://github.com/dotin-challenge/cache-t1.git
cd cache-t1
```

### 2) Build and Run

```bash
dotnet build
dotnet run
```

### 3) (Optional) Run Tests

If test files are included:

```bash
dotnet test
```

---

## How to Submit (PR)

1. **Fork** the repository.
2. Create a new branch:

   ```bash
   git checkout -b solution/<username>
   ```
3. Place your code inside the following folder:

   ```text
   solutions/<username>/
     ├─ Program.cs
     └─ README.md
   ```
4. Open a Pull Request with the title:

   ```text
   [Solution] Single Operator Calculator - <username>
   ```

---

## Evaluation Criteria

| Criteria                             | Weight |
| ------------------------------------ | ------ |
| Correctness                          | 40%    |
| Code Quality & Readability           | 30%    |
| Error Handling                       | 15%    |
| Output Formatting & User Interaction | 10%    |
| Documentation                        | 5%     |

---

## Timeline

* Start: `2025-10-18`
* PR Submission Deadline: `2025-10-20`

---

## Contact

* .NET Community Group
* Or open an **Issue** in this repository for any questions or discussions
