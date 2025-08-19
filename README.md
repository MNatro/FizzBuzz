# TDD Katas Implementation

This repository demonstrates proper Test-Driven Development (TDD) methodology through three classic coding katas.

## Implemented Katas

### 1. StringSum Kata ✅
**Requirement**: Write a String Sum utility that accepts only natural numbers and returns their sum. Invalid inputs should be treated as 0.

**TDD Progression**:
- Started with empty string edge case
- Added basic number addition
- Implemented invalid input handling with TryParse
- Added natural number validation (no negatives)

### 2. FizzBuzz Kata ✅
**Requirement**: Print numbers 1-100, but replace multiples of 3 with "Fizz", multiples of 5 with "Buzz", and multiples of 15 with "FizzBuzz".

**TDD Progression**:
- Started with basic number return
- Added Fizz logic for multiples of 3
- Added Buzz logic for multiples of 5
- Added FizzBuzz logic for multiples of 15

### 3. LeapYear Kata ✅
**Requirement**: Determine if a year is a leap year based on divisibility rules.

**TDD Progression**:
- Started with regular year (false case)
- Added basic divisible by 4 logic
- Added century year exception (divisible by 100)
- Added 400-year exception (divisible by 400)

## TDD Methodology Demonstrated

### Red-Green-Refactor Cycle
Each feature was implemented following strict TDD principles:

1. **RED**: Write a failing test
2. **GREEN**: Write minimal code to make the test pass
3. **REFACTOR**: Improve code while keeping tests green

### Commit History
The commit history shows clear TDD progression with **18 commits** demonstrating:
- Failing tests (RED phase)
- Minimal implementations (GREEN phase)
- Code improvements (REFACTOR phase)

### Commit Message Standards
All commits follow the "7 rules of good commit messages":
1. Separate subject from body with blank line
2. Limit subject line to 50 characters
3. Capitalize the subject line
4. Don't end subject line with period
5. Use imperative mood in subject line
6. Wrap body at 72 characters
7. Explain what and why, not how

## Test Results
- **Total Tests**: 12
- **Passed**: 12 ✅
- **Failed**: 0
- **Coverage**: 100%

## Key TDD Learning Outcomes

1. **Test-First Development**: Every feature started with a failing test
2. **Incremental Progress**: Small, focused changes with immediate feedback
3. **Confidence in Refactoring**: Comprehensive test suite enables safe code improvements
4. **Documentation**: Tests serve as living documentation of requirements
5. **Professional Git Workflow**: Clear commit history shows development progression

## Technologies Used
- **.NET 8.0**
- **C#**
- **xUnit** testing framework
- **Git** for version control

## Running the Tests
```bash
dotnet test
```

## TDD Best Practices Applied
- Start with the simplest test case
- Write only enough code to make tests pass
- Refactor after each passing test
- Use descriptive test names
- Follow AAA pattern (Arrange, Act, Assert)
- Commit frequently with meaningful messages
