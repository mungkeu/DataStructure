namespace CSharpDataStructure.Array
{
    internal class Jagged_Array
    {
        public void Run()
        {
            int[][] A = new int[3][];

            // 각 1차 배열 요소당 서로 다른 크기의 배열을 할당할 수 있다.
            A[0] = new int[2];
            A[1] = new int[6] { 1, 2, 3, 4, 5, 6 };
            A[2] = new int[3] { 9, 8, 7 };
        }
    }
}
/*
 * 가변 배열(Jagged Array)
 * - 배열의 배열 요소가 배열 타입인 경우를 말한다.
 * - 서로 다른 차원과 크기를 갖는 배열일 수 있다.
 * - 다차원 배열의 경우 [,]로 구분 하지만, 가변 배열은 [][]와 같이 "배열의 배열"처럼
 *   사각괄호를 겹쳐서 차원을 표기한다.
 * - 일반 다차워 배열로 했을때 공간의 낭비가 심해지는 경우, 각 차원마다 다른 배열 크기를
 *   가져야 하는 경우 특히 유용하다.
 */