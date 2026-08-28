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
    }
}
}
