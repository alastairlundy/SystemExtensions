//
//
//

#include "Version.hpp"

/**
 * Initialises all the variables with a default value of 1.0.0.0 with API Level 1.
 * Feel free to overide this.
 */
AluminiumTech::DeveloperKit::Version::Version() {
    major = 1;
    minor = 0;
    build = 0;
    revision = 0;

    api_level = 1;
}

/**
 * Converts a String in the format of Major.Minor.Build.Revision to a Version.
 * @param versionString
 */
AluminiumTech::DeveloperKit::Version::Version(std::string versionString) {
    auto splitter = stringFormatter.split_toObjectList('.', versionString);

    try{
        if(splitter.count >= 1){
            major = std::stoi(splitter.get(0));
        }
        if(splitter.count > 2){
            minor = std::stoi(splitter.get(2));
        }
        if(splitter.count > 4){
            build = std::stoi(splitter.get(4));
        }
        if(splitter.count > 6){
            revision = std::stoi(splitter.get(6));
        }
    }
    catch(std::invalid_argument const &e){
        throw &e;
    }
    catch(std::out_of_range const &e){
        throw &e;
    }
}

/*
 * Converts what would individually make up a Version into a Version.
 */
template<typename T> requires std::integral<T>
AluminiumTech::DeveloperKit::Version::Version(T Major, T Minor, T Build, T Revision) {
    major = Major;
    minor = Minor;
    build = Build;
    revision = Revision;
    api_level = 1;
}


/**
 * Returns the Version object as a string in the format of Major.Minor.Build.Revision
 * @return
 */
std::string AluminiumTech::DeveloperKit::Version::toString() {
   std::string m_major = std::to_string(major);
   std::string m_minor = std::to_string(minor);
   std::string m_build = std::to_string(build);
   std::string m_revision = std::to_string(revision);

  return m_major + "." + m_minor + "." + m_build + "." + m_revision;
}

/**
 *
 * @param version
 * @return
 */
bool AluminiumTech::DeveloperKit::Version::isThisVersionHigher(Version version) {
    if(major > version.major){
        return true;
    }
    else{
        if(minor > version.minor){
            return true;
        }
        else{
            if(build > version.build){
                return true;
            }
            else{
                return (revision > version.revision);
            }
        }
    }
}

/**
 *
 * @param version
 * @return
 */
bool AluminiumTech::DeveloperKit::Version::isThisVersionLower(Version version) {
    return !isThisVersionHigher(version) && !equals(version);
}

/**
 * Returns whether or not a Version object is equal to this version object.
 * @param version
 * @return
 */
bool AluminiumTech::DeveloperKit::Version::equals(Version version) {
   return (major == version.major && minor == version.minor && build == version.build && revision == version.revision);
}

/**
 *
 */
AluminiumTech::DeveloperKit::Version::~Version() {
   major = 0;
   minor = 0;
   build = 0;
   revision = 0;
}