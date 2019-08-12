# SafeObject
Sometimes in our work, we want to use with theard-safe object in multithrading enviroment.
This is generic calss, that provide smark lock. we are useing with `ReadWriteLock` so that in case of get/set operation we use in apropriate lock,and instead of use always with lock, we use with ReadLock in case of `get`
and use WriteLock in case of `set` operation. 
