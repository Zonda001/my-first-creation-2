using System;
using System.Data;
using System.Diagnostics;
using static System.Net.WebRequestMethods;


namespace Open {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What`s your name?");
            Process myProcess = new Process();
            string role = Console.ReadLine();
            if (role == "Kolya")
            {
                Console.WriteLine("Kolya Pidr");
                string url = "https://www.youtube.com/watch?v=BpmWTyKt3hk";
                myProcess.StartInfo.FileName = url;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (role == "Kate")
            {
                Console.WriteLine("HISTORY! HISTORY!!!!! HISTORY!!!!!!");
                string url4 = "https://www.youtube.com/watch?v=_kF-0IuecR8";
                myProcess.StartInfo.FileName = url4;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
            if (role == "Nastya")
            {
                Console.WriteLine("DRAW! DRAW!! DRAW!! MORE DRAW!!!! FUCKING MORE DRAW!!!!!");
                string url3 = "https://www.youtube.com/watch?v=XpplHldMGqY";
                myProcess.StartInfo.FileName = url3;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (role == "Kolya not a pidr")
            {
                Console.WriteLine("Kolya pidr and massive Nigger");
                Console.WriteLine("NIGGA!");
                string url1 = "https://www.youtube.com/watch?v=XHEsIgM0LzM";
                myProcess.StartInfo.FileName = url1;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (role == "Veronika")
            {
                Console.WriteLine("What the fucking NOSE!!!!!!");
                Console.WriteLine("Your good to life with this Fucking NOSE!!!!!!");
                string url10 = "https://www.youtube.com/watch?v=Ot3U2qmvT_U";
                myProcess.StartInfo.FileName = url10;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (role == "Maksim")
            {
                Console.WriteLine("BOBIK COME TO ME!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                Console.WriteLine("BOBIK!!!!");
                string url4 = "https://www.youtube.com/watch?v=iNvj5UVTwgU";
                myProcess.StartInfo.FileName = url4;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
       

            }
            if (role == "Denys")
            {
                string url2 = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
                myProcess.StartInfo.FileName = url2;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (role == "Stone")
            {
                string url5 = "https://www.youtube.com/watch?v=64TCo-9BD_U";
                myProcess.StartInfo.FileName = url5;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (role == "Bread")
            {
                string url6 = "https://www.youtube.com/watch?v=BQDqu4QQwMA";
                myProcess.StartInfo.FileName = url6;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (role == "USSR")
            {
                string url7 = "https://www.youtube.com/watch?v=Jwffk9sB1kI";
                myProcess.StartInfo.FileName = url7;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (role == "Salo")
            {
                string url8 = "https://www.youtube.com/watch?v=qCxoT_dDmpc";
                myProcess.StartInfo.FileName = url8;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                } catch (Exception ex) 
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (role == "Misha")
            {
                string url9 = "https://www.youtube.com/watch?v=IkCh8VfN2d4";
                myProcess.StartInfo.FileName = url9;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            if (role == "Cumshot")
            {
                string url11 = "https://www.youtube.com/watch?v=CeHh22HrCwI";
                myProcess.StartInfo.FileName = url11;
                myProcess.StartInfo.UseShellExecute = true;
                try
                {
                    myProcess.Start();
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            } 

        }
    }
    }