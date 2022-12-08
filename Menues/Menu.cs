namespace CurWork.Menu
{
    public class MenuObject  // 
    {
        private readonly List<string> _items;
        public MenuObject(params string[] items)
        {
            _items[0] = items[0];
            _items[1] = items[1]; 
        }
        public override string ToString()
        {
            return $"{_items[0]}\n{_items[1]}";   
        }
    }
}

