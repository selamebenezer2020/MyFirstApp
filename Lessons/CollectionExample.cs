using System.Collections;
using System;
using System.Collections.Generic; //Another class(collection)
namespace Lessons
{
    public class CollectionExample
    {
        public void MyListExample()
        {
            List<Dinosaur> myDino = new List<Dinosaur>();
            myDino.Add(new TRex());
            myDino.Add(new TRex() { Travel = "Stomp" });
            myDino.Add(new Triceratops() { Travel = "Trample" });

            foreach (Dinosaur dino in myDino)
            {
                Console.WriteLine("This dino travel by{0}", dino.Travel);
                Console.WriteLine(dino);
            }
        }



        public void MyArrayListExample()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add("World");
            arrayList.Add(50);
            arrayList.Add(250);

            Console.WriteLine("Count = " + arrayList.Count);

            arrayList.Remove(50);
            arrayList.RemoveAt(0);

            arrayList.Add("Other");
            arrayList.Add("Stuff");


            foreach (Object item in arrayList)
            {
                Console.WriteLine("type = " + item);
            }
        }


    }
}