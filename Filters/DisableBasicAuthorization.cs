using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Filters
{
    public class DisableBasicAuthorization : Attribute, IFilterMetadata
    {
    }
}
