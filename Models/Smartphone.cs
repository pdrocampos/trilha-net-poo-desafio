namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Model {get; set; }
        public string IMEI {get; set; }
        public int Memoria {get; set; }

        public Smartphone(string numero, string model, string imei, int memoria)
        {
            Numero = numero;
            Model = model;
            IMEI = imei; 
            Memoria = memoria;   
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}