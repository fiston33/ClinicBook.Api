using Microsoft.EntityFrameworkCore;

namespace ClinicBook.Api.Data;

public class ClinicBookDbContext(DbContextOptions<ClinicBookDbContext> options) : DbContext(options)
{
}
