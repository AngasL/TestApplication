using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlDeserialize
{
	class Program
	{
		static void Main(string[] args)
		{
			//var xmlString = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?><UserProfile xmlns=""http://services.lexisnexis.com/xmlschemas/identity/user/1""><securityQuestionAnswer><question></question><answer></answer></securityQuestionAnswer><userLoginId>angasliuR</userLoginId><status>ACTIVE</status><reason></reason><email>angas.liu+au2@lexisnexis.com</email><create>2017-07-17T07:41:12.0</create><lastSuccessfulLogin>2017-08-09T03:09:24</lastSuccessfulLogin><userSignInLocked>false</userSignInLocked><userForgotPasswordLocked>false</userForgotPasswordLocked><firstName>angas</firstName><lastName>liu0</lastName><primaryEmailAddress>angas.liu+au2@lexisnexis.com</primaryEmailAddress><locale>en-US</locale><formattingLocale>en-US</formattingLocale><languageLocale>en-US</languageLocale><timezone>US/Eastern</timezone><userType>VERIFIED</userType></UserProfile>";
			//var userprofile = xmlString.Deserialize<UserProfile>();

			//Console.WriteLine(userprofile.FirstName);

			var xmlString = @"<CheckUserAuthorizationsResponse>
								<componentInfo>
									<componentId>1516772</componentId>
									<authorized>true</authorized>
									<purchaseType>subscription</purchaseType>
									<complimentary>false</complimentary>
								</componentInfo>
							<componentInfo>
								<componentId>1516772</componentId>
								<authorized>true</authorized>
								<purchaseType>subscription</purchaseType>
								<complimentary>false</complimentary>
							</componentInfo>
						</CheckUserAuthorizationsResponse>";

			var result = xmlString.Deserialize<CheckUserAuthorizationsResponse>();

			string testData = @"<StepList>
                        <Step>
                            <Name>Name1</Name>
                            <Desc>Desc1</Desc>
                        </Step>
                        <Step>
                            <Name>Name2</Name>
                            <Desc>Desc2</Desc>
                        </Step>
                    </StepList>";

			var result2 = testData.Deserialize<StepList>();
		}
	}

	[XmlRoot("StepList")]
	public class StepList
	{
		[XmlElement("Step")]
		public List<Step> Steps { get; set; }
	}

	public class Step
	{
		[XmlElement("Name")]
		public string Name { get; set; }
		[XmlElement("Desc")]
		public string Desc { get; set; }
	}

	[XmlRoot("CheckUserAuthorizationsResponse")]
	public class CheckUserAuthorizationsResponse
	{
		[XmlElement("componentInfo")]
		public List<ComponentInfo> ComponentInfos { get; set; }
	}

	public class ComponentInfo
	{
		[XmlElement("componentId")]
		public string ComponentId { get; set; }
		[XmlElement("authorized")]
		public bool Authorized { get; set; }
		[XmlElement("purchaseType")]
		public string PurchaseType { get; set; }
		[XmlElement("complimentary")]
		public string Complimentary { get; set; }
	}

	[Serializable, XmlRoot(Namespace = "http://services.lexisnexis.com/xmlschemas/identity/user/1")]
	public class UserProfile
	{
		[XmlElement("userLoginId")]
		public string UserLoginId { get; set; }
		[XmlElement("userPermId")]
		public string UserPermId { get; set; }
		[XmlElement("email")]
		public string Email { get; set; }
		[XmlElement("primaryEmailAddress")]
		public string PrimaryEmailAddress { get; set; }
		[XmlElement("firstName")]
		public string FirstName { get; set; }
		[XmlElement("lastName")]
		public string LastName { get; set; }
		[XmlElement("status")]
		public string Status { get; set; }
		[XmlElement("locale")]
		public string Locale { get; set; }
		[XmlElement("formattingLocale")]
		public string FormattingLocale { get; set; }
		[XmlElement("languageLocale")]
		public string LanguageLocale { get; set; }
		[XmlElement("timezone")]
		public string Timezone { get; set; }
		[XmlElement("userType")]
		public string UserType { get; set; }
	}

	public static class Extensions
	{
		public static T Deserialize<T>(this string xmlString)
		{
			return (T)Deserialize(xmlString, typeof(T));
		}

		public static object Deserialize(this string xmlString, Type type)
		{
			var serializer = new XmlSerializer(type);
			object result;
			using (var reader = new StringReader(xmlString))
			{
				result = serializer.Deserialize(reader);
			}

			return result;
		}
	}
}
