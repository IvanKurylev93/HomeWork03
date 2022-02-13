// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x = true;
bool y = true;
if (!(x || y) == (!x && !y))
    Console.WriteLine($"Вар. 1 утверждение истино при {x, y}");
else 
    Console.WriteLine($"Вар. 1 утверждение не истинно при {x, y}");

x = true;
y = false;

if (!(x || y) == (!x && !y))
    Console.WriteLine($"Вар. 2 утверждение истино при {x, y}");
    else 
    Console.WriteLine($"Вар. 2 утверждение не истино при {x, y}");

x = false;
y = true;

if (!(x || y) == (!x && !y))
    Console.WriteLine($"Вар. 3 утверждение истино при {x, y}");
    else 
    Console.WriteLine($"Вар. 3 утверждение не истино при {x, y}");

x = false;
y = false;

if (!(x || y) == (!x && !y))
    Console.WriteLine($"Вар. 4 утверждение истино при {x, y}");
    else 
    Console.WriteLine($"Вар. 4 утверждение не истино при {x, y}");
