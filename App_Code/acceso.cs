using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

/// <summary>
/// Descripción breve de acceso
/// </summary>
public class acceso
{

	public acceso()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
   



    public MongoCollection getColecion<T>(String Nombre_coleccion) 
    {

        var connectionString = "mongodb://localhost";
        var client = new MongoClient(connectionString);
        var server = client.GetServer();
        var db = server.GetDatabase("ogame");
        var collection = db.GetCollection<T>(Nombre_coleccion);

      //  MongoCursor<usuario> members = collection.FindAll();
        //var collection = db.GetCollection<usuario>("usuarios");
        //MongoCursor<usuario> members = collection.FindAll();
        return collection;
    }

    #region usuarios

                                                        /*USUARIOS*/
    public List<usuario> getUsuarios()
    {
        List<usuario> todos = new List<usuario>();
        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");
        
        var query =
            from xe in coleccion.AsQueryable<usuario>()
          //  where xe.datos.Any(y => y.valor == "david")
            select xe;

        foreach (usuario use in query)
        {
            todos.Add(use);
        }
        return todos;
    }


    public usuario getUsuarioByID(double id)
    {

        List<usuario> arrId = new List<usuario>();
        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");

        var query = Query<usuario>.EQ(e => e.Id, id);
        var entity = coleccion.FindOne(query);

        return entity;
        //var query =
        //   ( from xe in coleccion.AsQueryable<usuario>()
        //    where xe.Id==id
        //     select xe).Take(1);

        //foreach (usuario use in query)
        //{
        //    arrId.Add(use);
        //}
        //return arrId[0];

    }


    public List<usuario> getUsuarioByDatos(String datoQuey, String valorQuey)
    {

        List<usuario> arrai = new List<usuario>();
        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");
       
       
        var query =
           from xe in coleccion.AsQueryable<usuario>()
           where xe.datos.Any(y => (y.dato==datoQuey)&&(y.valor == valorQuey))
           select xe;

        foreach (usuario use in query)
        {
            arrai.Add(use);
        }
        return arrai;
    }
    

    public List<usuario> getUsuarioByDefensas(double valorId)
    {

        List<usuario> arrai = new List<usuario>();
        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");


        var query =
           from xe in coleccion.AsQueryable<usuario>()
           where xe.defensas.Any(y => (y.Id == valorId) )
           select xe;

        foreach (usuario use in query)
        {
            arrai.Add(use);
        }
        return arrai;
    }
    public List<usuario> getUsuarioByInstalaciones( double valorId)
    {

        List<usuario> arrai = new List<usuario>();
        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");


        var query =
           from xe in coleccion.AsQueryable<usuario>()
           where xe.instalaciones.Any(y => (y.Id == valorId))
           select xe;

        foreach (usuario use in query)
        {
            arrai.Add(use);
        }
        return arrai;
    }
    public List<usuario> getUsuarioByterritorios(double valorId_Pais, double valorId_Continente)
    {

        List<usuario> arrai = new List<usuario>();
        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");


        var query =
           from xe in coleccion.AsQueryable<usuario>()
           where xe.territorios.Any(y => (y._id_pais == valorId_Pais) && (y._id_continente== valorId_Continente))
           select xe;

        foreach (usuario use in query)
        {
            arrai.Add(use);
        }
        return arrai;
    }

    public List<construccion> getUsuarioDefensas(double id_usuario,double id_construccion)//get defensas de un usuario
    {

        List<construccion> arrai = new List<construccion>();
        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");


        var query =
           from xe in coleccion.AsQueryable<usuario>()
           where xe.Id == id_usuario && xe.defensas.Any(y=>(y.Id==id_construccion))
           select xe.defensas;
             foreach (construccion item in query.ToList()[0]){
                 arrai.Add(item);
     
            }
        return arrai;
    }

    public List<construccion> getUsuarioInstalaciones(double id_usuario, double id_construccion)//get defensas de un usuario
    {

        List<construccion> arrai = new List<construccion>();
        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");


        var query =
           from xe in coleccion.AsQueryable<usuario>()
           where xe.Id == id_usuario && xe.instalaciones.Any(y => (y.Id == id_construccion))
           select xe.instalaciones;
        foreach (construccion item in query.ToList()[0])
        {
            arrai.Add(item);

        }
        return arrai;
    }

