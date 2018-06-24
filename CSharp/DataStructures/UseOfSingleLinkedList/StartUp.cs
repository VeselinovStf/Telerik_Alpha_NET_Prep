using DynamicList;

namespace UseOfSingleLinkedList
{
    public class StartUp
    {
        public static void Main()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
        }
    }
}