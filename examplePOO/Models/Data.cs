namespace examplePOO.Models
{
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
            }
        }
        
    }
}