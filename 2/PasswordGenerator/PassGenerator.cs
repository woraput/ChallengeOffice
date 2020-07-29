using System;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    public class PassGenerator
    {
        private static Random random = new Random();
        private static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public bool PassGen14Test(string result)
        {
            var upper = 3;
            var lower = 3;
            var numberUniqe = 5;
            var checkDupicate = true;
            var countNum = 0;
            var asciiByte = Encoding.ASCII.GetBytes(result);
            var lstDupUpper = asciiByte.Where(it => it >= 65 && it <= 90).ToList();
            var lstDupLower = asciiByte.Where(it => it >= 97 && it <= 122).ToList();
            var countUpper = lstDupUpper.Count();
            var countLower = lstDupLower.Count();

            for (int i = 0; i < lstDupUpper.Count() - 1; i++)
            {
                if (lstDupUpper[i] == lstDupUpper[i + 1]) checkDupicate = false;
            }
            for (int i = 0; i < lstDupLower.Count() - 1; i++)
            {
                if (lstDupLower[i] == lstDupLower[i + 1]) checkDupicate = false;
            }
            foreach (var item in result)
            {
                var chr = 0;
                if (int.TryParse(item.ToString(), out chr)) countNum++;
            }

            return ((countUpper <= upper) && (countLower <= lower) && (countNum <= numberUniqe) && (countNum > 0) && (countUpper > 0) && (countLower > 0) && checkDupicate);
        }

        public bool PassGen24Test(string result)
        {
            var upper = 3;
            var lower = 0;
            var numberUniqe = 6;
            var countUpper = 0;
            var countLower = 0;
            var countNum = 0;
            var checkDupicate = true;

            var asciiByte = Encoding.ASCII.GetBytes(result);
            var lstDupUpper = asciiByte.Where(it => it >= 65 && it <= 90).ToList();
            var lstDupLower = asciiByte.Where(it => it >= 97 && it <= 122).ToList();
            countUpper = lstDupUpper.Count();
            countLower = lstDupLower.Count();

            for (int i = 0; i < lstDupUpper.Count() - 1; i++)
            {
                if (lstDupUpper[i] == lstDupUpper[i + 1]) checkDupicate = false;
            }

            foreach (var item in result)
            {
                var chr = 0;
                if (int.TryParse(item.ToString(), out chr)) countNum++;
            }

            return ((countUpper <= upper) && (countLower <= lower) && (countNum <= numberUniqe) && (countNum > 0) && (countUpper > 0) && checkDupicate);


        }
        public string PassGen1()
        {
            var result = "";
            var upper = 3;
            var lower = 3;
            var numberUniqe = 5;
            var countUpper = 0;
            var countLower = 0;
            var countNum = 0;
            var checkDupicate = true;
            do
            {
                countUpper = 0;
                countLower = 0;
                countNum = 0;
                result = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
                var asciiByte = Encoding.ASCII.GetBytes(result);
                var lstDupUpper = asciiByte.Where(it => it >= 65 && it <= 90).ToList();
                var lstDupLower = asciiByte.Where(it => it >= 97 && it <= 122).ToList();
                countUpper = lstDupUpper.Count();
                countLower = lstDupLower.Count();

                for (int i = 0; i < lstDupUpper.Count() - 1; i++)
                {
                    if (lstDupUpper[i] == lstDupUpper[i + 1]) checkDupicate = false;
                }

                for (int i = 0; i < lstDupLower.Count() - 1; i++)
                {
                    if (lstDupLower[i] == lstDupLower[i + 1]) checkDupicate = false;
                }

                foreach (var item in result)
                {
                    var chr = 0;
                    if (int.TryParse(item.ToString(), out chr)) countNum++;
                }
            }

            while (!((countUpper <= upper) && (countLower <= lower) && (countNum <= numberUniqe) && (countNum > 0) && (countUpper > 0) && (countLower > 0) && checkDupicate));


            return result;
        }

        public string PassGen2()
        {
            var result = "";
            var upper = 3;
            var lower = 0;
            var numberUniqe = 6;
            var countUpper = 0;
            var countLower = 0;
            var countNum = 0;
            var checkDupicate = true;
            do
            {
                countUpper = 0;
                countLower = 0;
                countNum = 0;
                result = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
                var asciiByte = Encoding.ASCII.GetBytes(result);
                var lstDupUpper = asciiByte.Where(it => it >= 65 && it <= 90).ToList();
                var lstDupLower = asciiByte.Where(it => it >= 97 && it <= 122).ToList();
                countUpper = lstDupUpper.Count();
                countLower = lstDupLower.Count();

                for (int i = 0; i < lstDupUpper.Count() - 1; i++)
                {
                    if (lstDupUpper[i] == lstDupUpper[i + 1]) checkDupicate = false;
                }

                foreach (var item in result)
                {
                    var chr = 0;
                    if (int.TryParse(item.ToString(), out chr)) countNum++;
                }
            }

            while (!((countUpper <= upper) && (countLower <= lower) && (countNum <= numberUniqe) && (countNum > 0) && (countUpper > 0) && checkDupicate));


            return result;
        }
    }
}
