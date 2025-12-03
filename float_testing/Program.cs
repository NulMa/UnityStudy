using System;
public class Solution {
    public int solution(int hp) {
        int antGeneralRequire;
        int antSoldierRequire;
        int antNormalRequire;

        int antGeneralAtk = 5;
        int antSoldierAtk = 3;
        int antNormalAtk = 1;

        int answer = 0;

        antGeneralRequire = hp / antGeneralAtk;
        antSoldierRequire = (hp - (antGeneralAtk * antGeneralRequire)) / antSoldierAtk;
        antNormalRequire = hp - (antGeneralAtk * antGeneralRequire) - (antSoldierAtk * antSoldierRequire);

        answer = antGeneralRequire + antSoldierRequire + antNormalRequire;
        return answer;
    }
}