<img src="https://nshackblog.files.wordpress.com/2017/02/helixbase1.png" height="154px" width="200px" /><br />
# Helixbase-modules
A repository to store modules that can be used with the Helix Base repository (or in any Helix solution)


#### Module submit instructions

* Please supply a Readme with your module using the [sample template](https://github.com/muso31/Helixbase-modules/tree/master/README_Sample.md)
* Include a package (if required) in the root folder of your module in a folder called [sitecore package](https://github.com/muso31/Helixbase-modules/tree/master/src/Feature/Redirects/sitecore%20package) 

* Your module should follow the frameworks/conventions used in Helix Base e.g.:
  * use the Helixbase namespace - Helixbase.Feature.* for example
  * use SCS if serializing items
  * use Glass if mapping data for MVC modules, (you may wish to use the [Foundation Repositories](https://github.com/muso31/Helixbase/tree/master/src/Foundation/Content/website/Repositories))