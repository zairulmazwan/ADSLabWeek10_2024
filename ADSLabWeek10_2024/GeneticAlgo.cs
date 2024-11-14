using System.Data;

public class GeneticAlgo
{
    public void runGA(int generations, List<double> data)
    {
        //Create initial population
        Population myPop = new Population(20, data);

        //Sort the population based on their fitness values
        myPop.sortPopulation();
       

        //We are going to use this crossover strategy. The crossover prob. is reducing by generation
        double crossOverProb = 0.9;
        double coRate = 0.9/generations;

        //Loop until number of generation
        for(int i=0; i<generations; i++)
        {
            Console.WriteLine("Generation "+i);
           
            
            //Produce 2 children using the crossOver method. The method will return a list of Individuals
          

            
            //Produce a mutant. Create an Individual from the best parent, the mutate their genes. Use copyIndividual and mutation for this operation.
            


            //Add the new candidates to the population, i.e., child 1, child 2, and mutant. Use addCandidates method.
           
            


            //Sort the population after the new candidates join the population
            
            

            //Get the best individual from the population
           


            //Reduce the crossover probability
            crossOverProb -= coRate;
        }
        

        

    }
}

//©ZairulMazwan©