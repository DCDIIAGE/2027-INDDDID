package demo;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

class CalculatorTest {

    @Test
    void testAddShouldReturnCorrectSum() {
        Calculator calculator = new Calculator();

        int result = calculator.add(2, 3);

        assertEquals(5, result, "2 + 3 doit retourner 5");
    }

    @Test
    void testAddWithNegativeNumbers() {
        Calculator calculator = new Calculator();

        int result = calculator.add(-4, -6);

        assertEquals(-10, result, "La somme de deux négatifs doit être correcte");
    }
}