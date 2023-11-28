int[,] M =new int[4,3];
System.Console.WriteLine(M.Rank); //2
System.Console.WriteLine(M.GetLength(0)); //4
System.Console.WriteLine(M.GetLength(1)); //3
for(int i = 0; i < M.GetLength(0); i++)
{
    for(int j = 0; j < M.GetLength(1); j++)
    {
        System.Console.WriteLine($"tablica M {i},{j} {M[i,j]}");
    }
}

int[,,] cubes = new int[4,3,2];
for(int k = 0; k < cubes.GetLength(0); k++)
{
    System.Console.WriteLine($"cubes[{i}]");
    for(int l = 0; l < cubes.GetLength(1); l++)
    {
        System.Console.WriteLine($"\t{cubes[{k},{l}]}");
        for(int m = 0; m < cubes.GetLength(2); m++)
        {
            System.Console.WriteLine($"\t\tcubes[{k},{l},{m}]");
        }
    }
}

int[,]matrix = new int[,] {{1,2,3}, {4,5,6}, {7,8,9}}
for(int n = 0; n < matrix.GetLength(0); n++)
{
    for(int o = 0; o < matrix.GetLength(1); o++)
    {
        System.Console.WriteLine($"tablica matrix {i},{j} {matrix[i,j]}");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

double[,,] cube = new double[,,] { { {1.0, 2.0, 3.0},{4.0, 5.0, 6.0} }, {7.0, 8.0, 9.0},{10.0, 11.0, 12.0} };
for(int p = 0; p < cube.GetLength(0); p++)
{
    System.Console.WriteLine($"cubes[{p}]");
    for(int q = 0; q < cube.GetLength(1); q++)
    {
        System.Console.WriteLine($"\t{cubes[{p},{q}]}");
        for(int r = 0; r < cube.GetLength(2); r++)
        {
            System.Console.WriteLine($"\t\tcubes[{p},{q},{r}] = {cube[p,q,r]}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
