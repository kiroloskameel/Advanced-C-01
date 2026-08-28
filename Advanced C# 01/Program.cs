namespace Advanced_C__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            /*
             * Generic Class: هو كلاس يتم تعريفه باستخدام معاملات نوع (Type Parameters) مثل <T>،
             * مما يسمح له بالعمل مع أي نوع بيانات دون تحديد النوع مسبقاً.
             * 
             * Why use Generics?
             * 1. Type Safety: اكتشاف الأخطاء وقت بناء الكود (Compile-time) بدلاً من وقت التشغيل.
             * 2. Performance: تحسين الأداء عبر تجنب عمليات التحويل المكلفة (Boxing & Unboxing).
             * 3. Reusability: إعادة استخدام نفس الكود مع أنواع بيانات مختلفة دون تكراره.
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
             * نوع بيانات واحد في نفس الوقت (مثل T1, T2) ليتم استخدامهم داخلياً.
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
             * وتعمل عليه بغض النظر عما إذا كان الكلاس الذي يحتويها Generic أم لا.
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
             * ليتم تحديده لاحقاً عند الـ Implementation بواسطة الكلاس المستقبل.
             */
            //public interface IRepository<T>
            //    {
            //        void Add(T item);
            //        T Get(int id);
            //    }
            #endregion

            #region Q7: What is the 'struct' constraint? Write an example.
            /*
             * 'struct' constraint: قيد يفرض أن يكون نوع البيانات الممرر Value Type فقط (مثل int, double, struct).
             */
            //public class StructContainer<T> where T : struct
            //    {
            //        public T Value { get; set; }
            //    }
            #endregion

            #region Q8: What is the 'class' constraint? Write an example.
            /*
             * 'class' constraint: قيد يفرض أن يكون نوع البيانات الممرر Reference Type فقط (مثل class, interface, delegate, string).
             */
            //public class ReferenceContainer<T> where T : class
            //    {
            //        public T Item { get; set; }
            //    }
            #endregion

            #region Q9: What is the 'new()' constraint? Write an example.
            /*
             * 'new()' constraint: قيد يفرض أن يحتوي النوع الممرر على Parameterless Constructor،
             * مما يسمح بإنشاء نسخة جديدة من النوع داخل الكلاس باستخدام new T().
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
             * Interface constraint: قيد يشترط أن يكون النوع الممرر يطبق (Implements) واجهة برمجية محددة.
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
             * Base class constraint: قيد يشترط أن يكون النوع الممرر إما الكلاس الأساسي نفسه أو يرث منه.
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
             * (الـ class أو struct يوضع أولاً، ثم الـ interfaces، ويكون new() في النهاية دائماً).
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

            #region Q13: What does the 'default' keyword do in generics?
            /*
             * 'default' Keyword: تقوم بإعادة القيمة الافتراضية للنوع؛ 
             * فترجع null إذا كان النوع Reference Type، وترجع 0 أو false إذا كان Value Type.
             */
            #endregion

            #region Q15: What is covariance? Explain the 'out' keyword.
            /*
             * Covariance: تسمح باستبدال النوع المتوقع بنوع أثر تخصيصاً (Derived Type)،
             * وتستخدم الكلمة المفتاحية 'out' لتحديد أن معمل النوع يمرر كمُخرج (Return Type) فقط.
             */
            //public interface ICovariant<out T>
            //    {
            //        T GetItem();
            //    }
            #endregion

            #region Q16: What is contravariance? Explain the 'in' keyword.
            /*
             * Contravariance: تسمح باستبدال النوع المتوقع بنوع أكثر عمومية (Base Type)،
             * وتستخدم الكلمة المفتاحية 'in' لتحديد أن معامل النوع يمرر كمُدخل (Parameter) فقط.
             */
            //public interface IContravariant<in T>
            //    {
            //        void SetItem(T item);
            //    }
            #endregion

            #region Q17: What is the difference between covariance and contravariance?
            /*
             * Difference:
             * 1. Covariance (out): تعود بالبيانات (Output) وتتيح إسناد Derived إلى Base.
             * 2. Contravariance (in): تستقبل البيانات (Input) وتتيح إسناد Base إلى Derived.
             */
            #endregion

            #region Q18: How do static members work in generic types?
            /*
             * Static members in generic types:
             * يتم إنشاء نسخة مستقلة من الأعضاء الـ static لكل closed type مختلف؛
             * فمثلاً GenericClass<int> يمتلك نسخة static مختلفة تماماً عن GenericClass<string>.
             */
            #endregion

            #region Q19: How can you inherit from a generic class?
            /*
             * طرق الوراثة من Generic Class:
             * 1. أن يظل الكلاس الابن Generic أيضاً: class Child<T> : Parent<T>
             * 2. أن يحدد الكلاس الابن نوعاً معيناً للكلاس الأب: class Child : Parent<int>
             */
            #endregion

            #region Q20: Complete Exercise - Create a generic Cache<TKey, TValue> with Add, Get, Remove, Contains, and expiration support.
    //public class CacheItem<TValue>
    //    {
    //        public TValue Value { get; set; }
    //        public DateTime ExpirationTime { get; set; }
    //    }

    //    public class Cache<TKey, TValue>
    //    {
    //        private readonly Dictionary<TKey, CacheItem<TValue>> _cache = new Dictionary<TKey, CacheItem<TValue>>();

    //        public void Add(TKey key, TValue value, TimeSpan duration)
    //        {
    //            _cache[key] = new CacheItem<TValue>
    //            {
    //                Value = value,
    //                ExpirationTime = DateTime.Now.Add(duration)
    //            };
    //        }

    //        public TValue Get(TKey key)
    //        {
    //            if (_cache.TryGetValue(key, out var item))
    //            {
    //                if (DateTime.Now <= item.ExpirationTime)
    //                {
    //                    return item.Value;
    //                }
    //                _cache.Remove(key); 
    //            }
    //            return default;
    //        }

    //        public void Remove(TKey key)
    //        {
    //            _cache.Remove(key);
    //        }

    //        public bool Contains(TKey key)
    //        {
    //            if (_cache.TryGetValue(key, out var item))
    //            {
    //                if (DateTime.Now <= item.ExpirationTime)
    //                {
    //                    return true;
    //                }
    //                _cache.Remove(key);
    //            }
    //            return false;
    //        }
    //    }
         #endregion
    }
}
}
