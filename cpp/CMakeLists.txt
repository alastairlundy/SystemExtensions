cmake_minimum_required(VERSION 3.17)
project(DeveloperKit)

set(CMAKE_CXX_STANDARD 17)

add_library(DeveloperKit SHARED

        src/Types/Lists/HashMapV2.hpp

        src/Types/KeyValuePair.hpp

        src/Types/DeveloperTypes/Version/Version.hpp
        src/Types/DeveloperTypes/Version/Version.cpp

        src/Types/Lists/ObjectList.hpp

        src/StringManipulation/TextProcessors/StringFormatter/StringFormatter.hpp
        src/StringManipulation/TextProcessors/StringFormatter/StringFormatter.cpp

        src/StringManipulation/TextProcessors/GenericStringProcessing/GenericStringProcessor.hpp
        src/StringManipulation/TextProcessors/GenericStringProcessing/GenericStringProcessor.cpp

        src/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.hpp
        src/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp

        src/enums&constants/StringConstants.hpp

        src/StringManipulation/deps/ResultsAveraging.cpp
        src/StringManipulation/deps/ResultsAveraging.hpp

        src/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp
        src/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.hpp

        src/Types/DeveloperTypes/DateTime/Date/Date.cpp
        src/Types/DeveloperTypes/DateTime/Date/Date.hpp

        src/Types/DeveloperTypes/DateTime/Time/Time.cpp
        src/Types/DeveloperTypes/DateTime/Time/Time.hpp

        src/Types/DeveloperTypes/DateTime/DateTime.hpp

        src/Types/DeveloperTypes/Stopwatch/Stopwatch.hpp
        src/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp)