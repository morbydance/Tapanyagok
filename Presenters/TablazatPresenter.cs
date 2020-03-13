using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapanyagok.Models;
using Tapanyagok.Repositories;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Presenters
{
    class TablazatPresenter
    {
        TapanyagRepository tapanyagRepository = new TapanyagRepository();
        ITablazatView tablazatView;

        public TablazatPresenter(ITablazatView tablazatView)
        {
            this.tablazatView = tablazatView;
        }

        public void LoadData()
        {
            tablazatView.bindingList = tapanyagRepository.GetAllTapanyag(
                tablazatView.pageNumber,
                tablazatView.itemsPerPage,
                tablazatView.search,
                tablazatView.sortBy,
                tablazatView.ascending);
            tablazatView.totalItems = tapanyagRepository.Count();
        }

        public void Add(tapanyag etel)
        {
            tapanyagRepository.Insert(etel);
        }

        public void Remove(int id)
        {
            tapanyagRepository.Delete(id);
        }

        public void Modify(int index, tapanyag etel)
        {
            tapanyagRepository.Update(tablazatView.bindingList.ElementAt(index));
        }

        public void Save()
        {
            tapanyagRepository.Save();
        }


    }
}
