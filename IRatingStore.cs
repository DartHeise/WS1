using System.Collections.Generic;

namespace lab4
{
    public interface IRatingStore
    {
        string[] GetAll();
        void SaveAll(string[] text);
        List<string> Get();
    }
}
