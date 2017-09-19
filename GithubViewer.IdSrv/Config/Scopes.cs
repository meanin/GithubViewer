﻿using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace GithubViewer.IdSrv.Config
{
    internal static class Scopes
    {
        public static List<Scope> Get()
        {
            return new List<Scope>
            {
                new Scope { Name = "api", Type = ScopeType.Resource}
            };
        }
    }
}