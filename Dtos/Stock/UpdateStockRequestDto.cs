using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "Symbol must be at least 2 characters long.")]
        [MaxLength(10, ErrorMessage = "Symbol cannot exceed 10 characters.")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MinLength(2, ErrorMessage = "Company Name must be at least 2 characters long.")]
        [MaxLength(100, ErrorMessage = "Company Name cannot exceed 100 characters.")]
        public string CompanyName { get; set; } = string.Empty;
        [Range(0.001, 100, ErrorMessage = "Purchase price must be between 0.001 and 100.")]
        public decimal Purchase { get; set; }
        [Range(0.001, 100, ErrorMessage = "Last dividend must be between 0.001 and 100.")]
        public decimal LastDiv { get; set; }
        [MaxLength(10, ErrorMessage = "Industry cannot exceed 10 characters.")]
        public string Industry { get; set; } = string.Empty;
        [Range(1, 5000000000, ErrorMessage = "Market cap must be between 1 and 5,000,000,000.")]
        public long MarketCap { get; set; }
    }
}