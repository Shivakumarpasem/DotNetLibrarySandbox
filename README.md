# DotNetLibrarySandbox

A .NET class library focused on platform-style API design, unit testing with xUnit, and performance benchmarking with BenchmarkDotNet.

---

## Motivation

Building reliable libraries means more than just making code work. It means designing APIs that handle edge cases gracefully, writing tests that catch regressions automatically, and measuring performance so slowdowns never sneak in unnoticed. This project is a deliberate practice of those principles.

---

## Project Structure

```
DotNetLibrarySandbox
├── DotNetLibrarySandbox.Lib        # Class library with all API methods
│   ├── StringHelpers.cs            # String utility methods
│   └── ArrayHelpers.cs             # Array utility methods
├── DotNetLibrarySandbox.Tests      # xUnit tests and benchmarks
│   ├── UnitTest1.cs                # Unit tests for all methods
│   └── StringHelpersBenchmarks.cs  # BenchmarkDotNet benchmarks
└── DotNetLibrarySandbox.sln        # Solution file
```

---

## What's Inside

### StringHelpers

Utility methods for common string operations.

| Method | Description | Example |
|--------|-------------|---------|
| `IsPalindrome(string)` | Checks if a string reads the same forwards and backwards | `"racecar"` -> `true` |
| `Reverse(string)` | Reverses a string | `"hello"` -> `"olleh"` |
| `CountOccurrences(string, string)` | Counts how many times a word appears in a sentence | `"hi hi hi", "hi"` -> `3` |
| `CountVowels(string)` | Counts vowels in a string | `"hello"` -> `2` |
| `AreAnagrams(string, string)` | Checks if two strings are anagrams of each other | `"listen", "silent"` -> `true` |

### ArrayHelpers

Utility methods for common numeric array operations.

| Method | Description | Example |
|--------|-------------|---------|
| `FindMax(int[])` | Finds the maximum number in an array | `[1,5,3]` -> `5` |
| `RemoveDuplicates(int[])` | Removes duplicate numbers and preserves order | `[1,2,2,3]` -> `[1,2,3]` |
| `FlattenArray(int[,])` | Converts a 2D array into a 1D array | `[[1,2],[3,4]]` -> `[1,2,3,4]` |

---

## Design Principles

**Single responsibility** -- each method does one thing and does it well.

**Explicit contracts** -- all public methods are documented with XML comments covering inputs, outputs, and edge case behavior.

**Null safety** -- every method handles null, empty, and boundary inputs without throwing unexpected exceptions.

**Backward compatibility** -- method signatures are stable and non-breaking so consumers are never surprised.

---

## Getting Started

### Prerequisites

.NET 10 SDK or later. Download from [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

### Clone the repository

```bash
git clone https://github.com/your-username/DotNetLibrarySandbox.git
cd DotNetLibrarySandbox
```

### Run the tests

```bash
dotnet test
```

Expected output:

```
Test summary: total: 4, failed: 0, succeeded: 4, skipped: 0
```

### Run the benchmarks

```bash
cd DotNetLibrarySandbox.Tests
dotnet run -c Release
```

---

## Test Coverage

Tests are written with xUnit and cover three scenarios for every method:

1. Normal inputs with expected outputs
2. Edge cases like empty strings and single element arrays
3. Null inputs to verify safe handling

Current results:

```
total: 4, failed: 0, succeeded: 4, skipped: 0, duration: 1.3s
```

---

## Benchmarks

BenchmarkDotNet measures execution time and memory allocation for `IsPalindrome` and `Reverse` across short and long inputs. The goal is to catch performance regressions when implementations change.

---

## Tech Stack

| Tool | Purpose |
|------|---------|
| C# / .NET 10 | Core language and runtime |
| xUnit | Unit testing |
| BenchmarkDotNet | Performance measurement |
| GitHub Copilot | Test scaffolding and code review assistance |

---

## Author

**Shivakumar Pasem**
