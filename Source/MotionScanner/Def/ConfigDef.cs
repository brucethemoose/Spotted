﻿using System.Collections.Generic;
using Verse;

namespace Spotted;

internal class ConfigDef : Def
{
    private readonly List<string> args = new List<string>();

    public List<string> GetArgs()
    {
        return args;
    }
}