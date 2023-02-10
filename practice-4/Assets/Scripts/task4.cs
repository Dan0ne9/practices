using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task4 : MonoBehaviour
{
    void Start()
    {
        Dot dot_1 = new() { x = 2, y = 3, z = 4};
        Dot dot_2 = new() { x = 4, y = 6, z = 8};
        dot_1.Distance(dot_2);
        dot_1.RandomDot();
        dot_1.PrintDot();
        dot_1.ZeroDot();
        dot_1.PrintDot();
    }
}

struct Dot
{
    public int x, y, z;


    public void RandomDot()
    { x = Random.Range(0, 11);y=Random.Range(0, 11);z= Random.Range(0, 11); }
    public void ZeroDot()
    { x = 0;y = 0; z = 0;}
    public void Distance(Dot dot)
    {
        float distance = Mathf.Sqrt(Mathf.Pow(dot.x, 2)+Mathf.Pow(dot.y,2)+Mathf.Pow(dot.z,2));
    }

    public void PrintDot()
    {Debug.Log($"x = {x}, y = {y}, z = {z}");}
}
