namespace SGPdotNET.Util
{
    /// <summary>
    ///     Generic 3-dimensional vector
    /// </summary>
    public class Vector3
    {
        /// <inheritdoc />
        /// <summary>
        ///     Create a new Vector3 at the origin
        /// </summary>
        public Vector3() : this(0, 0, 0)
        {
        }

        /// <summary>
        ///     Create a new Vector3 at the specified position
        /// </summary>
        /// <param name="x">The X component of the new vector</param>
        /// <param name="y">The Y component of the new vector</param>
        /// <param name="z">The Z component of the new vector</param>
        public Vector3(double x,
            double y,
            double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        ///     Create a new Vector3 as a copy of the specified one
        /// </summary>
        /// <param name="v">Object to copy from</param>
        public Vector3(Vector3 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        /// <summary>
        ///     The X component of this vector
        /// </summary>
        public double X { get; }

        /// <summary>
        ///     The Y component of this vector
        /// </summary>
        public double Y { get; }

        /// <summary>
        ///     The Z component of this vector
        /// </summary>
        public double Z { get; }

        /// <summary>
        ///     The length of this vector
        /// </summary>
        public double Length => System.Math.Sqrt(X * X + Y * Y + Z * Z);

        /// <summary>
        ///     Calculates the dot product of this vector and another
        /// </summary>
        /// <param name="vec">The vector to calculate the dot with</param>
        /// <returns>The double representing the dot product of the two vectors</returns>
        public double Dot(Vector3 vec)
        {
            return X * vec.X + Y * vec.Y + Z * vec.Z;
        }

        /// <summary>
        ///     Subtracts one vector from another
        /// </summary>
        /// <param name="v">The left-hand vector</param>
        /// <param name="v2">The right-hand vector</param>
        /// <returns>The first vector minus the second</returns>
        public static Vector3 operator -(Vector3 v, Vector3 v2)
        {
            return new Vector3(v.X - v2.X, v.Y - v2.Y, v.Z - v2.Z);
        }

        /// <summary>
        ///     Adds one vector to another
        /// </summary>
        /// <param name="v">The left-hand vector</param>
        /// <param name="v2">The right-hand vector</param>
        /// <returns>The first vector plus the second</returns>
        public static Vector3 operator +(Vector3 v, Vector3 v2)
        {
            return new Vector3(v.X + v2.X, v.Y + v2.Y, v.Z + v2.Z);
        }

        /// <summary>
        ///     Scales one vector by another
        /// </summary>
        /// <param name="v">The left-hand vector</param>
        /// <param name="v2">The right-hand vector</param>
        /// <returns>The first vector multiplied by the second</returns>
        public static Vector3 operator *(Vector3 v, Vector3 v2)
        {
            return new Vector3(v.X * v2.X, v.Y * v2.Y, v.Z * v2.Z);
        }

        /// <summary>
        ///     Scales one vector by another
        /// </summary>
        /// <param name="v">The left-hand vector</param>
        /// <param name="v2">The right-hand vector</param>
        /// <returns>The first vector divided by the second</returns>
        public static Vector3 operator /(Vector3 v, Vector3 v2)
        {
            return new Vector3(v.X / v2.X, v.Y / v2.Y, v.Z / v2.Z);
        }

        /// <summary>
        ///     Scales one vector by a scalar
        /// </summary>
        /// <param name="v">The left-hand vector</param>
        /// <param name="v2">The right-hand scalar</param>
        /// <returns>The first vector multiplied by the scalar</returns>
        public static Vector3 operator *(Vector3 v, double v2)
        {
            return new Vector3(v.X * v2, v.Y * v2, v.Z * v2);
        }

        /// <summary>
        ///     Scales one vector by a scalar
        /// </summary>
        /// <param name="v">The left-hand vector</param>
        /// <param name="v2">The right-hand scalar</param>
        /// <returns>The first vector divided by the scalar</returns>
        public static Vector3 operator /(Vector3 v, double v2)
        {
            return new Vector3(v.X / v2, v.Y / v2, v.Z / v2);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"Vector3[X={X}, Y={Y}, Z={Z}, Length={Length}]";
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj is Vector3 vector &&
                   Equals(X, vector.X) &&
                   Equals(Y, vector.Y) &&
                   Equals(Z, vector.Z);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            var hashCode = 707706286;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            hashCode = hashCode * -1521134295 + Z.GetHashCode();
            return hashCode;
        }
    }
}