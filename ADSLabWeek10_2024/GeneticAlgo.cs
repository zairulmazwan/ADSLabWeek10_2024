using System.Data;

public class GeneticAlgo
{
    public void runGA(int generations, List<double> data)
    {
        //Create initial population
        Population myPop = new Population(20, data); //Change the size of population (20) if required.

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
            // Complete the code here
          

            
            //Produce a mutant. Create an Individual from the best parent, the mutate their genes. Use copyIndividual and mutation for this operation.
            Individual mutant = myPop.getParents()[0].copyIndividual(); // Getting the first parent (best fitness) and copy their genetic to a mutant.
            // Complete your code for mutant

            //Add the new candidates to the population, i.e., child 1, child 2, and mutant. Use addCandidates method.
            // Complete the code here

            


            //Sort the population after the new candidates join the population
            // Complete the code here

            
            

            //Get the best individual from the population
            // Complete the code here



            //Reduce the crossover probability
            crossOverProb -= coRate;

            // Comment out these lines to see outputs for every generation in the console.
            // Console.WriteLine("==Population==");
            // pop.printPopulation();
            // Console.WriteLine("==Best Candidate==");
            // best.printIndividual();
        }
        
        // Comment out these lines to see outputs in the console.
        // Console.WriteLine("==Population All Generations==");
        // myPop.printPopulation();

        // Write results to csv files: writeFitnessResults, writeSolutions, writePopulation: You must create these variables to save the results in CSV files. 
        // FileData.writeFitnessResults(results,"results.csv");
        // FileData.writeSolutions(solutions,"solutions.csv");
        // FileData.writePopulation(myPop,"Population.csv");

        

    }
}

//©ZairulMazwan©