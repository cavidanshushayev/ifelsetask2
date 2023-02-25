
            var saat = 4;
            if (saat < 3)
            {
                console.log("odenilecek mebleg  " + saat + "azn");
            }else if(saat >3 && saat <= 5)
            {
                var endrimsizmebleg = 3;
                var endrimlimebleg = (saat - endrimsizmebleg) * 80 / 100;
                var tammebleg = endrimsizmebleg + endrimlimebleg;
                console.log("odenilecek mebleg   " + tammebleg + "azn");
            }else if(saat > 5 && saat <= 8)
            {
                var endrimsizmebleg = 4.6;

                var secondendrimlimebleg = (saat - 5) * 50 / 100;
                var tammebleg = endrimsizmebleg +secondendrimlimebleg;
                console.log("odenilecek mebleg " + tammebleg + "azn");
            }else
            {
                var endrimsizmebleg = 6.1;
                var endrimlimebleg = (saat - 8) * 75 / 100;
                var tammebleg = endrimlimebleg + endrimsizmebleg;
                console.log("odenilecek mebleg " + tammebleg + "azn");

            }
        
    
