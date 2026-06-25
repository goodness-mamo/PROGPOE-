# PROGPOE!
#  CyberSecurity Awareness Chatbot – C# Console Application

## Project Description

The CyberSecurity Awareness Chatbot is an interactive C# Console Application developed to educate users about cybersecurity concepts while demonstrating software development principles.

The chatbot allows users to communicate through natural text input and receive guidance on cybersecurity topics such as password protection, phishing awareness, safe browsing, task management, and knowledge testing through an integrated quiz system.

This project combines practical cybersecurity awareness with programming concepts including Object-Oriented Programming (OOP), collections, methods, loops, conditional logic, multimedia integration, and Natural Language Processing (NLP) simulation.

---

# Project Objectives

This project was developed to:

* Create an interactive chatbot using C#
* Improve cybersecurity awareness
* Demonstrate Natural Language Processing through keyword recognition
* Allow users to create and manage tasks
* Test user knowledge using an interactive quiz
* Implement reusable and modular code
* Improve user experience through audio and visual interaction

---

# Features

## 1. Voice Greeting System

When the application launches, an audio greeting is played using the `SoundPlayer` class.

Purpose:

* Creates an interactive user experience
* Simulates a real chatbot welcome system

Technology Used:

* System.Media
* WAV Audio File Integration

---

## 2. ASCII Art Interface

The chatbot displays custom ASCII branding on startup.

Features:

* Improved console appearance
* User-friendly startup experience

Example:

```text
CYBERSECURITY AWARENESS CHATBOT
```

---

## 3. Natural Language Processing (NLP) Simulation

The chatbot recognises user intent using keyword matching stored inside a Dictionary collection.

Supported Commands:

| User Input    | Action                       |
| ------------- | ---------------------------- |
| Add Task      | Opens task manager           |
| Create Task   | Creates task                 |
| Start Quiz    | Starts quiz                  |
| Password      | Displays password advice     |
| Phishing      | Displays phishing awareness  |
| Safe Browsing | Displays browser safety tips |
| Purpose       | Explains chatbot purpose     |

Example:

```text
You: remind me
Bot: Task creation started
```

---

## 4. Task Management System

Users can create and manage tasks.

Functions:

* Add task title
* Add descriptions
* Set reminders
* Store multiple tasks

Data Structure:

* List<TaskItem>

Example:

```text
Task Title:
Update Password

Description:
Create stronger credentials

Reminder:
Tomorrow
```

---

## 5. Cybersecurity Quiz

An educational quiz tests user cybersecurity knowledge.

Features:

* Multiple-choice questions
* Instant feedback
* Score tracking
* Explanations after answers

Topics:

* Phishing
* Password security
* Two-Factor Authentication

Example Output:

```text
Question:
What is phishing?

Correct!
Phishing tricks users.
```

---

## 6. Cybersecurity Awareness Advice

The chatbot provides educational recommendations.

### Password Security

* Use strong passwords
* Enable Two-Factor Authentication
* Avoid password reuse

### Phishing Prevention

* Verify sender details
* Avoid suspicious links

### Safe Browsing

* Use HTTPS websites
* Avoid unsafe downloads

---

# Technologies Used

Programming Language:

* C#

Development Environment:

* Visual Studio

Application Type:

* Console Application

Libraries:

* System
* System.Collections.Generic
* System.Media
* System.Threading
* System.IO

Concepts Demonstrated:

* Object-Oriented Programming
* Lists
* Dictionaries
* Loops
* Conditional Statements
* Methods
* Exception Handling
* Multimedia Integration
* NLP Simulation

---

# Program Structure

## Classes

### TaskItem

Stores:

* Title
* Description
* Reminder
* Completion Status

### QuizQuestion

Stores:

* Question
* Options
* Correct Answer
* Explanation

### Program

Controls:

 Chatbot execution
 User interaction
 Command handling

---

 How to Run

1. Open Visual Studio
2. Create a Console Application
3. Replace Program.cs with the source code
4. Add `greeting.wav` to the output folder
5. Build and Run

---

 Example Commands

```text
add task
create task
start quiz
password
phishing
safe browsing
purpose
exit
```

---

 Challenges and Solutions

| Challenge                      | Solution                               |
| ------------------------------ | -------------------------------------- |
| Recognising different commands | Implemented Dictionary-based NLP       |
| Improving interaction          | Added audio greeting and typing effect |
| Managing reusable logic        | Used methods and classes               |
| Making the console attractive  | Added ASCII interface                  |

---

 Future Improvements

Possible enhancements:

 Database integration
 Graphical User Interface (GUI)
 Advanced AI responses
 User authentication
 Data persistence
 Reminder notifications

---

 Conclusion

The CyberSecurity Awareness Chatbot successfully demonstrates the development of an interactive console-based chatbot using C#.

The project combines cybersecurity education with software engineering practices and delivers a practical learning tool through quizzes, task management, multimedia interaction, and simulated NLP.

This project demonstrates technical competence, creativity, and effective application of programming concepts.


