using UnityEngine;

public class Desafio_simulador_par_impar : MonoBehaviour
{
    public string jogador1 = "nome";
    public string jogador2 = "nome";
    public int numeroJogador1 = 0;
    public int numeroJogador2 = 0;
    public string mao_jogador1 = "mao1";
    public string mao_jogador2 = "mao2";


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("o jogador: " + jogador1 + " escolheu: " + mao_jogador1);
        Debug.Log("o jogador: " + jogador2 + " escolheu: " + mao_jogador2);
        Debug.Log("PAR!....IMPAR!");
        Debug.Log($"o jogador: {jogador1} escolheu o numero: {numeroJogador1}");
        Debug.Log($"o jogador: {jogador2} escolheu o numero: {numeroJogador2}");
        /*
        if (mao_jogador1 == "par") 
        { 
            Debug.Log("o jogador: " + jogador1 + " escolheu PAR");
        }
        else if (mao_jogador1 == "impar")
        {
            Debug.Log("o jogador: " + jogador1 + " escolheu IMPAR");
        }
        if (mao_jogador2 == "par")
        {
            Debug.Log("o jogador: " + jogador2 + " escolheu PAR");
        }
        else if (mao_jogador2 == "impar")
        {
            Debug.Log("o jogador: " + jogador2 + " escolheu IMPAR");
        }
        */

        int resultado = numeroJogador1 + numeroJogador2;

        if (resultado % 2 == 0 && mao_jogador1 == "par" || resultado % 2 == 0 && mao_jogador2 == "par")
        {
            if(mao_jogador1 == "par")
            {
                Debug.Log("quem escolheu PAR, ganhou!, parabéns: " + jogador1);
            }
            else if (mao_jogador2 == "par")
            {
                Debug.Log("quem escolheu PAR, ganhou!, parabéns: " + jogador2);
            }
        }

        else if (resultado % 2 != 0 && mao_jogador1 == "impar" || resultado % 2 != 0 && mao_jogador2 == "impar")
        {
            if (mao_jogador1 == "impar")
            {
                Debug.Log("quem escolheu IMPAR, ganhou!, parabéns: " + jogador1);
            }
            else if (mao_jogador2 == "impar")
            {
                Debug.Log("quem escolheu IMPAR, ganhou!, parabéns: " + jogador2);
            }
        }

        //a expressão correta que eu deveria usar é == 1, mas sendo diferente de zero já é suficiente usar != 0, dividr por 2 só pode dar 1 ou 0

    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
