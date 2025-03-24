namespace BEC16.Assembler
{
    public class Program
    {   
        public static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                return 0;
            }
            new Program().Start(args);
            return 0;
        }

        public void Start(string[] args)
        {
            string src = "";



            Assembler assembler = new Assembler();
            assembler.Build(src);
        }
    }
}