using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFactory
{
    
    public class LogisticsCalculator
    {
        public double CalculateLogistics(double distance, double priceKm)
        {
            double CalculateLogistics = distance * priceKm;
            return CalculateLogistics;
        }
    }
    public class ProductCalculator
    {
        
        private const double MancaWeight = 130;
        private const double ButterWeight = 60;
        private const double SugarWeight = 60;
        private const double CocoaPowderSpoons = 3.5;
        private const double WaterVolume = 180;

        public int CalculateMaxCandyProduction(double mancaAvailable, double butterAvailable, double sugarAvailable, double cocoaPowderAvailable, double waterAvailable)
        {
            int maxCandyProduction = 0;

            // Проверяем, хватает ли ресурсов для производства одной конфеты
            if (mancaAvailable >= MancaWeight && butterAvailable >= ButterWeight && sugarAvailable >= SugarWeight && cocoaPowderAvailable >= CocoaPowderSpoons && waterAvailable >= WaterVolume)
            {
                // Вычисляем, сколько конфет можно изготовить на основе доступных ресурсов
                int candyProductionFromManca = (int)(mancaAvailable / MancaWeight);
                int candyProductionFromButter = (int)(butterAvailable / ButterWeight);
                int candyProductionFromSugar = (int)(sugarAvailable / SugarWeight);
                int candyProductionFromCocoaPowder = (int)(cocoaPowderAvailable / CocoaPowderSpoons);
                int candyProductionFromWater = (int)(waterAvailable / WaterVolume);

                // Находим минимальное количество конфет, которое можно изготовить
                maxCandyProduction = Math.Min(candyProductionFromManca, Math.Min(candyProductionFromButter, Math.Min(candyProductionFromSugar, Math.Min(candyProductionFromCocoaPowder, candyProductionFromWater))));
            }

            return maxCandyProduction;
        }
    }
}
