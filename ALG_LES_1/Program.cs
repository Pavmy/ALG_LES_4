using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Павлюков Михаил
//3. *** Требуется обойти конём шахматную доску размером NxM, пройдя через все поля доски по одному разу.
//Здесь алгоритм решения такой же как и в задаче о 8 ферзях.Разница только в проверке положения коня.

//#include <stdio.h>

//int A[8][8];
//const int dx[8] = { 2, 1, -1, -2, -2, -1, 1, 2 };
//const int dy[8] = { 1, 2, 2, 1, -1, -2, -2, -1 };
//int s;

//void rek(int x, int y, bool OK);

//int main(void)
//{
//    int x, y;
//    s = 2;
//    for (x = 0; x < 8; x++)
//    {
//        for (y = 0; y < 8; y++)
//        {
//            A[x][y] = 0;
//        }
//    }
//    A[0][0] = 1;

//    rek(0, 0, false);

//    for (x = 0; x < 8; x++)
//    {
//        for (y = 0; y < 8; y++)
//        {
//            printf("%d   ", A[x][y]);
//        }
//        printf("\n");
//    }
//}

//void rek(int x, int y, int step)
//{
//    A[x][y] = step;
//    int i;
//    for (i = 0; i < 8; i++)
//    {
//        int x1 = x + dx[i];
//        int y1 = y + dy[i];

//        if ((x1 >= 0) && (y1 >= 0) && (x1 < 8) && (y1 < 8) && (A[x1][y1] == 0))
//        {
//            rek(x1, y1, step + 1);
//        }
//    }
//}


namespace ALG_LES_4
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

