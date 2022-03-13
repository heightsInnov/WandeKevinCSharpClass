class Force{
    //formula for calculating force
    //mass * acceleration due to gravity => ma or mg
    //Force in a Liquid => mgh

    const int gravity = 10;

    public double calculateStaticForce(double mass){

        //Calculate the force and store it in a new variable
        double staticForce = mass * gravity;

        //return the value of your calculation above
        return staticForce;
    }

    public double calculatePotentialForce(double mass, double height){
        
        double potentialForce = mass * gravity * height;

        return potentialForce;
    }

    public double calculatePotentialForce2(double mass, double height){
        double potentialForce = calculateStaticForce(mass) * height;
        return potentialForce;
    }
}