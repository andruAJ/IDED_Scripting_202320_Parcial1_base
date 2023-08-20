using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> result = null;
            int elementoActual;
            List<int> lista = new List<int>();
            int numMayor;
            int i = 3;

            foreach (int elemento in sourceStack)
            {
                elementoActual = elemento;
                lista.add(elementoActual);
            }
            foreach (int elem in sourceStack) 
            {
                numMayor = -1;
                foreach(int num in lista)
                {
                    if(num != elem) 
                    {
                        if (num > elem) 
                        {
                            numMayor = num;
                        }
                        lista[i] = numMayor;
                        i = i - 1;
                    }
                }
            
            }

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}