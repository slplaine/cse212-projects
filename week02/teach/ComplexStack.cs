// This class contains a method that checks if parentheses, brackets,
// and braces in a string are balanced and correctly ordered.

public static class ComplexStack {
    // This method receives a line of text and returns true or false.
    // True = symbols are balanced
    // False = symbols are incorrect or mismatched
    public static bool DoSomethingComplicated(string line) {
        // Create a stack to store opening symbols: ( [ {
        var stack = new Stack<char>(); 
         // Loop through every character in the input string
        foreach (var item in line) { 
            // If we find an opening symbol, push it onto the stack
            // because we expect to find its closing pair later.
            if (item is '(' or '[' or '{') { 
                stack.Push(item); 
            }
             // If we find a closing parenthesis ')'
            else if (item is ')') {
                // Two checks:
                // 1) If the stack is empty -> there was no matching '('
                // 2) If the last opening symbol is not '(' -> mismatch
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
             // If we find a closing bracket ']'
            else if (item is ']') {
                 // Again we check:
                // 1) stack cannot be empty
                // 2) the last opening symbol must be '['
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            // If we find a closing brace '}'
            else if (item is '}') {
                // Check if the last opening symbol matches '{'
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }
        // After checking all characters:
        // If the stack is empty -> all symbols were matched correctly
        // If something remains in the stack -> there are unclosed symbols
        return stack.Count == 0;//se a pilha estiver vazia, significa que todos os simbolos de abertura foram fechados corretamente
    }
}