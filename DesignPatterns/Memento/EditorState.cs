namespace DesignPatterns.Memento
{
    public class EditorState
    {
        private string content;

        public EditorState(string content)
        {
            this.content = content;
        }

        public string Content => content;
    }
}