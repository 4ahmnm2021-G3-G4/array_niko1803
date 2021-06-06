using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrays : MonoBehaviour
{

    string[] array1 = new string[4];
    float[] array2 = new float[4](1.5, 2.2, 3.7, 4.1);
    int[] array3 = int[4](2, 3, 4, 5);

    //4 Werte überall.
    // 1) Durchlaufen ausgeben der Werte
    // 2) Länge des Arrays ausgeben als Debug
    // 3) 2 Werte direkt ändern
    // 4) GameObjects Images anlegen, Tag vergeben, zuweisen und Farbe ändern.

    private void Start()
    {
        Debug.Log("lenght_array1:" + array1.Length);
        Debug.Log("lenght_array2:" + array2.Length);
        Debug.Log("lenght_array3:" + array3.Length);
        array1[0] = "New";
        array3[3] = 3;
    }

    private void OnMouseDown()
    {
        GameObject[] arrayFarbe = GameObject.FindGameObjectsWithTag("Yeah");
        arrayFarbe[1].GetComponent<Image>().color = Color.yellow;
    }
 

}
