namespace CSharpDataStructure.Array
{
    internal class Dynamic_Array
    {
        private object[] arr = new object[0];

        /// <summary>
        /// 동적 배열을 만드는 방식(가장 간단한 방식)
        /// - 새로운 요소가 추가될 때마다 배열 크기를 하나씩 늘려가는 것이다.
        /// - 새 배열요소를 추가할 때 기존 배열(arr)의 크기보다 1개 더 큰 임시 배열(temp)를
        /// - 생성하고, 임시 배열에 모든 요소를 복사한 후, 다시 임시 배열(temp)을 기존 배열(arr)에
        /// - 할당하고, 배열 마지막 요소에서 새 배열요소를 추가한다.
        /// 
        /// 아래의 방식은 배열에 하나의 요소를 추가할 때마다 전체 기존 배열을 복사한다.
        /// 즉, 임의의 배열크기가 n 일때, n개를 복사하는 동작을 수행한다.
        /// 빅오 표기법 : O(n)
        /// </summary>
        /// <param name="element"></param>
        public void Add(object element)
        {
            var temp = new object[arr.Length + 1];
            for(int i=0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp; // 배열의 크기가 1증가.

            arr[arr.Length - 1] = element; // 추가할 데이터를 넣어준다.
        }
    }
}
/*
 * 동적 배열(Dynamic Array)
 * - 배열은 일정한 크기의 연속된 배열요소들의 집합이다.
 * - 배열의 크기는 초기화시 미리 지정된다.
 * - 정적 배열(Static Array)은 처음 지정한 고정 크기를 계속 유지한다.
 *   즉, c#에서의 기본 배열 문법인 int[], string[,] 같은 식으로 선언된 배열들은
 *   모두 정적 배열에 해당한다.
 * - 배열의 크기를 확장하거나 축소하는 기능이 필요한 경우가 있으며 이러한 기능을
 *   갖는 배열을 동적 배열(Dynamic Array)이라 한다.   
 */
