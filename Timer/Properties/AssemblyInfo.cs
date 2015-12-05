#region Using directives

using System;
using System.Reflection;
using System.Runtime.InteropServices;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Timer")]
[assembly: AssemblyDescription("Das Programm dient als Timer. \r\n" +
                               "Es lassen sich Sounds als Start-, Halbzeit-, Letze-Minute- und Endsounds abspielen.\r\n" +
                               "Es werden jegliche Dateiformate unterstützt, die nativ vom Windows Media Player abgespielt werden können (*.mp3, *.wav, *.ogg, *.wma, ...).\r\n" +
                               "In den Ordner für die Sponsoren-Logos bitte nur! Bilddateien (die nativ von Windows unterstützt werden) ablegen. \r\n" +
                               "\r\n"+
                               "In dieser Version deaktiviert:\r\n" +
							   "- Als Spielpläne können *html oder *htm Dateien angezeigt werden.\r\n" +
							   "- Pausentimer")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Privat Jonas Heim")]
[assembly: AssemblyProduct("Timer")]
[assembly: AssemblyCopyright("Copyright Jonas Heim, 2015. All rights reserved")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// This sets the default COM visibility of types in the assembly to invisible.
// If you need to expose a type to COM, use [ComVisible(true)] on that type.
[assembly: ComVisible(false)]

// The assembly version has following format :
//
// Major.Minor.Build.Revision
//
// You can specify all the values or you can use the default the Revision and 
// Build Numbers by using the '*' as shown below:
[assembly: AssemblyVersion("1.3")]
