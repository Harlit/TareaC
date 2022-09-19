// Crear el diseño de una clase para llevar
// el inventario de una tienda

public class Tienda
    {
        
        public string Articulo { get; set; }
        public float Cantidad { get; set; }
        public float Precio { get; set; }

        public Tienda(string Articulo, int cantidad, float precio)
        {
            
            this.Articulo = Articulo;
            this.Cantidad = cantidad;
            this.Precio=precio;
        }
}

//  Crear una clase para llevar la
// información de los estudiantes de una
// escuela

 public class Escuela
    {
       public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Curso { get; set; }

        public Escuela(int Matricula, string Nombre, string Apellido, string curso)
        {
            this.Matricula = Matricula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Curso = Curso;
        }

        
    }

//Programa de poligono


public class Poligono
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }
        public int LadoD { get; set; }
        public int LadoE { get; set; }

        public Poligono(int ladoA, int ladoB, int ladoC, int ladoD, int ladoE)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
            this.LadoD = ladoD;
            this.LadoE = ladoE;
        }

        public Poligono(int ladoA, int ladoB, int ladoC)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
        }

        public String ValoresValido(int a, int b, int c)
        {
            if(a <= 0)
            {
                return "El lado A no puede ser menor a 0";
            }
            if (b <= 0)
            {
                return "El lado B no puede ser menor a 0";
            }
            if (c <= 0)
            {
                return "El lado B no puede ser menor a 0";
            }
            return "Valores no validados";
        }

        public override string ToString()
        {
            int resultado = LadoA + LadoB + LadoC;

            return resultado.ToString();
        }
        
    }
        
