using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using kütüphaneOtomasyonu.Entites;

namespace kütüphaneOtomasyonu.DAL
{
    public class PersonelDAL:RepostoryBase<Personeller,ModelPersonelEntity>

    {
        public object PersonelleriGetir(ModelPersonelEntity db, Expression<Func<Personeller, bool>> obj)
        {
            object model;
            if (obj == null)
            {
                model = db.Personeller.Join(db.Birimler, x => x.BirimID, b => b.BirimID, (x, b) => new
                {
                    x.PersonelID,
                    x.AdıSoyadı,
                    x.Telefon,
                    x.Adress,
                    x.Email,
                    x.Tarih,
                    Birim = b.Acıklama,
                    x.IsActive
                }).ToList();
            }
            else
            {
                model = db.Personeller.Where(obj).Join(db.Birimler, x => x.BirimID, b => b.BirimID, (x, b) => new
                {
                    x.PersonelID,
                    x.AdıSoyadı,
                    x.Telefon,
                    x.Adress,
                    x.Email,
                    x.Tarih,
                    Birim = b.Acıklama,
                    x.IsActive
                }).ToList();
            }
            return model;

        }


        }


    }

