using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleViews.Helper
{
    /// <summary>
    /// http://dotnetpattern.com/csharp-generics
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class GenericList<T> where T : struct // value types allowed
    {
        private List<T> nodeList;

        public List<T> NodeList { get => nodeList; set => nodeList = value; }

        public GenericList()
        {
            NodeList = new List<T>();
        }

        public void AddEntry(T item)
        {
            NodeList.Add(item);
        }

        public void DeleteEntry(T item)
        {
            NodeList.Remove(item);
        }
    }
}
