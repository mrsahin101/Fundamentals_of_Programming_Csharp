static void SomeMethod(int x, int y = 5, int z = 7)
{

}
// Normal Call!
SomeMethod(1, 2, 3);

// Omiting Z : Equivalent to : SomeMethod(1,2,7);
SomeMethod(1, 2);

// Omiting bot z and y : Equivalent to : SomeMethod(1,5,7);
SomeMethod(1);

// Passing z by name and x by posiiton  : Equivalent to SomeMethod(1,5,3);
SomeMethod(1, z: 3);

// Passing both x and z by name  : Equivalent to SomeMethod(1,5,3);
SomeMethod(x: 1, z: 3);

// Passing both x and z by name (reverse order, but doesnt matter) : Equivalent to SomeMethod(1,5,3);
SomeMethod(z: 3, x: 1);
