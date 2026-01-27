%module resdata

%{
/* Include standard C/C++ headers */
#include <stdbool.h>
#include <stdlib.h>
#include <stdio.h>
#include <stdint.h>

/* Basic type definitions that may be needed */
typedef long long offset_type;
%}

/* Common SWIG directives for C# */
%include <stdint.i>
%include <typemaps.i>

/* Define basic types before including headers */
typedef long long offset_type;
typedef int bool;

/* Ignore complex macros and C++ specific features */
#define UTIL_IS_INSTANCE_HEADER(type)
#define UTIL_SAFE_CAST_HEADER(type)
#define extern

/* Wrap the C-compatible headers from lib/include/resdata */
%include <resdata/fortio.h>
%include <resdata/smspec_node.h>
