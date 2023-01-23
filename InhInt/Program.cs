using InhInt;

Complex c1=new Complex(1, 2);
Complex c2=new Complex(2, 3);
Complex c3= (Complex)c1.Add(c2);
Console.WriteLine(c3);
Complex c4 = (Complex)c1.Sub(c2);
Console.WriteLine(c4);
Complex c5 = (Complex)c1.Mult(c2);
Console.WriteLine(c5);
Complex c6 = (Complex)c1.Div(c2);
Console.WriteLine(c6);
Console.WriteLine(c1.Equ(c2));
Console.WriteLine(c1.Conj());