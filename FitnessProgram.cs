using System;

namespace fitness_console_app
{


    class FitnessProgram
    {
        //Rubrik:
        //Meaningful comments
        //Class(in addition to the class that contains Main)
        //Arrays or Enums
        //Loops(any one of while, do-while and for loops)
        //Methods(one returning void, and one returning non-void; one instance and one static method, and these can be  combined, e.g., void/static, and non-void/instance)
        //Constructor(at least one non-default constructor)
        //Private and  public access modifiers
        //Properties
        //Work with files(optional)
        //Random number generators(optional)
        //Collections(optional)
        //Github(optional)
        //Graphical interface (optional)
        //Database/SQL(optional)

        static void Main(string[] args)
        {
            //I made this program to give any user a general fitness profile and provide some free resources that they can look up in order to help them make the best choices for health!
            FitPerson profile1 = new FitPerson("", "", 0, 0, 0, 0);
            Console.WriteLine("Welcome to MVRKS Fitness profiler.");
            Console.WriteLine("Please enter your preferred name below:");
            profile1.Name = Console.ReadLine();
            Console.WriteLine("___________________________________________________________________________________________________________");
            Console.WriteLine($"Hi {profile1.Name}!\n\nFirst I'm going to ask you a couple questions so we can get you profile started!");
            Console.WriteLine("What is your birth gender?");
            profile1.Gender = Console.ReadLine();
            Console.WriteLine("___________________________________________________________________________________________________________");
            Console.WriteLine("Thanks! Now lets calculate your BMR(Base metabolic Rate) and BMI(Body Mass index)");
            Console.WriteLine();
            Console.WriteLine("You might be asking why it's important for you to know these things. I'll explain below:");
            Console.WriteLine();
            Console.WriteLine("- Your BMI gives you a broad overview of your general risk for health issues and is a quick and easy calculation.");
            Console.WriteLine("- A value of below 18.5 is generally considered underweight.");
            Console.WriteLine("- A value of 30 or higher is associated with obesity and higher risk of heart disease.");
            Console.WriteLine();
            Console.WriteLine("- Your BMR tells you how many calories you burn at rest\n- This is based on your age, gender, weight, height, and given activity level.");
            Console.WriteLine("- This simplifies things a bit if you are one of the many who want to know where to get started with gaining, losing, or maintaining weight.\n");
            Console.WriteLine("___________________________________________________________________________________________________________");
            Console.WriteLine($"Alright {profile1.Name}, lets get started. How tall are you in inches?");
            profile1.Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Awesome! Now how much do you weigh in lbs?");
            profile1.Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How old are you?");
            profile1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("___________________________________________________________________________________________________________");
            Console.WriteLine("Now that we've got that.\n");
            Console.WriteLine("Tell me how active you are on a scale of 1 - 5.");
            Console.WriteLine("1 - You are sedentary(little or no exercise).");
            Console.WriteLine("2 - If you are lightly active(light exercise or sports 1-3 days/week).");
            Console.WriteLine("3 - If you are moderately active (moderate exercise 3-5 days/week).");
            Console.WriteLine("4 - If you are very active (hard exercise 6.7 days/week).");
            Console.WriteLine("5 - If you are super active (very hard exercise and a physical job).");
            profile1.Activitylevel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("___________________________________________________________________________________________________________");
            profile1.GreetFitPerson();

        }
    }
    public class FitPerson
    {
        public string Name;
        public string Gender;
        public int Height; 
        public double Weight;
        public int Age;
        public int Activitylevel;

        public FitPerson(string name, string gender, int height, int weight, int age, int activitylevel)
        {
        }
        

