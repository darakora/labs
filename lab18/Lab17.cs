using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    public class CVector<T>
    {
        public List<T> Vector { get; set; }

        public CVector(List<T> vector)
        {
            Vector = vector;
        }

        ~CVector()
        {
            Vector.Clear();
        }

        public static CVector<T> operator +(CVector<T> cVector, T item)
        {
            cVector.Vector.Add(item);
            return new CVector<T>(cVector.Vector);
        }

        public static CVector<T> operator -(CVector<T> cVector, T item)
        {
            cVector.Vector.Remove(item);
            return new CVector<T>(cVector.Vector);
        }

        public static CVector<T> operator ++(CVector<T> cVector)
        {
            return cVector;
        }

        public static CVector<T> operator --(CVector<T> cVector)
        {
            return cVector;
        }


        public static CVector<T> operator *(CVector<T> cVector, CVector<T> cVector1)
        {
            List<T> res = new List<T>();
            for (int i = 0; i != cVector.Vector.Count; ++i)
            {
                if (cVector.Vector.Contains(cVector1.Vector[i]))
                {
                    res.Add(cVector1.Vector[i]);
                }
            }
            return new CVector<T>(res);
        }

        public static bool operator ==(CVector<T> cVector, CVector<T> cVector1)
        {
            return cVector.Vector.SequenceEqual(cVector1.Vector);
        }

        public static bool operator !=(CVector<T> cVector, CVector<T> cVector1)
        {
            return !cVector.Vector.SequenceEqual(cVector1.Vector);
        }

        public void Print()
        {
            foreach(var item in Vector)
            {
                Console.WriteLine(item);
            }
        }
    }
}
