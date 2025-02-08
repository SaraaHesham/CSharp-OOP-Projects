# CSharp-OOP-Projects

## Overview
This repository contains three C# projects that demonstrate Object-Oriented Programming (OOP) principles, including encapsulation, inheritance, and polymorphism. Each project showcases how OOP concepts can be applied to real-world applications.

---

## 📚 Library Management System
### Description
A console-based library management system where librarians can manage books and users can borrow them.

### Features
- **Librarians:** Add, remove, and display books.
- **Users:** Borrow books and view available books.
- **Library Card System:** Users need a library card to borrow books.

### Files
- `Program.cs` – Main program logic.
- `Library.cs` – Handles book storage and borrowing.
- `Book.cs` – Represents book data.
- `Librarian.cs` & `LibraryUser.cs` – Manage librarian and user functionalities.

### 📌 Additional Resources
- **User Stories:** [`LibraryManagementSystem/User-Story.pdf`](LibraryManagementSystem/User-Story.pdf) – Describes system requirements from a user's perspective.

> **Note:** The UML diagram for this project was not created by me and is not included.

---

## 🎮 Maze Game
### Description
A console-based maze game where the player navigates a maze using arrow keys to reach the exit.

### Features
- **Maze Generation:** Walls and empty spaces are displayed to create a maze layout.
- **Player Movement:** The player moves using the arrow keys.
- **Collision Detection:** The player cannot pass through walls.

### Files
- `Program.cs` – Initializes the game and starts the main loop.
- `Maze.cs` – Handles maze creation and rendering.
- `Player.cs` – Represents the player character.
- `Wall.cs` – Represents walls in the maze.
- `EmptySpace.cs` – Represents open spaces in the maze.
- `IMazeObject.cs` – Interface for maze objects.

### 📌 Additional Resources
- **UML Diagram (Image):** [`MazeGame/UML.png`](MazeGame/UML.png) – Non-editable UML diagram for the project.
- **User Stories:** [`MazeGame/User-Story.pdf`](MazeGame/User-Story.pdf) – Describes system requirements from a player's perspective.

---

## 📂 File Analyzer
### Description
A console-based application that analyzes text files (`.txt`) and CSV files (`.csv`). It extracts useful information such as word count, character count, line count, and field count for CSV files.

### Features
- **TXT File Analysis:** Counts words, characters, and lines.
- **CSV File Analysis:** Identifies the number of fields in each row.
- **Extensible Design:** Supports adding new file types for analysis.

### Files
- `Program.cs` – Handles folder input and processes files.
- `FileInfoExtensions.cs` – Provides extension methods to identify file types.
- `AnalysisResults.cs` – Struct for storing analysis results.
- `FileAnalyzer.cs` – Base class for analysis operations.
- `IFileAnalysis.cs` – Interface for file analysis classes.
- `TxtFileAnalyzer.cs` – Implements `.txt` file analysis.
- `CSVFileAnalyzer.cs` – Implements `.csv` file analysis.

### 📌 Additional Resources
- **Sample Files:** [`TextAnalyzer/SampleFiles`](TextAnalyzer/samples) – Example files for testing.
- **UML Diagram (Image):** [`TextAnalyzer/UML.png`](TextAnalyzer/UML.png) – Non-editable UML diagram for the project.
- **User Stories:** [`TextAnalyzer/User-Story.pdf`](TextAnalyzer/User-Story.pdf) – Describes system requirements from a user's perspective.

---

## 📌 Topics Covered
This repository demonstrates several key Object-Oriented Programming (OOP) concepts and software development principles, including:

- **Encapsulation:** Protecting data using classes, private fields, and access modifiers.
- **Inheritance:** Creating specialized classes from base classes to promote code reusability.
- **Polymorphism:** Implementing interfaces and method overriding to provide flexible functionality.
- **Interfaces & Abstraction:** Defining contracts for class behavior to enforce consistency.
- **File Handling:** Reading and analyzing files in different formats (`.txt`, `.csv`).
- **Data Structures & Algorithms:** Implementing efficient data handling techniques in projects.
- **Software Design:** Using UML diagrams and structured design methodologies.

## 🎓 Learning Journey
This repository is a result of my continuous learning in **.NET development and Object-Oriented Programming**.  
Throughout my journey, I have built various projects to strengthen my understanding of **C#**, OOP principles, and software architecture. These projects were developed based on **academic learning, self-study, and hands-on experience with real-world applications**.

By implementing these projects, I have gained:
- **Practical experience in C# and the .NET ecosystem.**
- **A deep understanding of OOP principles and their application.**
- **Experience in designing and structuring maintainable, scalable code.**
- **Hands-on experience in working with files, user interactions, and system modeling.**

This repository serves as both a learning resource and a **showcase of my software development journey**. I continuously seek to improve my skills and apply best practices in software engineering.

---

## 📬 Contact  
If you have any questions, suggestions, or would like to collaborate, feel free to connect with me on **[LinkedIn](https://www.linkedin.com/in/sarahesham/)**.
