namespace CurWork.Helpers
{
    public  class ChoisenHelper
    {
        private readonly string _answer;
        EnterApp enterApp;

        public ChoisenHelper(string answer)
        {
            _answer = answer;
            enterApp = new();
        }
        
    }
}