        public void GreetFitPerson()//This will outline all of the info given and display recommendations based on individual results entered.
        {
            
            Console.WriteLine($"Thanks {Name}.\n");
            Console.WriteLine("According to your input:");
            Console.WriteLine($"You are {Height} inches tall.");
            Console.WriteLine($"You weigh {Weight} lbs");
            Console.WriteLine($"You are {Age} years old");
            Console.WriteLine($"Your BMI is {Math.Round(BMICalculator(Weight))}.");
            Console.WriteLine($"According to your BMR, you burn about {BMRCalculator(Weight, Height, Age)} calories at rest.\n");
            while (Math.Round(BMICalculator(Weight)) >= 30.0)//As long as a BMI of 30 or above is the result, it will give a unique greeting.
            {
                Console.WriteLine("___________________________________________________________________________________________________________");
                Console.WriteLine("Based on your input, your BMI is 30 or higher. This puts you at a higher risk for heart disease and stroke.");
                Console.WriteLine("Does this mean that you are 'fat'? Not necessarily.\nThere are plenty of people who have a BMI above the 'obese' threshhold and they are perfectly healthy.");
                Console.WriteLine("So are you someone that should worry about this?\n");
                Console.WriteLine("Let me ask you a question. Are you even slightly concerned about your current fitness level?");
                Console.WriteLine("Enter Yes or No.");
                string answer = Console.ReadLine();

                if (answer == "Yes" || answer == "yes")
                {
                    Console.WriteLine("By answering yes, you are acknowledging that you believe there is an issue with your health and you posess a desire to change something.");
                    Console.WriteLine("Press any key to see some recommended resources.");
                    Console.ReadKey();
                    Console.WriteLine("___________________________________________________________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("The first step towards fixing something is acknowledging that there is INDEED something that needs fixing.");
                    Console.WriteLine("The following websites are great free resources for general knowledge and advice for health and wellness.\n");
                    Console.WriteLine("- https://www.fitnessblender.com/videos");
                    Console.WriteLine("Fitness blender has a ton of full length workout videos of various types to help you get started whether you're new to the gym or a veteran.\n");
                    Console.WriteLine("Once you have completed some of their free workouts, you may even want to buy some of their paid content!");
                    Console.WriteLine("- https://makeyourbodywork.com/best-online-workout-videos/");
                    Console.WriteLine("This site has a ton of free 'stay at home' workout vidoes for those who don't want to venture out of their home.\n");
                    Console.WriteLine("Press any key to see nutrion resources.");
                    Console.ReadKey();
                    Console.WriteLine("___________________________________________________________________________________________________________");
                    Console.WriteLine("\nBelow are some websites to help you get familiar with basic nutrition.");
                    Console.WriteLine("- https://www.livestrong.com/");
                    Console.WriteLine("Livestrong.com is awesome if you are new to fitness. They also have a slew of certified professionals backing the information on their site.");                  
                    Console.WriteLine("Here you can find workout videos, nutrition advice, and really just a ton of overall health information that you might be curious about.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.WriteLine("___________________________________________________________________________________________________________");
                    Console.WriteLine("\nRemember that your health and fitness state is a lifestyle. If you cannot commit to it, you will not be able to sustain it.");
                    Console.WriteLine("There is no growth in the comfort zone, and there is no comfort in the growth zone!");
                    Console.WriteLine("Here's to getting(or staying) healthy!\n\nThanks for trusting MVRKS!");
                    break;
                }
                else if (answer == "no" || answer == "No")
                {
                    Console.WriteLine("You currently have no desire to change yourself, and that's okay.");
                    Console.WriteLine("Maybe you were just curious to find out your specific profile.");
                    Console.WriteLine("Either way, if you have any questions about how to gain weight, lose weight, or just progress in your fitness journey. These websites can definitely help:\n");
                    Console.WriteLine("Press any key to see our recommended resources.");
                    Console.ReadKey();
                    Console.WriteLine("___________________________________________________________________________________________________________");
                    Console.WriteLine("- https://www.fitnessblender.com/videos");
                    Console.WriteLine("Fitness blender has a ton of full length workout videos of various types to help you get started whether you're new to the gym or a veteran.");
                    Console.WriteLine("Once you have completed some of their free workouts, you may even want to buy some of their paid content!");
                    Console.WriteLine("- https://makeyourbodywork.com/best-online-workout-videos/");
                    Console.WriteLine("This site has a ton of free 'stay at home' workout vidoes for those who don't want to venture out of their home.");
                    Console.WriteLine("Press any key to see our recommendations for nutritional information.");
                    Console.ReadKey();
                    Console.WriteLine("___________________________________________________________________________________________________________");
                    Console.WriteLine("\nBelow are some websites to help you get familiar with basic nutrition.");
                    Console.WriteLine("- https://www.livestrong.com/");
                    Console.WriteLine("Livestrong.com is awesome if you are new to fitness. They also have a slew of certified professionals backing the information on their site.");
                    Console.WriteLine("Here you can find workout videos, nutrition advice, and really just a ton of overall health information that you might be curious about.");
                    Console.WriteLine("___________________________________________________________________________________________________________");
                    Console.WriteLine("\nThanks for trusting MVRKS!");
                    break;
                }

            }
            Console.WriteLine("Have any questions about fitness? Below are some good resources to get you started!");
            Console.WriteLine("Press any key to see some of our recommended resources");
            Console.ReadKey();
            Console.WriteLine("___________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("The following websites are great free resources for general knowledge and advice for health and wellness.\n");
            Console.WriteLine("- https://www.fitnessblender.com/videos");
            Console.WriteLine("Fitness blender has a ton of full length workout videos of various types to help you get started whether you're new to the gym or a veteran.\n");
            Console.WriteLine("Once you have completed some of their free workouts, you may even want to buy some of their paid content!");
            Console.WriteLine("- https://makeyourbodywork.com/best-online-workout-videos/");
            Console.WriteLine("This site has a ton of free 'stay at home' workout vidoes for those who don't want to venture out of their home.\n");
            Console.WriteLine("Press any key to see nutrion resources.");
            Console.ReadKey();
            Console.WriteLine("___________________________________________________________________________________________________________");
            Console.WriteLine("\nBelow are some websites to help you get familiar with basic nutrition.");
            Console.WriteLine("- https://www.livestrong.com/");
            Console.WriteLine("Livestrong.com is awesome if you are new to fitness. They also have a slew of certified professionals backing the information on their site.");
            Console.WriteLine("Here you can find workout videos, nutrition advice, and really just a ton of overall health information that you might be curious about.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("___________________________________________________________________________________________________________");
            Console.WriteLine("There is no growth in the comfort zone, and there is no comfort in the growth zone!");
            Console.WriteLine("Here's to getting(or staying) healthy!\n\nThanks for trusting MVRKS!");

        }

        public double PoundstoKilos(double Weight)//for future development when I use this in an actual website or app.
        {
            double convertedWeight = Weight * 0.45359;
            return convertedWeight;
        }

        public double BMICalculator(double a)//To determine the individuals BMI using the imperial system based on the user input
        {
            double BMI = (703 * Weight / (Height * Height));
            return BMI;
        }

        public double BMRCalculator(double Weight, int Height, int Age)//Calculates the BMR using the imperial system base on user input
        {
            double maleBMR = (4.536 * Weight) + (15.88 * Height) - (5 * Age) + 5;
            double femaleBMR = (4.35 * Weight) + (15.88 * Height) - (5 * Age) - 161;
            if (Gender == "Male" || Gender == "male")
            {
                return maleBMR;
            }
            else if (Gender == "Male" || Gender == "male" && Activitylevel == 1)
            {
                return maleBMR * 1.2;
            }

            else if (Gender == "Male" || Gender == "male" && Activitylevel == 2)
            {
                return maleBMR * 1.375;
            }

            else if (Gender == "Male" || Gender == "male" && Activitylevel == 3)
            {
                return maleBMR * 1.55;
            }

            else if (Gender == "Male" || Gender == "male" && Activitylevel == 4)
            {
                return maleBMR * 1.725;
            }

            else if (Gender == "Male" || Gender == "male" && Activitylevel == 5)
            {
                return maleBMR * 1.9;
            }

            else if (Gender == "Female" || Gender == "female")
            {
                return femaleBMR;
            }

            else if (Gender == "Female" || Gender == "female" && Activitylevel == 1)
            {
                return femaleBMR * 1.2;
            }

            else if (Gender == "Female" || Gender == "female" && Activitylevel == 2)
            {
                return femaleBMR * 1.375;
            }

            else if (Gender == "Female" || Gender == "female" && Activitylevel == 3)
            {
                return femaleBMR * 1.55;
            }

            else if (Gender == "Female" || Gender == "female" && Activitylevel == 4)
            {
                return femaleBMR * 1.725;
            }

            else if (Gender == "Female" || Gender == "female" && Activitylevel == 5)
            {
                return femaleBMR * 1.9;
            }

            else
            {
                return maleBMR * 1.2;
            }

        }

    }
}

