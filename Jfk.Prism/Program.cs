namespace Jfk.Prism
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;

    using static System.Console;

    public static class Program
    {
        public static List<Type> assignableClasses = new List<Type>();
        public static List<String> classDescriptionAtributes = new List<String>();

        public static void Main(string[] args)
        {
            var path = 0 == args.Length ? string.Empty : args[0];
            if (!File.Exists(path))
            {
                return;
            }

            assignableClasses.Clear();
            classDescriptionAtributes.Clear();

            var assembly = Assembly.LoadFrom(path);
            foreach (var type in assembly.GetExportedTypes())
            {

                if (!typeof(ICallable).IsAssignableFrom(type))
                {
                    continue;
                }

                var descriptionAttribute = type.GetCustomAttribute<DescriptionAttribute>(true);
                if (null != descriptionAttribute)
                {
                    Write("Description: '{0}'", descriptionAttribute.Description);
                    String desc = ("Description: " + descriptionAttribute.Description);
                    classDescriptionAtributes.Add(desc);
                }

                if (!(Activator.CreateInstance(type) is ICallable callable))
                {
                    throw new InvalidOperationException();
                }

                assignableClasses.Add(type);

                 WriteLine("Result: {0}", callable.Count(8));      //type already checked, static invoke
                                                                   //results.Add("Result: " + callable.Count(n));
                Console.Read();
            }
        }
    }
}
