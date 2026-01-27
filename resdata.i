%module resdata

%{
/* Include standard C/C++ headers */
#include <stdbool.h>
#include <stdlib.h>
#include <stdio.h>

/* Include resdata headers */
#include <resdata/fortio.h>
#include <resdata/smspec_node.h>
#include <resdata/rd_type.hpp>
#include <resdata/rd_util.hpp>
%}

/* Common SWIG directives */
%include <stdint.i>
%include <typemaps.i>

/* Basic type definitions */
typedef long long offset_type;

/* Wrap C headers with simple C API */
%include <resdata/fortio.h>
%include <resdata/smspec_node.h>
