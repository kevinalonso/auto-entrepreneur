using AutoEntrepreneur.WPF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEntrepreneur.WPF.ViewModel
{
    public class MainViewModel
    {
        #region Fields
        private CreateDatabase _CreateDatabase;
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public MainViewModel()
        {
            _CreateDatabase = new CreateDatabase();
            _CreateDatabase.CreateDb();
        }
        #endregion

        #region Methods

        #endregion

        #region Commands

        #endregion
    }
}
