using System.Runtime.CompilerServices;

namespace CurWork.TypeOFValidations
{
    public class Validation
    {

        private int _resualt;

       

        public virtual string IsValid(string Exception)
        {
            
            string input = Console.ReadLine().ToUpper();
            try
            {

               
                if(int.TryParse(input , out _resualt))
                {
                   if(_resualt > 120 && _resualt < 0)
                    {
                        throw new Exception("Uninvalid age");
                    }
                }
                
                return input;
            }
            catch
            {
                throw new Exception(Exception);
            }
        }
    }
}
