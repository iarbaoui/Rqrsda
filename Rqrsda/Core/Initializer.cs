using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rqrsda.Core
{
    public class Initializer : MigrateDatabaseToLatestVersion<RqrsdaContext, Configuration>
    {
    }
}