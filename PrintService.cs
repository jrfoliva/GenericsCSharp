namespace GenericsCSharp
{
    internal class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is Full!");
            }
            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty!");
            }
            return _values[0];
        }

        public void Print()
        {
            string aux = "[";
            for (int i = 0; i < _count; i++)
            {
                aux += _values[i].ToString();
                if (i < _count - 1)
                {
                    aux += ", ";
                }
                else
                {
                    aux += "]";
                }
            }
            Console.WriteLine(aux);
        }
    }
}
