﻿using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefa 
    {
        [Description("A fazer")]
        Afazer = 1,
        [Description("Em andamento")]
        Andamento = 2,
        [Description("Concluido")]
        Concluido = 3,
    }
}
