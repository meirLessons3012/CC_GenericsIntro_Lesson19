using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CC_GenericsIntro_Lesson19
{
    internal class BaseBook
    {

    }

    internal class Book : BaseBook
    {
        public string Author { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
            //return JsonConvert.SerializeObject(this);
        }
    }

    internal class SubBook : Book, ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
