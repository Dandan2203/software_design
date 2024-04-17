## YAGNI - You Aren't Gonna Need It

The codebase strictly implements features that are immediately required, avoiding any unnecessary functionality that is not specified.

## Composition Over Inheritance

The `Product` class demonstrates the use of composition by including a `Money` object for handling price, instead of inheriting from it.

## Program to Interfaces, not Implementations

While the current implementation directly uses classes, the design allows for easy refactoring to utilize interfaces for `Warehouse` and other components, facilitating better adherence to this principle.

## Fail Fast

The `ReducePrice` method in the `Product` class is designed to fail fast by immediately checking for negative price settings and aborting the operation if the conditions are met.

- **File:** [Product.cs](./Product.cs)
- **Lines:** [18-26], where price reduction and validation are handled.

## Conclusion

The principles of programming are essential for writing clean, maintainable, and efficient code. This document links directly to the source files and lines where these principles are demonstrated, ensuring clarity and ease of understanding the application of these principles in a practical context.
