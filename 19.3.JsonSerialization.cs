
using Newtonsoft.Json;

namespace DexTraining
{
    class JsonSerializationExampleClass
    {
        public List<Plug> list = new List<Plug>();
        public JsonSerializationExampleClass()
        {
            list.Add(new Plug(8));
            list.Add(new Plug(9));
            list.Add(new Plug(8888));
        }       
    }

    public class Plug
    {
        public int value;

        public Plug(int v)
        {
            value = v;
        }
    }

    public class JsonSerializationTestRun
    {
        public JsonSerializationTestRun() 
        {
            JsonSerializationExampleClass cl = new();
            string json = JsonConvert.SerializeObject(cl);
            File.WriteAllText(@"c:\jsontext.json", json);
        }       
       
    }
}
