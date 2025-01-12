using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
    public static class GlobalService
    {
        public static readonly ProfilesService Profiles = new();
    }
}
