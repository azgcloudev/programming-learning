// default constructor called implicitly
using ReadOnlyPointAfterCreation;

PointReadOnlyAfterCreation finalPoint1 = new PointReadOnlyAfterCreation { X = 10, Y = 30 };


// default constructor callled explicitly
PointReadOnlyAfterCreation finalPoint2 = new PointReadOnlyAfterCreation() { X = 20, Y = 30 };