using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazorApp.Shared.Constant
{
    public static  class LanguageConstants
    {
       public static Languages[] languages = new Languages[] {

         new Languages{Code = "fr-Fr" , DisplayName = "Frensh" },
         new Languages{Code = "en-EN" , DisplayName = "English" }
        
        };

    }
}
