package demo;

/**
 * Service métier qui utilise Calculator.
 * On simule une logique métier simple : additionner deux valeurs
 * puis appliquer une règle métier (ex : valeur minimale).
 */
public class CalculatorService {

    private final Calculator calculator;

    public CalculatorService(Calculator calculator) {
        this.calculator = calculator;
    }

    public int addAndClamp(int a, int b) {
        int result = calculator.add(a, b);

        // Règle métier : le résultat ne peut pas être inférieur à 0
        return Math.max(result, 0);
    }
}