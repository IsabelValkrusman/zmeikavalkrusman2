using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeikavalkrusman2
{
    class Params
    {
        var ind = Directory.GetCurrentDirectory().ToString()
              .IndexOf("bin", StringComparison.Ordinal); 

        string binFolder =
            Directory.GetCurrentDirectory().ToString().Substring(0, ind)
                .ToString(); 

        resourcesFoler = binFolder + "resources\\";
        }

    public string GetResourceFolder()
    {
        return resourcesFoler;
    }
}
