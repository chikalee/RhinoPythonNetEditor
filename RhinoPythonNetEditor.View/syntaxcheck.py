﻿from io import StringIO
from pylint.lint import pylinter
from pylint.lint import Run
from pylint.reporters.text import TextReporter
import io 
def syntax_check(text,path):
    with open(path+r"\temp.py", "w") as f:
        f.write(text)
    pylinter.MANAGER.clear_cache()
    pylint_output = StringIO()  # Custom open stream
    reporter = TextReporter(pylint_output)
    Run([path+r"\temp.py","--disable=all","--enable=Main"], reporter=reporter, exit=False,)
    return pylint_output.getvalue()
