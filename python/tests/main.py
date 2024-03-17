import unittest

loader = unittest.TestLoader()
testSuite = loader.discover("python/tests", pattern="*tests.py")
testRunner = unittest.TextTestRunner(verbosity=2)
testRunner.run(testSuite)
