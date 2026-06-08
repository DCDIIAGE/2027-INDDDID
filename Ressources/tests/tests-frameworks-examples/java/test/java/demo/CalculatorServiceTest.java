package demo;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

class CalculatorServiceTest {

    @Test
    void testAddAndClampShouldClampNegativeResult() {
        CalculatorService service = new CalculatorService(new Calculator());

        int result = service.addAndClamp(-10, 3);

        assertEquals(0, result, "Le résultat doit être clampé à 0");
    }

    @Test
    void testAddAndClampShouldReturnNormalSum() {
        CalculatorService service = new CalculatorService(new Calculator());

        int result = service.addAndClamp(4, 5);

        assertEquals(9, result, "La somme normale doit être retournée");
    }
}
