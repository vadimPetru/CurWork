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
            string menu = String.Empty;
            for (int i =0; i < _items.Count; i++)
            {
                 menu += $"{i + 1}.{_items[i]}\n";
            }
            return menu;
        }
    }
}

