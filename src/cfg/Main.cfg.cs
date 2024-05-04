using System.Reflection;
using HotChocolate.Types.Descriptors;

namespace Cfg;

public class PreserveMethodNamesNamingConvention : DefaultNamingConventions {
  public override string GetMemberName(MemberInfo member, MemberKind kind) => member.Name;
}