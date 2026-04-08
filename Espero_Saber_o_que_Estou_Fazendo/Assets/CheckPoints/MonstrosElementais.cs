using UnityEngine;

public class MonstrosElementais : MonoBehaviour
{
    // Nicholas Garcia de Souza | rm572234

    [Header("Escolha o Tipo de Monstrinho: {1(Fogo) | 2(Água) | 3(Pedra)}")]
    [SerializeField] private int Monstrinho;
    private int MonstrinhoCPU;
    private int Vitórias;
    private int VitóriasCPU;

    void Start()
    {
        // Provavelmente tem uma forma MUITO mais otimizada de fazer tudo isso, mas eu não pensei como ;-;
        if (Monstrinho == 1)
        {
            print("Você escolheu Robertinho(Fogo)!");
        }
        else if (Monstrinho == 2)
        {
            print("Você escolheu Pippi(Água)!");
        }
        else if (Monstrinho == 3)
        {
            print("Você escolheu FOGAZZA, O DEVORADOR DE DIMENSÕES INTERGALÁTICO(Pedra)!");
        }
        else
        {
            print("Essa não é uma opção... Que pena, vai para a Gulag.");
            
        }

        MonstrinhoCPU = Random.Range(1, 4);
        if (MonstrinhoCPU == 1)
        {
            print("O oponente escolheu Foguinho(Fogo)!");
        }
        else if (MonstrinhoCPU == 2)
        {
            print("O oponente escolheu Aguinho(Água)!");
        }
        else if (MonstrinhoCPU == 3)
        {
            print("O oponente escolheu Pedroso(Pedra)!");
        }

        Vitórias = 0;
        VitóriasCPU = 0;
    }

    void Update()
    {
        if (Monstrinho > 3 || Monstrinho < 1)
        {
            print("Meu querido, você NÃO vai jogar até escolher um Monstrinho válido...");
        }
        else
        {
            if (Input.anyKeyDown)
            {
                print("BATALHA!");
                if (Monstrinho == MonstrinhoCPU)
                {
                    print("Um empate! Ninguém adquire a vitória!");
                }
                else
                {
                    if (Monstrinho == 1)
                    {
                        if (MonstrinhoCPU == 2)
                        {
                            print("Fogo é apagado por água! Uma vitória para o oponente!");
                            VitóriasCPU = VitóriasCPU + 1;
                        }
                        else
                        {
                            print("Fogo EXTINGUE a pedra da existência! Uma vitória para você!");
                            Vitórias = Vitórias + 1;
                        }
                    }
                    else if (Monstrinho == 2)
                    {
                        if (MonstrinhoCPU == 1)
                        {
                            print("Água apaga fogo! Uma vitória para você!");
                            Vitórias = Vitórias + 1;
                        }
                        else
                        {
                            print("Água é...absorvida pela pedra??? Sei lá... Uma vitória para o oponente!");
                            VitóriasCPU = VitóriasCPU + 1;
                        }
                    }
                    else
                    {
                        if (MonstrinhoCPU == 1)
                        {
                            print("Pedra é derretida por fogo! Uma vitória para o oponente!");
                            VitóriasCPU = VitóriasCPU + 1;
                        }
                        else
                        {
                            print("Pedra...ocupa o espaço da água...??? Uma vitória para você!");
                            Vitórias = Vitórias + 1;
                        }
                    }
                }
                print("Placar: " + Vitórias + " - Você | Oponente - " + VitóriasCPU);

                MonstrinhoCPU = Random.Range(1, 4);
                if (MonstrinhoCPU == 1)
                {
                    print("O oponente trocou para Foguinho(Fogo)!");
                }
                else if (MonstrinhoCPU == 2)
                {
                    print("O oponente trocou para Aguinho(Água)!");
                }
                else if (MonstrinhoCPU == 3)
                {
                    print("O oponente trocou para Pedroso(Pedra)!");
                }
            }
            if (Vitórias == 3)
            {
                print("Você ganhou! Um passo mais perto de se tornar Mestre Monstrinho!");
            }
            else if (VitóriasCPU == 3)
            {
                print("Você perdeu... Mas não se preocupe, isso é só mais um passo para a vitória!");
            }
        }
    }
    /* Eu não lembro como se encerra de vez comandos... Lembro nem se você passou isso, honestamente. 
    Mas tá aí, o que minhas capacidades permitem :D */
}
