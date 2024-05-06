namespace Entidades
{
    public class Producto
    {
        public int codigo;
        public string nombre;
        public double precio;

        public Producto(int codigo, string nombre, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Mostrar() 
        {
            return $"{codigo} - {nombre} - {precio}";
        }
    }
}
