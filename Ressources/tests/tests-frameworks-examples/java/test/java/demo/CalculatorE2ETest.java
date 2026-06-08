package demo;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

/**
 * Test E2E simplifié.
 * On simule un "parcours utilisateur" :
 * 1. L'utilisateur demande une addition
 * 2. Le service applique sa règle métier
 * 3. On vérifie le résultat final
 */
class CalculatorE2ETest {

    @Test
    void testUserScenarioAddTwoNumbers() {
        Calculator calculator = new Calculator();
        CalculatorService service = new CalculatorService(calculator);

        // Scénario utilisateur : additionner 7 et 8
        int result = service.addAndClamp(7, 8);

        assertEquals(15, result, "Le scénario E2E doit retourner 15");
    }
}