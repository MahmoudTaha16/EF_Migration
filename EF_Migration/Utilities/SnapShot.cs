using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Migration.Utilities
{
    [NotMapped]
    public class SnapShot
    {
        public DateTime LoadedAt=>DateTime.UtcNow;
        public string Version=>Guid.NewGuid().ToString().Substring(0,8);

    }
}