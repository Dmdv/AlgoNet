namespace AlgoNet.Types
{
	public class BaseHeap
	{
		protected int Parent(int i)
		{
			return i/2;
		}

		protected int Left(int i)
		{
			return 2*i;
		}

		protected int Right (int i)
		{
			return 2*i + 1;
		}
	}
}