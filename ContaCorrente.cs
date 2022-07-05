/**********************************************************************************************************************\
    - metodos são ações
    - atributos são características
\**********************************************************************************************************************/

//classe
public class ContaCorrente 
{
    // tipo do modificador de acesso [publico ou privado], tipo [nº inteiro, nº quebrado, letra], nome [nome do objeto] 
    public string Titular; 
    public int Agencia;
    public int Numero;
    public double Saldo;

    // construtor: o mesmo nome da classe
    public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo) { 
        
        //this é a representação de um objeto: não é de alguém especifico.
        this.Titular = Titular;
        this.Agencia = Agencia;
        this.Numero = Numero;
        this.Saldo = Saldo; 

    } 
    public bool Sacar( double valorSaque )
    { 
        if(this.Saldo >= valorSaque){
            this.Saldo = this.Saldo - valorSaque ;
            return true;
        }
            return false;
    }
}