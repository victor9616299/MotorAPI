namespace Dominio
{
    // Atividade: Criação de uma Entidade no Domínio
    // Nome completo: VICTOR HUGO FERREIRA ALVES
    // Data de realização: 02/09/2026
    //
    // A entidade Sensor representa um sensor do sistema e contém os dados
    // necessários para que ele possa ser armazenado posteriormente no banco de dados.
    public class Sensor
    {
        // Identificador único do sensor. Será utilizado como chave primária.
        public int IdSensor { get; set; }

        // Nome utilizado para identificar o sensor no sistema.
        public string NomeSensor { get; set; }
    }
}
