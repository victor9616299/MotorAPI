using Dominio;
using System.Collections.Generic;

namespace DataAccess.Repositorios.Contratos
{
    public interface IMotorRepositorio
    {
        void AdicionarMotor(Motor motor);
        void AtualizarMotor(Motor motor);
        void RemoverMotor(Motor motor);
        IEnumerable<Motor> ListarTodos();
        Motor ObterPorId(int motorID);
    }
}