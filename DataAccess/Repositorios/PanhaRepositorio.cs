using DataAccess.Repositorios.Contratos;
using Dominio;

namespace DataAccess.Repositorios
{
    public class MotorRepositorio : IMotorRepositorio
    {
        private readonly Contexto _contexto;

        public MotorRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Motor ObterPorId(int motorID)
        {
            return _contexto.Motores.FirstOrDefault(motor => motor.IdMotor == motorID);
        }

        public void AdicionarMotor(Motor motor)
        {
            _contexto.Motores.Add(motor);
            _contexto.SaveChanges();
        }

        public void AtualizarMotor(Motor motor)
        {
            _contexto.Motores.Update(motor);
            _contexto.SaveChanges();
        }

        public void RemoverMotor(Motor motor)
        {
            _contexto.Motores.Remove(motor);
            _contexto.SaveChanges();
        }

        public IEnumerable<Motor> ListarTodos()
        {
            return _contexto.Motores.ToList();
        }
    }
}