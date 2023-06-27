using ApiSirene.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSirene.Logic.Repository
{
    public interface IrecupRepositorie
    {
        Task<List<Etablissement>> FetchAll(CancellationToken cancellationToken);
    }
}
