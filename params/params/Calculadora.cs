namespace paramsTest
{
    internal class Calculadora {


        // Params
        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {

                sum += numbers[i];

            }
            return sum;
        }

        // Ref

        public static void Triple(ref int x) {
            x *= 3;
        }

        // Out

        public static void Double(int x,out int result) {
            result = x * 2;
        }
}
}
