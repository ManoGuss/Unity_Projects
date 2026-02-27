using UnityEngine;

public class desafio_TRIANGULOS : MonoBehaviour
{
    public int angulo1 = 0;
    public int angulo2 = 0;
    public int angulo3 = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (angulo1 == angulo2 && angulo1 == angulo3)
        {
            Debug.Log("Este Triângulo é Equilátero");

        }
        else if (angulo1 == angulo2 || angulo1 == angulo3 || angulo2 == angulo3)
        {
            Debug.Log("Este Triângulo é Isósceles");
        }
        else
        {
            Debug.Log("Este Triângulo é Escaleno");
        }


    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
