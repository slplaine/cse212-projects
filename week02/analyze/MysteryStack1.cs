public static class MysteryStack1 {
    public static string Run(string text) {
        var stack = new Stack<char>();//cria uma pilha vazia
        foreach (var letter in text)
            stack.Push(letter);//percorre cada letra do texto e coloca na pilha

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;//retira os caracteres da pilha e juntando em result
    }
}
// Purpose:
// This function reverses the input text using a stack.
//
// How the stack helps:
// A stack follows LIFO (Last In, First Out).
// Each character is pushed onto the stack in the original order.
// When the characters are popped, they come out in reverse order,
// which produces the reversed string.
//
// Expected outputs:
// MysteryStack1.Run("racecar") -> "racecar"
// MysteryStack1.Run("stressed") -> "desserts"
// MysteryStack1.Run("a nut for a jar of tuna") -> "anut fo raj a rof tun a"