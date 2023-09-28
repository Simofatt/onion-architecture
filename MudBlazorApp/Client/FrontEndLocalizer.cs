using ICSharpCode.Decompiler.Util;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synaplic.UniRH.Client
{
    public class FrontEndLocalizer : IStringLocalizer<FrontEndLocalizer>
    {
        private readonly IStringLocalizer _localizer;

        public FrontEndLocalizer(IStringLocalizer<FrontEndLocalizer> localizer)
        {
            _localizer = localizer;
        }

        public LocalizedString this[string name] => _localizer[name];

        public LocalizedString this[string name, params object[] arguments] => _localizer[name, arguments];

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures) => _localizer.GetAllStrings(includeParentCultures);


    }

    public class ResourceFileGenerator
    {
        public static void GenerateResourceFile(FrontEndLocalizer localizer)
        {
            using (var writer = new ResXResourceWriter("FrontEndLocalizer.fr.resx"))
            {
                var strings = localizer.GetAllStrings(includeParentCultures: true);
                foreach (var stringLocalizer in strings)
                {
                    writer.AddResource(stringLocalizer.Name, stringLocalizer.Value);
                }
            }
        }
    }
}
