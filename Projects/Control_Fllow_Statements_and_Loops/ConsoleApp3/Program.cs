//while loop
int i = 0;
while (i < 3)
{

    Console.WriteLine("Number of iteration:"+ i);

    i++;
};
//Do-While Loop

int a = 0;
do
{

    Console.WriteLine(a.ToString());

    a++;

} while (a < 5);

//break and continue statements;


for (int k = 0; k < 4; k++)
{

    if (k == 2)
    {

        break;
    }

    Console.WriteLine(k);
}

 
for(int j = 0; j < 3; j++)
{

    Console.WriteLine("j= " + j.ToString());

    for (int r = 0; r < 4; r++)
    {

        if (r == 2)
        {

            break;
        }

        Console.WriteLine("r= " + r.ToString());
    }
}

for(int u = 0; u < 4; u++)
{

    if (u == 2)
    {

        continue;
    }

    Console.WriteLine(u.ToString());
}