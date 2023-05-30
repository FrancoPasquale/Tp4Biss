public static class info
{
      private static List<Pais> ListaPaises = new List<Pais>();
      private static void InicializarLista()
      {
        Pais pais = new Pais("Argentina","Argentina.png",45000000,new DateTime(1916,07,09),"Perito Moreno");
        ListaPaises.Add(pais);
         pais = new Pais("Chile","Chile.png",25000000,new DateTime(1916,07,09),"Santiago de Chile");
        ListaPaises.Add(pais);
          pais = new Pais("Brasil","Brasil.png",145000000,new DateTime(1916,07,09),"Buzios");
        ListaPaises.Add(pais);
         pais = new Pais("Uruguay","Uruguay.png",6000000,new DateTime(1916,07,09),"Punta del Este");
        ListaPaises.Add(pais);
         pais = new Pais("Paraguay","Paraguay.png",35000000,new DateTime(1916,07,09),"Asuncion");
        ListaPaises.Add(pais);
        


      }
      public static List<Pais> ListarPaises()
        {
            if (ListaPaises.Count == 0)
            {
                InicializarLista();
            }
            return ListaPaises;
        }
        public static Pais DetallePais(string Nombre)
        {
            Pais paisBuscado = new Pais();
            foreach (Pais item in ListaPaises)
            {
                if(item.nombre == Nombre)
                return item;
            }
            return paisBuscado;

        }

}