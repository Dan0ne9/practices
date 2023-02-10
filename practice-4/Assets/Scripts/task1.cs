using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using first;
using second;

public class task1 : MonoBehaviour
{
    void Start()
    {
        Practice_First practice_First = new Practice_First();
        Practice_Second practice_Second = new Practice_Second();

        practice_First.task1("asasaasasasAAASAgfdfdf0adsdsaadsads");
        practice_First.task2(4);
        practice_First.task3(3,5);
        practice_First.task4();
        practice_Second.task1(5);
        practice_Second.task2(6);
        practice_Second.task3(5,6);
        practice_Second.task4(6,7);
        practice_Second.task5(7);
        practice_Second.task6();
        practice_Second.Week(3);
    }
}

namespace first
{
    class Practice_First
    {
        public void task1(string line)
        {
            int Acounter = 0;
            int Bcounter = 0;
            foreach (char line1 in line)
            {
                if (line1 == '0')
                {
                    Debug.Log(Bcounter);
                    return;
                }
                if (line1 == 'a' || line1 == 'A')
                {
                    Acounter++;
                }
                Bcounter++;
            }
            Debug.Log($"bukva a = {Acounter} and kol-vo bukv v nabore {Bcounter}");
        }

        public void task2(float R)
        {
            {
                const float PI = 3.14f;
                float circle;
                circle = PI * Mathf.Pow(2, PI);
                Debug.Log($"Area of the circle = {circle}");
            }
        }

        public void task3(int a, int b)
        {
            int square, specifiedarea = 40, difference;
            square = a * b;
            if (specifiedarea < square)
            {
                difference = square - specifiedarea;
                Debug.Log($"Specified area = {specifiedarea}, Calculated area = {square}, Area difference = {difference}");
            }
            if (specifiedarea > square)
            {
                Debug.Log("The specified area is larger than the calculated one");
            }
        }

        public void task4()
        {
            for (int a = 5; a <= 10; a++)
            {
                for (int b = 5; b <= 10; b++)
                {
                    Debug.Log($"{a} x {b} = {a * b}");
                }
            }
        }
    }
    
}

namespace second
{
    class Practice_Second
    {
        public void task1(int N)
        {
            int[,] massive = new int[N, N];
            int[] maxmin = new int[2] { 255, 0 };
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    massive[i, j] = Random.Range(0, 100);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (maxmin[1] < massive[i, j])
                    {
                        maxmin[1] = massive[i, j];
                    }
                    if (maxmin[0] > massive[i, j])
                    {
                        maxmin[0] = massive[i, j];
                    }
                }
                Debug.Log($"The number of elements in the array initially = {massive.Length}.Maximum element = {maxmin[1]} and minimum element = {maxmin[0]}.");
            }
        }

        public void task2(int N)
        {
            int[][] massive = new int[N][];
            for (int i = 0; i < N; i++)
            {
                massive[i] = new int[N];
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    massive[i][j] = Random.Range(0, 2);
                }
            }

            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = 0; j < massive.Length; j++)
                {
                    if (massive[i][j] == 1)
                    {
                        Debug.Log($"Found an element equal to one. Index = {i},{j}");
                    }
                }
            }
        }

        public void task3(int Narray_1, int Narray_2)
        {
            int[,] array_1 = new int[Narray_1, Narray_1];
            int[] maxmin = new int[2] { 255, 0 };
            for (int i = 0; i < Narray_1; i++)
            {
                for (int j = 0; j < Narray_1; j++)
                {
                    array_1[i, j] = Random.Range(0, 100);
                }
            }
            Exercise1(array_1, ref maxmin);
            Debug.Log($"The number of elements in the array initially = {array_1.Length}.Maximum element = {maxmin[1]} and minimum element = {maxmin[0]}.");


            int[][] array_2 = new int[Narray_2][];
            for (int i = 0; i < Narray_2; i++)
            {
                array_2[i] = new int[Narray_2];
            }

            for (int i = 0; i < Narray_2; i++)
            {
                for (int j = 0; j < Narray_2; j++)
                {
                    array_2[i][j] = Random.Range(0, 2);
                }
            }
            Exercise2(array_2);


            void Exercise1(int[,] array, ref int[] maxmin)
            {
                for (int i = 0; i < Narray_1; i++)
                {
                    for (int j = 0; j < Narray_1; j++)
                    {
                        if (maxmin[1] < array[i, j])
                        {
                            maxmin[1] = array[i, j];
                        }
                        if (maxmin[0] > array[i, j])
                        {
                            maxmin[0] = array[i, j];
                        }
                    }
                }
            }

            void Exercise2(int[][] array)
            {
                for (int i = 0; i < array_2.Length; i++)
                {
                    for (int j = 0; j < array_2.Length; j++)
                    {
                        if (array_2[i][j] == 1)
                        {
                            Debug.Log($"Found an element equal to one. Index = {i},{j}");
                        }
                    }
                }
            }
        }

        public void task4(int row, int column)
        {
            int[,] Array = GenerateMas(row, column);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Debug.Log(Array[i, j]);
                }
            }

            int[,] GenerateMas(int row, int column)
            {
                int[,] Array = new int[row, column];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Array[i, j] = Random.Range(0, 255);
                    }
                }
                return Array;
            }
        }

        public void task5(int row)
        {
            int[][] massive = GenerateMas(row);
            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = 0; j < massive[i].Length; j++)
                {
                    Debug.Log(massive[i][j]);
                }
            }

            int[][] GenerateMas(int row)
            {
                int[][] massive = new int[row][];

                for (int i = 0; i < row; i++)
                {
                    massive[i] = new int[Random.Range(1, 255)];
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < massive[i].Length; j++)
                    {
                        massive[i][j] = Random.Range(0, 255);
                    }
                }
                return massive;
            }
        }

        public void task6()
        {
            int number = 0;

            Generator1(number);
            Debug.Log(number);
            Generator2(ref number);
            Debug.Log(number);
        }

        public void Generator1(int number)
        {
            number = Random.Range(-999, 999);
        }
        public void Generator2(ref int number)
        {
            number = Random.Range(-999, 999);
        }

        public void Week(int Day)
        {
            switch (Day)
            {
                case 1:
                    Debug.Log("Monday");
                    break;
                case 2:
                    Debug.Log("Tuesday");
                    break;
                case 3:
                    Debug.Log("Wednesday");
                    break;
                case 4:
                    Debug.Log("Thursday");
                    break;
                case 5:
                    Debug.Log("Friday");
                    break;
                case 6:
                    Debug.Log("Saturday");
                    break;
                case 7:
                    Debug.Log("Sunday");
                    break;

            }
        }
    }
}