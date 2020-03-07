using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    public class History
    {
        private Stack<EditorState> states = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            states.Push(state);
        }

        public EditorState Pop()
        {
            return states.Pop();
        }
    }
}
