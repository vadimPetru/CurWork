namespace CurWork.TypeOFValidations
{
    public class ValidationString : Validation
    {
        private int _resualt;
        public override string IsValid(string Exception)
        {
            

            string input = Console.ReadLine();
            try
            {

                if (int.TryParse(input, out _resualt))
                {
                    if (_resualt > 120 && _resualt < 0)
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
