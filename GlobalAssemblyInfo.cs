﻿using System;
using System.Reflection;

[assembly: CLSCompliant(true)]

[assembly: AssemblyProduct("NetMonkey")]
[assembly: AssemblyCompany("")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
