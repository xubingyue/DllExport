﻿// [Decompiled] Assembly: RGiesecke.DllExport, Version=1.2.4.23262, Culture=neutral, PublicKeyToken=ad5f9f4a55b5020b
// Author of original assembly (MIT-License): Robert Giesecke
// Use Readme & LICENSE files for details.

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace RGiesecke.DllExport.Parsing
{
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
public class Regexes
{
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static ResourceManager ResourceManager
    {
        get
        {
            if (object.ReferenceEquals((object) Regexes.resourceMan, (object) null)) {
                Regexes.resourceMan = new ResourceManager("RGiesecke.DllExport.Parsing.Regexes", typeof (Regexes).Assembly);
            }
            return Regexes.resourceMan;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static CultureInfo Culture
    {
        get
        {
            return Regexes.resourceCulture;
        }
        set
        {
            Regexes.resourceCulture = value;
        }
    }

    internal Regexes()
    {
    }
}
}
