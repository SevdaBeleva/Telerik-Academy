public struct StructPoint3D       // task 1 ---Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

    private static readonly StructPoint3D point0 = new StructPoint3D(0, 0, 0); // task 2 -- Add a private static read-only field to hold
                                                                              // the start of the coordinate system – the point O{0, 0, 0}
   
    public StructPoint3D( int x, int y, int z) : this()  // Define constructor
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()   // task 1---Implement the ToString() to enable printing a 3D point
    {
        string Point3D = string.Format("The coordinates of the Point3D are: x: {0} y: {1} z: {2}", x, y, z);
        return Point3D;
    }

    public static StructPoint3D Point0    // Add a static property to return the point O
    {
        get { return point0; }
    }

}
