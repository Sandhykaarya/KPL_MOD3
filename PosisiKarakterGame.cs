using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302204002
{
    internal class PosisiKarakterGame
    {
        public enum State
        {
            Berdiri,
            Terbang,
            Jongkok,
            Tengkurap
        }

        public void play()
        {
            State state = State.Berdiri;
            string[] posisi = { "Berdiri", "Terbang", "Jongkok", "Tengkurap" };
            while (true)
            {
                Console.WriteLine("Posisi " + posisi[(int)state]);
                Console.Write("Tekan Tombol: ");
                string cmd = Console.ReadLine();
                switch (state)
                {
                    case State.Berdiri:
                        if(cmd == "TombolW")
                        {
                            state = State.Terbang;
                            Console.WriteLine("tombol arah atas ditekan");
                        }
                        else if(cmd == "TombolS")
                        {
                            state = State.Jongkok;
                            Console.WriteLine("tombol arah bawah ditekan");
                        }
                        else
                        {
                            state = State.Berdiri;
                        }
                        break;
                    case State.Terbang:
                        if(cmd == "TombolS")
                        {
                            state = State.Berdiri;
                            Console.WriteLine("tombol arah bawah ditekan");
                        }
                        else if(cmd == "TombolX")
                        {
                            state = State.Jongkok;
                            Console.WriteLine("tombol arah atas ditekan");
                        }
                        else if(cmd == "TombolW")
                        {
                            Console.WriteLine("tombol arah atas ditekan");
                        }
                        else
                        {
                            state = State.Terbang;
                        }
                        break;
                    case State.Jongkok:
                        if(cmd == "TombolS")
                        {
                            state = State.Tengkurap;
                            Console.WriteLine("tombol arah bawah ditekan");
                        }
                        else if(cmd == "TombolW")
                        {
                            state = State.Berdiri;
                            Console.WriteLine("tombol arah atas ditekan");
                        }
                        else
                        {
                            state = State.Jongkok;
                        }
                        break;
                    case State.Tengkurap:
                        if(cmd == "TombolW")
                        {
                            state = State.Jongkok;
                            Console.WriteLine("tombol arah atas ditekan");
                        }
                        else if(cmd == "TombolS")
                        {
                            Console.WriteLine("tombol arah bawah ditekan");
                        }
                        else
                        {
                            state = State.Tengkurap;
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
        
    }
}
