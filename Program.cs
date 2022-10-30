// sort out more complex examples

using Expressions_For_Calculator;

string s = "2+2";
ExpressionTree e = ExpressionTree.Build(s);
ExprVarValue[] vars = { new ExprVarValue("x", 2), new ExprVarValue("y", 3) };
Console.WriteLine(s);
foreach (ExprVarValue var in vars)
    Console.WriteLine(var);
Console.Write(e.ToString() + " = ");
Console.WriteLine(e.getValue(vars));

Console.ReadKey();
