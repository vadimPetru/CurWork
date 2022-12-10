namespace CurWork.Menu
{
    public class MenuObject  
    {
        private readonly List<string> _items;
        public MenuObject(params string[] items)
        {
            _items = new List<string>();
            _items.AddRange(items);
        }
           
        public override string ToString()
        {
            return $"1.{_items[0]}\n2.{_items[1]}";   
        }
    }
}

