

using HW._13.OtherTypes;

var text1 = FileWorkerSingleton.Instance;
var text2 = FileWorkerSingleton.Instance;

text1.WriteText("Hi there! ");
text2.WriteText("How are you?");

text1.Save();
text2.Save();
