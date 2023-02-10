using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using first;
using second;

public class task2 : MonoBehaviour
{
    void Start()
    {
        Practice_First practice_First = new();
        Practice_Second practice_Second = new();

        Task task = new(practice_First, practice_Second);

        task.GetPractice_First();
        task.GetPractice_Second();
    }
}

class Task
{
    public Practice_First practice_first;
    public Practice_Second practice_second;
    
    public Task(Practice_First practice_First, Practice_Second practice_Second)
    {
        this.practice_first= practice_First;
        this.practice_second= practice_Second;
    }

    public void GetPractice_First()
    {
        Debug.Log("Practice_First:");

        Debug.Log("Task1");
        practice_first.task1("ASFDFsadfasdSDAS0asds");

        Debug.Log("Task2");
        practice_first.task2(6);

        Debug.Log("Task3");
        practice_first.task3(9,4);

        Debug.Log("Task4");
        practice_first.task4();
    }

    public void GetPractice_Second()
    {
        Debug.Log("Practice_Second");

        Debug.Log("Task1");
        practice_second.task1(5);

        Debug.Log("Task2");
        practice_second.task2(5);

        Debug.Log("Task3");
        practice_second.task3(5,7);

        Debug.Log("Task4");
        practice_second.task4(4,6);

        Debug.Log("Task5");
        practice_second.task5(5);

        Debug.Log("Task6");
        practice_second.task6();

        Debug.Log("Task7");
        practice_second.Week(3);
    }
}