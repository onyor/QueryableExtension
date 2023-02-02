using QueryableExtension;
using QueryableExtension.Extensions;

SeedData.SeedInit();

// Class Extension for 
ClassExtension.ChangeMethod(SeedData.User);

// Aggregate
Aggregate.GetLongestName(SeedData.fruits);
Aggregate.GetEvenNumber(SeedData.numbers);
            
Aggregate.Reversing();
