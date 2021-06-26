using System;
using System.Collections.Generic;

namespace Sorting 
{
    class Queue<T>
    {
        private class Element
        {
            public T key { get; set; }
            public Element next { get; set; }
            public Element(T key, Element next = null)
            {
                this.key = key;
                this.next = next;
            }
        }

        private Element head = null;
        private Element tail = null;

        private bool isEmpty => head==null && tail==null;

        public void Enqueue(T data) 
        {
            if(isEmpty)
            {
                Element element = new Element(data);
                head = element;
                tail = element;
            }
            else 
            {
                Element element = new Element(data);
                tail.next = element;
                tail = element;
            }
        }

        public T Dequeue()
        {
            if(isEmpty)
            {
                throw new Exception("Queue is empty!");
            }
            else
            {
                Element element = head;
                head = head.next;
                return element.key;
            }
        }

        public T Peek()
        {
            if(isEmpty)
            {
                throw new Exception("Queue is empty!");
            }
            else
            {
                return head.key;
            }
        }

        public bool Contains(T data)
        {
            if(isEmpty)
            {
                throw new Exception("Queue is empty!");
            }
            else
            {
                Element element = head;
                while(element != null)
                {
                    if(element.key.Equals(data))
                    {
                        return true;
                    }
                    element = element.next;
                }
                return false;
            }
        }

        public void Clear()
        {
            head = tail = null;
        }
    }
}
