using MyRow = Bhudi.Administration.RoleRow;

namespace Bhudi.Administration;

public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow> { }
public class RoleRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow>(context), IRoleRetrieveHandler
{
}