import java.util.ArrayList;
import java.util.Random;

class DnDCharacter {


    private final int strength;
    private final int dexterity;
    private final int constitution;
    private final int wisdom;
    private final int intelligence;
    private final int charisma;

    public DnDCharacter(){
        this.strength = this.ability();
        this.dexterity = this.ability();
        this.constitution = this.ability();
        this.wisdom = this.ability();
        this.intelligence = this.ability();
        this.charisma = this.ability();
    }

    int ability() {
        var rolls  = new ArrayList<Integer>();
        rolls.add(new Random().nextInt(6) + 1);
        rolls.add(new Random().nextInt(6) + 1);
        rolls.add(new Random().nextInt(6) + 1);
        rolls.add(new Random().nextInt(6) + 1);
        var total = rolls.stream().sorted().skip(1).reduce(0, (acc, item) -> {
            return acc + item;
        });;
        return total;
    }

    int modifier(int input) {
       return (int)Math.floor((double)(input - 10) / 2);
    }

    int getStrength() {
        return this.strength;
    }

    int getDexterity() {
        return this.dexterity;
    }

    int getConstitution() {
       return this.constitution;
    }

    int getIntelligence() {
     return this.intelligence;
    }

    int getWisdom() {
      return this.wisdom;
    }

    int getCharisma() {
       return this.charisma;
    }

    int getHitpoints() {
        return 10 + this.modifier(this.constitution);
    }

}
