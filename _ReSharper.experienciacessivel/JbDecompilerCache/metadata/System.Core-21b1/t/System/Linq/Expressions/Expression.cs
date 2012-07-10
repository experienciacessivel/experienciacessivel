// Type: System.Linq.Expressions.Expression
// Assembly: System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Core.dll

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
    /// <summary>
    /// Provides the base class from which the classes that represent expression tree nodes are derived. It also contains static (Shared in Visual Basic) factory methods to create the various node types. This is an abstract class.
    /// </summary>
    public abstract class Expression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Linq.Expressions.Expression"/> class.
        /// </summary>
        /// <param name="nodeType">The <see cref="T:System.Linq.Expressions.ExpressionType"/> to set as the node type.</param><param name="type">The <see cref="P:System.Linq.Expressions.Expression.Type"/> of this <see cref="T:System.Linq.Expressions.Expression"/>.</param>
        [Obsolete("use a different constructor that does not take ExpressionType. Then override NodeType and Type properties to provide the values that would be specified to this constructor.")]
        protected Expression(ExpressionType nodeType, Type type);

        /// <summary>
        /// Constructs a new instance of <see cref="T:System.Linq.Expressions.Expression"/>.
        /// </summary>
        protected Expression();

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Assign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression Assign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/>, given the left and right operands, by calling an appropriate factory method.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Linq.Expressions.BinaryExpression"/> that results from calling the appropriate factory method.
        /// </returns>
        /// <param name="binaryType">The <see cref="T:System.Linq.Expressions.ExpressionType"/> that specifies the type of binary operation.</param><param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the left operand.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the right operand.</param><exception cref="T:System.ArgumentException"><paramref name="binaryType"/> does not correspond to a binary expression node.</exception><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception>
        public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/>, given the left operand, right operand and implementing method, by calling the appropriate factory method.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Linq.Expressions.BinaryExpression"/> that results from calling the appropriate factory method.
        /// </returns>
        /// <param name="binaryType">The <see cref="T:System.Linq.Expressions.ExpressionType"/> that specifies the type of binary operation.</param><param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the left operand.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the right operand.</param><param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to false.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that specifies the implementing method.</param><exception cref="T:System.ArgumentException"><paramref name="binaryType"/> does not correspond to a binary expression node.</exception><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception>
        public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/>, given the left operand, right operand, implementing method and type conversion function, by calling the appropriate factory method.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Linq.Expressions.BinaryExpression"/> that results from calling the appropriate factory method.
        /// </returns>
        /// <param name="binaryType">The <see cref="T:System.Linq.Expressions.ExpressionType"/> that specifies the type of binary operation.</param><param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the left operand.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the right operand.</param><param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to false.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that specifies the implementing method.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that represents a type conversion function. This parameter is used only if <paramref name="binaryType"/> is <see cref="F:System.Linq.Expressions.ExpressionType.Coalesce"/> or compound assignment..</param><exception cref="T:System.ArgumentException"><paramref name="binaryType"/> does not correspond to a binary expression node.</exception><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception>
        public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an equality comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Equal"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The equality operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Equal(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an equality comparison. The implementing method can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Equal"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to false.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the equality operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a reference equality comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Equal"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression ReferenceEqual(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an inequality comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NotEqual"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The inequality operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression NotEqual(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an inequality comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NotEqual"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to false.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the inequality operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a reference inequality comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NotEqual"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression ReferenceNotEqual(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a "greater than" numeric comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.GreaterThan"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The "greater than" operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression GreaterThan(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a "greater than" numeric comparison. The implementing method can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.GreaterThan"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to false.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the "greater than" operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a "less than" numeric comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LessThan"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The "less than" operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression LessThan(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a "less than" numeric comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LessThan"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to false.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the "less than" operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a "greater than or equal" numeric comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.GreaterThanOrEqual"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The "greater than or equal" operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a "greater than or equal" numeric comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.GreaterThanOrEqual"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to false.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the "greater than or equal" operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a " less than or equal" numeric comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LessThanOrEqual"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The "less than or equal" operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression LessThanOrEqual(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a "less than or equal" numeric comparison.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LessThanOrEqual"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="liftToNull">true to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to true; false to set <see cref="P:System.Linq.Expressions.BinaryExpression.IsLiftedToNull"/> to false.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the "less than or equal" operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a conditional AND operation that evaluates the second operand only if the first operand evaluates to true.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AndAlso"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The bitwise AND operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.-or-<paramref name="left"/>.Type and <paramref name="right"/>.Type are not the same Boolean type.</exception>
        public static BinaryExpression AndAlso(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a conditional AND operation that evaluates the second operand only if the first operand is resolved to true. The implementing method can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AndAlso"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the bitwise AND operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.-or-<paramref name="method"/> is null and <paramref name="left"/>.Type and <paramref name="right"/>.Type are not the same Boolean type.</exception>
        public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a conditional OR operation that evaluates the second operand only if the first operand evaluates to false.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.OrElse"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The bitwise OR operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.-or-<paramref name="left"/>.Type and <paramref name="right"/>.Type are not the same Boolean type.</exception>
        public static BinaryExpression OrElse(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a conditional OR operation that evaluates the second operand only if the first operand evaluates to false.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.OrElse"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the bitwise OR operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.-or-<paramref name="method"/> is null and <paramref name="left"/>.Type and <paramref name="right"/>.Type are not the same Boolean type.</exception>
        public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a coalescing operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Coalesce"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of <paramref name="left"/> does not represent a reference type or a nullable value type.</exception><exception cref="T:System.ArgumentException"><paramref name="left"/>.Type and <paramref name="right"/>.Type are not convertible to each other.</exception>
        public static BinaryExpression Coalesce(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a coalescing operation, given a conversion function.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Coalesce"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="left"/>.Type and <paramref name="right"/>.Type are not convertible to each other.-or-<paramref name="conversion"/> is not null and <paramref name="conversion"/>.Type is a delegate type that does not take exactly one argument.</exception><exception cref="T:System.InvalidOperationException">The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of <paramref name="left"/> does not represent a reference type or a nullable value type.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of <paramref name="left"/> represents a type that is not assignable to the parameter type of the delegate type <paramref name="conversion"/>.Type.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of <paramref name="right"/> is not equal to the return type of the delegate type <paramref name="conversion"/>.Type.</exception>
        public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic addition operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Add"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The addition operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Add(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic addition operation that does not have overflow checking. The implementing method can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Add"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the addition operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Add(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an addition assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression AddAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an addition assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an addition assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an addition assignment operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddAssignChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression AddAssignChecked(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an addition assignment operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddAssignChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an addition assignment operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddAssignChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic addition operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The addition operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression AddChecked(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic addition operation that has overflow checking. The implementing method can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AddChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the addition operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic subtraction operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Subtract"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The subtraction operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Subtract(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic subtraction operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Subtract"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the subtraction operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a subtraction assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression SubtractAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a subtraction assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a subtraction assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a subtraction assignment operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractAssignChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression SubtractAssignChecked(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a subtraction assignment operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractAssignChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a subtraction assignment operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractAssignChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic subtraction operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The subtraction operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression SubtractChecked(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic subtraction operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.SubtractChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the subtraction operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic division operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Divide"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The division operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Divide(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic division operation. The implementing method can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Divide"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the division operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a division assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.DivideAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression DivideAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a division assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.DivideAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a division assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.DivideAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic remainder operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Modulo"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The modulus operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Modulo(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic remainder operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Modulo"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the modulus operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a remainder assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ModuloAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression ModuloAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a remainder assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ModuloAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a remainder assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ModuloAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic multiplication operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Multiply"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The multiplication operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Multiply(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic multiplication operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Multiply"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the multiplication operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a multiplication assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression MultiplyAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a multiplication assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a multiplication assignment operation that does not have overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a multiplication assignment operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyAssignChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a multiplication assignment operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyAssignChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a multiplication assignment operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyAssignChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic multiplication operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The multiplication operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression MultiplyChecked(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents an arithmetic multiplication operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MultiplyChecked"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the multiplication operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise left-shift operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LeftShift"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The left-shift operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression LeftShift(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise left-shift operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LeftShift"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the left-shift operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise left-shift assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LeftShiftAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression LeftShiftAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise left-shift assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LeftShiftAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise left-shift assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.LeftShiftAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise right-shift operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.RightShift"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The right-shift operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression RightShift(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise right-shift operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.RightShift"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the right-shift operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise right-shift assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.RightShiftAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression RightShiftAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise right-shift assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.RightShiftAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise right-shift assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.RightShiftAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise AND operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.And"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The bitwise AND operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression And(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise AND operation. The implementing method can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.And"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the bitwise AND operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression And(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise AND assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AndAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression AndAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise AND assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AndAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise AND assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.AndAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise OR operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Or"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The bitwise OR operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Or(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise OR operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Or"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the bitwise OR operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression Or(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise OR assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.OrAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression OrAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise OR assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.OrAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise OR assignment operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.OrAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise XOR operation, using op_ExclusiveOr for user-defined types.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ExclusiveOr"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The XOR operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression ExclusiveOr(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise XOR operation, using op_ExclusiveOr for user-defined types. The implementing method can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ExclusiveOr"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the XOR operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.</exception>
        public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise XOR assignment operation, using op_ExclusiveOr for user-defined types.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ExclusiveOrAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise XOR assignment operation, using op_ExclusiveOr for user-defined types.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ExclusiveOrAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents a bitwise XOR assignment operation, using op_ExclusiveOr for user-defined types.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ExclusiveOrAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents raising a number to a power.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Power"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.InvalidOperationException">The exponentiation operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.-or-<paramref name="left"/>.Type and/or <paramref name="right"/>.Type are not <see cref="T:System.Double"/>.</exception>
        public static BinaryExpression Power(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents raising a number to a power.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Power"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="left"/> or <paramref name="right"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly two arguments.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the exponentiation operator is not defined for <paramref name="left"/>.Type and <paramref name="right"/>.Type.-or-<paramref name="method"/> is null and <paramref name="left"/>.Type and/or <paramref name="right"/>.Type are not <see cref="T:System.Double"/>.</exception>
        public static BinaryExpression Power(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents raising an expression to a power and assigning the result back to the expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.PowerAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param>
        public static BinaryExpression PowerAssign(Expression left, Expression right);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents raising an expression to a power and assigning the result back to the expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.PowerAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param>
        public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents raising an expression to a power and assigning the result back to the expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.PowerAssign"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/>, <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/>, and <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> properties set to the specified values.
        /// </returns>
        /// <param name="left">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="right">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Method"/> property equal to.</param><param name="conversion">A <see cref="T:System.Linq.Expressions.LambdaExpression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Conversion"/> property equal to.</param>
        public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BinaryExpression"/> that represents applying an array index operator to an array of rank one.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.BinaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ArrayIndex"/> and the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> and <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        /// <param name="array">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Left"/> property equal to.</param><param name="index">A <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.BinaryExpression.Right"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="array"/> or <paramref name="index"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="array"/>.Type does not represent an array type.-or-<paramref name="array"/>.Type represents an array type whose rank is not 1.-or-<paramref name="index"/>.Type does not represent the <see cref="T:System.Int32"/> type.</exception>
        public static BinaryExpression ArrayIndex(Expression array, Expression index);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains two expressions and has no variables.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="arg0">The first expression in the block.</param><param name="arg1">The second expression in the block.</param>
        public static BlockExpression Block(Expression arg0, Expression arg1);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains three expressions and has no variables.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="arg0">The first expression in the block.</param><param name="arg1">The second expression in the block.</param><param name="arg2">The third expression in the block.</param>
        public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains four expressions and has no variables.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="arg0">The first expression in the block.</param><param name="arg1">The second expression in the block.</param><param name="arg2">The third expression in the block.</param><param name="arg3">The fourth expression in the block.</param>
        public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains five expressions and has no variables.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="arg0">The first expression in the block.</param><param name="arg1">The second expression in the block.</param><param name="arg2">The third expression in the block.</param><param name="arg3">The fourth expression in the block.</param><param name="arg4">The fifth expression in the block.</param>
        public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains the given expressions and has no variables.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="expressions">The expressions in the block.</param>
        public static BlockExpression Block(params Expression[] expressions);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains the given expressions and has no variables.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="expressions">The expressions in the block.</param>
        public static BlockExpression Block(IEnumerable<Expression> expressions);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains the given expressions, has no variables and has specific result type.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="type">The result type of the block.</param><param name="expressions">The expressions in the block.</param>
        public static BlockExpression Block(Type type, params Expression[] expressions);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains the given expressions, has no variables and has specific result type.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="type">The result type of the block.</param><param name="expressions">The expressions in the block.</param>
        public static BlockExpression Block(Type type, IEnumerable<Expression> expressions);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains the given variables and expressions.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="variables">The variables in the block.</param><param name="expressions">The expressions in the block.</param>
        public static BlockExpression Block(IEnumerable<ParameterExpression> variables, params Expression[] expressions);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains the given variables and expressions.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="type">The result type of the block.</param><param name="variables">The variables in the block.</param><param name="expressions">The expressions in the block.</param>
        public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, params Expression[] expressions);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains the given variables and expressions.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="variables">The variables in the block.</param><param name="expressions">The expressions in the block.</param>
        public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.BlockExpression"/> that contains the given variables and expressions.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.BlockExpression"/>.
        /// </returns>
        /// <param name="type">The result type of the block.</param><param name="variables">The variables in the block.</param><param name="expressions">The expressions in the block.</param>
        public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.CatchBlock"/> representing a catch statement.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.CatchBlock"/>.
        /// </returns>
        /// <param name="type">The <see cref="P:System.Linq.Expressions.Expression.Type"/> of <see cref="T:System.Exception"/> this <see cref="T:System.Linq.Expressions.CatchBlock"/> will handle.</param><param name="body">The body of the catch statement.</param>
        public static CatchBlock Catch(Type type, Expression body);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.CatchBlock"/> representing a catch statement with a reference to the caught <see cref="T:System.Exception"/> object for use in the handler body.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.CatchBlock"/>.
        /// </returns>
        /// <param name="variable">A <see cref="T:System.Linq.Expressions.ParameterExpression"/> representing a reference to the <see cref="T:System.Exception"/> object caught by this handler.</param><param name="body">The body of the catch statement.</param>
        public static CatchBlock Catch(ParameterExpression variable, Expression body);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.CatchBlock"/> representing a catch statement with an <see cref="T:System.Exception"/> filter but no reference to the caught <see cref="T:System.Exception"/> object.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.CatchBlock"/>.
        /// </returns>
        /// <param name="type">The <see cref="P:System.Linq.Expressions.Expression.Type"/> of <see cref="T:System.Exception"/> this <see cref="T:System.Linq.Expressions.CatchBlock"/> will handle.</param><param name="body">The body of the catch statement.</param><param name="filter">The body of the <see cref="T:System.Exception"/> filter.</param>
        public static CatchBlock Catch(Type type, Expression body, Expression filter);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.CatchBlock"/> representing a catch statement with an <see cref="T:System.Exception"/> filter and a reference to the caught <see cref="T:System.Exception"/> object.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.CatchBlock"/>.
        /// </returns>
        /// <param name="variable">A <see cref="T:System.Linq.Expressions.ParameterExpression"/> representing a reference to the <see cref="T:System.Exception"/> object caught by this handler.</param><param name="body">The body of the catch statement.</param><param name="filter">The body of the <see cref="T:System.Exception"/> filter.</param>
        public static CatchBlock Catch(ParameterExpression variable, Expression body, Expression filter);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.CatchBlock"/> representing a catch statement with the specified elements.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.CatchBlock"/>.
        /// </returns>
        /// <param name="type">The <see cref="P:System.Linq.Expressions.Expression.Type"/> of <see cref="T:System.Exception"/> this <see cref="T:System.Linq.Expressions.CatchBlock"/> will handle.</param><param name="variable">A <see cref="T:System.Linq.Expressions.ParameterExpression"/> representing a reference to the <see cref="T:System.Exception"/> object caught by this handler.</param><param name="body">The body of the catch statement.</param><param name="filter">The body of the <see cref="T:System.Exception"/> filter.</param>
        public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ConditionalExpression"/> that represents a conditional statement.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ConditionalExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Conditional"/> and the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test"/>, <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue"/>, and <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse"/> properties set to the specified values.
        /// </returns>
        /// <param name="test">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test"/> property equal to.</param><param name="ifTrue">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue"/> property equal to.</param><param name="ifFalse">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="test"/> or <paramref name="ifTrue"/> or <paramref name="ifFalse"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="test"/>.Type is not <see cref="T:System.Boolean"/>.-or-<paramref name="ifTrue"/>.Type is not equal to <paramref name="ifFalse"/>.Type.</exception>
        public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ConditionalExpression"/> that represents a conditional statement.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ConditionalExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Conditional"/> and the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test"/>, <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue"/>, and <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse"/> properties set to the specified values.
        /// </returns>
        /// <param name="test">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test"/> property equal to.</param><param name="ifTrue">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue"/> property equal to.</param><param name="ifFalse">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse"/> property equal to.</param><param name="type">A <see cref="P:System.Linq.Expressions.Expression.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param>
        public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ConditionalExpression"/> that represents a conditional block with an if statement.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ConditionalExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Conditional"/> and the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test"/>, <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue"/>, properties set to the specified values. The <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse"/> property is set to default expression and the type of the resulting <see cref="T:System.Linq.Expressions.ConditionalExpression"/> returned by this method is <see cref="T:System.Void"/>.
        /// </returns>
        /// <param name="test">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test"/> property equal to.</param><param name="ifTrue">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue"/> property equal to.</param>
        public static ConditionalExpression IfThen(Expression test, Expression ifTrue);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ConditionalExpression"/> that represents a conditional block with if and else statements.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ConditionalExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Conditional"/> and the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test"/>, <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue"/>, and <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse"/> properties set to the specified values. The type of the resulting <see cref="T:System.Linq.Expressions.ConditionalExpression"/> returned by this method is <see cref="T:System.Void"/>.
        /// </returns>
        /// <param name="test">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.Test"/> property equal to.</param><param name="ifTrue">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfTrue"/> property equal to.</param><param name="ifFalse">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.ConditionalExpression.IfFalse"/> property equal to.</param>
        public static ConditionalExpression IfThenElse(Expression test, Expression ifTrue, Expression ifFalse);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ConstantExpression"/> that has the <see cref="P:System.Linq.Expressions.ConstantExpression.Value"/> property set to the specified value.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ConstantExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Constant"/> and the <see cref="P:System.Linq.Expressions.ConstantExpression.Value"/> property set to the specified value.
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> to set the <see cref="P:System.Linq.Expressions.ConstantExpression.Value"/> property equal to.</param>
        public static ConstantExpression Constant(object value);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ConstantExpression"/> that has the <see cref="P:System.Linq.Expressions.ConstantExpression.Value"/> and <see cref="P:System.Linq.Expressions.Expression.Type"/> properties set to the specified values.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ConstantExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Constant"/> and the <see cref="P:System.Linq.Expressions.ConstantExpression.Value"/> and <see cref="P:System.Linq.Expressions.Expression.Type"/> properties set to the specified values.
        /// </returns>
        /// <param name="value">An <see cref="T:System.Object"/> to set the <see cref="P:System.Linq.Expressions.ConstantExpression.Value"/> property equal to.</param><param name="type">A <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="type"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="value"/> is not null and <paramref name="type"/> is not assignable from the dynamic type of <paramref name="value"/>.</exception>
        public static ConstantExpression Constant(object value, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DebugInfoExpression"/> with the specified span.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.DebugInfoExpression"/>.
        /// </returns>
        /// <param name="document">The <see cref="T:System.Linq.Expressions.SymbolDocumentInfo"/> that represents the source file.</param><param name="startLine">The start line of this <see cref="T:System.Linq.Expressions.DebugInfoExpression"/>. Must be greater than 0.</param><param name="startColumn">The start column of this <see cref="T:System.Linq.Expressions.DebugInfoExpression"/>. Must be greater than 0.</param><param name="endLine">The end line of this <see cref="T:System.Linq.Expressions.DebugInfoExpression"/>. Must be greater or equal than the start line.</param><param name="endColumn">The end column of this <see cref="T:System.Linq.Expressions.DebugInfoExpression"/>. If the end line is the same as the start line, it must be greater or equal than the start column. In any case, must be greater than 0.</param>
        public static DebugInfoExpression DebugInfo(SymbolDocumentInfo document, int startLine, int startColumn, int endLine, int endColumn);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DebugInfoExpression"/> for clearing a sequence point.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.DebugInfoExpression"/> for clearning a sequence point.
        /// </returns>
        /// <param name="document">The <see cref="T:System.Linq.Expressions.SymbolDocumentInfo"/> that represents the source file.</param>
        public static DebugInfoExpression ClearDebugInfo(SymbolDocumentInfo document);

        /// <summary>
        /// Creates an empty expression that has <see cref="T:System.Void"/> type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DefaultExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Default"/> and the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to <see cref="T:System.Void"/>.
        /// </returns>
        public static DefaultExpression Empty();

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DefaultExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to the specified type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DefaultExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Default"/> and the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to the specified type.
        /// </returns>
        /// <param name="type">A <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param>
        public static DefaultExpression Default(Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType"/>, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/>, and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="delegateType">The type of the delegate used by the <see cref="T:System.Runtime.CompilerServices.CallSite"/>.</param><param name="binder">The runtime binder for the dynamic operation.</param><param name="arguments">The arguments to the dynamic operation.</param>
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, params Expression[] arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType"/>, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/>, and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="delegateType">The type of the delegate used by the <see cref="T:System.Runtime.CompilerServices.CallSite"/>.</param><param name="binder">The runtime binder for the dynamic operation.</param><param name="arguments">The arguments to the dynamic operation.</param>
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, IEnumerable<Expression> arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/> and one argument.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType"/>, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/>, and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="delegateType">The type of the delegate used by the <see cref="T:System.Runtime.CompilerServices.CallSite"/>.</param><param name="binder">The runtime binder for the dynamic operation.</param><param name="arg0">The argument to the dynamic operation.</param>
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/> and two arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType"/>, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/>, and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="delegateType">The type of the delegate used by the <see cref="T:System.Runtime.CompilerServices.CallSite"/>.</param><param name="binder">The runtime binder for the dynamic operation.</param><param name="arg0">The first argument to the dynamic operation.</param><param name="arg1">The second argument to the dynamic operation.</param>
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/> and three arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType"/>, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/>, and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="delegateType">The type of the delegate used by the <see cref="T:System.Runtime.CompilerServices.CallSite"/>.</param><param name="binder">The runtime binder for the dynamic operation.</param><param name="arg0">The first argument to the dynamic operation.</param><param name="arg1">The second argument to the dynamic operation.</param><param name="arg2">The third argument to the dynamic operation.</param>
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/> and four arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.DelegateType"/>, <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/>, and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="delegateType">The type of the delegate used by the <see cref="T:System.Runtime.CompilerServices.CallSite"/>.</param><param name="binder">The runtime binder for the dynamic operation.</param><param name="arg0">The first argument to the dynamic operation.</param><param name="arg1">The second argument to the dynamic operation.</param><param name="arg2">The third argument to the dynamic operation.</param><param name="arg3">The fourth argument to the dynamic operation.</param>
        public static DynamicExpression MakeDynamic(Type delegateType, CallSiteBinder binder, Expression arg0, Expression arg1, Expression arg2, Expression arg3);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/> and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="binder">The runtime binder for the dynamic operation.</param><param name="returnType">The result type of the dynamic expression.</param><param name="arguments">The arguments to the dynamic operation.</param>
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, params Expression[] arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/> and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="binder">The runtime binder for the dynamic operation.</param><param name="returnType">The result type of the dynamic expression.</param><param name="arg0">The first argument to the dynamic operation.</param>
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/> and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="binder">The runtime binder for the dynamic operation.</param><param name="returnType">The result type of the dynamic expression.</param><param name="arg0">The first argument to the dynamic operation.</param><param name="arg1">The second argument to the dynamic operation.</param>
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/> and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="binder">The runtime binder for the dynamic operation.</param><param name="returnType">The result type of the dynamic expression.</param><param name="arg0">The first argument to the dynamic operation.</param><param name="arg1">The second argument to the dynamic operation.</param><param name="arg2">The third argument to the dynamic operation.</param>
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/> and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="binder">The runtime binder for the dynamic operation.</param><param name="returnType">The result type of the dynamic expression.</param><param name="arg0">The first argument to the dynamic operation.</param><param name="arg1">The second argument to the dynamic operation.</param><param name="arg2">The third argument to the dynamic operation.</param><param name="arg3">The fourth argument to the dynamic operation.</param>
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.DynamicExpression"/> that represents a dynamic operation bound by the provided <see cref="T:System.Runtime.CompilerServices.CallSiteBinder"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.DynamicExpression"/> that has <see cref="P:System.Linq.Expressions.Expression.NodeType"/> equal to <see cref="F:System.Linq.Expressions.ExpressionType.Dynamic"/> and has the <see cref="P:System.Linq.Expressions.DynamicExpression.Binder"/> and <see cref="P:System.Linq.Expressions.DynamicExpression.Arguments"/> set to the specified values.
        /// </returns>
        /// <param name="binder">The runtime binder for the dynamic operation.</param><param name="returnType">The result type of the dynamic expression.</param><param name="arguments">The arguments to the dynamic operation.</param>
        public static DynamicExpression Dynamic(CallSiteBinder binder, Type returnType, IEnumerable<Expression> arguments);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.ElementInit"/>, given an array of values as the second argument.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Linq.Expressions.ElementInit"/> that has the <see cref="P:System.Linq.Expressions.ElementInit.AddMethod"/> and <see cref="P:System.Linq.Expressions.ElementInit.Arguments"/> properties set to the specified values.
        /// </returns>
        /// <param name="addMethod">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.ElementInit.AddMethod"/> property equal to.</param><param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects to set the <see cref="P:System.Linq.Expressions.ElementInit.Arguments"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="addMethod"/> or <paramref name="arguments"/> is null.</exception><exception cref="T:System.ArgumentException">The method that addMethod represents is not named "Add" (case insensitive).-or-The method that addMethod represents is not an instance method.-or-arguments does not contain the same number of elements as the number of parameters for the method that addMethod represents.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of one or more elements of <paramref name="arguments"/> is not assignable to the type of the corresponding parameter of the method that <paramref name="addMethod"/> represents.</exception>
        public static ElementInit ElementInit(MethodInfo addMethod, params Expression[] arguments);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.ElementInit"/>, given an <see cref="T:System.Collections.Generic.IEnumerable`1"/> as the second argument.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Linq.Expressions.ElementInit"/> that has the <see cref="P:System.Linq.Expressions.ElementInit.AddMethod"/> and <see cref="P:System.Linq.Expressions.ElementInit.Arguments"/> properties set to the specified values.
        /// </returns>
        /// <param name="addMethod">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.ElementInit.AddMethod"/> property equal to.</param><param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects to set the <see cref="P:System.Linq.Expressions.ElementInit.Arguments"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="addMethod"/> or <paramref name="arguments"/> is null.</exception><exception cref="T:System.ArgumentException">The method that <paramref name="addMethod"/> represents is not named "Add" (case insensitive).-or-The method that <paramref name="addMethod"/> represents is not an instance method.-or-<paramref name="arguments"/> does not contain the same number of elements as the number of parameters for the method that <paramref name="addMethod"/> represents.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of one or more elements of <paramref name="arguments"/> is not assignable to the type of the corresponding parameter of the method that <paramref name="addMethod"/> represents.</exception>
        public static ElementInit ElementInit(MethodInfo addMethod, IEnumerable<Expression> arguments);

        /// <summary>
        /// Reduces this node to a simpler expression. If CanReduce returns true, this should return a valid expression. This method can return another node which itself must be reduced.
        /// </summary>
        /// 
        /// <returns>
        /// The reduced expression.
        /// </returns>
        public virtual Expression Reduce();

        /// <summary>
        /// Reduces the node and then calls the visitor delegate on the reduced expression. The method throws an exception if the node is not reducible.
        /// </summary>
        /// 
        /// <returns>
        /// The expression being visited, or an expression which should replace it in the tree.
        /// </returns>
        /// <param name="visitor">An instance of <see cref="T:System.Func`2"/>.</param>
        protected internal virtual Expression VisitChildren(ExpressionVisitor visitor);

        /// <summary>
        /// Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression"/> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)"/>.
        /// </summary>
        /// 
        /// <returns>
        /// The result of visiting this node.
        /// </returns>
        /// <param name="visitor">The visitor to visit this node with.</param>
        protected internal virtual Expression Accept(ExpressionVisitor visitor);

        /// <summary>
        /// Reduces this node to a simpler expression. If CanReduce returns true, this should return a valid expression. This method can return another node which itself must be reduced.
        /// </summary>
        /// 
        /// <returns>
        /// The reduced expression.
        /// </returns>
        public Expression ReduceAndCheck();

        /// <summary>
        /// Reduces the expression to a known node type (that is not an Extension node) or just returns the expression if it is already a known type.
        /// </summary>
        /// 
        /// <returns>
        /// The reduced expression.
        /// </returns>
        public Expression ReduceExtensions();

        /// <summary>
        /// Returns a textual representation of the <see cref="T:System.Linq.Expressions.Expression"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A textual representation of the <see cref="T:System.Linq.Expressions.Expression"/>.
        /// </returns>
        public override string ToString();

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a break statement.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Break, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, and a null value to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param>
        public static GotoExpression Break(LabelTarget target);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a break statement. The value passed to the label upon jumping can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Break, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, and <paramref name="value"/> to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="value">The value that will be passed to the associated label upon jumping.</param>
        public static GotoExpression Break(LabelTarget target, Expression value);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a break statement with the specified type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Break, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, and the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to <paramref name="type"/>.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="type">An <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param>
        public static GotoExpression Break(LabelTarget target, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a break statement with the specified type. The value passed to the label upon jumping can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Break, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to <paramref name="type"/>, and <paramref name="value"/> to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="value">The value that will be passed to the associated label upon jumping.</param><param name="type">An <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param>
        public static GotoExpression Break(LabelTarget target, Expression value, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a continue statement.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Continue, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, and a null value to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param>
        public static GotoExpression Continue(LabelTarget target);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a continue statement with the specified type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Continue, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to <paramref name="type"/>, and a null value to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="type">An <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param>
        public static GotoExpression Continue(LabelTarget target, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a return statement.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Return, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, and a null value to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param>
        public static GotoExpression Return(LabelTarget target);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a return statement with the specified type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Return, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to <paramref name="type"/>, and a null value to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="type">An <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param>
        public static GotoExpression Return(LabelTarget target, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a return statement. The value passed to the label upon jumping can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Continue, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, and <paramref name="value"/> to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="value">The value that will be passed to the associated label upon jumping.</param>
        public static GotoExpression Return(LabelTarget target, Expression value);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a return statement with the specified type. The value passed to the label upon jumping can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Continue, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to <paramref name="type"/>, and <paramref name="value"/> to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="value">The value that will be passed to the associated label upon jumping.</param><param name="type">An <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param>
        public static GotoExpression Return(LabelTarget target, Expression value, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a "go to" statement.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Goto, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to the specified value, and a null value to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param>
        public static GotoExpression Goto(LabelTarget target);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a "go to" statement with the specified type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Goto, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to the specified value, the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to <paramref name="type"/>, and a null value to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="type">An <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param>
        public static GotoExpression Goto(LabelTarget target, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a "go to" statement. The value passed to the label upon jumping can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Goto, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, and <paramref name="value"/> to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="value">The value that will be passed to the associated label upon jumping.</param>
        public static GotoExpression Goto(LabelTarget target, Expression value);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a "go to" statement with the specified type. The value passed to the label upon jumping can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to Goto, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to <paramref name="type"/>, and <paramref name="value"/> to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="value">The value that will be passed to the associated label upon jumping.</param><param name="type">An <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param>
        public static GotoExpression Goto(LabelTarget target, Expression value, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.GotoExpression"/> representing a jump of the specified <see cref="T:System.Linq.Expressions.GotoExpressionKind"/>. The value passed to the label upon jumping can also be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.GotoExpression"/> with <see cref="P:System.Linq.Expressions.GotoExpression.Kind"/> equal to <paramref name="kind"/>, the <see cref="P:System.Linq.Expressions.GotoExpression.Target"/> property set to <paramref name="target"/>, the <see cref="P:System.Linq.Expressions.Expression.Type"/> property set to <paramref name="type"/>, and <paramref name="value"/> to be passed to the target label upon jumping.
        /// </returns>
        /// <param name="kind">The <see cref="T:System.Linq.Expressions.GotoExpressionKind"/> of the <see cref="T:System.Linq.Expressions.GotoExpression"/>.</param><param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> that the <see cref="T:System.Linq.Expressions.GotoExpression"/> will jump to.</param><param name="value">The value that will be passed to the associated label upon jumping.</param><param name="type">An <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param>
        public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.IndexExpression"/> that represents accessing an indexed property in an object.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.IndexExpression"/>.
        /// </returns>
        /// <param name="instance">The object to which the property belongs. It should be null if the property is static (shared in Visual Basic).</param><param name="indexer">An <see cref="T:System.Linq.Expressions.Expression"/> representing the property to index.</param><param name="arguments">An IEnumerable&lt;Expression&gt; (IEnumerable (Of Expression) in Visual Basic) that contains the arguments that will be used to index the property.</param>
        public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.IndexExpression"/> to access an array.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.IndexExpression"/>.
        /// </returns>
        /// <param name="array">An expression representing the array to index.</param><param name="indexes">An array that contains expressions used to index the array.</param>
        public static IndexExpression ArrayAccess(Expression array, params Expression[] indexes);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.IndexExpression"/> to access a multidimensional array.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.IndexExpression"/>.
        /// </returns>
        /// <param name="array">An expression that represents the multidimensional array.</param><param name="indexes">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> containing expressions used to index the array.</param>
        public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.IndexExpression"/> representing the access to an indexed property.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.IndexExpression"/>.
        /// </returns>
        /// <param name="instance">The object to which the property belongs. If the property is static/shared, it must be null.</param><param name="propertyName">The name of the indexer.</param><param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects that are used to index the property.</param>
        public static IndexExpression Property(Expression instance, string propertyName, params Expression[] arguments);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.IndexExpression"/> representing the access to an indexed property.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.IndexExpression"/>.
        /// </returns>
        /// <param name="instance">The object to which the property belongs. If the property is static/shared, it must be null.</param><param name="indexer">The <see cref="T:System.Reflection.PropertyInfo"/> that represents the property to index.</param><param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects that are used to index the property.</param>
        public static IndexExpression Property(Expression instance, PropertyInfo indexer, params Expression[] arguments);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.IndexExpression"/> representing the access to an indexed property.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.IndexExpression"/>.
        /// </returns>
        /// <param name="instance">The object to which the property belongs. If the property is static/shared, it must be null.</param><param name="indexer">The <see cref="T:System.Reflection.PropertyInfo"/> that represents the property to index.</param><param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> of <see cref="T:System.Linq.Expressions.Expression"/> objects that are used to index the property.</param>
        public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.InvocationExpression"/> that applies a delegate or lambda expression to a list of argument expressions.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Linq.Expressions.InvocationExpression"/> that applies the specified delegate or lambda expression to the provided arguments.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the delegate or lambda expression to be applied.</param><param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects that represent the arguments that the delegate or lambda expression is applied to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="expression"/>.Type does not represent a delegate type or an <see cref="T:System.Linq.Expressions.Expression`1"/>.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="arguments"/> is not assignable to the type of the corresponding parameter of the delegate represented by <paramref name="expression"/>.</exception><exception cref="T:System.InvalidOperationException"><paramref name="arguments"/> does not contain the same number of elements as the list of parameters for the delegate represented by <paramref name="expression"/>.</exception>
        public static InvocationExpression Invoke(Expression expression, params Expression[] arguments);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.InvocationExpression"/> that applies a delegate or lambda expression to a list of argument expressions.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Linq.Expressions.InvocationExpression"/> that applies the specified delegate or lambda expression to the provided arguments.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the delegate or lambda expression to be applied to.</param><param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects that represent the arguments that the delegate or lambda expression is applied to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="expression"/>.Type does not represent a delegate type or an <see cref="T:System.Linq.Expressions.Expression`1"/>.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="arguments"/> is not assignable to the type of the corresponding parameter of the delegate represented by <paramref name="expression"/>.</exception><exception cref="T:System.InvalidOperationException"><paramref name="arguments"/> does not contain the same number of elements as the list of parameters for the delegate represented by <paramref name="expression"/>.</exception>
        public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LabelExpression"/> representing a label without a default value.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LabelExpression"/> without a default value.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> which this <see cref="T:System.Linq.Expressions.LabelExpression"/> will be associated with.</param>
        public static LabelExpression Label(LabelTarget target);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LabelExpression"/> representing a label with the given default value.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LabelExpression"/> with the given default value.
        /// </returns>
        /// <param name="target">The <see cref="T:System.Linq.Expressions.LabelTarget"/> which this <see cref="T:System.Linq.Expressions.LabelExpression"/> will be associated with.</param><param name="defaultValue">The value of this <see cref="T:System.Linq.Expressions.LabelExpression"/> when the label is reached through regular control flow.</param>
        public static LabelExpression Label(LabelTarget target, Expression defaultValue);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LabelTarget"/> representing a label with void type and no name.
        /// </summary>
        /// 
        /// <returns>
        /// The new <see cref="T:System.Linq.Expressions.LabelTarget"/>.
        /// </returns>
        public static LabelTarget Label();

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LabelTarget"/> representing a label with void type and the given name.
        /// </summary>
        /// 
        /// <returns>
        /// The new <see cref="T:System.Linq.Expressions.LabelTarget"/>.
        /// </returns>
        /// <param name="name">The name of the label.</param>
        public static LabelTarget Label(string name);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LabelTarget"/> representing a label with the given type.
        /// </summary>
        /// 
        /// <returns>
        /// The new <see cref="T:System.Linq.Expressions.LabelTarget"/>.
        /// </returns>
        /// <param name="type">The type of value that is passed when jumping to the label.</param>
        public static LabelTarget Label(Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LabelTarget"/> representing a label with the given type and name.
        /// </summary>
        /// 
        /// <returns>
        /// The new <see cref="T:System.Linq.Expressions.LabelTarget"/>.
        /// </returns>
        /// <param name="type">The type of value that is passed when jumping to the label.</param><param name="name">The name of the label.</param>
        public static LabelTarget Label(Type type, string name);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.Expression`1"/> where the delegate type is known at compile time.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Linq.Expressions.Expression`1"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Lambda"/> and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="parameters">An array of <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param><typeparam name="TDelegate">A delegate type.</typeparam><exception cref="T:System.ArgumentNullException"><paramref name="body"/> is null.-or-One or more elements in <paramref name="parameters"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="TDelegate"/> is not a delegate type.-or-<paramref name="body"/>.Type represents a type that is not assignable to the return type of <paramref name="TDelegate"/>.-or-<paramref name="parameters"/> does not contain the same number of elements as the list of parameters for <paramref name="TDelegate"/>.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="parameters"/> is not assignable from the type of the corresponding parameter type of <paramref name="TDelegate"/>.</exception>
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params ParameterExpression[] parameters);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.Expression`1"/> where the delegate type is known at compile time.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Linq.Expressions.Expression`1"/> that has the <see cref="P:System.Linq.Expressions.Expression`1.NodeType"/> property equal to <see cref="P:System.Linq.Expressions.Expression`1.Lambda"/> and the <see cref="P:System.Linq.Expressions.Expression`1.Body"/> and <see cref="P:System.Linq.Expressions.Expression`1.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.Expression`1.Body"/> property equal to.</param><param name="tailCall">A <see cref="T:System.Boolean"/> that indicates if tail call optimization will be applied when compiling the created expression.</param><param name="parameters">An array that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.Expression`1.Parameters"/> collection.</param><typeparam name="TDelegate">The delegate type. </typeparam>
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, params ParameterExpression[] parameters);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.Expression`1"/> where the delegate type is known at compile time.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Linq.Expressions.Expression`1"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Lambda"/> and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param><typeparam name="TDelegate">A delegate type.</typeparam><exception cref="T:System.ArgumentNullException"><paramref name="body"/> is null.-or-One or more elements in <paramref name="parameters"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="TDelegate"/> is not a delegate type.-or-<paramref name="body"/>.Type represents a type that is not assignable to the return type of <paramref name="TDelegate"/>.-or-<paramref name="parameters"/> does not contain the same number of elements as the list of parameters for <paramref name="TDelegate"/>.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="parameters"/> is not assignable from the type of the corresponding parameter type of <paramref name="TDelegate"/>.</exception>
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.Expression`1"/> where the delegate type is known at compile time.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Linq.Expressions.Expression`1"/> that has the <see cref="P:System.Linq.Expressions.Expression`1.NodeType"/> property equal to <see cref="P:System.Linq.Expressions.Expression`1.Lambda"/> and the <see cref="P:System.Linq.Expressions.Expression`1.Body"/> and <see cref="P:System.Linq.Expressions.Expression`1.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.Expression`1.Body"/> property equal to.</param><param name="tailCall">A <see cref="T:System.Boolean"/> that indicates if tail call optimization will be applied when compiling the created expression.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.Expression`1.Parameters"/> collection.</param><typeparam name="TDelegate">The delegate type. </typeparam>
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.Expression`1"/> where the delegate type is known at compile time.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Linq.Expressions.Expression`1"/> that has the <see cref="P:System.Linq.Expressions.Expression`1.NodeType"/> property equal to <see cref="P:System.Linq.Expressions.Expression`1.Lambda"/> and the <see cref="P:System.Linq.Expressions.Expression`1.Body"/> and <see cref="P:System.Linq.Expressions.Expression`1.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.Expression`1.Body"/> property equal to.</param><param name="name">The name of the lambda. Used for generating debugging information.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.Expression`1.Parameters"/> collection.</param><typeparam name="TDelegate">The delegate type. </typeparam>
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates an <see cref="T:System.Linq.Expressions.Expression`1"/> where the delegate type is known at compile time.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Linq.Expressions.Expression`1"/> that has the <see cref="P:System.Linq.Expressions.Expression`1.NodeType"/> property equal to <see cref="P:System.Linq.Expressions.Expression`1.Lambda"/> and the <see cref="P:System.Linq.Expressions.Expression`1.Body"/> and <see cref="P:System.Linq.Expressions.Expression`1.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.Expression`1.Body"/> property equal to.</param><param name="name">The name of the lambda. Used for generating debugging info.</param><param name="tailCall">A <see cref="T:System.Boolean"/> that indicates if tail call optimization will be applied when compiling the created expression.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.Expression`1.Parameters"/> collection.</param><typeparam name="TDelegate">The delegate type. </typeparam>
        public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LambdaExpression"/> by first constructing a delegate type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Lambda"/> and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="parameters">An array of <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="body"/> is null.-or-One or more elements of <paramref name="parameters"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="parameters"/> contains more than sixteen elements.</exception>
        public static LambdaExpression Lambda(Expression body, params ParameterExpression[] parameters);

        /// <summary>
        /// Creates a LambdaExpression by first constructing a delegate type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType"/> property equal to Lambda and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="tailCall">A <see cref="T:System.Boolean"/> that indicates if tail call optimization will be applied when compiling the created expression.</param><param name="parameters">An array that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param>
        public static LambdaExpression Lambda(Expression body, bool tailCall, params ParameterExpression[] parameters);

        /// <summary>
        /// Creates a LambdaExpression by first constructing a delegate type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType"/> property equal to Lambda and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param>
        public static LambdaExpression Lambda(Expression body, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates a LambdaExpression by first constructing a delegate type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType"/> property equal to Lambda and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="tailCall">A <see cref="T:System.Boolean"/> that indicates if tail call optimization will be applied when compiling the created expression.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param>
        public static LambdaExpression Lambda(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LambdaExpression"/> by first constructing a delegate type. It can be used when the delegate type is not known at compile time.
        /// </summary>
        /// 
        /// <returns>
        /// An object that represents a lambda expression which has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Lambda"/> and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="delegateType">A <see cref="T:System.Type"/> that represents a delegate signature for the lambda.</param><param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="parameters">An array of <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="delegateType"/> or <paramref name="body"/> is null.-or-One or more elements in <paramref name="parameters"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="delegateType"/> does not represent a delegate type.-or-<paramref name="body"/>.Type represents a type that is not assignable to the return type of the delegate type represented by <paramref name="delegateType"/>.-or-<paramref name="parameters"/> does not contain the same number of elements as the list of parameters for the delegate type represented by <paramref name="delegateType"/>.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="parameters"/> is not assignable from the type of the corresponding parameter type of the delegate type represented by <paramref name="delegateType"/>.</exception>
        public static LambdaExpression Lambda(Type delegateType, Expression body, params ParameterExpression[] parameters);

        /// <summary>
        /// Creates a LambdaExpression by first constructing a delegate type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType"/> property equal to Lambda and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="delegateType">A <see cref="P:System.Linq.Expressions.Expression.Type"/> representing the delegate signature for the lambda.</param><param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="tailCall">A <see cref="T:System.Boolean"/> that indicates if tail call optimization will be applied when compiling the created expression.</param><param name="parameters">An array that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param>
        public static LambdaExpression Lambda(Type delegateType, Expression body, bool tailCall, params ParameterExpression[] parameters);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LambdaExpression"/> by first constructing a delegate type. It can be used when the delegate type is not known at compile time.
        /// </summary>
        /// 
        /// <returns>
        /// An object that represents a lambda expression which has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Lambda"/> and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="delegateType">A <see cref="T:System.Type"/> that represents a delegate signature for the lambda.</param><param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="delegateType"/> or <paramref name="body"/> is null.-or-One or more elements in <paramref name="parameters"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="delegateType"/> does not represent a delegate type.-or-<paramref name="body"/>.Type represents a type that is not assignable to the return type of the delegate type represented by <paramref name="delegateType"/>.-or-<paramref name="parameters"/> does not contain the same number of elements as the list of parameters for the delegate type represented by <paramref name="delegateType"/>.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="parameters"/> is not assignable from the type of the corresponding parameter type of the delegate type represented by <paramref name="delegateType"/>.</exception>
        public static LambdaExpression Lambda(Type delegateType, Expression body, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates a LambdaExpression by first constructing a delegate type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType"/> property equal to Lambda and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="delegateType">A <see cref="P:System.Linq.Expressions.Expression.Type"/> representing the delegate signature for the lambda.</param><param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="tailCall">A <see cref="T:System.Boolean"/> that indicates if tail call optimization will be applied when compiling the created expression.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param>
        public static LambdaExpression Lambda(Type delegateType, Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates a LambdaExpression by first constructing a delegate type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType"/> property equal to Lambda and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="name">The name for the lambda. Used for emitting debug information.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param>
        public static LambdaExpression Lambda(Expression body, string name, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates a LambdaExpression by first constructing a delegate type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType"/> property equal to Lambda and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="name">The name for the lambda. Used for emitting debug information.</param><param name="tailCall">A <see cref="T:System.Boolean"/> that indicates if tail call optimization will be applied when compiling the created expression.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param>
        public static LambdaExpression Lambda(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates a LambdaExpression by first constructing a delegate type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType"/> property equal to Lambda and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="delegateType">A <see cref="P:System.Linq.Expressions.Expression.Type"/> representing the delegate signature for the lambda.</param><param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to.</param><param name="name">The name for the lambda. Used for emitting debug information.</param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection.</param>
        public static LambdaExpression Lambda(Type delegateType, Expression body, string name, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates a LambdaExpression by first constructing a delegate type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.LambdaExpression"/> that has the <see cref="P:System.Linq.Expressions.LambdaExpression.NodeType"/> property equal to Lambda and the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> and <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> properties set to the specified values.
        /// </returns>
        /// <param name="delegateType">A <see cref="P:System.Linq.Expressions.Expression.Type"/> representing the delegate signature for the lambda.</param><param name="body">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.LambdaExpression.Body"/> property equal to. </param><param name="name">The name for the lambda. Used for emitting debug information.</param><param name="tailCall">A <see cref="T:System.Boolean"/> that indicates if tail call optimization will be applied when compiling the created expression. </param><param name="parameters">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.LambdaExpression.Parameters"/> collection. </param>
        public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters);

        /// <summary>
        /// Creates a <see cref="P:System.Linq.Expressions.Expression.Type"/> object that represents a generic System.Func delegate type that has specific type arguments. The last type argument specifies the return type of the created delegate.
        /// </summary>
        /// 
        /// <returns>
        /// The type of a System.Func delegate that has the specified type arguments.
        /// </returns>
        /// <param name="typeArgs">An array of one to five <see cref="T:System.Type"/> objects that specify the type arguments for the System.Func delegate type.</param><exception cref="T:System.ArgumentException"><paramref name="typeArgs"/> contains less than one or more than five elements.</exception><exception cref="T:System.ArgumentNullException"><paramref name="typeArgs"/> is null.</exception>
        public static Type GetFuncType(params Type[] typeArgs);

        /// <summary>
        /// Creates a <see cref="P:System.Linq.Expressions.Expression.Type"/> object that represents a generic System.Func delegate type that has specific type arguments. The last type argument specifies the return type of the created delegate.
        /// </summary>
        /// 
        /// <returns>
        /// true if generic System.Func delegate type was created for specific <paramref name="typeArgs"/>; false otherwise.
        /// </returns>
        /// <param name="typeArgs">An array of Type objects that specify the type arguments for the System.Func delegate type.</param><param name="funcType">When this method returns, contains the generic System.Func delegate type that has specific type arguments. Contains null if there is no generic System.Func delegate that matches the <paramref name="typeArgs"/>.This parameter is passed uninitialized.</param>
        public static bool TryGetFuncType(Type[] typeArgs, out Type funcType);

        /// <summary>
        /// Creates a <see cref="T:System.Type"/> object that represents a generic System.Action delegate type that has specific type arguments.
        /// </summary>
        /// 
        /// <returns>
        /// The type of a System.Action delegate that has the specified type arguments.
        /// </returns>
        /// <param name="typeArgs">An array of <see cref="T:System.Type"/> objects that specify the type arguments for the System.Action delegate type.</param><exception cref="T:System.ArgumentException"><paramref name="typeArgs"/> contains more than four elements.</exception><exception cref="T:System.ArgumentNullException"><paramref name="typeArgs"/> is null.</exception>
        public static Type GetActionType(params Type[] typeArgs);

        /// <summary>
        /// Creates a <see cref="P:System.Linq.Expressions.Expression.Type"/> object that represents a generic System.Action delegate type that has specific type arguments.
        /// </summary>
        /// 
        /// <returns>
        /// true if generic System.Action delegate type was created for specific <paramref name="typeArgs"/>; false otherwise.
        /// </returns>
        /// <param name="typeArgs">An array of Type objects that specify the type arguments for the System.Action delegate type.</param><param name="actionType">When this method returns, contains the generic System.Action delegate type that has specific type arguments. Contains null if there is no generic System.Action delegate that matches the <paramref name="typeArgs"/>.This parameter is passed uninitialized.</param>
        public static bool TryGetActionType(Type[] typeArgs, out Type actionType);

        /// <summary>
        /// Gets a <see cref="P:System.Linq.Expressions.Expression.Type"/> object that represents a generic System.Func or System.Action delegate type that has specific type arguments.
        /// </summary>
        /// 
        /// <returns>
        /// The delegate type.
        /// </returns>
        /// <param name="typeArgs">The type arguments of the delegate.</param>
        public static Type GetDelegateType(params Type[] typeArgs);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ListInitExpression"/> that uses a method named "Add" to add elements to a collection.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ListInitExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ListInit"/> and the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> property set to the specified value.
        /// </returns>
        /// <param name="newExpression">A <see cref="T:System.Linq.Expressions.NewExpression"/> to set the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> property equal to.</param><param name="initializers">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.ListInitExpression.Initializers"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="newExpression"/> or <paramref name="initializers"/> is null.-or-One or more elements of <paramref name="initializers"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="newExpression"/>.Type does not implement <see cref="T:System.Collections.IEnumerable"/>.</exception><exception cref="T:System.InvalidOperationException">There is no instance method named "Add" (case insensitive) declared in <paramref name="newExpression"/>.Type or its base type.-or-The add method on <paramref name="newExpression"/>.Type or its base type does not take exactly one argument.-or-The type represented by the <see cref="P:System.Linq.Expressions.Expression.Type"/> property of the first element of <paramref name="initializers"/> is not assignable to the argument type of the add method on <paramref name="newExpression"/>.Type or its base type.-or-More than one argument-compatible method named "Add" (case-insensitive) exists on <paramref name="newExpression"/>.Type and/or its base type.</exception>
        public static ListInitExpression ListInit(NewExpression newExpression, params Expression[] initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ListInitExpression"/> that uses a method named "Add" to add elements to a collection.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ListInitExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ListInit"/> and the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> property set to the specified value.
        /// </returns>
        /// <param name="newExpression">A <see cref="T:System.Linq.Expressions.NewExpression"/> to set the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> property equal to.</param><param name="initializers">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.ListInitExpression.Initializers"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="newExpression"/> or <paramref name="initializers"/> is null.-or-One or more elements of <paramref name="initializers"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="newExpression"/>.Type does not implement <see cref="T:System.Collections.IEnumerable"/>.</exception><exception cref="T:System.InvalidOperationException">There is no instance method named "Add" (case insensitive) declared in <paramref name="newExpression"/>.Type or its base type.-or-The add method on <paramref name="newExpression"/>.Type or its base type does not take exactly one argument.-or-The type represented by the <see cref="P:System.Linq.Expressions.Expression.Type"/> property of the first element of <paramref name="initializers"/> is not assignable to the argument type of the add method on <paramref name="newExpression"/>.Type or its base type.-or-More than one argument-compatible method named "Add" (case-insensitive) exists on <paramref name="newExpression"/>.Type and/or its base type.</exception>
        public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<Expression> initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ListInitExpression"/> that uses a specified method to add elements to a collection.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ListInitExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ListInit"/> and the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> property set to the specified value.
        /// </returns>
        /// <param name="newExpression">A <see cref="T:System.Linq.Expressions.NewExpression"/> to set the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> property equal to.</param><param name="addMethod">A <see cref="T:System.Reflection.MethodInfo"/> that represents an instance method that takes one argument, that adds an element to a collection.</param><param name="initializers">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.ListInitExpression.Initializers"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="newExpression"/> or <paramref name="initializers"/> is null.-or-One or more elements of <paramref name="initializers"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="newExpression"/>.Type does not implement <see cref="T:System.Collections.IEnumerable"/>.-or-<paramref name="addMethod"/> is not null and it does not represent an instance method named "Add" (case insensitive) that takes exactly one argument.-or-<paramref name="addMethod"/> is not null and the type represented by the <see cref="P:System.Linq.Expressions.Expression.Type"/> property of one or more elements of <paramref name="initializers"/> is not assignable to the argument type of the method that <paramref name="addMethod"/> represents.</exception><exception cref="T:System.InvalidOperationException"><paramref name="addMethod"/> is null and no instance method named "Add" that takes one type-compatible argument exists on <paramref name="newExpression"/>.Type or its base type.</exception>
        public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, params Expression[] initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ListInitExpression"/> that uses a specified method to add elements to a collection.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ListInitExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ListInit"/> and the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> property set to the specified value.
        /// </returns>
        /// <param name="newExpression">A <see cref="T:System.Linq.Expressions.NewExpression"/> to set the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> property equal to.</param><param name="addMethod">A <see cref="T:System.Reflection.MethodInfo"/> that represents an instance method named "Add" (case insensitive), that adds an element to a collection.</param><param name="initializers">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.ListInitExpression.Initializers"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="newExpression"/> or <paramref name="initializers"/> is null.-or-One or more elements of <paramref name="initializers"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="newExpression"/>.Type does not implement <see cref="T:System.Collections.IEnumerable"/>.-or-<paramref name="addMethod"/> is not null and it does not represent an instance method named "Add" (case insensitive) that takes exactly one argument.-or-<paramref name="addMethod"/> is not null and the type represented by the <see cref="P:System.Linq.Expressions.Expression.Type"/> property of one or more elements of <paramref name="initializers"/> is not assignable to the argument type of the method that <paramref name="addMethod"/> represents.</exception><exception cref="T:System.InvalidOperationException"><paramref name="addMethod"/> is null and no instance method named "Add" that takes one type-compatible argument exists on <paramref name="newExpression"/>.Type or its base type.</exception>
        public static ListInitExpression ListInit(NewExpression newExpression, MethodInfo addMethod, IEnumerable<Expression> initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ListInitExpression"/> that uses specified <see cref="T:System.Linq.Expressions.ElementInit"/> objects to initialize a collection.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ListInitExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ListInit"/> and the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> and <see cref="P:System.Linq.Expressions.ListInitExpression.Initializers"/> properties set to the specified values.
        /// </returns>
        /// <param name="newExpression">A <see cref="T:System.Linq.Expressions.NewExpression"/> to set the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> property equal to.</param><param name="initializers">An array of <see cref="T:System.Linq.Expressions.ElementInit"/> objects to use to populate the <see cref="P:System.Linq.Expressions.ListInitExpression.Initializers"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="newExpression"/> or <paramref name="initializers"/> is null.-or-One or more elements of <paramref name="initializers"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="newExpression"/>.Type does not implement <see cref="T:System.Collections.IEnumerable"/>.</exception>
        public static ListInitExpression ListInit(NewExpression newExpression, params ElementInit[] initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ListInitExpression"/> that uses specified <see cref="T:System.Linq.Expressions.ElementInit"/> objects to initialize a collection.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ListInitExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ListInit"/> and the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> and <see cref="P:System.Linq.Expressions.ListInitExpression.Initializers"/> properties set to the specified values.
        /// </returns>
        /// <param name="newExpression">A <see cref="T:System.Linq.Expressions.NewExpression"/> to set the <see cref="P:System.Linq.Expressions.ListInitExpression.NewExpression"/> property equal to.</param><param name="initializers">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ElementInit"/> objects to use to populate the <see cref="P:System.Linq.Expressions.ListInitExpression.Initializers"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="newExpression"/> or <paramref name="initializers"/> is null.-or-One or more elements of <paramref name="initializers"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="newExpression"/>.Type does not implement <see cref="T:System.Collections.IEnumerable"/>.</exception>
        public static ListInitExpression ListInit(NewExpression newExpression, IEnumerable<ElementInit> initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LoopExpression"/> with the given body.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.LoopExpression"/>.
        /// </returns>
        /// <param name="body">The body of the loop.</param>
        public static LoopExpression Loop(Expression body);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LoopExpression"/> with the given body and break target.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.LoopExpression"/>.
        /// </returns>
        /// <param name="body">The body of the loop.</param><param name="break">The break target used by the loop body.</param>
        public static LoopExpression Loop(Expression body, LabelTarget @break);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.LoopExpression"/> with the given body.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.LoopExpression"/>.
        /// </returns>
        /// <param name="body">The body of the loop.</param><param name="break">The break target used by the loop body.</param><param name="continue">The continue target used by the loop body.</param>
        public static LoopExpression Loop(Expression body, LabelTarget @break, LabelTarget @continue);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberAssignment"/> that represents the initialization of a field or property.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberAssignment"/> that has <see cref="P:System.Linq.Expressions.MemberBinding.BindingType"/> equal to <see cref="F:System.Linq.Expressions.MemberBindingType.Assignment"/> and the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> and <see cref="P:System.Linq.Expressions.MemberAssignment.Expression"/> properties set to the specified values.
        /// </returns>
        /// <param name="member">A <see cref="T:System.Reflection.MemberInfo"/> to set the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property equal to.</param><param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.MemberAssignment.Expression"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="member"/> or <paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="member"/> does not represent a field or property.-or-The property represented by <paramref name="member"/> does not have a set accessor.-or-<paramref name="expression"/>.Type is not assignable to the type of the field or property that <paramref name="member"/> represents.</exception>
        public static MemberAssignment Bind(MemberInfo member, Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberAssignment"/> that represents the initialization of a member by using a property accessor method.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberAssignment"/> that has the <see cref="P:System.Linq.Expressions.MemberBinding.BindingType"/> property equal to <see cref="F:System.Linq.Expressions.MemberBindingType.Assignment"/>, the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property set to the <see cref="T:System.Reflection.PropertyInfo"/> that represents the property accessed in <paramref name="propertyAccessor"/>, and the <see cref="P:System.Linq.Expressions.MemberAssignment.Expression"/> property set to <paramref name="expression"/>.
        /// </returns>
        /// <param name="propertyAccessor">A <see cref="T:System.Reflection.MethodInfo"/> that represents a property accessor method.</param><param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.MemberAssignment.Expression"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="propertyAccessor"/> or <paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="propertyAccessor"/> does not represent a property accessor method.-or-The property accessed by <paramref name="propertyAccessor"/> does not have a set accessor.-or-<paramref name="expression"/>.Type is not assignable to the type of the field or property that <paramref name="member"/> represents.</exception>
        public static MemberAssignment Bind(MethodInfo propertyAccessor, Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberExpression"/> that represents accessing a field.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberAccess"/> and the <see cref="P:System.Linq.Expressions.MemberExpression.Expression"/> and <see cref="P:System.Linq.Expressions.MemberExpression.Member"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.MemberExpression.Expression"/> property equal to. For static (Shared in Visual Basic), <paramref name="expression"/> must be null.</param><param name="field">The <see cref="T:System.Reflection.FieldInfo"/> to set the <see cref="P:System.Linq.Expressions.MemberExpression.Member"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="field"/> is null.-or-The field represented by <paramref name="field"/> is not static (Shared in Visual Basic) and <paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="expression"/>.Type is not assignable to the declaring type of the field represented by <paramref name="field"/>.</exception>
        public static MemberExpression Field(Expression expression, FieldInfo field);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberExpression"/> that represents accessing a field given the name of the field.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberAccess"/>, the <see cref="P:System.Linq.Expressions.MemberExpression.Expression"/> property set to <paramref name="expression"/>, and the <see cref="P:System.Linq.Expressions.MemberExpression.Member"/> property set to the <see cref="T:System.Reflection.FieldInfo"/> that represents the field denoted by <paramref name="fieldName"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> whose <see cref="P:System.Linq.Expressions.Expression.Type"/> contains a field named <paramref name="fieldName"/>. This can be null for static fields.</param><param name="fieldName">The name of a field to be accessed.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> or <paramref name="fieldName"/> is null.</exception><exception cref="T:System.ArgumentException">No field named <paramref name="fieldName"/> is defined in <paramref name="expression"/>.Type or its base types.</exception>
        public static MemberExpression Field(Expression expression, string fieldName);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberExpression"/> that represents accessing a field.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.MemberExpression"/>.
        /// </returns>
        /// <param name="expression">The containing object of the field. This can be null for static fields.</param><param name="type">The <see cref="P:System.Linq.Expressions.Expression.Type"/> that contains the field.</param><param name="fieldName">The field to be accessed.</param>
        public static MemberExpression Field(Expression expression, Type type, string fieldName);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberExpression"/> that represents accessing a property.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberAccess"/>, the <see cref="P:System.Linq.Expressions.MemberExpression.Expression"/> property set to <paramref name="expression"/>, and the <see cref="P:System.Linq.Expressions.MemberExpression.Member"/> property set to the <see cref="T:System.Reflection.PropertyInfo"/> that represents the property denoted by <paramref name="propertyName"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> whose <see cref="P:System.Linq.Expressions.Expression.Type"/> contains a property named <paramref name="propertyName"/>. This can be null for static properties.</param><param name="propertyName">The name of a property to be accessed.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> or <paramref name="propertyName"/> is null.</exception><exception cref="T:System.ArgumentException">No property named <paramref name="propertyName"/> is defined in <paramref name="expression"/>.Type or its base types.</exception>
        public static MemberExpression Property(Expression expression, string propertyName);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberExpression"/> accessing a property.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.MemberExpression"/>.
        /// </returns>
        /// <param name="expression">The containing object of the property. This can be null for static properties.</param><param name="type">The <see cref="P:System.Linq.Expressions.Expression.Type"/> that contains the property.</param><param name="propertyName">The property to be accessed.</param>
        public static MemberExpression Property(Expression expression, Type type, string propertyName);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberExpression"/> that represents accessing a property.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberAccess"/> and the <see cref="P:System.Linq.Expressions.MemberExpression.Expression"/> and <see cref="P:System.Linq.Expressions.MemberExpression.Member"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.MemberExpression.Expression"/> property equal to. This can be null for static properties.</param><param name="property">The <see cref="T:System.Reflection.PropertyInfo"/> to set the <see cref="P:System.Linq.Expressions.MemberExpression.Member"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="property"/> is null.-or-The property that <paramref name="property"/> represents is not static (Shared in Visual Basic) and <paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="expression"/>.Type is not assignable to the declaring type of the property that <paramref name="property"/> represents.</exception>
        public static MemberExpression Property(Expression expression, PropertyInfo property);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberExpression"/> that represents accessing a property by using a property accessor method.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberAccess"/>, the <see cref="P:System.Linq.Expressions.MemberExpression.Expression"/> property set to <paramref name="expression"/> and the <see cref="P:System.Linq.Expressions.MemberExpression.Member"/> property set to the <see cref="T:System.Reflection.PropertyInfo"/> that represents the property accessed in <paramref name="propertyAccessor"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.MemberExpression.Expression"/> property equal to. This can be null for static properties.</param><param name="propertyAccessor">The <see cref="T:System.Reflection.MethodInfo"/> that represents a property accessor method.</param><exception cref="T:System.ArgumentNullException"><paramref name="propertyAccessor"/> is null.-or-The method that <paramref name="propertyAccessor"/> represents is not static (Shared in Visual Basic) and <paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="expression"/>.Type is not assignable to the declaring type of the method represented by <paramref name="propertyAccessor"/>.-or-The method that <paramref name="propertyAccessor"/> represents is not a property accessor method.</exception>
        public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberExpression"/> that represents accessing a property or field.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberAccess"/>, the <see cref="P:System.Linq.Expressions.MemberExpression.Expression"/> property set to <paramref name="expression"/>, and the <see cref="P:System.Linq.Expressions.MemberExpression.Member"/> property set to the <see cref="T:System.Reflection.PropertyInfo"/> or <see cref="T:System.Reflection.FieldInfo"/> that represents the property or field denoted by <paramref name="propertyOrFieldName"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> whose <see cref="P:System.Linq.Expressions.Expression.Type"/> contains a property or field named <paramref name="propertyOrFieldName"/>. This can be null for static members.</param><param name="propertyOrFieldName">The name of a property or field to be accessed.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> or <paramref name="propertyOrFieldName"/> is null.</exception><exception cref="T:System.ArgumentException">No property or field named <paramref name="propertyOrFieldName"/> is defined in <paramref name="expression"/>.Type or its base types.</exception>
        public static MemberExpression PropertyOrField(Expression expression, string propertyOrFieldName);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberExpression"/> that represents accessing either a field or a property.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Linq.Expressions.MemberExpression"/> that results from calling the appropriate factory method.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the object that the member belongs to. This can be null for static members.</param><param name="member">The <see cref="T:System.Reflection.MemberInfo"/> that describes the field or property to be accessed.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> or <paramref name="member"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="member"/> does not represent a field or property.</exception>
        public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberInitExpression"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberInitExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberInit"/> and the <see cref="P:System.Linq.Expressions.MemberInitExpression.NewExpression"/> and <see cref="P:System.Linq.Expressions.MemberInitExpression.Bindings"/> properties set to the specified values.
        /// </returns>
        /// <param name="newExpression">A <see cref="T:System.Linq.Expressions.NewExpression"/> to set the <see cref="P:System.Linq.Expressions.MemberInitExpression.NewExpression"/> property equal to.</param><param name="bindings">An array of <see cref="T:System.Linq.Expressions.MemberBinding"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MemberInitExpression.Bindings"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="newExpression"/> or <paramref name="bindings"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property of an element of <paramref name="bindings"/> does not represent a member of the type that <paramref name="newExpression"/>.Type represents.</exception>
        public static MemberInitExpression MemberInit(NewExpression newExpression, params MemberBinding[] bindings);

        /// <summary>
        /// Represents an expression that creates a new object and initializes a property of the object.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberInitExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.MemberInit"/> and the <see cref="P:System.Linq.Expressions.MemberInitExpression.NewExpression"/> and <see cref="P:System.Linq.Expressions.MemberInitExpression.Bindings"/> properties set to the specified values.
        /// </returns>
        /// <param name="newExpression">A <see cref="T:System.Linq.Expressions.NewExpression"/> to set the <see cref="P:System.Linq.Expressions.MemberInitExpression.NewExpression"/> property equal to.</param><param name="bindings">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.MemberBinding"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MemberInitExpression.Bindings"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="newExpression"/> or <paramref name="bindings"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property of an element of <paramref name="bindings"/> does not represent a member of the type that <paramref name="newExpression"/>.Type represents.</exception>
        public static MemberInitExpression MemberInit(NewExpression newExpression, IEnumerable<MemberBinding> bindings);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberListBinding"/> where the member is a field or property.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberListBinding"/> that has the <see cref="P:System.Linq.Expressions.MemberBinding.BindingType"/> property equal to <see cref="F:System.Linq.Expressions.MemberBindingType.ListBinding"/> and the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> and <see cref="P:System.Linq.Expressions.MemberListBinding.Initializers"/> properties set to the specified values.
        /// </returns>
        /// <param name="member">A <see cref="T:System.Reflection.MemberInfo"/> that represents a field or property to set the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property equal to.</param><param name="initializers">An array of <see cref="T:System.Linq.Expressions.ElementInit"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MemberListBinding.Initializers"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="member"/> is null. -or-One or more elements of <paramref name="initializers"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="member"/> does not represent a field or property.-or-The <see cref="P:System.Reflection.FieldInfo.FieldType"/> or <see cref="P:System.Reflection.PropertyInfo.PropertyType"/> of the field or property that <paramref name="member"/> represents does not implement <see cref="T:System.Collections.IEnumerable"/>.</exception>
        public static MemberListBinding ListBind(MemberInfo member, params ElementInit[] initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberListBinding"/> where the member is a field or property.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberListBinding"/> that has the <see cref="P:System.Linq.Expressions.MemberBinding.BindingType"/> property equal to <see cref="F:System.Linq.Expressions.MemberBindingType.ListBinding"/> and the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> and <see cref="P:System.Linq.Expressions.MemberListBinding.Initializers"/> properties set to the specified values.
        /// </returns>
        /// <param name="member">A <see cref="T:System.Reflection.MemberInfo"/> that represents a field or property to set the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property equal to.</param><param name="initializers">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ElementInit"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MemberListBinding.Initializers"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="member"/> is null. -or-One or more elements of <paramref name="initializers"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="member"/> does not represent a field or property.-or-The <see cref="P:System.Reflection.FieldInfo.FieldType"/> or <see cref="P:System.Reflection.PropertyInfo.PropertyType"/> of the field or property that <paramref name="member"/> represents does not implement <see cref="T:System.Collections.IEnumerable"/>.</exception>
        public static MemberListBinding ListBind(MemberInfo member, IEnumerable<ElementInit> initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberListBinding"/> object based on a specified property accessor method.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberListBinding"/> that has the <see cref="P:System.Linq.Expressions.MemberBinding.BindingType"/> property equal to <see cref="F:System.Linq.Expressions.MemberBindingType.ListBinding"/>, the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property set to the <see cref="T:System.Reflection.MemberInfo"/> that represents the property accessed in <paramref name="propertyAccessor"/>, and <see cref="P:System.Linq.Expressions.MemberListBinding.Initializers"/> populated with the elements of <paramref name="initializers"/>.
        /// </returns>
        /// <param name="propertyAccessor">A <see cref="T:System.Reflection.MethodInfo"/> that represents a property accessor method.</param><param name="initializers">An array of <see cref="T:System.Linq.Expressions.ElementInit"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MemberListBinding.Initializers"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="propertyAccessor"/> is null. -or-One or more elements of <paramref name="initializers"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="propertyAccessor"/> does not represent a property accessor method.-or-The <see cref="P:System.Reflection.PropertyInfo.PropertyType"/> of the property that the method represented by <paramref name="propertyAccessor"/> accesses does not implement <see cref="T:System.Collections.IEnumerable"/>.</exception>
        public static MemberListBinding ListBind(MethodInfo propertyAccessor, params ElementInit[] initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberListBinding"/> based on a specified property accessor method.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberListBinding"/> that has the <see cref="P:System.Linq.Expressions.MemberBinding.BindingType"/> property equal to <see cref="F:System.Linq.Expressions.MemberBindingType.ListBinding"/>, the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property set to the <see cref="T:System.Reflection.MemberInfo"/> that represents the property accessed in <paramref name="propertyAccessor"/>, and <see cref="P:System.Linq.Expressions.MemberListBinding.Initializers"/> populated with the elements of <paramref name="initializers"/>.
        /// </returns>
        /// <param name="propertyAccessor">A <see cref="T:System.Reflection.MethodInfo"/> that represents a property accessor method.</param><param name="initializers">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.ElementInit"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MemberListBinding.Initializers"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="propertyAccessor"/> is null. -or-One or more elements of <paramref name="initializers"/> are null.</exception><exception cref="T:System.ArgumentException"><paramref name="propertyAccessor"/> does not represent a property accessor method.-or-The <see cref="P:System.Reflection.PropertyInfo.PropertyType"/> of the property that the method represented by <paramref name="propertyAccessor"/> accesses does not implement <see cref="T:System.Collections.IEnumerable"/>.</exception>
        public static MemberListBinding ListBind(MethodInfo propertyAccessor, IEnumerable<ElementInit> initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberMemberBinding"/> that represents the recursive initialization of members of a field or property.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberMemberBinding"/> that has the <see cref="P:System.Linq.Expressions.MemberBinding.BindingType"/> property equal to <see cref="F:System.Linq.Expressions.MemberBindingType.MemberBinding"/> and the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> and <see cref="P:System.Linq.Expressions.MemberMemberBinding.Bindings"/> properties set to the specified values.
        /// </returns>
        /// <param name="member">The <see cref="T:System.Reflection.MemberInfo"/> to set the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property equal to.</param><param name="bindings">An array of <see cref="T:System.Linq.Expressions.MemberBinding"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MemberMemberBinding.Bindings"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="member"/> or <paramref name="bindings"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="member"/> does not represent a field or property.-or-The <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property of an element of <paramref name="bindings"/> does not represent a member of the type of the field or property that <paramref name="member"/> represents.</exception>
        public static MemberMemberBinding MemberBind(MemberInfo member, params MemberBinding[] bindings);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberMemberBinding"/> that represents the recursive initialization of members of a field or property.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberMemberBinding"/> that has the <see cref="P:System.Linq.Expressions.MemberBinding.BindingType"/> property equal to <see cref="F:System.Linq.Expressions.MemberBindingType.MemberBinding"/> and the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> and <see cref="P:System.Linq.Expressions.MemberMemberBinding.Bindings"/> properties set to the specified values.
        /// </returns>
        /// <param name="member">The <see cref="T:System.Reflection.MemberInfo"/> to set the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property equal to.</param><param name="bindings">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.MemberBinding"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MemberMemberBinding.Bindings"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="member"/> or <paramref name="bindings"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="member"/> does not represent a field or property.-or-The <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property of an element of <paramref name="bindings"/> does not represent a member of the type of the field or property that <paramref name="member"/> represents.</exception>
        public static MemberMemberBinding MemberBind(MemberInfo member, IEnumerable<MemberBinding> bindings);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberMemberBinding"/> that represents the recursive initialization of members of a member that is accessed by using a property accessor method.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberMemberBinding"/> that has the <see cref="P:System.Linq.Expressions.MemberBinding.BindingType"/> property equal to <see cref="F:System.Linq.Expressions.MemberBindingType.MemberBinding"/>, the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property set to the <see cref="T:System.Reflection.PropertyInfo"/> that represents the property accessed in <paramref name="propertyAccessor"/>, and <see cref="P:System.Linq.Expressions.MemberMemberBinding.Bindings"/> properties set to the specified values.
        /// </returns>
        /// <param name="propertyAccessor">The <see cref="T:System.Reflection.MethodInfo"/> that represents a property accessor method.</param><param name="bindings">An array of <see cref="T:System.Linq.Expressions.MemberBinding"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MemberMemberBinding.Bindings"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="propertyAccessor"/> or <paramref name="bindings"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="propertyAccessor"/> does not represent a property accessor method.-or-The <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property of an element of <paramref name="bindings"/> does not represent a member of the type of the property accessed by the method that <paramref name="propertyAccessor"/> represents.</exception>
        public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, params MemberBinding[] bindings);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MemberMemberBinding"/> that represents the recursive initialization of members of a member that is accessed by using a property accessor method.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MemberMemberBinding"/> that has the <see cref="P:System.Linq.Expressions.MemberBinding.BindingType"/> property equal to <see cref="F:System.Linq.Expressions.MemberBindingType.MemberBinding"/>, the <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property set to the <see cref="T:System.Reflection.PropertyInfo"/> that represents the property accessed in <paramref name="propertyAccessor"/>, and <see cref="P:System.Linq.Expressions.MemberMemberBinding.Bindings"/> properties set to the specified values.
        /// </returns>
        /// <param name="propertyAccessor">The <see cref="T:System.Reflection.MethodInfo"/> that represents a property accessor method.</param><param name="bindings">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.MemberBinding"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MemberMemberBinding.Bindings"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="propertyAccessor"/> or <paramref name="bindings"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="propertyAccessor"/> does not represent a property accessor method.-or-The <see cref="P:System.Linq.Expressions.MemberBinding.Member"/> property of an element of <paramref name="bindings"/> does not represent a member of the type of the property accessed by the method that <paramref name="propertyAccessor"/> represents.</exception>
        public static MemberMemberBinding MemberBind(MethodInfo propertyAccessor, IEnumerable<MemberBinding> bindings);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a static (Shared in Visual Basic) method that takes one argument.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> property equal to.</param><param name="arg0">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the first argument.</param><exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.</exception>
        public static MethodCallExpression Call(MethodInfo method, Expression arg0);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to an static method that takes two arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> property equal to.</param><param name="arg0">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the first argument.</param><param name="arg1">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the second argument.</param><exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.</exception>
        public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a static method that takes three arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> property equal to.</param><param name="arg0">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the first argument.</param><param name="arg1">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the second argument.</param><param name="arg2">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the third argument.</param><exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.</exception>
        public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a static method that takes four arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> property equal to.</param><param name="arg0">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the first argument.</param><param name="arg1">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the second argument.</param><param name="arg2">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the third argument.</param><param name="arg3">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the fourth argument.</param><exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.</exception>
        public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a static method that takes five arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> property equal to.</param><param name="arg0">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the first argument.</param><param name="arg1">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the second argument.</param><param name="arg2">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the third argument.</param><param name="arg3">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the fourth argument.</param><param name="arg4">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the fifth argument.</param><exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.</exception>
        public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a static (Shared in Visual Basic) method that has arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> properties set to the specified values.
        /// </returns>
        /// <param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that represents a static (Shared in Visual Basic) method to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> property equal to.</param><param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.</exception><exception cref="T:System.ArgumentException">The number of elements in <paramref name="arguments"/> does not equal the number of parameters for the method represented by <paramref name="method"/>.-or-One or more of the elements of <paramref name="arguments"/> is not assignable to the corresponding parameter for the method represented by <paramref name="method"/>.</exception>
        public static MethodCallExpression Call(MethodInfo method, params Expression[] arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a static (Shared in Visual Basic) method.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="method">The <see cref="T:System.Reflection.MethodInfo"/> that represents the target method.</param><param name="arguments">A collection of <see cref="T:System.Linq.Expressions.Expression"/> that represents the call arguments.</param>
        public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to an instance method that takes no arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression"/> that specifies the instance for an instance method call (pass null for a static (Shared in Visual Basic) method).</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.-or-<paramref name="instance"/> is null and <paramref name="method"/> represents an instance method.</exception><exception cref="T:System.ArgumentException"><paramref name="instance"/>.Type is not assignable to the declaring type of the method represented by <paramref name="method"/>.</exception>
        public static MethodCallExpression Call(Expression instance, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a method that takes arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/>, <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/>, and <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> properties set to the specified values.
        /// </returns>
        /// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression"/> that specifies the instance fo an instance method call (pass null for a static (Shared in Visual Basic) method).</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> property equal to.</param><param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.-or-<paramref name="instance"/> is null and <paramref name="method"/> represents an instance method.-or-<paramref name="arguments"/> is not null and one or more of its elements is null.</exception><exception cref="T:System.ArgumentException"><paramref name="instance"/>.Type is not assignable to the declaring type of the method represented by <paramref name="method"/>.-or-The number of elements in <paramref name="arguments"/> does not equal the number of parameters for the method represented by <paramref name="method"/>.-or-One or more of the elements of <paramref name="arguments"/> is not assignable to the corresponding parameter for the method represented by <paramref name="method"/>.</exception>
        public static MethodCallExpression Call(Expression instance, MethodInfo method, params Expression[] arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a static method that takes two arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression"/> that specifies the instance for an instance call. (pass null for a static (Shared in Visual Basic) method).</param><param name="method">The <see cref="T:System.Reflection.MethodInfo"/> that represents the target method.</param><param name="arg0">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the first argument.</param><param name="arg1">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the second argument.</param>
        public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a method that takes no arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression"/> that specifies the instance for an instance call. (pass null for a static (Shared in Visual Basic) method).</param><param name="method">The <see cref="T:System.Reflection.MethodInfo"/> that represents the target method.</param><param name="arg0">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the first argument.</param><param name="arg1">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the second argument.</param><param name="arg2">The <see cref="T:System.Linq.Expressions.Expression"/> that represents the third argument.</param>
        public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to an instance method by calling the appropriate factory method.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/>, the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> property equal to <paramref name="instance"/>, <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> set to the <see cref="T:System.Reflection.MethodInfo"/> that represents the specified instance method, and <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> set to the specified arguments.
        /// </returns>
        /// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression"/> whose <see cref="P:System.Linq.Expressions.Expression.Type"/> property value will be searched for a specific method.</param><param name="methodName">The name of the method.</param><param name="typeArguments">An array of <see cref="T:System.Type"/> objects that specify the type parameters of the generic method. This argument should be null when methodName specifies a non-generic method.</param><param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects that represents the arguments to the method.</param><exception cref="T:System.ArgumentNullException"><paramref name="instance"/> or <paramref name="methodName"/> is null.</exception><exception cref="T:System.InvalidOperationException">No method whose name is <paramref name="methodName"/>, whose type parameters match <paramref name="typeArguments"/>, and whose parameter types match <paramref name="arguments"/> is found in <paramref name="instance"/>.Type or its base types.-or-More than one method whose name is <paramref name="methodName"/>, whose type parameters match <paramref name="typeArguments"/>, and whose parameter types match <paramref name="arguments"/> is found in <paramref name="instance"/>.Type or its base types.</exception>
        public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, params Expression[] arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a static (Shared in Visual Basic) method by calling the appropriate factory method.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/>, the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> property set to the <see cref="T:System.Reflection.MethodInfo"/> that represents the specified static (Shared in Visual Basic) method, and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> property set to the specified arguments.
        /// </returns>
        /// <param name="type">The <see cref="T:System.Type"/> that specifies the type that contains the specified static (Shared in Visual Basic) method.</param><param name="methodName">The name of the method.</param><param name="typeArguments">An array of <see cref="T:System.Type"/> objects that specify the type parameters of the generic method. This argument should be null when methodName specifies a non-generic method.</param><param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects that represent the arguments to the method.</param><exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="methodName"/> is null.</exception><exception cref="T:System.InvalidOperationException">No method whose name is <paramref name="methodName"/>, whose type parameters match <paramref name="typeArguments"/>, and whose parameter types match <paramref name="arguments"/> is found in <paramref name="type"/> or its base types.-or-More than one method whose name is <paramref name="methodName"/>, whose type parameters match <paramref name="typeArguments"/>, and whose parameter types match <paramref name="arguments"/> is found in <paramref name="type"/> or its base types.</exception>
        public static MethodCallExpression Call(Type type, string methodName, Type[] typeArguments, params Expression[] arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents a call to a method that takes arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/>, <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/>, and <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> properties set to the specified values.
        /// </returns>
        /// <param name="instance">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> property equal to (pass null for a static (Shared in Visual Basic) method).</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Method"/> property equal to.</param><param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.-or-<paramref name="instance"/> is null and <paramref name="method"/> represents an instance method.</exception><exception cref="T:System.ArgumentException"><paramref name="instance"/>.Type is not assignable to the declaring type of the method represented by <paramref name="method"/>.-or-The number of elements in <paramref name="arguments"/> does not equal the number of parameters for the method represented by <paramref name="method"/>.-or-One or more of the elements of <paramref name="arguments"/> is not assignable to the corresponding parameter for the method represented by <paramref name="method"/>.</exception>
        public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents applying an array index operator to a multidimensional array.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> properties set to the specified values.
        /// </returns>
        /// <param name="array">An array of <see cref="T:System.Linq.Expressions.Expression"/> instances - indexes for the array index operation.</param><param name="indexes">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="array"/> or <paramref name="indexes"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="array"/>.Type does not represent an array type.-or-The rank of <paramref name="array"/>.Type does not match the number of elements in <paramref name="indexes"/>.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of one or more elements of <paramref name="indexes"/> does not represent the <see cref="T:System.Int32"/> type.</exception>
        public static MethodCallExpression ArrayIndex(Expression array, params Expression[] indexes);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that represents applying an array index operator to an array of rank more than one.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.MethodCallExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Call"/> and the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> and <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> properties set to the specified values.
        /// </returns>
        /// <param name="array">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.MethodCallExpression.Object"/> property equal to.</param><param name="indexes">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.MethodCallExpression.Arguments"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="array"/> or <paramref name="indexes"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="array"/>.Type does not represent an array type.-or-The rank of <paramref name="array"/>.Type does not match the number of elements in <paramref name="indexes"/>.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of one or more elements of <paramref name="indexes"/> does not represent the <see cref="T:System.Int32"/> type.</exception>
        public static MethodCallExpression ArrayIndex(Expression array, IEnumerable<Expression> indexes);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.NewArrayExpression"/> that represents creating a one-dimensional array and initializing it from a list of elements.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.NewArrayExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayInit"/> and the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions"/> property set to the specified value.
        /// </returns>
        /// <param name="type">A <see cref="T:System.Type"/> that represents the element type of the array.</param><param name="initializers">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="initializers"/> is null.-or-An element of <paramref name="initializers"/> is null.</exception><exception cref="T:System.InvalidOperationException">The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="initializers"/> represents a type that is not assignable to the type <paramref name="type"/>.</exception>
        public static NewArrayExpression NewArrayInit(Type type, params Expression[] initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.NewArrayExpression"/> that represents creating a one-dimensional array and initializing it from a list of elements.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.NewArrayExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayInit"/> and the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions"/> property set to the specified value.
        /// </returns>
        /// <param name="type">A <see cref="T:System.Type"/> that represents the element type of the array.</param><param name="initializers">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="initializers"/> is null.-or-An element of <paramref name="initializers"/> is null.</exception><exception cref="T:System.InvalidOperationException">The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="initializers"/> represents a type that is not assignable to the type that <paramref name="type"/> represents.</exception>
        public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.NewArrayExpression"/> that represents creating an array that has a specified rank.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.NewArrayExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayBounds"/> and the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions"/> property set to the specified value.
        /// </returns>
        /// <param name="type">A <see cref="T:System.Type"/> that represents the element type of the array.</param><param name="bounds">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="bounds"/> is null.-or-An element of <paramref name="bounds"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="bounds"/> does not represent an integral type.</exception>
        public static NewArrayExpression NewArrayBounds(Type type, params Expression[] bounds);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.NewArrayExpression"/> that represents creating an array that has a specified rank.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.NewArrayExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NewArrayBounds"/> and the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions"/> property set to the specified value.
        /// </returns>
        /// <param name="type">A <see cref="T:System.Type"/> that represents the element type of the array.</param><param name="bounds">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.NewArrayExpression.Expressions"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="type"/> or <paramref name="bounds"/> is null.-or-An element of <paramref name="bounds"/> is null.</exception><exception cref="T:System.ArgumentException">The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="bounds"/> does not represent an integral type.</exception>
        public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.NewExpression"/> that represents calling the specified constructor that takes no arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.NewExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.New"/> and the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/> property set to the specified value.
        /// </returns>
        /// <param name="constructor">The <see cref="T:System.Reflection.ConstructorInfo"/> to set the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="constructor"/> is null.</exception><exception cref="T:System.ArgumentException">The constructor that <paramref name="constructor"/> represents has at least one parameter.</exception>
        public static NewExpression New(ConstructorInfo constructor);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.NewExpression"/> that represents calling the specified constructor with the specified arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.NewExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.New"/> and the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/> and <see cref="P:System.Linq.Expressions.NewExpression.Arguments"/> properties set to the specified values.
        /// </returns>
        /// <param name="constructor">The <see cref="T:System.Reflection.ConstructorInfo"/> to set the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/> property equal to.</param><param name="arguments">An array of <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.NewExpression.Arguments"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="constructor"/> is null.-or-An element of <paramref name="arguments"/> is null.</exception><exception cref="T:System.ArgumentException">The length of <paramref name="arguments"/> does match the number of parameters for the constructor that <paramref name="constructor"/> represents.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="arguments"/> is not assignable to the type of the corresponding parameter of the constructor that <paramref name="constructor"/> represents.</exception>
        public static NewExpression New(ConstructorInfo constructor, params Expression[] arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.NewExpression"/> that represents calling the specified constructor with the specified arguments.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.NewExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.New"/> and the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/> and <see cref="P:System.Linq.Expressions.NewExpression.Arguments"/> properties set to the specified values.
        /// </returns>
        /// <param name="constructor">The <see cref="T:System.Reflection.ConstructorInfo"/> to set the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/> property equal to.</param><param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.NewExpression.Arguments"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="constructor"/> is null.-or-An element of <paramref name="arguments"/> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="arguments"/> parameter does not contain the same number of elements as the number of parameters for the constructor that <paramref name="constructor"/> represents.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="arguments"/> is not assignable to the type of the corresponding parameter of the constructor that <paramref name="constructor"/> represents.</exception>
        public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.NewExpression"/> that represents calling the specified constructor with the specified arguments. The members that access the constructor initialized fields are specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.NewExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.New"/> and the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/>, <see cref="P:System.Linq.Expressions.NewExpression.Arguments"/> and <see cref="P:System.Linq.Expressions.NewExpression.Members"/> properties set to the specified values.
        /// </returns>
        /// <param name="constructor">The <see cref="T:System.Reflection.ConstructorInfo"/> to set the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/> property equal to.</param><param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.NewExpression.Arguments"/> collection.</param><param name="members">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Reflection.MemberInfo"/> objects to use to populate the <see cref="P:System.Linq.Expressions.NewExpression.Members"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="constructor"/> is null.-or-An element of <paramref name="arguments"/> is null.-or-An element of <paramref name="members"/> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="arguments"/> parameter does not contain the same number of elements as the number of parameters for the constructor that <paramref name="constructor"/> represents.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="arguments"/> is not assignable to the type of the corresponding parameter of the constructor that <paramref name="constructor"/> represents.-or-The <paramref name="members"/> parameter does not have the same number of elements as <paramref name="arguments"/>.-or-An element of <paramref name="arguments"/> has a <see cref="P:System.Linq.Expressions.Expression.Type"/> property that represents a type that is not assignable to the type of the member that is represented by the corresponding element of <paramref name="members"/>.-or-An element of members represents a property that does not have a get accessor.</exception>
        public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.NewExpression"/> that represents calling the specified constructor with the specified arguments. The members that access the constructor initialized fields are specified as an array.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.NewExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.New"/> and the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/>, <see cref="P:System.Linq.Expressions.NewExpression.Arguments"/> and <see cref="P:System.Linq.Expressions.NewExpression.Members"/> properties set to the specified values.
        /// </returns>
        /// <param name="constructor">The <see cref="T:System.Reflection.ConstructorInfo"/> to set the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/> property equal to.</param><param name="arguments">An <see cref="T:System.Collections.Generic.IEnumerable`1"/> that contains <see cref="T:System.Linq.Expressions.Expression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.NewExpression.Arguments"/> collection.</param><param name="members">An array of <see cref="T:System.Reflection.MemberInfo"/> objects to use to populate the <see cref="P:System.Linq.Expressions.NewExpression.Members"/> collection.</param><exception cref="T:System.ArgumentNullException"><paramref name="constructor"/> is null.-or-An element of <paramref name="arguments"/> is null.-or-An element of <paramref name="members"/> is null.</exception><exception cref="T:System.ArgumentException">The <paramref name="arguments"/> parameter does not contain the same number of elements as the number of parameters for the constructor that <paramref name="constructor"/> represents.-or-The <see cref="P:System.Linq.Expressions.Expression.Type"/> property of an element of <paramref name="arguments"/> is not assignable to the type of the corresponding parameter of the constructor that <paramref name="constructor"/> represents.-or-The <paramref name="members"/> parameter does not have the same number of elements as <paramref name="arguments"/>.-or-An element of <paramref name="arguments"/> has a <see cref="P:System.Linq.Expressions.Expression.Type"/> property that represents a type that is not assignable to the type of the member that is represented by the corresponding element of <paramref name="members"/>.-or-An element of <paramref name="members"/> represents a property that does not have a get accessor.</exception>
        public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, params MemberInfo[] members);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.NewExpression"/> that represents calling the parameterless constructor of the specified type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.NewExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.New"/> and the <see cref="P:System.Linq.Expressions.NewExpression.Constructor"/> property set to the <see cref="T:System.Reflection.ConstructorInfo"/> that represents the constructor without parameters for the specified type.
        /// </returns>
        /// <param name="type">A <see cref="T:System.Type"/> that has a constructor that takes no arguments.</param><exception cref="T:System.ArgumentNullException"><paramref name="type"/> is null.</exception><exception cref="T:System.ArgumentException">The type that <paramref name="type"/> represents does not have a constructor without parameters.</exception>
        public static NewExpression New(Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ParameterExpression"/> node that can be used to identify a parameter or a variable in an expression tree.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ParameterExpression"/> node with the specified name and type.
        /// </returns>
        /// <param name="type">The type of the parameter or variable.</param>
        public static ParameterExpression Parameter(Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ParameterExpression"/> node that can be used to identify a parameter or a variable in an expression tree.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ParameterExpression"/> node with the specified name and type
        /// </returns>
        /// <param name="type">The type of the parameter or variable.</param>
        public static ParameterExpression Variable(Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ParameterExpression"/> node that can be used to identify a parameter or a variable in an expression tree.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ParameterExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Parameter"/> and the <see cref="P:System.Linq.Expressions.Expression.Type"/> and <see cref="P:System.Linq.Expressions.ParameterExpression.Name"/> properties set to the specified values.
        /// </returns>
        /// <param name="type">The type of the parameter or variable.</param><param name="name">The name of the parameter or variable, used for debugging or printing purpose only.</param><exception cref="T:System.ArgumentNullException"><paramref name="type"/> is null.</exception>
        public static ParameterExpression Parameter(Type type, string name);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.ParameterExpression"/> node that can be used to identify a parameter or a variable in an expression tree.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.ParameterExpression"/> node with the specified name and type.
        /// </returns>
        /// <param name="type">The type of the parameter or variable.</param><param name="name">The name of the parameter or variable. This name is used for debugging or printing purpose only.</param>
        public static ParameterExpression Variable(Type type, string name);

        /// <summary>
        /// Creates an instance of <see cref="T:System.Linq.Expressions.RuntimeVariablesExpression"/>.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.RuntimeVariablesExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.RuntimeVariables"/> and the <see cref="P:System.Linq.Expressions.RuntimeVariablesExpression.Variables"/> property set to the specified value.
        /// </returns>
        /// <param name="variables">An array of <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.RuntimeVariablesExpression.Variables"/> collection.</param>
        public static RuntimeVariablesExpression RuntimeVariables(params ParameterExpression[] variables);

        /// <summary>
        /// Creates an instance of <see cref="T:System.Linq.Expressions.RuntimeVariablesExpression"/>.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.RuntimeVariablesExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.RuntimeVariables"/> and the <see cref="P:System.Linq.Expressions.RuntimeVariablesExpression.Variables"/> property set to the specified value.
        /// </returns>
        /// <param name="variables">A collection of <see cref="T:System.Linq.Expressions.ParameterExpression"/> objects to use to populate the <see cref="P:System.Linq.Expressions.RuntimeVariablesExpression.Variables"/> collection.</param>
        public static RuntimeVariablesExpression RuntimeVariables(IEnumerable<ParameterExpression> variables);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.SwitchCase"/> for use in a <see cref="T:System.Linq.Expressions.SwitchExpression"/>.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.SwitchCase"/>.
        /// </returns>
        /// <param name="body">The body of the case.</param><param name="testValues">The test values of the case.</param>
        public static SwitchCase SwitchCase(Expression body, params Expression[] testValues);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.SwitchCase"/> object to be used in a <see cref="T:System.Linq.Expressions.SwitchExpression"/> object.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.SwitchCase"/>.
        /// </returns>
        /// <param name="body">The body of the case.</param><param name="testValues">The test values of the case.</param>
        public static SwitchCase SwitchCase(Expression body, IEnumerable<Expression> testValues);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.SwitchExpression"/> that represents a switch statement without a default case.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.SwitchExpression"/>.
        /// </returns>
        /// <param name="switchValue">The value to be tested against each case.</param><param name="cases">The set of cases for this switch expression.</param>
        public static SwitchExpression Switch(Expression switchValue, params SwitchCase[] cases);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.SwitchExpression"/> that represents a switch statement that has a default case.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.SwitchExpression"/>.
        /// </returns>
        /// <param name="switchValue">The value to be tested against each case.</param><param name="defaultBody">The result of the switch if <paramref name="switchValue"/> does not match any of the cases.</param><param name="cases">The set of cases for this switch expression.</param>
        public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, params SwitchCase[] cases);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.SwitchExpression"/> that represents a switch statement that has a default case.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.SwitchExpression"/>.
        /// </returns>
        /// <param name="switchValue">The value to be tested against each case.</param><param name="defaultBody">The result of the switch if <paramref name="switchValue"/> does not match any of the cases.</param><param name="comparison">The equality comparison method to use.</param><param name="cases">The set of cases for this switch expression.</param>
        public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, MethodInfo comparison, params SwitchCase[] cases);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.SwitchExpression"/> that represents a switch statement that has a default case..
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.SwitchExpression"/>.
        /// </returns>
        /// <param name="type">The result type of the switch.</param><param name="switchValue">The value to be tested against each case.</param><param name="defaultBody">The result of the switch if <paramref name="switchValue"/> does not match any of the cases.</param><param name="comparison">The equality comparison method to use.</param><param name="cases">The set of cases for this switch expression.</param>
        public static SwitchExpression Switch(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, params SwitchCase[] cases);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.SwitchExpression"/> that represents a switch statement that has a default case.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.SwitchExpression"/>.
        /// </returns>
        /// <param name="switchValue">The value to be tested against each case.</param><param name="defaultBody">The result of the switch if <paramref name="switchValue"/> does not match any of the cases.</param><param name="comparison">The equality comparison method to use.</param><param name="cases">The set of cases for this switch expression.</param>
        public static SwitchExpression Switch(Expression switchValue, Expression defaultBody, MethodInfo comparison, IEnumerable<SwitchCase> cases);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.SwitchExpression"/> that represents a switch statement that has a default case.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.SwitchExpression"/>.
        /// </returns>
        /// <param name="type">The result type of the switch.</param><param name="switchValue">The value to be tested against each case.</param><param name="defaultBody">The result of the switch if <paramref name="switchValue"/> does not match any of the cases.</param><param name="comparison">The equality comparison method to use.</param><param name="cases">The set of cases for this switch expression.</param>
        public static SwitchExpression Switch(Type type, Expression switchValue, Expression defaultBody, MethodInfo comparison, IEnumerable<SwitchCase> cases);

        /// <summary>
        /// Creates an instance of <see cref="T:System.Linq.Expressions.SymbolDocumentInfo"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.SymbolDocumentInfo"/> that has the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.FileName"/> property set to the specified value.
        /// </returns>
        /// <param name="fileName">A <see cref="T:System.String"/> to set the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.FileName"/> equal to.</param>
        public static SymbolDocumentInfo SymbolDocument(string fileName);

        /// <summary>
        /// Creates an instance of <see cref="T:System.Linq.Expressions.SymbolDocumentInfo"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.SymbolDocumentInfo"/> that has the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.FileName"/> and <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.Language"/> properties set to the specified value.
        /// </returns>
        /// <param name="fileName">A <see cref="T:System.String"/> to set the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.FileName"/> equal to.</param><param name="language">A <see cref="T:System.Guid"/> to set the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.Language"/> equal to.</param>
        public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language);

        /// <summary>
        /// Creates an instance of <see cref="T:System.Linq.Expressions.SymbolDocumentInfo"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.SymbolDocumentInfo"/> that has the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.FileName"/> and <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.Language"/> and <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.LanguageVendor"/> properties set to the specified value.
        /// </returns>
        /// <param name="fileName">A <see cref="T:System.String"/> to set the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.FileName"/> equal to.</param><param name="language">A <see cref="T:System.Guid"/> to set the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.Language"/> equal to.</param><param name="languageVendor">A <see cref="T:System.Guid"/> to set the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.LanguageVendor"/> equal to.</param>
        public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language, Guid languageVendor);

        /// <summary>
        /// Creates an instance of <see cref="T:System.Linq.Expressions.SymbolDocumentInfo"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.SymbolDocumentInfo"/> that has the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.FileName"/> and <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.Language"/> and <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.LanguageVendor"/> and <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.DocumentType"/> properties set to the specified value.
        /// </returns>
        /// <param name="fileName">A <see cref="T:System.String"/> to set the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.FileName"/> equal to.</param><param name="language">A <see cref="T:System.Guid"/> to set the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.Language"/> equal to.</param><param name="languageVendor">A <see cref="T:System.Guid"/> to set the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.LanguageVendor"/> equal to.</param><param name="documentType">A <see cref="T:System.Guid"/> to set the <see cref="P:System.Linq.Expressions.SymbolDocumentInfo.DocumentType"/> equal to.</param>
        public static SymbolDocumentInfo SymbolDocument(string fileName, Guid language, Guid languageVendor, Guid documentType);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.TryExpression"/> representing a try block with a fault block and no catch statements.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.TryExpression"/>.
        /// </returns>
        /// <param name="body">The body of the try block.</param><param name="fault">The body of the fault block.</param>
        public static TryExpression TryFault(Expression body, Expression fault);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.TryExpression"/> representing a try block with a finally block and no catch statements.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.TryExpression"/>.
        /// </returns>
        /// <param name="body">The body of the try block.</param><param name="finally">The body of the finally block.</param>
        public static TryExpression TryFinally(Expression body, Expression @finally);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.TryExpression"/> representing a try block with any number of catch statements and neither a fault nor finally block.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.TryExpression"/>.
        /// </returns>
        /// <param name="body">The body of the try block.</param><param name="handlers">The array of zero or more <see cref="T:System.Linq.Expressions.CatchBlock"/> expressions representing the catch statements to be associated with the try block.</param>
        public static TryExpression TryCatch(Expression body, params CatchBlock[] handlers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.TryExpression"/> representing a try block with any number of catch statements and a finally block.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.TryExpression"/>.
        /// </returns>
        /// <param name="body">The body of the try block.</param><param name="finally">The body of the finally block.</param><param name="handlers">The array of zero or more <see cref="T:System.Linq.Expressions.CatchBlock"/> expressions representing the catch statements to be associated with the try block.</param>
        public static TryExpression TryCatchFinally(Expression body, Expression @finally, params CatchBlock[] handlers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.TryExpression"/> representing a try block with the specified elements.
        /// </summary>
        /// 
        /// <returns>
        /// The created <see cref="T:System.Linq.Expressions.TryExpression"/>.
        /// </returns>
        /// <param name="type">The result type of the try expression. If null, bodh and all handlers must have identical type.</param><param name="body">The body of the try block.</param><param name="finally">The body of the finally block. Pass null if the try block has no finally block associated with it.</param><param name="fault">The body of the t block. Pass null if the try block has no fault block associated with it.</param><param name="handlers">A collection of <see cref="T:System.Linq.Expressions.CatchBlock"/>s representing the catch statements to be associated with the try block.</param>
        public static TryExpression MakeTry(Type type, Expression body, Expression @finally, Expression fault, IEnumerable<CatchBlock> handlers);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.TypeBinaryExpression"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.TypeBinaryExpression"/> for which the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property is equal to <see cref="F:System.Linq.Expressions.ExpressionType.TypeIs"/> and for which the <see cref="P:System.Linq.Expressions.TypeBinaryExpression.Expression"/> and <see cref="P:System.Linq.Expressions.TypeBinaryExpression.TypeOperand"/> properties are set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.TypeBinaryExpression.Expression"/> property equal to.</param><param name="type">A <see cref="P:System.Linq.Expressions.Expression.Type"/> to set the <see cref="P:System.Linq.Expressions.TypeBinaryExpression.TypeOperand"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> or <paramref name="type"/> is null.</exception>
        public static TypeBinaryExpression TypeIs(Expression expression, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.TypeBinaryExpression"/> that compares run-time type identity.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.TypeBinaryExpression"/> for which the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property is equal to <see cref="M:System.Linq.Expressions.Expression.TypeEqual(System.Linq.Expressions.Expression,System.Type)"/> and for which the <see cref="T:System.Linq.Expressions.Expression"/> and <see cref="P:System.Linq.Expressions.TypeBinaryExpression.TypeOperand"/> properties are set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="T:System.Linq.Expressions.Expression"/> property equal to.</param><param name="type">A <see cref="P:System.Linq.Expressions.Expression.Type"/> to set the <see cref="P:System.Linq.Expressions.TypeBinaryExpression.TypeOperand"/> property equal to.</param>
        public static TypeBinaryExpression TypeEqual(Expression expression, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/>, given an operand, by calling the appropriate factory method.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Linq.Expressions.UnaryExpression"/> that results from calling the appropriate factory method.
        /// </returns>
        /// <param name="unaryType">The <see cref="T:System.Linq.Expressions.ExpressionType"/> that specifies the type of unary operation.</param><param name="operand">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the operand.</param><param name="type">The <see cref="T:System.Type"/> that specifies the type to be converted to (pass null if not applicable).</param><exception cref="T:System.ArgumentNullException"><paramref name="operand"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="unaryType"/> does not correspond to a unary expression node.</exception>
        public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/>, given an operand and implementing method, by calling the appropriate factory method.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Linq.Expressions.UnaryExpression"/> that results from calling the appropriate factory method.
        /// </returns>
        /// <param name="unaryType">The <see cref="T:System.Linq.Expressions.ExpressionType"/> that specifies the type of unary operation.</param><param name="operand">An <see cref="T:System.Linq.Expressions.Expression"/> that represents the operand.</param><param name="type">The <see cref="T:System.Type"/> that specifies the type to be converted to (pass null if not applicable).</param><param name="method">The <see cref="T:System.Reflection.MethodInfo"/> that represents the implementing method.</param><exception cref="T:System.ArgumentNullException"><paramref name="operand"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="unaryType"/> does not correspond to a unary expression node.</exception>
        public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents an arithmetic negation operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Negate"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property set to the specified value.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception><exception cref="T:System.InvalidOperationException">The unary minus operator is not defined for <paramref name="expression"/>.Type.</exception>
        public static UnaryExpression Negate(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents an arithmetic negation operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Negate"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> and <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the unary minus operator is not defined for <paramref name="expression"/>.Type.-or-<paramref name="expression"/>.Type (or its corresponding non-nullable type if it is a nullable value type) is not assignable to the argument type of the method represented by <paramref name="method"/>.</exception>
        public static UnaryExpression Negate(Expression expression, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a unary plus operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.UnaryPlus"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property set to the specified value.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception><exception cref="T:System.InvalidOperationException">The unary plus operator is not defined for <paramref name="expression"/>.Type.</exception>
        public static UnaryExpression UnaryPlus(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a unary plus operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.UnaryPlus"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> and <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the unary plus operator is not defined for <paramref name="expression"/>.Type.-or-<paramref name="expression"/>.Type (or its corresponding non-nullable type if it is a nullable value type) is not assignable to the argument type of the method represented by <paramref name="method"/>.</exception>
        public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents an arithmetic negation operation that has overflow checking.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NegateChecked"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property set to the specified value.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception><exception cref="T:System.InvalidOperationException">The unary minus operator is not defined for <paramref name="expression"/>.Type.</exception>
        public static UnaryExpression NegateChecked(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents an arithmetic negation operation that has overflow checking. The implementing method can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.NegateChecked"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> and <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the unary minus operator is not defined for <paramref name="expression"/>.Type.-or-<paramref name="expression"/>.Type (or its corresponding non-nullable type if it is a nullable value type) is not assignable to the argument type of the method represented by <paramref name="method"/>.</exception>
        public static UnaryExpression NegateChecked(Expression expression, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a bitwise complement operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Not"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property set to the specified value.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception><exception cref="T:System.InvalidOperationException">The unary not operator is not defined for <paramref name="expression"/>.Type.</exception>
        public static UnaryExpression Not(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a bitwise complement operation. The implementing method can be specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Not"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> and <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception><exception cref="T:System.InvalidOperationException"><paramref name="method"/> is null and the unary not operator is not defined for <paramref name="expression"/>.Type.-or-<paramref name="expression"/>.Type (or its corresponding non-nullable type if it is a nullable value type) is not assignable to the argument type of the method represented by <paramref name="method"/>.</exception>
        public static UnaryExpression Not(Expression expression, MethodInfo method);

        /// <summary>
        /// Returns whether the expression evaluates to false.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.UnaryExpression"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to evaluate.</param>
        public static UnaryExpression IsFalse(Expression expression);

        /// <summary>
        /// Returns whether the expression evaluates to false.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.UnaryExpression"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to evaluate.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that represents the implementing method.</param>
        public static UnaryExpression IsFalse(Expression expression, MethodInfo method);

        /// <summary>
        /// Returns whether the expression evaluates to true.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.UnaryExpression"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to evaluate.</param>
        public static UnaryExpression IsTrue(Expression expression);

        /// <summary>
        /// Returns whether the expression evaluates to true.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.UnaryExpression"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to evaluate.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that represents the implementing method.</param>
        public static UnaryExpression IsTrue(Expression expression, MethodInfo method);

        /// <summary>
        /// Returns the expression representing the ones complement.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.UnaryExpression"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/>.</param>
        public static UnaryExpression OnesComplement(Expression expression);

        /// <summary>
        /// Returns the expression representing the ones complement.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.UnaryExpression"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/>.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that represents the implementing method.</param>
        public static UnaryExpression OnesComplement(Expression expression, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents an explicit reference or boxing conversion where null is supplied if the conversion fails.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.TypeAs"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> and <see cref="P:System.Linq.Expressions.Expression.Type"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><param name="type">A <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> or <paramref name="type"/> is null.</exception>
        public static UnaryExpression TypeAs(Expression expression, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents an explicit unboxing.
        /// </summary>
        /// 
        /// <returns>
        /// An instance of <see cref="T:System.Linq.Expressions.UnaryExpression"/>.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to unbox.</param><param name="type">The new <see cref="T:System.Type"/> of the expression.</param>
        public static UnaryExpression Unbox(Expression expression, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a type conversion operation.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Convert"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> and <see cref="P:System.Linq.Expressions.Expression.Type"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><param name="type">A <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> or <paramref name="type"/> is null.</exception><exception cref="T:System.InvalidOperationException">No conversion operator is defined between <paramref name="expression"/>.Type and <paramref name="type"/>.</exception>
        public static UnaryExpression Convert(Expression expression, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a conversion operation for which the implementing method is specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Convert"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/>, <see cref="P:System.Linq.Expressions.Expression.Type"/>, and <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><param name="type">A <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> or <paramref name="type"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception><exception cref="T:System.InvalidOperationException">No conversion operator is defined between <paramref name="expression"/>.Type and <paramref name="type"/>.-or-<paramref name="expression"/>.Type is not assignable to the argument type of the method represented by <paramref name="method"/>.-or-The return type of the method represented by <paramref name="method"/> is not assignable to <paramref name="type"/>.-or-<paramref name="expression"/>.Type or <paramref name="type"/> is a nullable value type and the corresponding non-nullable value type does not equal the argument type or the return type, respectively, of the method represented by <paramref name="method"/>.</exception><exception cref="T:System.Reflection.AmbiguousMatchException">More than one method that matches the <paramref name="method"/> description was found.</exception>
        public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a conversion operation that throws an exception if the target type is overflowed.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ConvertChecked"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> and <see cref="P:System.Linq.Expressions.Expression.Type"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><param name="type">A <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> or <paramref name="type"/> is null.</exception><exception cref="T:System.InvalidOperationException">No conversion operator is defined between <paramref name="expression"/>.Type and <paramref name="type"/>.</exception>
        public static UnaryExpression ConvertChecked(Expression expression, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a conversion operation that throws an exception if the target type is overflowed and for which the implementing method is specified.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ConvertChecked"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/>, <see cref="P:System.Linq.Expressions.Expression.Type"/>, and <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> properties set to the specified values.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><param name="type">A <see cref="T:System.Type"/> to set the <see cref="P:System.Linq.Expressions.Expression.Type"/> property equal to.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Method"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> or <paramref name="type"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="method"/> is not null and the method it represents returns void, is not static (Shared in Visual Basic), or does not take exactly one argument.</exception><exception cref="T:System.InvalidOperationException">No conversion operator is defined between <paramref name="expression"/>.Type and <paramref name="type"/>.-or-<paramref name="expression"/>.Type is not assignable to the argument type of the method represented by <paramref name="method"/>.-or-The return type of the method represented by <paramref name="method"/> is not assignable to <paramref name="type"/>.-or-<paramref name="expression"/>.Type or <paramref name="type"/> is a nullable value type and the corresponding non-nullable value type does not equal the argument type or the return type, respectively, of the method represented by <paramref name="method"/>.</exception><exception cref="T:System.Reflection.AmbiguousMatchException">More than one method that matches the <paramref name="method"/> description was found.</exception>
        public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents an expression for obtaining the length of a one-dimensional array.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.ArrayLength"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to <paramref name="array"/>.
        /// </returns>
        /// <param name="array">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="array"/> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="array"/>.Type does not represent an array type.</exception>
        public static UnaryExpression ArrayLength(Expression array);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents an expression that has a constant value of type <see cref="T:System.Linq.Expressions.Expression"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that has the <see cref="P:System.Linq.Expressions.Expression.NodeType"/> property equal to <see cref="F:System.Linq.Expressions.ExpressionType.Quote"/> and the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property set to the specified value.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to set the <see cref="P:System.Linq.Expressions.UnaryExpression.Operand"/> property equal to.</param><exception cref="T:System.ArgumentNullException"><paramref name="expression"/> is null.</exception>
        public static UnaryExpression Quote(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a rethrowing of an exception.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a rethrowing of an exception.
        /// </returns>
        public static UnaryExpression Rethrow();

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a rethrowing of an exception with a given type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a rethrowing of an exception.
        /// </returns>
        /// <param name="type">The new <see cref="T:System.Type"/> of the expression.</param>
        public static UnaryExpression Rethrow(Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a throwing of an exception.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the exception.
        /// </returns>
        /// <param name="value">An <see cref="T:System.Linq.Expressions.Expression"/>.</param>
        public static UnaryExpression Throw(Expression value);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents a throwing of an exception with a given type.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the exception.
        /// </returns>
        /// <param name="value">An <see cref="T:System.Linq.Expressions.Expression"/>.</param><param name="type">The new <see cref="T:System.Type"/> of the expression.</param>
        public static UnaryExpression Throw(Expression value, Type type);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the incrementing of the expression value by 1.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the incremented expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to increment.</param>
        public static UnaryExpression Increment(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the incrementing of the expression by 1.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the incremented expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to increment.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that represents the implementing method.</param>
        public static UnaryExpression Increment(Expression expression, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the decrementing of the expression by 1.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the decremented expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to decrement.</param>
        public static UnaryExpression Decrement(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the decrementing of the expression by 1.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the decremented expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to decrement.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that represents the implementing method.</param>
        public static UnaryExpression Decrement(Expression expression, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that increments the expression by 1 and assigns the result back to the expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the resultant expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to apply the operations on.</param>
        public static UnaryExpression PreIncrementAssign(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that increments the expression by 1 and assigns the result back to the expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the resultant expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to apply the operations on.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that represents the implementing method.</param>
        public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that decrements the expression by 1 and assigns the result back to the expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the resultant expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to apply the operations on.</param>
        public static UnaryExpression PreDecrementAssign(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that decrements the expression by 1 and assigns the result back to the expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the resultant expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to apply the operations on.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that represents the implementing method.</param>
        public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the assignment of the expression followed by a subsequent increment by 1 of the original expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the resultant expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to apply the operations on.</param>
        public static UnaryExpression PostIncrementAssign(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the assignment of the expression followed by a subsequent increment by 1 of the original expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the resultant expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to apply the operations on.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that represents the implementing method.</param>
        public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the assignment of the expression followed by a subsequent decrement by 1 of the original expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the resultant expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to apply the operations on.</param>
        public static UnaryExpression PostDecrementAssign(Expression expression);

        /// <summary>
        /// Creates a <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the assignment of the expression followed by a subsequent decrement by 1 of the original expression.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Linq.Expressions.UnaryExpression"/> that represents the resultant expression.
        /// </returns>
        /// <param name="expression">An <see cref="T:System.Linq.Expressions.Expression"/> to apply the operations on.</param><param name="method">A <see cref="T:System.Reflection.MethodInfo"/> that represents the implementing method.</param>
        public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method);

        /// <summary>
        /// Gets the node type of this <see cref="T:System.Linq.Expressions.Expression"/>.
        /// </summary>
        /// 
        /// <returns>
        /// One of the <see cref="T:System.Linq.Expressions.ExpressionType"/> values.
        /// </returns>
        public virtual ExpressionType NodeType { get; }

        /// <summary>
        /// Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression"/> represents.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Type"/> that represents the static type of the expression.
        /// </returns>
        public virtual Type Type { get; }

        /// <summary>
        /// Indicates that the node can be reduced to a simpler node. If this returns true, Reduce() can be called to produce the reduced form.
        /// </summary>
        /// 
        /// <returns>
        /// True if the node can be reduced, otherwise false.
        /// </returns>
        public virtual bool CanReduce { get; }
    }
}
