using System;

namespace ResistanceColor
{
    public class Program
    {
        public static void Main(string[] args) { }

        public enum colorValue
        {
            black = 0,
            brown,
            red,
            orange,
            yellow,
            green,
            blue,
            violet,
            grey,
            white
        }

        public enum multiplierEnum
        {
            black = 1,
            brown = 10,
            red = 100,
            orange = 1000,
            yellow = 10000,
            green = 100000,
            blue = 1000000,
            violet = 10000000,
        }

        public static int ColorToValue(string color)
        {
            string value = "";
            string[] colors = color.Split(' ');

            for (int i = 0; i < colors.Length - 1; i++)
            {
                switch (colors[i])
                {
                    case "black":
                        value += (int) colorValue.black;
                        break;

                    case "brown":
                        value += (int)colorValue.brown;
                        break;

                    case "red":
                        value += (int)colorValue.red;
                        break;

                    case "orange":
                        value += (int)colorValue.orange;
                        break;

                    case "yellow":
                        value += (int)colorValue.yellow;
                        break;

                    case "green":
                        value += (int)colorValue.green;
                        break;

                    case "blue":
                        value += (int)colorValue.blue;
                        break;

                    case "violet":
                        value += (int)colorValue.violet;
                        break;

                    case "grey":
                        value += (int)colorValue.grey;
                        break;

                    case "white":
                        value += (int)colorValue.white;
                        break;
                }
            }

            int output = 0;

            try
            {
                output = Convert.ToInt32(value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            int multiplier = 0;
            switch (colors[colors.Length - 1])
            {
                case "black":
                    multiplier = (int)multiplierEnum.black;
                    break;

                case "brown":
                    multiplier = (int)multiplierEnum.brown;
                    break;

                case "red":
                    multiplier = (int)multiplierEnum.red;
                    break;

                case "orange":
                    multiplier = (int)multiplierEnum.orange;
                    break;

                case "yellow":
                    multiplier = (int)multiplierEnum.yellow;
                    break;

                case "green":
                    multiplier = (int)multiplierEnum.green;
                    break;

                case "blue":
                    multiplier = (int)multiplierEnum.blue;
                    break;

                case "violet":
                    multiplier = (int)multiplierEnum.violet;
                    break;
            }

            return output * multiplier;
        }

        public static string ValueToColor(int value)
        {
            string output = "";
            string input = value.ToString();

            for (int i = 0; i < 3; i++)
            {
                switch (input[i])
                {
                    case '0':
                        output += colorValue.black.ToString() + " ";
                        break;

                    case '1':
                        output += colorValue.brown.ToString() + " ";
                        break;

                    case '2':
                        output += colorValue.red.ToString() + " ";
                        break;

                    case '3':
                        output += colorValue.orange.ToString() + " ";
                        break;

                    case '4':
                        output += colorValue.yellow.ToString() + " ";
                        break;

                    case '5':
                        output += colorValue.green.ToString() + " ";
                        break;

                    case '6':
                        output += colorValue.blue.ToString() + " ";
                        break;

                    case '7':
                        output += colorValue.violet.ToString() + " ";
                        break;

                    case '8':
                        output += colorValue.grey.ToString() + " ";
                        break;

                    case '9':
                        output += colorValue.white.ToString() + " ";
                        break;
                }
            }

            input = input.Substring(3);

            switch (input.Length)
            {
                case 0:
                    output += multiplierEnum.black.ToString();
                    break;

                case 1:
                    output += multiplierEnum.brown.ToString();
                    break;

                case 2:
                    output += multiplierEnum.red.ToString();
                    break;

                case 3:
                    output += multiplierEnum.orange.ToString();
                    break;

                case 4:
                    output += multiplierEnum.yellow.ToString();
                    break;

                case 5:
                    output += multiplierEnum.green.ToString();
                    break;

                case 6:
                    output += multiplierEnum.blue.ToString();
                    break;

                case 7:
                    output += multiplierEnum.violet.ToString();
                    break;
            }



            return output;
        }
    }
}