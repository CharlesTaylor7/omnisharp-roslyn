using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OmniSharp.Models;

namespace OmniSharp.MSBuild
{
    public interface IHasher
    {
        HashedString HashInput(string clearText);
    }
}
