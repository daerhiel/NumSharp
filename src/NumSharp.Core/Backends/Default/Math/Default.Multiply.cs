﻿using System;

namespace NumSharp.Backends
{
    public partial class DefaultEngine
    {
        public override NDArray Multiply(NDArray lhs, NDArray rhs)
        {
            switch (lhs.GetTypeCode)
            {
#if _REGEN
	            %foreach supported_dtypes,supported_dtypes_lowercase%
	            case NPTypeCode.#1: return Multiply#1(lhs, rhs);
	            %
	            default:
		            throw new NotSupportedException();
#else
	            case NPTypeCode.Boolean: return MultiplyBoolean(lhs, rhs);
	            case NPTypeCode.Byte: return MultiplyByte(lhs, rhs);
	            case NPTypeCode.Int16: return MultiplyInt16(lhs, rhs);
	            case NPTypeCode.UInt16: return MultiplyUInt16(lhs, rhs);
	            case NPTypeCode.Int32: return MultiplyInt32(lhs, rhs);
	            case NPTypeCode.UInt32: return MultiplyUInt32(lhs, rhs);
	            case NPTypeCode.Int64: return MultiplyInt64(lhs, rhs);
	            case NPTypeCode.UInt64: return MultiplyUInt64(lhs, rhs);
	            case NPTypeCode.Char: return MultiplyChar(lhs, rhs);
	            case NPTypeCode.Double: return MultiplyDouble(lhs, rhs);
	            case NPTypeCode.Single: return MultiplySingle(lhs, rhs);
	            case NPTypeCode.Decimal: return MultiplyDecimal(lhs, rhs);
	            default:
		            throw new NotSupportedException();
#endif
            }

        }
    }
}
