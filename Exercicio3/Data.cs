using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Data
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public Data(int dia, int mes, int ano)
        {
            if (VerificarAno(ano))
            {
                Ano = ano;
            }
            if (VerificarMes(mes))
            {
                Mes = mes;
            }
            if (VerificarDia(dia))
            {
                Dia = dia;
            }

        }

        public bool VerificarMes(int mes)
        {
            if(mes < 0 || mes > 12)//Verificação se o mês pode existir
            {
                throw new ArgumentException("Erro na passagem do parametro mes", nameof(mes));
            }
            
            return true;
        }

        public bool VerificarDia(int dia)
        {
            if(dia < 0 || dia > 31)//Verificação se o dia pode existir
            {
                throw new ArgumentException("Erro na passagem do parametro dia", nameof(dia));
            }

            if(Mes == 2)
            {
                if(Ano%4 == 0 && Ano%100 != 0)//Verificação de ano bissexto
                {
                    if(dia > 29)//Fevereiro ano bissexto
                    {
                        throw new ArgumentException("Como o ano é bissexto, fevereiro possui no máximo 29 dias", nameof(dia));
                    }
                    
                    return true;
                }
                else
                {
                    if(dia > 28) //Fevereiro não ano bissexto
                    {
                        throw new ArgumentException("Esso ano não é bissexto, portanto fevereiro possui no máximo 28 dias", nameof(dia));
                    }
                    return true;
                }
            }
            else if((Mes < 8 && Mes%2 == 1) || (Mes>7 && Mes%2 == 0)) //Meses de 31 dias
            {
                return true;
            }
            else
            {
                if(dia > 30)
                {
                    throw new ArgumentException("Esso mes possui no máximo 30 dias", nameof(dia)); //Meses de 30 dias
                }
                return true;
            }
        }

        public bool VerificarAno(int ano)
        {
            if(ano < 1)
            {
                throw new ArgumentException("O ano não pode ser 0 ou negativo", nameof(ano));
            }
            return true;
        }

        public void ImprimirData()
        {
            Console.WriteLine(Dia + "/" + Mes + "/" + Ano);
        }

        public static Data VerificarMaiorData(Data data1, Data data2)
        {
            if (data1.Ano > data2.Ano)
            {
                return data1;
            }
            else if (data2.Ano > data1.Ano)
            {
                return data2;
            }
            else if (data1.Mes > data2.Mes)
            {
                return data1;
            }
            else if (data2.Mes > data1.Mes)
            {
                return data2;
            }
            else if (data1.Dia > data2.Dia)
            {
                return data1;
            }
            else if(data2.Dia > data1.Dia)
            {
                return data2;
            }
            else
            {
                throw new ArgumentException("As datas são iguais");
            }
        }

        public void AdicionarDias()
        {
            Dia++;
            if((Mes < 8 && Mes % 2 == 1) || (Mes > 7 && Mes % 2 == 0))//Para mês de 31 dias
            {
                if(Dia > 31)
                {
                    Dia -= 31;
                    Mes++;
                    if(Mes > 12)
                    {
                        Ano++;
                        Mes -= 12;
                    }
                }
            }
            else if(Mes == 2) //Para fevereiro
            {
                if(Ano % 4 == 0 && Ano % 100 != 0)
                {
                   if(Dia > 29)
                    {
                        Dia -= 29;
                        Mes++;
                    }
                }
                else
                {
                    if(Dia > 28)
                    {
                        Dia -= 28;
                        Mes++;
                    }
                }
            }
            else
            {
                if(Dia > 30)
                {
                    Dia -= 30;
                    Mes++;
                }
            }

        }


    }
}
