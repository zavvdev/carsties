using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options)
        : base(options) { }

    public required DbSet<Auction> Auctions { get; set; }
}
