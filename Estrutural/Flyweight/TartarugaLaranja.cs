﻿using System;

namespace Flyweight
{
    public class TartarugaLaranja : Tartaruga
    {
        public TartarugaLaranja()
        {
            this.Condicao = "tartaruga dentro do casco, ";
            this.Acao = "rodando no chão - ";
        }
        public override void Mostra(string cor)
        {
            this.Cor = cor;
            Console.WriteLine(Condicao + Acao + cor.ToUpper());
        }
    }
}
