#region OpenPDF Charting - A .NET charting library based on OpenPDF
//
// Authors:
//   Niklas Schneider
//
// Copyright (c) 2005-2019 empira Software GmbH, Cologne Area (Germany)
//
// http://www.OpenPDF.com
// http://sourceforge.net/projects/OpenPDF
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System.Reflection;
using System.Runtime.InteropServices;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("OpenPDF Charting")]
[assembly: AssemblyVersion(OpenPDF.ProductVersionInfo.Version)]
[assembly: AssemblyDescription("A .NET charting library based on OpenPDF.")]
[assembly: AssemblyConfiguration(OpenPDF.ProductVersionInfo.Configuration)]
[assembly: AssemblyCompany(OpenPDF.ProductVersionInfo.Company)]
#if DEBUG
  [assembly: AssemblyProduct(OpenPDF.ProductVersionInfo.Product + " (Debug Build)")]
#else
  [assembly: AssemblyProduct(OpenPDF.ProductVersionInfo.Product)]
#endif
[assembly: AssemblyCopyright(OpenPDF.ProductVersionInfo.Copyright)]
[assembly: AssemblyTrademark(OpenPDF.ProductVersionInfo.Trademark)]
[assembly: AssemblyCulture(OpenPDF.ProductVersionInfo.Culture)]

[assembly: ComVisible(false)]
//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyName("")]