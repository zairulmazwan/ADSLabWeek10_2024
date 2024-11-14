
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class ReadWriteFile
{

    public static List<int> genData(int n)
    {
        Random r = new Random();
        List<int> data = Enumerable.Range(1,n).ToList();
        return data;
    } 

    public static List<int> genNumbers(int n) //using RandomNumberGenerator
    {
        List<int> res = new List<int>();
        RandomNumberGenerator.Create();
        for (int i=0; i<n; i++)
        {
            double x = RandomNumberGenerator.GetInt32(2,20);
            Console.WriteLine(x);
        }
        return res;
    }


    public static List<Double> genDoubleData(int n)
    {
        List<Double> data = new List<Double>();
        for(int i=0; i<n; i++)
        {
            Random r = new Random();
            double x = Math.Round(r.NextDouble()*100,3);

            if(!data.Contains(x))
                data.Add(x);

        }

        return data;
    }

    public static void writeFile<T>(List<T> data, string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            for(int i=0; i<data.Count; i++)
            {
                sw.Write(data[i]);
                if(i<data.Count-1)
                    sw.Write(",");
            }
        }
    }

    public static List<Double> readData(string filename)
    {
        List<Double> res = new List<double>();

        string [] x = System.IO.File.ReadAllLines(filename);
        var raw = x[0].Split(',');
        // Console.WriteLine(raw.Length);
        foreach(var item in raw)
        {
            res.Add(Convert.ToDouble(item));
        }
        return res;
    }

     public static void printList<T>(List<T> list)
     {
            
        foreach (T i in list)
        {
            Console.WriteLine(i);
        }
    }

    public static void writeFitnessResults<T>(T [,] results, string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            sw.Write("GENERATION,P1,P2,C1,C2,MUTANT");
            sw.WriteLine();
            for (int i=0; i<results.GetLength(0); i++)
            {
                for (int j=0; j<results.GetLength(1); j++)
                {
                    // Console.WriteLine(results[i,j]);
                    sw.Write(results[i,j]);
                    if (j<results.GetLength(1)-1)
                        sw.Write(",");
                }
                sw.Write("\n");
            }
        }
    }

    public static void writeSolutions(List<List<int>> solutions, string filename)
    {
        using(StreamWriter sw = new StreamWriter(filename))
        {
            sw.Write("GENERATION,CHROMOSOME");
            sw.WriteLine();
            for(int i=0; i<solutions.Count; i++)
            {
                sw.Write(i+",");
                for(int j=0; j<solutions[i].Count; j++)
                {
                    sw.Write(solutions[i][j]);
                    sw.Write(" ");
                }
                sw.WriteLine();
            }
        }
    }

    public static void writePopulation(Population pop, string filename)
    {
        using(StreamWriter sw = new StreamWriter(filename))
        {
            sw.Write("CHROMOSOME,FITNESS");
            sw.WriteLine();

            for (int i=0; i<pop.pop.Count; i++) //go through all candidates in the population
            {
                for (int j=0; j<pop.pop[i].chromosome.Count; j++) //each candidate has a chromosome
                {
                    sw.Write(pop.pop[i].chromosome[j]); //write each gene to file
                    if (j<pop.pop[i].chromosome.Count-1) //this is to have a space between genes only
                        sw.Write(" ");
                }

                sw.Write(","+pop.pop[i].fitness); //write the candidate fitness value
                sw.WriteLine(); //go to the next candidate
            }
        }
    }
}

//©ZairulMazwan©