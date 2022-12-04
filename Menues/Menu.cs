namespace CurWork.Menu
{
    public class MenuObject : IHint // - Обьект предоставляющий Главное Меню 
    {
        public string FirstItem { get; private set; }
        public string SecontItem { get; private set; }
        public string ThirdItem { get; private set; }

        public MenuObject(string first, string second, string third)
        {
            FirstItem = first;
            SecontItem = second;
            ThirdItem = third;
        }
        public override string ToString()
        {
            return $"1. {FirstItem}\n2. {SecontItem}\n3. {ThirdItem}";
        }

        public void GetHint(string message)
        {
            Console.WriteLine(message);
        }
    }
}

