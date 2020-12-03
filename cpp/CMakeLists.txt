cmake_minimum_required(VERSION 3.17)
project(DeveloperKit)

set(CMAKE_CXX_STANDARD 17)

add_library(DeveloperKit SHARED

        Types/Lists/HashMap/HashMapV2.hpp
        Types/Lists/HashMap/HashMapV2.cpp

        Types/KeyValuePair.hpp

        Types/DeveloperTypes/Version/Version.hpp
        Types/DeveloperTypes/Version/Version.cpp

        Types/Lists/ObjectList/ObjectList.hpp
        Types/Lists/ObjectList/ObjectList.cpp

        StringManipulation/TextProcessors/StringFormatter/StringFormatter.hpp
        StringManipulation/TextProcessors/StringFormatter/StringFormatter.cpp

        StringManipulation/TextProcessors/GenericStringProcessing/GenericStringProcessor.hpp
        StringManipulation/TextProcessors/GenericStringProcessing/GenericStringProcessor.cpp

        StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.hpp
        StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp

        enums&constants/StringConstants.hpp

        StringManipulation/deps/ResultsAveraging.cpp
        StringManipulation/deps/ResultsAveraging.hpp

        StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp
        StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.hpp

        Types/DeveloperTypes/DateTime/Date/Date.cpp
        Types/DeveloperTypes/DateTime/Date/Date.hpp

        Types/DeveloperTypes/DateTime/Time/Time.cpp
        Types/DeveloperTypes/DateTime/Time/Time.hpp

        Types/DeveloperTypes/DateTime/DateTime.hpp

        Types/DeveloperTypes/Stopwatch/Stopwatch.hpp
        Types/DeveloperTypes/Stopwatch/Stopwatch.cpp)

install(TARGETS DeveloperKit DESTINATION lib)

export(TARGETS DeveloperKit
        FILE DeveloperKit.cmake)