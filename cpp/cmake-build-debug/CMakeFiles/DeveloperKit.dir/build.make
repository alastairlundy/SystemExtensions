# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.17

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Disable VCS-based implicit rules.
% : %,v


# Disable VCS-based implicit rules.
% : RCS/%


# Disable VCS-based implicit rules.
% : RCS/%,v


# Disable VCS-based implicit rules.
% : SCCS/s.%


# Disable VCS-based implicit rules.
% : s.%


.SUFFIXES: .hpux_make_needs_suffix_list


# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = "/Users/alastairlundy/Library/Application Support/JetBrains/Toolbox/apps/CLion/ch-0/202.8194.17/CLion.app/Contents/bin/cmake/mac/bin/cmake"

# The command to remove a file.
RM = "/Users/alastairlundy/Library/Application Support/JetBrains/Toolbox/apps/CLion/ch-0/202.8194.17/CLion.app/Contents/bin/cmake/mac/bin/cmake" -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /Users/alastairlundy/Documents/Gitlab/developerkit/cpp

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/DeveloperKit.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/DeveloperKit.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/DeveloperKit.dir/flags.make

CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.o: ../Types/Lists/HashMap/HashMapV2.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/Lists/HashMap/HashMapV2.cpp

CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/Lists/HashMap/HashMapV2.cpp > CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.i

CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/Lists/HashMap/HashMapV2.cpp -o CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.s

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.o: ../Types/DeveloperTypes/Version/Version.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Building CXX object CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/Version/Version.cpp

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/Version/Version.cpp > CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.i

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/Version/Version.cpp -o CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.s

CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.o: ../Types/Lists/ObjectList/ObjectList.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_3) "Building CXX object CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/Lists/ObjectList/ObjectList.cpp

CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/Lists/ObjectList/ObjectList.cpp > CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.i

CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/Lists/ObjectList/ObjectList.cpp -o CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.s

CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.o: ../StringManipulation/StringFormatter.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_4) "Building CXX object CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/StringFormatter.cpp

CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/StringFormatter.cpp > CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.i

CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/StringFormatter.cpp -o CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.s

CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.o: ../StringManipulation/GenericStringProcessor.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_5) "Building CXX object CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/GenericStringProcessor.cpp

CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/GenericStringProcessor.cpp > CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.i

CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/GenericStringProcessor.cpp -o CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.s

CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.o: ../StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_6) "Building CXX object CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp

CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp > CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.i

CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp -o CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.s

CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.o: ../StringManipulation/deps/ResultsAveraging.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_7) "Building CXX object CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/deps/ResultsAveraging.cpp

CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/deps/ResultsAveraging.cpp > CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.i

CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/deps/ResultsAveraging.cpp -o CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.s

CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.o: ../StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_8) "Building CXX object CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp

CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp > CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.i

CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp -o CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.s

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.o: ../Types/DeveloperTypes/DateTime/Date/Date.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_9) "Building CXX object CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/DateTime/Date/Date.cpp

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/DateTime/Date/Date.cpp > CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.i

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/DateTime/Date/Date.cpp -o CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.s

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.o: ../Types/DeveloperTypes/DateTime/Time/Time.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_10) "Building CXX object CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/DateTime/Time/Time.cpp

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/DateTime/Time/Time.cpp > CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.i

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/DateTime/Time/Time.cpp -o CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.s

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.o: ../Types/DeveloperTypes/DateTime/DateTime.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_11) "Building CXX object CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/DateTime/DateTime.cpp

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/DateTime/DateTime.cpp > CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.i

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/DateTime/DateTime.cpp -o CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.s

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.o: CMakeFiles/DeveloperKit.dir/flags.make
CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.o: ../Types/DeveloperTypes/Stopwatch/Stopwatch.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_12) "Building CXX object CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.o -c /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp > CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.i

CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp -o CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.s

# Object files for target DeveloperKit
DeveloperKit_OBJECTS = \
"CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.o" \
"CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.o" \
"CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.o" \
"CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.o" \
"CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.o" \
"CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.o" \
"CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.o" \
"CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.o" \
"CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.o" \
"CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.o" \
"CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.o" \
"CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.o"

# External object files for target DeveloperKit
DeveloperKit_EXTERNAL_OBJECTS =

libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/Types/Lists/HashMap/HashMapV2.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Version/Version.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/Types/Lists/ObjectList/ObjectList.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/StringManipulation/StringFormatter.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/StringManipulation/GenericStringProcessor.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/SarcasmProcessing/SarcasmTextProcessor.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/StringManipulation/deps/ResultsAveraging.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/StringManipulation/TextProcessors/ClickBaitProcessing/ClickBaitTextProcessor.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Date/Date.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/Time/Time.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/DateTime/DateTime.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/Types/DeveloperTypes/Stopwatch/Stopwatch.cpp.o
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/build.make
libDeveloperKit.dylib: CMakeFiles/DeveloperKit.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_13) "Linking CXX shared library libDeveloperKit.dylib"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/DeveloperKit.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/DeveloperKit.dir/build: libDeveloperKit.dylib

.PHONY : CMakeFiles/DeveloperKit.dir/build

CMakeFiles/DeveloperKit.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/DeveloperKit.dir/cmake_clean.cmake
.PHONY : CMakeFiles/DeveloperKit.dir/clean

CMakeFiles/DeveloperKit.dir/depend:
	cd /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /Users/alastairlundy/Documents/Gitlab/developerkit/cpp /Users/alastairlundy/Documents/Gitlab/developerkit/cpp /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug /Users/alastairlundy/Documents/Gitlab/developerkit/cpp/cmake-build-debug/CMakeFiles/DeveloperKit.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/DeveloperKit.dir/depend
