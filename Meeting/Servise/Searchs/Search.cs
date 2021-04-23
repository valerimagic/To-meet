using DAL.Contexts;
using DAL.Entiti;
using DTO.EnterObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servise.Searchs
{
    public class Search
    {
        private Context context = new Context();
        public List<User> GetMatch(EnterObjectINFoamtion model)
        {
            if (model.Age_from < 18 )
            {
                return null;
            }
            List<User> _base_list;
            if (model.Age_from == 0 || model.Age_to == 0)
            {
                _base_list = context.Users.ToList();
            }
            else { 
                _base_list = context.Users.Where(x => x.Age >= model.Age_from && x.Age <= model.Age_to).ToList();
            }

            if (model.City != "")
            {
                _base_list = _base_list.Where(x => x.City == model.City).ToList();
            }
            if (model.Relationship != "")
            {
                _base_list = _base_list.Where(x => x.Relationship == model.Relationship).ToList();
            }
            if (model.Gender != "")
            {
                _base_list = _base_list.Where(x => x.Gender == model.Gender).ToList();
            }
            return _base_list;
        }
    }
}
