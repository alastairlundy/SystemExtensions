cmake_minimum_required(VERSION 3.17)
project(DeveloperKit)

set(CMAKE_CXX_STANDARD 20)

add_library(DeveloperKit SHARED

        HashMapV2.hpp HashMapV2.cpp
        KeyValuePair.hpp
        Version.hpp Version.cpp
        ObjectList.hpp ObjectList.cpp

        StringManipulation/StringFormatter.hpp StringManipulation/StringFormatter.cpp
        StringManipulation/GenericStringProcessor.hpp StringManipulation/GenericStringProcessor.cpp

        StringManipulation/TextProcessors/SarcasmTextProcessor.hpp StringManipulation/TextProcessors/SarcasmTextProcessor.cpp enums&constants/StringConstants.hpp)

install(TARGETS DeveloperKit DESTINATION lib)

export(TARGETS DeveloperKit
        FILE DeveloperKit.cmake)