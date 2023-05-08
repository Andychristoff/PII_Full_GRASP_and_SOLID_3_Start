namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
    void PrintRecipe(Recipe recipe);
    }
}

// El ejercicio no cumplia con el principio de polimorfismo ya que utilizaba logica para preguntar el destino del texto
// y asi elegir un metodo de impresion para utilizar, todo dentro de la misma clase. Esto lo arregle usando una interfaz 
// dividiendo la tarea en 2 clases distintas, una clase que emplearia el metodo cuando el texto se dirije a una impresora,
// y otra clase que emplearia el metodo cuando el texto se dirije a una consola.