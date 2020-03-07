using System;
using DesignPatterns.Memento;

namespace DesignPatterns
{
    class MementoPattern
    {
        static void Main(string[] args)
        {
            Editor  editor = new Editor();
            History history = new History();
            
            editor.Content = "a";
            history.Push(editor.CreateState());
            Console.WriteLine(editor.Content);

            editor.Content = "b";
            history.Push(editor.CreateState());
            Console.WriteLine(editor.Content);

            editor.Content = "c";
            Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);

            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);
        }
    }
}
