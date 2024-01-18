
using System.Reflection;

Assembly assembly = Assembly.LoadFrom("HomeWorkLib.dll");
Type type = assembly.GetType("HomeWorkLib.MyLibrary");
MethodInfo method = type.GetMethod("Print");
method.Invoke(null, null);



