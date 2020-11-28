﻿namespace PyramidChallengeDomain.Test.Unit
{
    public static class TestEntities
    {
        public static readonly int[] SmallTestInput = new[] 
        { 
            1, 
            8, 9, 
            1, 5, 9, 
            4, 5, 2, 3 
        };
        
        public static readonly int[] LargeTestInput = new[] 
        { 
            215,
            192, 124,
            117, 269, 442,
            218, 836, 347, 235,
            320, 805, 522, 417, 345,
            229, 601, 728, 835, 133, 124,
            248, 202, 277, 433, 207, 263, 257,
            359, 464, 504, 528, 516, 716, 871, 182,
            461, 441, 426, 656, 863, 560, 380, 171, 923,
            381, 348, 573, 533, 448, 632, 387, 176, 975, 449,
            223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444,
            330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197,
            131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928,
            223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121,
            924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233, 
        };

        public static readonly int[] HugeTestInput = new[]
        {
            508,
            835, 915,
            404, 566, 840,
            371, 905, 471, 267,
            658, 530, 398, 432, 716,
            479, 725, 841, 881, 607, 447,
            552, 826, 156, 728, 442, 372, 394,
            577, 907, 393, 341, 897, 187, 609, 211,
            774, 746, 494, 570, 296, 638, 220, 794, 724,
            851, 311, 351, 961, 453, 649, 617, 421, 801, 585,
            426, 678, 890, 664, 266, 620, 970, 466, 570, 870, 456,
            613, 341, 831, 651, 704, 985, 477, 451, 451, 811, 481, 181,
            416, 870, 278, 150, 434, 250, 392, 774, 896, 230, 586, 312, 536,
            871, 225, 388, 967, 309, 297, 655, 924, 415, 369, 953, 525, 443, 751,
            664, 272, 952, 496, 780, 930, 624, 622, 790, 988, 606, 696, 348, 314, 246,
            541, 532, 737, 651, 263, 831, 897, 237, 497, 261, 637, 805, 247, 147, 621, 310,
            618, 976, 488, 724, 636, 924, 732, 802, 380, 896, 400, 398, 380, 476, 626, 948, 494,
            823, 858, 833, 345, 855, 323, 923, 753, 185, 605, 365, 259, 274, 507, 609, 317, 825, 970,
            720, 858, 572, 590, 596, 780, 914, 424, 350, 562, 648, 856, 150, 650, 704, 458, 416, 304, 766,
            946, 762, 784, 578, 971, 581, 467, 491, 697, 277, 520, 771, 241, 568, 503, 906, 241, 901, 368, 373,
            180, 408, 598, 950, 494, 230, 328, 564, 712, 572, 796, 240, 432, 532, 860, 358, 914, 408, 580, 158, 278,
            429, 369, 319, 827, 791, 529, 415, 623, 721, 591, 556, 195, 889, 734, 666, 291, 791, 234, 890, 401, 879, 761,
            246, 436, 430, 464, 714, 664, 314, 970, 788, 490, 360, 264, 750, 188, 430, 272, 704, 700, 868, 916, 966, 958, 390,
            149, 542, 791, 341, 171, 271, 321, 691, 734, 353, 683, 272, 835, 545, 453, 836, 753, 457, 773, 801, 191, 851, 796, 959,
            628, 882, 690, 504, 314, 532, 936, 750, 310, 194, 406, 920, 916, 446, 244, 848, 590, 774, 600, 862, 188, 890, 546, 702, 376,
            837, 265, 608, 361, 306, 323, 316, 719, 814, 736, 312, 555, 789, 475, 352, 389, 885, 935, 790, 311, 481, 920, 428, 335, 924, 337,
            388, 354, 882, 920, 712, 434, 960, 278, 476, 364, 476, 558, 154, 894, 240, 322, 252, 708, 930, 416, 800, 448, 422, 622, 302, 954, 754,
            540, 865, 942, 863, 391, 442, 941, 881, 907, 831, 891, 173, 850, 565, 681, 174, 933, 883, 475, 929, 867, 222, 279, 818, 691, 404, 629, 536,
            938, 958, 436, 738, 758, 680, 568, 356, 504, 528, 256, 236, 156, 984, 304, 484, 328, 682, 256, 822, 234, 394, 432, 710, 770, 996, 856, 438, 706,
            274, 289, 961, 781, 582, 911, 976, 519, 276, 385, 320, 997, 421, 611, 553, 804, 357, 891, 881, 887, 791, 610, 951, 267, 834, 422, 663, 617, 726, 937,
            730, 794, 248, 618, 378, 358, 234, 480, 602, 192, 328, 932, 200, 414, 936, 826, 812, 782, 846, 874, 562, 224, 974, 518, 910, 632, 338, 844, 950, 278, 398,
            447, 791, 277, 654, 493, 863, 802, 349, 343, 657, 906, 437, 868, 707, 830, 497, 686, 329, 158, 613, 910, 737, 820, 523, 681, 820, 697, 708, 741, 173, 389, 530,
            410, 794, 816, 290, 888, 758, 528, 926, 126, 518, 652, 366, 622, 722, 256, 810, 260, 250, 618, 632, 908, 698, 454, 676, 152, 754, 934, 704, 286, 244, 602, 322, 418,
            491, 176, 189, 890, 655, 573, 861, 800, 191, 567, 475, 266, 604, 865, 930, 714, 885, 563, 612, 511, 788, 555, 744, 456, 255, 253, 283, 789, 856, 789, 881, 881, 413, 913,
            280, 694, 182, 920, 570, 676, 756, 832, 892, 212, 978, 592, 548, 820, 186, 954, 332, 646, 138, 836, 630, 936, 396, 732, 750, 552, 440, 186, 908, 340, 650, 558, 818, 656, 768,
            315, 682, 963, 176, 899, 725, 951, 696, 649, 478, 691, 738, 463, 786, 866, 569, 383, 891, 610, 431, 307, 411, 379, 283, 168, 349, 684, 888, 631, 562, 534, 737, 891, 236, 799, 421,
            368, 582, 200, 188, 674, 390, 748, 438, 204, 776, 978, 398, 226, 732, 416, 664, 358, 302, 538, 866, 380, 792, 158, 700, 226, 180, 178, 234, 944, 886, 846, 338, 950, 522, 350, 762, 804,
            497, 755, 952, 661, 976, 227, 317, 369, 361, 773, 898, 296, 832, 527, 665, 660, 932, 151, 538, 573, 499, 998, 601, 362, 705, 455, 280, 966, 752, 447, 629, 493, 616, 896, 822, 507, 622, 390,
            402, 714, 802, 404, 788, 366, 280, 938, 262, 468, 254, 714, 128, 480, 810, 338, 378, 536, 336, 740, 922, 632, 984, 388, 654, 914, 294, 516, 640, 896, 742, 268, 188, 692, 748, 784, 808, 204, 282,
            350, 191, 762, 341, 733, 783, 147, 427, 298, 641, 387, 621, 436, 319, 841, 427, 801, 730, 523, 788, 873, 221, 723, 401, 326, 761, 986, 676, 435, 770, 135, 489, 324, 364, 945, 658, 309, 400, 360, 525,
            616, 596, 954, 834, 360, 456, 456, 948, 306, 372, 940, 202, 394, 414, 366, 198, 468, 504, 164, 118, 836, 470, 950, 486, 656, 898, 454, 180, 332, 372, 188, 516, 478, 998, 280, 466, 224, 928, 156, 828, 458,
            188, 477, 212, 830, 889, 243, 868, 915, 896, 341, 844, 303, 309, 728, 213, 563, 618, 328, 461, 152, 384, 724, 891, 291, 532, 724, 396, 241, 899, 931, 497, 455, 336, 700, 791, 949, 928, 655, 724, 762, 586, 264,
            476, 138, 384, 362, 274, 376, 172, 860, 604, 706, 610, 824, 180, 420, 542, 836, 404, 314, 888, 734, 166, 880, 758, 454, 158, 650, 886, 264, 634, 920, 604, 740, 566, 270, 354, 902, 948, 276, 514, 934, 174, 230, 432,
            745, 799, 425, 583, 441, 511, 155, 355, 516, 874, 807, 248, 509, 380, 843, 309, 661, 445, 907, 289, 726, 251, 912, 407, 952, 171, 639, 930, 233, 800, 867, 623, 891, 553, 162, 609, 645, 129, 594, 708, 628, 627, 238, 866,
            714, 172, 844, 626, 166, 966, 890, 592, 220, 896, 704, 644, 886, 122, 630, 374, 826, 268, 272, 716, 918, 334, 312, 956, 368, 338, 618, 598, 894, 348, 660, 160, 162, 196, 736, 930, 326, 162, 868, 266, 864, 378, 506, 188, 848,
            518, 722, 625, 451, 324, 836, 463, 545, 475, 902, 530, 813, 841, 407, 823, 451, 351, 741, 872, 291, 647, 541, 839, 385, 744, 198, 813, 353, 961, 761, 690, 782, 227, 258, 850, 615, 945, 249, 720, 556, 299, 656, 639, 247, 309, 220,
            436, 708, 190, 858, 614, 680, 678, 800, 304, 930, 836, 390, 706, 276, 976, 260, 588, 714, 362, 700, 736, 732, 556, 270, 460, 252, 172, 418, 948, 186, 854, 742, 226, 674, 714, 254, 312, 204, 248, 160, 254, 426, 906, 872, 824, 704, 542,
            545, 531, 187, 218, 923, 931, 559, 484, 704, 207, 825, 548, 511, 609, 367, 803, 268, 131, 247, 317, 227, 567, 777, 853, 487, 567, 357, 595, 467, 777, 689, 499, 661, 661, 531, 889, 911, 919, 881, 763, 618, 340, 111, 147, 486, 655, 687, 502,
            842, 574, 786, 840, 730, 538, 414, 132, 704, 334, 732, 504, 728, 964, 124, 878, 570, 530, 838, 850, 228, 476, 940, 300, 200, 432, 646, 838, 552, 730, 516, 782, 832, 800, 702, 836, 990, 794, 762, 272, 346, 548, 282, 726, 336, 526, 184, 654, 316
        };

        //Arrange
        public static readonly int[] BigValueInput = new int[]
        {
            int.MaxValue,
            int.MaxValue - 1, int.MaxValue,
        };

        public static readonly int[] AsymmetricInput = new int[]
        {
            1,
            4, 2,
            3, 5, 99,
            8, 4
        };
    }
}
