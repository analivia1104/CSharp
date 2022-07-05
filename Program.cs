using System;

namespace FirstProgram //nome do arquivo ".csproj"
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_da_Barbara = new ContaCorrente ("Barbara", 12345, 789, 10 ) ;
            ContaCorrente conta_da_ana = new ContaCorrente ("Ana",12345, 215, 1200 ) ;
            ContaCorrente conta_da_jessica = new ContaCorrente ("Jessica", 12345, 858, -598454) ;

            Console.WriteLine ("A conta é do (a) " + conta_da_Barbara.Titular + 
            ", a agência é " + conta_da_Barbara.Agencia + ", o nº é " + conta_da_Barbara.Numero + "e o saldo é de: "
            + conta_da_Barbara.Saldo + ".") ;
            Console.WriteLine ("A conta é do (a) " + conta_da_ana.Titular + 
            ", a agência é " + conta_da_ana.Agencia + " e o nº é " + conta_da_ana.Numero + "e o saldo é de: "
            + conta_da_ana.Saldo + ".") ;
            Console.WriteLine ("A conta é do (a) " + conta_da_jessica.Titular + 
            ", a agência é " + conta_da_jessica.Agencia + ", o nº é " + conta_da_jessica.Numero + "e o saldo é de: "
            + conta_da_jessica.Saldo + ".") ;

            bool sacar_conta1 = conta_da_Barbara.Sacar(100);
            bool sacar_conta2 = conta_da_ana.Sacar(100);
            bool sacar_conta3 = conta_da_jessica.Sacar(100);

            Console.WriteLine ("A conta é do (a) " + conta_da_Barbara.Titular + 
            ", a agência é " + conta_da_Barbara.Agencia + ", o nº é " + conta_da_Barbara.Numero + "e o saldo é de: "
            + conta_da_Barbara.Saldo + ".") ;
            Console.WriteLine ("A conta é do (a) " + conta_da_ana.Titular + 
            ", a agência é " + conta_da_ana.Agencia + " e o nº é " + conta_da_ana.Numero + "e o saldo é de: "
            + conta_da_ana.Saldo + ".") ;
            Console.WriteLine ("A conta é do (a) " + conta_da_jessica.Titular + 
            ", a agência é " + conta_da_jessica.Agencia + ", o nº é " + conta_da_jessica.Numero + "e o saldo é de: "
            + conta_da_jessica.Saldo + ".") ;
        }
    }
}
