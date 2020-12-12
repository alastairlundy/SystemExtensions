//
//
//

#include "Version.hpp"

/*
 * Initialises all the variables with a default value of 1.0.0.0 with API Level 1.
 * Converts what would individually make up a Version into a Version.
 */
AluminiumTech::DeveloperKit::Version::Version(int_least32_t Major, int_least32_t Minor, int_least32_t Build, int_least32_t Revision, int_least32_t Api_level) {
    major = Major;
    minor = Minor;
    build = Build;
    revision = Revision;
    api_level = Api_level;
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
bool AluminiumTech::DeveloperKit::Version::isThisVersionHigher(const Version& version) {
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
bool AluminiumTech::DeveloperKit::Version::isThisVersionLower(const Version& version) {
    return !isThisVersionHigher(version) && !equals(version);
}

/**
 * Returns whether or not a Version object is equal to this version object.
 * @param version
 * @return
 */
bool AluminiumTech::DeveloperKit::Version::equals(const Version& version) {
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

/**
 * Converts a String in the format of Major.Minor.Build.Revision to a Version.
 * @param versionString
 */
AluminiumTech::DeveloperKit::Version AluminiumTech::DeveloperKit::Version::convertStringToVersion(std::string versionString) {
    AluminiumTech::DeveloperKit::Version version;

    auto splitter = stringFormatter.split_toObjectList('.', versionString);

    try{
        if(splitter.count >= 1){
            version.major = std::stoi(splitter.get(0));
        }
        if(splitter.count > 2){
            version.minor = std::stoi(splitter.get(2));
        }
        if(splitter.count > 4){
            version.build = std::stoi(splitter.get(4));
        }
        if(splitter.count > 6){
            version.revision = std::stoi(splitter.get(6));
        }

        return version;
    }
    catch(std::exception const &e){
        throw &e;
    }
}
