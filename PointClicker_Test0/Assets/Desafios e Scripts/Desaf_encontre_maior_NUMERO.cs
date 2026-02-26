using UnityEngine;

public class Desaf_encontre_maior_NUMERO : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;
    public int num3 = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (num1 > num2 && num1 > num3)
        {
            Debug.Log("O número maior é: " + num1);

        }
        else if (num2 > num1 && num2 > num3)
        {
            Debug.Log("O número maior é: " + num2);
        }
        else if (num3 > num1 && num3 > num2)
        {
            Debug.Log("O número maior é: " + num3);

        }
        else if (num3 == num1 && num3 == num2)
        {
            Debug.Log("todos os números são iguais");
        }

        else if (num1 == num2)
        {
            Debug.Log("Os maiores números são: " + (num1, num2));
        }
        else if (num1 == num3)
        {
            Debug.Log("Os maiores números são: " + (num1, num3));
        }
        else if (num2 == num3)
        {
            Debug.Log("Os maiores números são: " + (num2, num3));
        }
        

        // Update is called once per frame
        void Update()
        {

        }
    }
}