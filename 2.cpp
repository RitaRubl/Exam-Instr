#include <iostream>
#include <fstream>

int main() {
    // Имена файлов
    const char* inputFile = "input.txt";
    const char* outputFile = "output_unicode.txt";

    // Открываем файлы
    std::ifstream inFile(inputFile, std::ios::binary);
    std::ofstream outFile(outputFile, std::ios::binary);

    // Записываем BOM для UTF-16 LE
    outFile.put(0xFF);
    outFile.put(0xFE);

    // Копируем с преобразованием ASCII -> UTF-16
    char ch;
    while (inFile.get(ch)) {
        outFile.put(ch);   // Сам символ
        outFile.put(0);    // Нулевой старший байт для ASCII
    }

    // Закрываем файлы
    inFile.close();
    outFile.close();

    std::cout << "Файл преобразован в Unicode!" << std::endl;
    return 0;
}
