// This program evaluates a postfix expression using a stack.
// Its purpose is to read numbers and operators, perform the operations
// in the correct order, and return the final result.

// The stack is useful because it stores the numbers until an operator appears.
// When an operator is found, the program pops the last two values,
// applies the operation, and pushes the result back onto the stack.

// "5 3 7 + *" returns 50.
// 3 + 7 = 10, then 5 * 10 = 50.

// "6 2 + 5 3 - /" returns 4.
// 6 + 2 = 8, 5 - 3 = 2, then 8 / 2 = 4.

// Invalid Case 1 example: "5 +"
// There is only one value in the stack, but '+' needs two operands.

// Invalid Case 2 example: "5 0 /"
// Division by zero causes this error.

// Invalid Case 3 example: "5 2 abc +"
// "abc" is not a number or a valid operator.

// Invalid Case 4 example: "5 6"
// The expression ends with two values left in the stack.
public static class MysteryStack2 {
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _);
    }

    public static float Run(string text) {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' ')) {
            if (item == "+" || item == "-" || item == "*" || item == "/") {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+") {
                    res = op1 + op2;
                }
                else if (item == "-") {
                    res = op1 - op2;
                }
                else if (item == "*") {
                    res = op1 * op2;
                }
                else {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }

                stack.Push(res);
            }
            else if (IsFloat(item)) {
                stack.Push(float.Parse(item));
            }
            else if (item == "") {
            }
            else {
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();
    }
}