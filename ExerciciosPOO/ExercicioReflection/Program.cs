using System.Reflection;

namespace ExercicioReflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student bruno = new Student();
            Console.WriteLine("Exibindo propriedades");
            DisplayPublicProperties(bruno);

            Console.WriteLine();
            Console.WriteLine("Criando uma instância");
            CreateInstance();
        }

        static void DisplayPublicProperties(object obj)
        {
            Type t = obj.GetType();
            var propriedades = t.GetProperties();
            foreach (PropertyInfo property in propriedades)
            {
                Console.WriteLine(property.Name);
            }
        }

        static void CreateInstance()
        {
            Type t = typeof(Student);
            object obj = Activator.CreateInstance(t);
            PropertyInfo nameProp = t.GetProperty("Name");
            nameProp.SetValue(obj, "Bruno");
            PropertyInfo universityProp = t.GetProperty("University");
            universityProp.SetValue(obj, "Faculdade Ada");
            PropertyInfo rollNumberProp = t.GetProperty("RollNumber");
            rollNumberProp.SetValue(obj, 10000);
            MethodInfo displayMethod = t.GetMethod("DisplayInfo");
            displayMethod.Invoke(obj, null);
        }
    }

 }



