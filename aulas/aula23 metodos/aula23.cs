using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{
    int n1, n2;
    void Start()
    {
        n1= 10;
        n2= 20;
        Soma();
        multiplicaçao(n1,n2);
        
    }

    
    void Update()
    {
        
    }

    void Soma()
    {
        int resultado;
        resultado= n1 + n2;
        Debug.Log(resultado);

    }

    void multiplicaçao(int valorA,int valorB)
    {
        int resultado;
        resultado=valorA * valorB;
        Debug.Log(resultado);

    }

}
