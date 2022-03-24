namespace CSharpDataStructure.Array
{
    // Dynamic_Array.cs의 동적 배열은 O(n)으로 비효율적이다.
    // 이를 해결하기 위해 흔히 사용하는 동적 배열의 구현 방식은
    // 배열을 2배씩 확장하는 것이다.

    /// <summary>
    /// 아래의 방식의 O(1)인 이유는 1~16까지는 즉시 추가되고 17에서 16개의 요소 복사가 일어난다.
    /// 이런 16개의 복사 수행시간을 기존 첫 요소부터 16번까지의 수행시간에 분할하여 분산하면,
    /// O(1)*2이 되어 결국 수행시간은 O(1)이 된다.
    /// 
    /// 이러한 분석으로 하나씩 증가보다 2배 혹은 1.5배로 증가하는 방식으 훨씬 효율적임을 알 수 있다.
    /// </summary>
    internal class Dynamic_Array2
    {
        private object[] arr;

        // 배열이 꽉찼을 경우 얼마나 확장할지.
        private const int GROWTH_FACTOR = 2; // 2배.

        // 현재 배열의 요소
        public int Count { get; private set; }

        // 배열의 최대 수용가능 용량
        public int Capacity { get => arr.Length; } 
        public Dynamic_Array2(int capacity = 16)
        {
            // 생성시 초기 크기로 16.
            arr = new object[capacity];
            Count = 0;
        }

        public void Add(object element)
        {
            // 배열이 가득 찼을 경우 확장
            if(Count >= Capacity)
            {
                int newSize = Capacity * GROWTH_FACTOR;
                var temp = new object[newSize];
                for(int i=0; i< arr.Length; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
            }
            arr[Count] = element;
            Count++;
        }

        public object Get(int index)
        {
            // 현재 배열의 크기보다 큰 경우.
            if(index > Capacity-1)
            {
                throw new ApplicationException("Element not found");
            }
            return arr[index];
        }
    }
}
