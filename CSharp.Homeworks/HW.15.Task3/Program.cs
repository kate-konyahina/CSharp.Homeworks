using HW._15.Task3;
using System.Reflection;

Type motoType = typeof(Motorcycle);

Type ctorParameter1 = typeof(System.DateTime);
Type ctorParameter2 = typeof(string);

var ctor = motoType.GetTypeInfo().DeclaredConstructors
.First(ct => ct.GetParameters().Any() && ct.GetParameters()[0].ParameterType == ctorParameter1);

object[] args1 = new object[2] { new System.DateTime(2015, 07, 07), "Honda"};
object obj = ctor.Invoke(args1);

Console.WriteLine(obj.ToString());

MethodInfo methodInfo = obj.GetType().GetTypeInfo().GetDeclaredMethod("GetVinNumber");
object[] args2 = new object[0];
object vinNum = methodInfo.Invoke(obj, args2);
Console.WriteLine(vinNum);


FieldInfo fieldInfo = obj.GetType().GetTypeInfo().GetDeclaredField("_odometer");
fieldInfo.SetValue(obj, 234);
Console.WriteLine(fieldInfo.GetValue(obj));