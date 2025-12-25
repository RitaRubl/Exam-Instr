#include <iostream>
#include <fstream>
#include <string>
#include <windows.h>

bool convertAsciiToUnicode(const std::string& inputFile, const std::string& outputFile) {
    // Открываем входной файл в режиме чтения
    std::ifstream inFile(inputFile, std::ios::binary);
    if (!inFile.is_open()) {
        std::cerr << "Ошибка: не удалось открыть входной файл " << inputFile << std::endl;
        return false;
    }

    // Открываем выходной файл в режиме записи
    std::ofstream outFile(outputFile, std::ios::binary);
    if (!outFile.is_open()) {
        std::cerr << "Ошибка: не удалось открыть выходной файл " << outputFile << std::endl;
        inFile.close();
        return false;
    }

    // Записываем BOM (Byte Order Mark) для UTF-16 LE
    // 0xFFFE указывает на little-endian порядок байт
    const unsigned char bom[] = { 0xFF, 0xFE };
    outFile.write(reinterpret_cast<const char*>(bom), sizeof(bom));

    // Читаем и преобразуем данные
    char ch;
    while (inFile.get(ch)) {
        // ASCII символы в диапазоне 0-127
        // В Unicode (UTF-16) они просто дополняются нулевым байтом
        outFile.put(ch);        // Младший байт
        outFile.put('\0');      // Старший байт (0 для ASCII)
    }

    // Проверяем, не произошла ли ошибка при чтении
    if (!inFile.eof() && inFile.fail()) {
        std::cerr << "Ошибка при чтении файла" << std::endl;
        inFile.close();
        outFile.close();
        return false;
    }

    // Закрываем файлы
    inFile.close();
    outFile.close();

    std::cout << "Файл успешно преобразован из ASCII в Unicode (UTF-16 LE)" << std::endl;
    return true;
}

int main() {
    // Устанавливаем русскую кодировку для консоли
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    std::string inputFile, outputFile;

    std::cout << "Программа преобразования файла из ASCII в Unicode (UTF-16)" << std::endl;
    std::cout << "Введите путь к исходному файлу (ASCII): ";
    std::getline(std::cin, inputFile);
    
    std::cout << "Введите путь к целевому файлу (Unicode): ";
    std::getline(std::cin, outputFile);

    if (inputFile.empty()) inputFile = "input.txt";
    if (outputFile.empty()) outputFile = "output_unicode.txt";

    if (convertAsciiToUnicode(inputFile, outputFile)) {
        std::cout << "Преобразование завершено успешно!" << std::endl;
        std::cout << "Исходный файл: " << inputFile << std::endl;
        std::cout << "Конечный файл: " << outputFile << std::endl;
    } else {
        std::cerr << "Преобразование не удалось!" << std::endl;
        return 1;
    }

    return 0;
}
