using QueryableExtension;
using QueryableExtension.Extensions;
SeedData.SeedInit();


// Class Extension
ClassExtension.ChangeMethod(SeedData.User);

// Aggregate
Aggregate.Test(SeedData.User);






