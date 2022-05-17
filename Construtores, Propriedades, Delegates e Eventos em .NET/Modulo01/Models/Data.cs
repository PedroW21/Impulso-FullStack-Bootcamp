public class Data
{
    private int mes;
    private bool mesValido;

    public int GetMes()
    {
        return this.mes;
    }

    public void SetMes(int mes)
    {
        if (mes > 0 && mes <= 12)
        {
            this.mes = mes;
            this.mesValido = true;
        }

    }
    
    // Outro meio de fazer o get e set
    public int Mes 
    { 
        get
        {
            return this.mes;
        } 
        set
        {
            if(value > 0 && value <= 12)
            {
                this.mes = value;
                this.mesValido = true;
            }
        } 
    }

    public void MostraMesValido()
    {
        if (this.mesValido == true)
        {
            Console.WriteLine(this.mes);
        }
        else
        {
            Console.WriteLine("Valor inválido meliante!");
        }
    }
}
