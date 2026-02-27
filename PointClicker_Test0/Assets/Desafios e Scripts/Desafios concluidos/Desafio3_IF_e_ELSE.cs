using UnityEngine;

public class Desafio3_IF_e_ELSE : MonoBehaviour
{

    public int x = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (x == 10){

            // se estiver CERTO, o código dentro deste bloco será executado
            Debug.Log("O valor de X é igual a 10");

        }
        else{
            
            // se estiver ERRADO, o código dentro deste bloco será executado
            Debug.Log("O valor de X é diferente de 10");

        }


    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
