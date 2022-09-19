// Crear una estructura para guardar los
// productos de una tienda.

struct Productos
    {
        public String Producto { get; set; }

    
        public string TipoProducto  { get; set; }

        public int Costo { get; set; }



       public Productos(String Producto , string TipoProducto,int costo )
       {
         this.Producto=Producto;
         this.TipoProducto=TipoProducto;
         this.Costo=costo;
        
       }
        
}

// Crear estructuras enlazadas para guardar
// la información de una mascota y su
// dueño.

 struct Mascota
{
    public string NombreMascota { get; set; }
    public string Raza  { get; set; }
    public int EdadMascota { get; set; }



    public Mascota(string NombreMascota, string Raza,int EdadMascota)
        {
            this.NombreMascota = NombreMascota;
            this.Raza = Raza;
            this.EdadMascota=EdadMascota;
        }

}
struct Propietario
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Direccion  { get; set; }

    public Propietario(string nombre,int Edad,string Direccion)
            {

                this.Nombre =nombre;
                this.Edad = Edad;
                this.Direccion = Direccion;
            }
}
// Crear una enumeración para los
// diferentes tipos de neumáticos.
 enum TipoNeumatico
{
    NeumaticoInvierno = 1,
    NeumaticoDiagonal = 2,
    NeumaticoVerano=3,
          
};