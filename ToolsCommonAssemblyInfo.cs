// ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalAssemblyInfo.cs" company="VirtoCommerce">
//   Copyright � VirtoCommerce. All rights reserved.
// </copyright>
// <summary>
//   Virto Commerce
// </summary>
// ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyCompany("VirtoCommerce")]
[assembly: AssemblyProduct("Virto Commerce Tools")]
[assembly: AssemblyCopyright("Copyright � VirtoCommerce 2011-2017")]

[assembly: AssemblyFileVersion("1.2.0.0")]
[assembly: AssemblyVersion("1.2.0.0")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
