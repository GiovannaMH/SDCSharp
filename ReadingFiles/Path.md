### **Accessing a File in the Project Folder**
Assume your project structure looks like this:

```
Solution_name
|__Arrays1
|__ReadingFiles1               <- Your Project
   |__Program.cs               <- Your C# code
   |__bin
      |__Debug
         |__netX.X             <- Where the compiled application runs
   	      |__myNumbers.txt   <- File you want to read - the default path
```

```
MyProject
│
├── myNumbers.txt     <- File you want to read
├── Program.cs        <- Your C# code
├── bin
│   └── Debug
│       └── netX.X    <- Where the compiled application runs
```

To read `myNumbers.txt` from the project folder, you can construct the path dynamically:
```csharp
string fileName = "../../../emyNumbers.txt"; // if the file is created in the Project folder, where the .cs file is
```
---

To read `example.txt` from the Solution folder, you can construct the path dynamically:
```csharp
string fileName = "../../../../example.txt"; // if the file is created in the Solution, to be accessible to all projects inside
```
### Testing It:
1. Place `example.txt` in the **Solution folder**.
2. Run the application.
3. The file content should load correctly.
