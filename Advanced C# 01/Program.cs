namespace Advanced_C__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            /*
             * Generic Class: هو كلاس يتم تعريفه باستخدام معاملات نوع (Type Parameters) مثل <T>،
             * مما يسمح له بالعمل مع أي نوع بيانات دون تحديد النوع مسبقاً[cite: 5].
             * 
             * Why use Generics?
             * 1. Type Safety: اكتشاف الأخطاء وقت بناء الكود (Compile-time) بدلاً من وقت التشغيل[cite: 5].
             * 2. Performance: تحسين الأداء عبر تجنب عمليات التحويل المكلفة (Boxing & Unboxing)[cite: 5].
             * 3. Reusability: إعادة استخدام نفس الكود مع أنواع بيانات مختلفة دون تكراره[cite: 5].
             */
            #endregion

            #region Q2: Write a generic class Container<T> with Add and Get methods.
            //public class Container<T>
            //{
            //private T _item;

            //public void Add(T item)
            //{
            //    _item = item;
            //}

            //public T Get()
            //{
            //    return _item;
            //}
            //}
            #endregion

            #region Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            /*
             * Multiple Type Parameters: تعني قدرة الكلاس أو الواجهة أو الدالة على استقبال أكثر من 
             * نوع بيانات واحد في نفس الوقت (مثل T1, T2) ليتم استخدامهم داخلياً[cite: 5].
             */
            // public class Pair<TKey, TValue>
            //  {
            //public TKey Key { get; set; }
            //public TValue Value { get; set; }

            //public Pair(TKey key, TValue value)
            //{
            //    Key = key;
            //    Value = value;
            //}
            // }
            #endregion

            #region Q4: What is a generic method? Write Swap<T> method.
            /*
             * Generic Method: هي دالة تستقبل نوع بيانات (Type Parameter) خاص بها، 
             * وتعمل عليه بغض النظر عما إذا كان الكلاس الذي يحتويها Generic أم لا[cite: 5].
             */
            //public class Utility
            //    {
            //        public static void Swap<T>(ref T a, ref T b)
            //        {
            //            T temp = a;
            //            a = b;
            //            b = temp;
            //        }
            //    }
            #endregion

            #region Q5: Write a generic method FindMax<T> that finds maximum value

            //public class MathUtility
            //        {
            //            // where T : IComparable<T>  ->  شرط عشان نسمح بالمقارنة
            //            public static T FindMax<T>(T a, T b) where T : IComparable<T>
            //            {
            //                // CompareTo بترجع رقم موجب لو كانت a أكبر من b
            //                if (a.CompareTo(b) > 0)
            //                {
            //                    return a;
            //                }
            //                else
            //                {
            //                    return b;
            //                }
            //            }
            //}

            #endregion

            #region Q6: What is a generic interface? Write IRepository<T>.
            /*
             * Generic Interface: واجهة برمجية تحدد مجموعة من الدوال والمعاملات بدون تحديد نوع البيانات،
             * ليتم تحديده لاحقاً عند الـ Implementation بواسطة الكلاس المستقبل[cite: 6].
             */
            //public interface IRepository<T>
            //    {
            //        void Add(T item);
            //        T Get(int id);
            //    }
            #endregion

            #region Q7: What is the 'struct' constraint? Write an example.
            /*
             * 'struct' constraint: قيد يفرض أن يكون نوع البيانات الممرر Value Type فقط (مثل int, double, struct)[cite: 6].
             */
            //public class StructContainer<T> where T : struct
            //    {
            //        public T Value { get; set; }
            //    }
            #endregion

            #region Q8: What is the 'class' constraint? Write an example.
            /*
             * 'class' constraint: قيد يفرض أن يكون نوع البيانات الممرر Reference Type فقط (مثل class, interface, delegate, string)[cite: 6].
             */
            //public class ReferenceContainer<T> where T : class
            //    {
            //        public T Item { get; set; }
            //    }
            #endregion

            #region Q9: What is the 'new()' constraint? Write an example.
            /*
             * 'new()' constraint: قيد يفرض أن يحتوي النوع الممرر على Parameterless Constructor،
             * مما يسمح بإنشاء نسخة جديدة من النوع داخل الكلاس باستخدام new T()[cite: 6].
             */
            //public class Creator<T> where T : new()
            //    {
            //        public T CreateInstance()
            //        {
            //            return new T();
            //        }
            //    }
            #endregion

            #region Q10: What is the interface constraint? Write an example.
            /*
             * Interface constraint: قيد يشترط أن يكون النوع الممرر يطبق (Implements) واجهة برمجية محددة[cite: 6].
             */
            //public class Processor<T> where T : IDisposable
            //    {
            //        public void Process(T item)
            //        {
            //            item.Dispose();
            //        }
            //    }
            #endregion

            #region Q11: What is the base class constraint? Write an example.
            /*
             * Base class constraint: قيد يشترط أن يكون النوع الممرر إما الكلاس الأساسي نفسه أو يرث منه[cite: 6].
             */
            //public class Entity { public int Id { get; set; } }

            //    public class EntityManager<T> where T : Entity
            //    {
            //        public void PrintId(T entity)
            //        {
            //            Console.WriteLine(entity.Id);
            //        }
            //    }
            #endregion

            #region Q12: How do you apply multiple constraints? Write an example.
            /*
             * Multiple Constraints: يتم تطبيق أكثر من قيد بيفصل بينهم بفاصلة (,) مع مراعاة الترتيب
             * (الـ class أو struct يوضع أولاً، ثم الـ interfaces، ويكون new() في النهاية دائماً)[cite: 6].
             */
            //public class CustomManager<T> where T : class, IComparable<T>, new()
            //    {
            //        public T CreateAndCompare(T other)
            //        {
            //            T newItem = new T();
            //            return newItem.CompareTo(other) > 0 ? newItem : other;
            //        }
            //    }
            #endregion
    }
}
}
