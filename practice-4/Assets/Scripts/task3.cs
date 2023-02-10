using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task3 : MonoBehaviour
{
    void Start()
    {
        Hall hall = new();

        hall.availableseats();
        hall.Profit();
    }
}

public class Hall
{
    public int cost, occupiedseats, count;
    public float coefficient_N, coefficient_M;

    public Hall(int count = 100,int ocuppiedseats = 50,int cost = 500,float coefficient_N = 1.15f,float coefficient_M = 1f)
    {
        this.count = count;
        this.cost = cost;
        this.occupiedseats = ocuppiedseats;
        this.coefficient_N = coefficient_N;
        this.coefficient_M = coefficient_M;
    }

    public int[] CreateArray()
    {
        int[] array= new int[this.count];
        int countOccupiedSeat = 0;

        while(countOccupiedSeat < occupiedseats) 
        {
            for (int i = 0;i < this.count;i++)
            {
                if (countOccupiedSeat < occupiedseats)
                {
                    if (array[i] == 0)
                    {
                        array[i] = Random.Range(0, 2);

                        if (array[i] == 1)
                        {
                            countOccupiedSeat++;
                        }
                    }
                }
                else
                    break;
            }
        }
        return array;
    }


    public void Profit()
    {
        float profit = 0;
        int[] hall = CreateArray();
        for (int i = 0;i<this.count;i++)
        {
            if (hall[i]==1)
            {
                if (i < this.count * 0.2 || i > this.count * 0.85)
                    profit += cost * coefficient_N;
                else
                    profit+= cost * coefficient_M;
            }
        }
        Debug.Log($"Profit the sale {profit}");
    }

    public void availableseats()
    {
        Debug.Log($"Number of available seats {count - occupiedseats}");
    }
}