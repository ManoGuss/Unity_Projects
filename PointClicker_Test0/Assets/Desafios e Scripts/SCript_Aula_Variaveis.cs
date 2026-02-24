using UnityEngine;

public class SCript_Aula_Variaveis : MonoBehaviour
{
    public int idade = 25; // Variável do tipo inteiro
    public float altura = 1.93f; // Variável do tipo float
    public bool isStudent = true; // Variável do tipo booleano
    public string nome = "João"; // Variável do tipo string
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
        
        string verdade = "sim, é estudante";
        string mentira = "não, não é estudante";

        if (isStudent == true) {
            Debug.Log(verdade);
        } else {
            Debug.Log(mentira);
        }

        int contabosta = 5 + idade;
        float calculo = -27f / idade;

        Debug.Log("O resultado do cálculo de -27f / pela Idade é " + calculo);
        Debug.Log("É estudante? " + isStudent);

        Debug.Log("Minha altura é " + altura);
        Debug.Log("Minha idade é " + idade);
        Debug.Log("Meu nome é " + nome);

        //- código quebrado - Debug.Log("o resultado do " + nome, "é" ,+ calculo);
        Debug.Log("resultado da soma 01 teste é " + contabosta);
        Debug.Log("Oirr bebezinho " + nome);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
