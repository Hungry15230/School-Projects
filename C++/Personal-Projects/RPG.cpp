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
        double CD, CC, HP, DEF, MONEY, XP, DMG, HP_MAX;
        string ORIGIN, NAME;
        Player(int str, int con, int dex, int Int, int wis, int cha,
               double cd, double cc, double hp, double def, double dmg,
               string origin, string name, double money, int lvl, double xp) {
            STR = str;
            CON = con;
            DEX = dex;
            INT = Int;
            WIS = wis;
            CHA = cha;

            CD = cd;
            CC = cc;

            HP = hp;
            HP_MAX = HP;
            DEF = def;
            DMG = dmg;
            ORIGIN = origin;
            NAME = name;
            MONEY = money;
            LVL = lvl;
            XP = xp;
        }
    void displayStats() {
        cout << "\nHP: " << HP;
        cout << "\nMax HP: " << HP_MAX;
        cout << "\nDEF: " << DEF;
        cout << "\nDMG: " << DMG;
        cout << "\nSTR: " << STR;
        cout << "\nCON: " << CON;
        cout << "\nDEX: " << DEX;
        cout << "\nINT: " << INT;
        cout << "\nWIS: " << WIS;
        cout << "\nCHA: " << CHA;
        cout << "\nCrit Damage: " << CD << "%";
        cout << "\nCrit Chance: " << CC << "%";
        cout << "\nOrigin: " << ORIGIN;
        cout << "\nName: " << NAME;
        cout << "\nMoney: " << MONEY;
        cout << "\nLVL: " << LVL;
        cout << "\nXP: " << XP;
    }

    void levelUp() {
        LVL++;
        XP = 0;
        cout << "\nYou leveled up to level: " << LVL;
    }

    void heal(double healAmount) {
        HP += healAmount;
        cout << "\nYou healed for " << healAmount << " HP";
        cout << "\nHP: " << HP << "/" << HP_MAX;
    }

    void hurt(double damageTaken) {
        HP -= damageTaken;
        cout << "\nYou were attacked for " << damageTaken << " HP";
        cout << "\nHP: " << HP << "/" << HP_MAX;
    }
};

int main(){
    //Stats: str, con, dex, int, wis, cha, cd, cc, hp, def, dmg, origin, name, money, lvl, xp
    Player player(1, 1, 1, 1, 1, 1, 110, 1, 100, 0, 1, "", "", 0, 1, 0);

    player.displayStats();
    player.levelUp();
    player.hurt(20);
    player.heal(10);

    return 0;
}