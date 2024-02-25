using static System.Console;
namespace DSA_CourseSheet.Generic
{
    public class GenericCollection
    {
        public void genericTypeMethod()
        {
            bool intEqual = areEqual(4, 4);
            bool strEqual = areEqual("India", "Pakistan");
            bool doubleEqual = areEqual(32.3, 32.1);
            bool objEqual = areEqual(new object(), new object());
            WriteLine("\nint {0} \n string {1} \n double {2} \n object {3}", intEqual, strEqual, doubleEqual, objEqual);
        }
        public bool areEqual<T>(T a, T b)
        {
            return a!.Equals(b);
        }
        public void listCollection()
        {

        }
        public void sortedListCollection()
        {

        }
        public void stackCollection()
        {

        }
        public void queueCollection()
        {

        }
        public void linkedListCollection()
        {

        }
        public void hashSetCollection()
        {

        }
        public void sortedSetCollection()
        {

        }
        public void dictionaryCollection()
        {

        }
        public void sortedDictionaryCollection()
        {

        }

    }
}
