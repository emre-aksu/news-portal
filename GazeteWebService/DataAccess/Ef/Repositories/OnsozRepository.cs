using BaseLib.DataAccess.Implementation.EF;
using DataAccess.Contracts.Repositories;
using DataAccess.Ef.Context;
using Model.Model;

namespace DataAccess.Ef.Repositories
{
    public class OnsozRepository:BaseRepository<OnsozOzel,int,GazeteDbContext>,IOnsozRepository
    {

    }
}
