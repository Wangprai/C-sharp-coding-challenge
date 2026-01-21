# Old Phone Pad - C# Coding Challenge [Technical test for Iron Software]

This project simulates text input from a **classic mobile phone keypad (Old Phone Pad)**  
using a **C# (.NET Console Application)**.

I started with Python code before C#
Python code: https://colab.research.google.com/drive/1Fkw64wrTqQBd5wh0wWzm3V8PlXT-HlXB?usp=sharing
Prompt using: https://chatgpt.com/share/6970b519-7304-8005-b7c2-d154dd6a5919

## Problem Description

Old mobile phones allowed users to type text by pressing number keys (`2–9`).  
Pressing the same key multiple times cycles through its corresponding letters.

Example:
- `2` → A  
- `22` → B  
- `222` → C  


## Project Structure
```text
C_sharp_coding_challenge/
│
├── Phone.cs        // Core Old Phone Pad logic
├── Program.cs      // Console application entry point
├── .gitignore
└── README.md
```

## Keypad Mapping

| Number | Letters |
|--------|--------|
| 2 | ABC |
| 3 | DEF |
| 4 | GHI |
| 5 | JKL |
| 6 | MNO |
| 7 | PQRS |
| 8 | TUV |
| 9 | WXYZ |

## Special Characters

| Character | Description |
|----------|------------|
| `space` or `#` | Confirm the current character |
| `*` | Backspace (delete last character) |

## Example Test Cases

```csharp
Phone.OldPhonePad("33#");                 // E
Phone.OldPhonePad("227*#");               // B
Phone.OldPhonePad("4433555 555666#");     // HELLO
Phone.OldPhonePad("8 88777444666*664#");  // TURING