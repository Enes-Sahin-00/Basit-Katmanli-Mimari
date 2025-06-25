using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace kütüphaneOtomasyonu
{
    public class RepostoryBase<Entity, Context>
        where Entity : class, new()
        where Context : DbContext, new()
    {
        Context db = new Context();

        public void AddorUpdate(Entity entity) //ekleme ve güncelleme işlemlerini tek metotla yapıyoruz.
        {
            db.Set<Entity>().AddOrUpdate(entity);
        }

        public void Save() //kaydetme işlemini yapıyoruz.
        {
            db.SaveChanges();
        }

        public void Delete(Expression<Func<Entity, bool>> obj) //silme metodunu yazıyoruz.
        {
            var model = db.Set<Entity>().FirstOrDefault(obj); //silme kiriterlerini belirliyoruz 
            db.Set<Entity>().Remove(model);
        }

        public List<Entity> GetList(Expression<Func<Entity, bool>> obj = null)//listeleme metodunu yazıyoruz.
        //parametre kullanımı istege bağlı
        {
            List<Entity> liste;
            if (obj == null)
            {
                liste = db.Set<Entity>().ToList();
            }
            else
            {
                liste = db.Set<Entity>().Where(obj).ToList();
            }

            return liste;
        }
        //parametre kullanımına bağlı olarak tek kayıt getirilir .
        public Entity GetByFilter(Expression<Func<Entity, bool>> obj) //filtreleme metodunu yazıyoruz.
        {
            var model = db.Set<Entity>().FirstOrDefault(obj);
            return model;
        } 
    }
}
