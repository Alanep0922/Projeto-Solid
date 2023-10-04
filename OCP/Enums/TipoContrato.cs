using System.ComponentModel;

namespace Solid.OCP.Violacao
{
    public enum TipoContrato
    {
        [Description("CLT")]
        Clt = 0, 
        [Description("ESTÁGIO")]
        Estagio = 1
    }
}