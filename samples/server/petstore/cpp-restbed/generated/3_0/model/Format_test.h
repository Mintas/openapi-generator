/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 6.4.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * Format_test.h
 *
 * 
 */

#ifndef Format_test_H_
#define Format_test_H_



#include <string>
#include <memory>
#include <vector>
#include <boost/property_tree/ptree.hpp>
#include "helpers.h"

namespace org {
namespace openapitools {
namespace server {
namespace model {

/// <summary>
/// 
/// </summary>
class  Format_test 
{
public:
    Format_test() = default;
    explicit Format_test(boost::property_tree::ptree const& pt);
    virtual ~Format_test() = default;

    Format_test(const Format_test& other) = default; // copy constructor
    Format_test(Format_test&& other) noexcept = default; // move constructor

    Format_test& operator=(const Format_test& other) = default; // copy assignment
    Format_test& operator=(Format_test&& other) noexcept = default; // move assignment

    std::string toJsonString(bool prettyJson = false) const;
    void fromJsonString(std::string const& jsonString);
    boost::property_tree::ptree toPropertyTree() const;
    void fromPropertyTree(boost::property_tree::ptree const& pt);


    /////////////////////////////////////////////
    /// Format_test members

    /// <summary>
    /// 
    /// </summary>
    int32_t getInteger() const;
    void setInteger(int32_t value);

    /// <summary>
    /// 
    /// </summary>
    int32_t getInt32() const;
    void setInt32(int32_t value);

    /// <summary>
    /// 
    /// </summary>
    int64_t getInt64() const;
    void setInt64(int64_t value);

    /// <summary>
    /// 
    /// </summary>
    double getNumber() const;
    void setNumber(double value);

    /// <summary>
    /// 
    /// </summary>
    float getFloat() const;
    void setFloat(float value);

    /// <summary>
    /// 
    /// </summary>
    double getDouble() const;
    void setDouble(double value);

    /// <summary>
    /// 
    /// </summary>
    std::string getDecimal() const;
    void setDecimal(std::string value);

    /// <summary>
    /// 
    /// </summary>
    std::string getString() const;
    void setString(std::string value);

    /// <summary>
    /// 
    /// </summary>
    std::string getByte() const;
    void setByte(std::string value);

    /// <summary>
    /// 
    /// </summary>
    std::string getBinary() const;
    void setBinary(std::string value);

    /// <summary>
    /// 
    /// </summary>
    std::string getDate() const;
    void setDate(std::string value);

    /// <summary>
    /// 
    /// </summary>
    std::string getDateTime() const;
    void setDateTime(std::string value);

    /// <summary>
    /// 
    /// </summary>
    std::string getUuid() const;
    void setUuid(std::string value);

    /// <summary>
    /// 
    /// </summary>
    std::string getPassword() const;
    void setPassword(std::string value);

    /// <summary>
    /// A string that is a 10 digit number. Can have leading zeros.
    /// </summary>
    std::string getPatternWithDigits() const;
    void setPatternWithDigits(std::string value);

    /// <summary>
    /// A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.
    /// </summary>
    std::string getPatternWithDigitsAndDelimiter() const;
    void setPatternWithDigitsAndDelimiter(std::string value);

protected:
    int32_t m_integer = 0;
    int32_t m_Int32 = 0;
    int64_t m_Int64 = 0L;
    double m_number = 0.0;
    float m_float = 0.0f;
    double m_double = 0.0;
    std::string m_decimal = "";
    std::string m_string = "";
    std::string m_Byte = "";
    std::string m_binary = "";
    std::string m_date = "";
    std::string m_DateTime = "";
    std::string m_Uuid = "";
    std::string m_Password = "";
    std::string m_Pattern_with_digits = "";
    std::string m_Pattern_with_digits_and_delimiter = "";
};

std::vector<Format_test> createFormat_testVectorFromJsonString(const std::string& json);

template<>
inline boost::property_tree::ptree toPt<Format_test>(const Format_test& val) {
    return val.toPropertyTree();
}

template<>
inline Format_test fromPt<Format_test>(const boost::property_tree::ptree& pt) {
    Format_test ret;
    ret.fromPropertyTree(pt);
    return ret;
}

}
}
}
}

#endif /* Format_test_H_ */
