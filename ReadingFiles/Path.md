### **Accessing a File in the Project Folder**
Assume your project structure looks like this:

```
SD_Arrays_Dec24
|__Arrays1
|__ReadingFiles1
   |__bin
      |__Debug
         |__net7.0
   	    |myNumbers.txt
```

```
MyProject
│
├── example.txt       <- File you want to read
├── Program.cs        <- Your C# code
├── bin
│   └── Debug
│       └── netX.X    <- Where the compiled application runs
```

To read `example.txt` from the project folder, you can construct the path dynamically:
```csharp
string fileName = "../../../example.txt"; // if the file is created in the Project folder, where the .cs file is
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
