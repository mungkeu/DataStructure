namespace CSharpDataStructure.Array
{
    internal class Circular_Array
    {
        public void Run()
        {
            char[] A = "abcdefgh".ToCharArray();
            int startIndex = 2;

            for (int i = 0; i < A.Length; i++)
            {
                int index = (startIndex + i) % A.Length;
                Console.Write(A[index]);
            }
        }
    }
}

/*
 * 원형 배열(Circular Array)
 * - 고정된 크기의 배열을 마치 양 끝이 연결된 것처럼 사용할 수 있게 한 자료구조.
 * - 원형 버퍼(Circular Buffer), 링 버퍼(Ring Buffer)라고도 한다.
 * - 즉, 배열의 크기가 N일 때, 배열의 마지막 요소(N-1)에 도착하면, 다음 배열 요소는
 *   첫번째 요소(O)로 순환하는 구조이다.
 * 
 * - 원형 배열은 FIFO 구조의 데이터 버퍼에 적합하다.
 * - 비원형 배열은 LIFO 구조의 데이터 버퍼에 적합하다.
 * 
 * - 원형 배열은 FIFO 구조를 가진 큐(Queue)를 구현하거나 데이터 스트림 버퍼 등을
 *   구현할 때 흔히 사용된다.
 * 
 * - 배열 자체는 고정된 크기를 갖는 일반 배열과 동일하지만, 배열 인덱스를 증가시킬 때
 *   mod 연산자를 사용하여 마지막 배열의 다음 인덱스가 첫 배열 인덱스로 돌아오게 한다.
 *   
 *   index = (index+1) % A.Length;
 *   
 *   위의 식대로 하면 (7 + 1) % 8 = 0으로 A[0]배열 요소로 이동하게 된다.
 */