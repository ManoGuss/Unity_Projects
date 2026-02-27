using UnityEngine;

public class Desafio_Vogal_e_CONSOANTE : MonoBehaviour
{
    public string letra = "a";


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            Debug.Log("A letra: " + letra + " é uma vogal");
        }
        else 
        { 
            Debug.Log("A letra: " + letra + " é uma consoante");
        }

    }

    // Update is called once per frame
    void Update()
    {
        




    }
}
