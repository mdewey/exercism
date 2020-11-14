import java.util.HashMap;

class Scrabble {

    private HashMap<Integer, Integer> lookup = new HashMap<>();
    private String word;
    private void initLookup(){
        var temp = new HashMap<String, Integer>();
        temp.put("AEIOULNRST", 1);
        temp.put("DG", 2);
        temp.put("BCMP", 3);
        temp.put("FHVWY", 4);
        temp.put("K", 5);
        temp.put("JX", 8);
        temp.put("QZ", 10);
        for (var thing : temp.entrySet() ) {
            for(var letter : thing.getKey().toCharArray()){
                lookup.put((int)letter, thing.getValue());
            }
        }
    }

    Scrabble(){
        this.initLookup();
    }

    Scrabble(String word) {
        this();
        this.word = word;

    }

    int getScore() {
        return this.word
                .toUpperCase()
                .chars()
                .reduce(0,(acc, letter) -> acc + lookup.get(letter));
    }

}
