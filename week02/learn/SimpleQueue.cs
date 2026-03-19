public class SimpleQueue {
    public static void Run() {
        // Test 1
        Console.WriteLine("Test 1");
        var queue = new SimpleQueue();
        queue.Enqueue(100); // Enfileira o número 100
        var value = queue.Dequeue(); // Desenfileira o número 100
        Console.WriteLine(value); // Deve mostrar 100
        Console.WriteLine("------------");

        // Test 2
        Console.WriteLine("Test 2");
        queue = new SimpleQueue();
        queue.Enqueue(200);
        queue.Enqueue(300);
        queue.Enqueue(400);
        Console.WriteLine(queue.Dequeue()); // Deve mostrar 200
        Console.WriteLine(queue.Dequeue()); // Deve mostrar 300
        Console.WriteLine(queue.Dequeue()); // Deve mostrar 400
        Console.WriteLine("------------");

        // Test 3
        Console.WriteLine("Test 3");
        queue = new SimpleQueue();
        try {
            queue.Dequeue(); // Tentando remover de uma fila vazia
            Console.WriteLine("Oops ... Isso não deveria funcionar.");
        }
        catch (InvalidOperationException) { // ← CORREÇÃO: antes era IndexOutOfRangeException
            Console.WriteLine("Exceção lançada corretamente.");
        }
    }

    // Lista interna que guarda os elementos da fila
    private readonly List<int> _queue = new();

    /// <summary>
    /// Enfileira o valor fornecido
    /// </summary>
    public void Enqueue(int value) { // ← CORREÇÃO: antes era private, agora é public
        _queue.Add(value); // Adiciona no final da lista
    }

    /// <summary>
    /// Desenfileira o próximo valor
    /// </summary>
    /// <exception cref="InvalidOperationException">Se a fila estiver vazia</exception>
    public int Dequeue() { // ← CORREÇÃO: antes era private, agora é public
        if (_queue.Count == 0)
            throw new InvalidOperationException("Fila vazia!"); // ← CORREÇÃO: exceção trocada

        var value = _queue[0]; // Pega o primeiro elemento
        _queue.RemoveAt(0);    // Remove o primeiro elemento
        return value;          // Retorna o valor removido
    }
}
