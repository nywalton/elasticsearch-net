using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.XPack.Docs.En.RestApi.Security
{
	public class SamlPrepareAuthenticationApiPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line70()
		{
			// tag::a5dfcfd1cfb3558e7912456669c92eee[]
			var response0 = new SearchResponse<object>();
			// end::a5dfcfd1cfb3558e7912456669c92eee[]

			response0.MatchesExample(@"POST /_security/saml/prepare
			{
			  ""realm"" : ""saml1""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line81()
		{
			// tag::da3f280bc65b581fb3097be768061bee[]
			var response0 = new SearchResponse<object>();
			// end::da3f280bc65b581fb3097be768061bee[]

			response0.MatchesExample(@"POST /_security/saml/prepare
			{
			  ""acs"" : ""https://kibana.org/api/security/saml/callback""
			}");
		}
	}
}