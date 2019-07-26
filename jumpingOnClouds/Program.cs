using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumpingOnClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int minJumpCount = 0;
            int i = 0;
            bool canJump = false;

            do
            {
                if (i + 1 < c.Length)
                {
                    if (c[i + 1] != 1)
                    {
                        if (i + 2 < c.Length)
                        {

                            if (c[i + 2] != 1)
                            {
                                canJump = true;
                                i += 2;
                            }
                            else
                            {
                                canJump = true;
                                i += 1;
                            }
                        }
                        else
                        {
                            canJump = true;
                            i += 1;
                        }
                    }
                    else if (i+2 < c.Length)
                    {
                        if (c[i + 2] != 1)
                        {
                            canJump = true;
                            i += 2;
                        }

                    }
                    else
                    {
                        canJump = false;
                        i += 1;
                    }
                }
                else
                {
                    canJump = false;
                    i += 1;
                }

                if (canJump)
                {
                    minJumpCount += 1;
                    canJump = false;
                }


            } while (i<c.Length);




            return minJumpCount;


        }

        static void Main(string[] args)
        {

            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int n = 7;

            string cloudArray = "0 1 0 0 0 1 0";


            int[] c = Array.ConvertAll(cloudArray.Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c);

            Console.WriteLine(result.ToString());
            Console.ReadKey();

        }
    }
}
