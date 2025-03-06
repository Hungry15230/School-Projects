#include <iostream>
using namespace std;

/*
Physical statistics:
    -Strength - Damage
    -Constitution - Health
    -Dexterity - Agility
Mental statistics:
    -Intelligence - XP Gain
    -Wisdom - Magic
    -Charisma - Lower NPC Prices
*/

class Player {
    public:
        int STR, CON, DEX, INT, WIS, CHA, LVL;
        double CD, CC, HP, DEF, MONEY, XP, DMG;
        string ORIGIN, NAME;
        Player(int STR, int CON, int DEX, int INT, int WIS, int CHA,
               double CD, double CC, double HP, double DEF, double DMG,
               string ORIGIN, string NAME, double MONEY, int LVL, double XP) {
            STR = STR;
            CON = CON;
            DEX = DEX;
            INT = INT;
            WIS = WIS;
            CHA = CHA;

            CD = CD;
            CC = CC;

            HP = HP;
            DEF = DEF;
            DMG = DMG;
            ORIGIN = ORIGIN;
            NAME = NAME;
            MONEY = MONEY;
            LVL = LVL;
            XP = XP;
        }
    void displayStats() {
        cout << "";
    }
};

int main(){
    //Stats: str, con, dex, int, wis, cha, cd, cc, hp, arm, dmg, origin, name, money, lvl, xp
    Player player(1, 1, 1, 1, 1, 1, 1.10, 1, 100, 0, 1, "", "", 0, 1, 0);



    return 0;
}