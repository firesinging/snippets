
namespace Libraries.database
{

    public static class Database
    {

        public static readonly bool Instance = false;

        static Database()
        {

            if (!Instance)
            {                             

                
                

                Instance = true;

            }            

        }
        
    }

}
