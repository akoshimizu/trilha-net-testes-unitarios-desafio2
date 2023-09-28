using System;
using System.Collections.Generic;
using System.Text;

namespace Talents
{
    public class Calculadora
    {
        private string _data;
        private List<string> _listaHistorico { get; set; }

        public Calculadora(string data)
        {
            _listaHistorico = new List<string>();
            _data = data;
        }

        public int Somar(int numero1, int numero2)
        {
            var resp = numero1 + numero2;
            _listaHistorico.Insert(0, $"{numero1} + {numero2} = {resp} + data: {_data}");
            return resp;
        }

        public int Subtrair(int numero1, int numero2)
        {
            var resp = numero1 - numero2;
            _listaHistorico.Insert(0, $"{numero1} - {numero2} = {resp} + data: {_data}");
            return resp;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            var resp = numero1 * numero2;
            _listaHistorico.Insert(0, $"{numero1} * {numero2} = {resp} + data: {_data}");
            return resp;
        }

        public int Dividir(int numero1, int numero2)
        {
            var resp = numero1 / numero2;
            _listaHistorico.Insert(0, $"{numero1} / {numero2} = {resp} + data: {_data}");
            return resp;
        }

        public List<string> Historico()
        {
            _listaHistorico.RemoveRange(3, _listaHistorico.Count - 3);
            return _listaHistorico;
        }

    }
}
