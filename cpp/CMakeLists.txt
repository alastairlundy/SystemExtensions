cmake_minimum_required(VERSION 3.17)
project(DeveloperKit)

set(CMAKE_CXX_STANDARD 20)

add_library(DeveloperKit SHARED

        Types/Lists/HashMapV2.hpp
        Types/Lists/HashMapV2.cpp

        Types/KeyValuePair.hpp

        Types/DeveloperTypes/Version/Version.hpp
        Types/DeveloperTypes/Version/Version.cpp

        Types/Lists/ObjectList.hpp
        Types/Lists/ObjectList.cpp

        StringManipulation/StringFormatter.hpp
        StringManipulation/StringFormatter.cpp

        StringManipulation/GenericStringProcessor.hpp
        StringManipulation/GenericStringProcessor.cpp

        StringManipulation/TextProcessors/SarcasmTextProcessor.hpp
        StringManipulation/TextProcessors/SarcasmTextProcessor.cpp

        enums&constants/StringConstants.hpp

        StringManipulation/deps/ResultsAveraging.cpp
        StringManipulation/deps/ResultsAveraging.hpp

        StringManipulation/TextProcessors/ClickBaitTextProcessor.cpp
        StringManipulation/TextProcessors/ClickBaitTextProcessor.hpp

        Types/DeveloperTypes/DateTime/Date/Date.cpp
        Types/DeveloperTypes/DateTime/Date/Date.hpp

        Types/DeveloperTypes/DateTime/Time/Time.cpp
        Types/DeveloperTypes/DateTime/Time/Time.hpp

        Types/DeveloperTypes/DateTime/DateTime.hpp
        Types/DeveloperTypes/DateTime/DateTime.cpp

        Types/DeveloperTypes/Stopwatch/Stopwatch.hpp
        Types/DeveloperTypes/Stopwatch/Stopwatch.cpp)

install(TARGETS DeveloperKit DESTINATION lib)

export(TARGETS DeveloperKit
        FILE DeveloperKit.cmake)