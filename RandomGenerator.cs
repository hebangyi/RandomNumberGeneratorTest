using System.Security.Cryptography;
using System.Text;

namespace RandomNumberGeneratorTest
{
    public static class RandomGenerator
    {
        private static char[] m_charArr = new char []
        {
            'A','B', 'C','D','E','F','G','H','J','K','L','M',
            'N','P','Q','R','S','T','U','V','W','X','Y','Z',
            '2','3','4','5','6','7','8','9'
        };

        public static char RandomChar()
        {
            int index = RandomNumberGenerator.GetInt32(0, m_charArr.Length);
            return m_charArr[index];
        }

        public static string RandomStr(int size)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                sb.Append(RandomChar());
            }
            return sb.ToString();
        }
        
    }
}