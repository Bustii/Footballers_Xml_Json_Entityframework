using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballers.Common
{
    public class ValidationConst
    {
        // Footballer
        public const int FootballerNameMaxLength = 40;

        public const int FootballerNameMinLength = 2;

        public const int BestSkillTypeMinLength = 0;
        public const int BestSkillTypeMaxLength = 4;

        public const int PositionTypeMinLength = 0;
        public const int PositionTypeMaxLength = 3;

        // Team
        public const int TeamNameMaxLength = 40;
        public const int TeamNameMinLength = 3;

        public const int TeamNationalityNameMaxLength = 40;
        public const int TeamNationalityNameMinLength = 2;

        public const string TeamLettersContains =
            @"^[A-Za-z0-9\s\.\-]{3,}$";

        // Coach
        public const int CoachNameMaxLength = 40;
        public const int CoachNameMinLength = 2;


    }
}
