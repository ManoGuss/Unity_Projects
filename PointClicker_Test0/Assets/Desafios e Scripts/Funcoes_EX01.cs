using JetBrains.Annotations;
using UnityEngine;

public class Funcoes_EX01 : MonoBehaviour
{

    string item1 ;
    public int gold ;

    string inimigo1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Crafting();



    }

    // Update is called once per frame
    void Update()
    {
        




    }

    void Crafting() 
    { 
        string item_name = "Espada de Ferro";

        if (gold == 0) 
        { 
            Debug.Log("Você não tem ouro suficiente para criar um item");
        }
        else { 
            Debug.Log("Você criou um item");
        }
            
        if (item_name == "Espada de Ferro") 
        { 
            Debug.Log("Você criou uma Espada de Ferro");
        }

    }

}
