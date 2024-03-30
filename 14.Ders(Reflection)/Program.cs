using ReflectionLibrary;
using System.Reflection;

//Console.WriteLine("Hello, World!");
Customer customer = new Customer();

////Console.WriteLine(customer.GetExecutingAssambly().FullName);


Type[] reflectionLibTypes = customer.GetExecutingAssambly().GetTypes();


foreach (var type in reflectionLibTypes)
{


    if (type.IsClass && type.BaseType != null)
    {
        MethodInfo[] methodInfos = type.GetMethods();

        //Type[] interfaces = type.GetInterfaces();


        //foreach (var inter in interfaces)
        //{
        //    if (inter.Name == "ITable")
        //    {

        //        Console.WriteLine(type.Name);

        //    }
        //}

        PropertyInfo[] propertyInfos = type.GetProperties();

        foreach (var property in propertyInfos)
        {
            //var instance = Activator.CreateInstance(type);



            // property.SetValue(instance,null);
            // Console.WriteLine(property.GetValue(instance));


        }
    }
}


//Type type = typeof(Customer);

//Console.WriteLine(type.Name);
//Console.WriteLine($"{type.BaseType.Name}");
//Console.WriteLine($"{type.GetInterfaces()[0].Name}");
//Console.WriteLine($"{type.GetConstructors()[0].Name}");



Type simpleType = typeof(MyClass);
Console.WriteLine(
simpleType.IsAssignableTo(typeof(ISimpleInterface)));

Console.WriteLine(simpleType.IsAssignableFrom(typeof(SimpleClass)));



Type simpleType2 = typeof(SimpleClass);

PropertyInfo propertyInfo = simpleType2.GetProperty("Simple");

Console.WriteLine(propertyInfo.CanWrite);
class MyClass : ISimpleInterface
{

}


class SimpleClass : MyClass
{
    public int Simple { get; }
}

interface ISimpleInterface
{

}