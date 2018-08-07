using System;
using System.Linq;

namespace SonarBadge {
    static class Program {
        static void Main(string[] args) {
            var host = args[0];
            var project = args[1];
            var metrics = new[] {
                "alert_status",
                "reliability_rating",
                "security_rating",
                "bugs",
                "code_smells",
                "sqale_index",
                "vulnerabilities",
                "ncloc",
                "duplicated_lines_density"
            };

            var markdowns = metrics.Select(metric => {
                var md = $@"[![]({host}/api/project_badges/measure?project={project}&metric={metric})]({host}/dashboard?id={project})";
                return md;
            });

            foreach (var md in markdowns) {
                Console.WriteLine(md);
            }
        }
    }
}