    public List<territorio> getUsuarioTerritorios(double id_usuario, double id,int tipo)//get territorios de un usuario (tipo = 0 es continente, tipo=1 pais)
    {

        List<territorio> arrai = new List<territorio>();
        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");
        var query = from xe in coleccion.AsQueryable<usuario>() select xe.territorios;

        if (tipo == 0)
        {

             query =
               from xe in coleccion.AsQueryable<usuario>()
               where xe.Id == id_usuario && xe.territorios.Any(y => (y._id_continente == id))
               select xe.territorios;
        }
        else if (tipo == 1)
        {
             query =
              from xe in coleccion.AsQueryable<usuario>()
              where xe.Id == id_usuario && xe.territorios.Any(y => (y._id_pais == id))
              select xe.territorios;
        }
        foreach (territorio item in query.ToList()[0])
        {
            arrai.Add(item);

        }
        return arrai;
    }

                                                                    /*USUARIOS  ACCIONs*/
    public void addUsuario(double id, List<Dato> datos, List<construccion> list_instalaciones, List<construccion> list_defensas, List<territorio> list_territorios)
    {

        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");
        usuario newelento = new usuario { Id = id, datos = datos, instalaciones = list_instalaciones, defensas = list_defensas, territorios = list_territorios };
        coleccion.Insert(newelento);

    }
    public void updateUsuario(double id, string campo, List<construccion> valor) //Pasar en campo defnsas o instalaciones. Actualiza todo la array de objetos(defensas o instalaciones)
    {

        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");
        var query2 = Query<usuario>.EQ(e => e.Id, id);
        var entity = coleccion.FindOne(query2);
        var propInfo = entity.GetType().GetProperty(campo);
        if (propInfo != null)
        {
            propInfo.SetValue(entity, valor, null);
        }
        coleccion.Save(entity);

    }

    public void updateUsuario(double id, string campo, string valor)
    {

        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<rol>("usuarios");
        var query2 = Query<usuario>.EQ(e => e.Id, id);
        var entity = coleccion.FindOne(query2);
        var propInfo = entity.GetType().GetProperty(campo);
        if (propInfo != null)
        {
            propInfo.SetValue(entity, valor, null);
        }
        coleccion.Save(entity);
        
    }

    public void updateUsuario(usuario updateUser)
    {

        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<usuario>("usuarios");

        coleccion.Save(updateUser);


    }

    public void delUsuario(double id)
    {

        MongoCollection<usuario> coleccion = (MongoCollection<usuario>)getColecion<rol>("usuarios");
        var query = Query<usuario>.EQ(e => e.Id, id);
        coleccion.Remove(query);

    }

    #endregion

        #region roles 
                                                       /*ROLES  GETS*/

    public List<rol> getRoles()
    {
        List<rol> todos = new List<rol>();
        MongoCollection<rol> coleccion = (MongoCollection<rol>)getColecion<rol>("roles");

        var query =
            from xe in coleccion.AsQueryable<rol>()
         //   where xe.datos.Any(y => y.valor == "david")
            select xe;

        foreach (rol member in query)
        {
            todos.Add(member);
        }
        return todos;
    }


    public rol getRolByID(double id)
    {

        List<rol> arrId = new List<rol>();
        MongoCollection<rol> coleccion = (MongoCollection<rol>)getColecion<rol>("roles");


        var query = Query<rol>.EQ(e => e.Id, id);
        var entity = coleccion.FindOne(query);

        return entity;
    }
                                                          /*ROLES  ACCIONs*/
    public void addRol(double id,string rol, string descripcion)
    {

        MongoCollection<rol> coleccion = (MongoCollection<rol>)getColecion<rol>("roles");
        rol newrol = new rol { Id = id,Rol=rol,descripcion = descripcion};
        coleccion.Insert(newrol);

    }
    public void updateRol(double id, string campo, string valor)
    {

        MongoCollection<rol> coleccion = (MongoCollection<rol>)getColecion<rol>("roles");
        var query2 = Query<rol>.EQ(e => e.Id, id);
        var entity = coleccion.FindOne(query2);
        var propInfo = entity.GetType().GetProperty(campo);
        if (propInfo != null)
        {
            propInfo.SetValue(entity, valor, null);
        }
        coleccion.Save(entity);

        //var query = Query<rol>.EQ(e => e.Id, id);
        //var update = Update<rol>.Set(e => e.descripcion, valor); // update modifiers
        //coleccion.Update(query, update);

    }

    public void delRol(double id)
    {

        MongoCollection<rol> coleccion = (MongoCollection<rol>)getColecion<rol>("roles");
        var query = Query<rol>.EQ(e => e.Id, id);
        coleccion.Remove(query);

    }

        #endregion
}