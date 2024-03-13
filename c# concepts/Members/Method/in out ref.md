## `in`, `out` & `ref` difference

Used as parameter modifier

All parameters specified in these keywords **must be passed by a reference**


- **`in`** : the parameter passed **cannot** be modified by the method + **must be initialized** before being passed in a method call

- **`out`** : the parameter passed **can be** changed in the method + **not required to be initialized** before being passed in a method call

- **`ref`** : the parameter passed **can be** changed in the method + **must be initialized** before being passed in a method call


#### remark: 
||Can be changed?|must be intialized?|
|-|-|-|
|**`in`**|**F**|**T**|
|**`out`**|**T**|**F**|
|**`ref`**|**T**|**T**|

> `out` & `ref` are used for specify the parameter passed can be modified and returned, while `int` can't
