© 2025 Alibre Design Inc. All rights reserved.
This source code was authored by Stephen S. Mitchell and is the intellectual property of Alibre Design Inc. All copyrights, trademarks, and associated rights are solely held by Alibre Design Inc.
This code is provided "as is," without any warranties, express or implied, including but not limited to warranties of merchantability, fitness for a particular purpose, or non-infringement. 
The author and Alibre Design Inc. disclaim any liability for damages or losses arising from the use, modification, or distribution of this code.
Any use, reproduction, modification, or distribution of this source code must comply with the terms and conditions set forth by Alibre Design Inc. Unauthorized use is strictly prohibited.
For inquiries regarding licensing or permissions, please contact Alibre Design Inc.
public enum ADSketchConstraintType
{
	AD_CONSTRAINT_UNKNOWN,
	AD_CONSTRAINT_HORIZONTAL,
	AD_CONSTRAINT_VERTICAL,
	AD_CONSTRAINT_COLLINEAR,
	AD_CONSTRAINT_CORADIAL,
	AD_CONSTRAINT_COINCIDENT,
	AD_CONSTRAINT_PERPENDICULAR,
	AD_CONSTRAINT_PARALLEL,
	AD_CONSTRAINT_TANGENT,
	AD_CONSTRAINT_EQUAL,
	AD_CONSTRAINT_MIDPOINT,
	AD_CONSTRAINT_INTERSECTION,
	AD_CONSTRAINT_SYMMETRIC,
	AD_CONSTRAINT_FIX,
	AD_CONSTRAINT_NORMAL,
}
public static class AD_3DSketch_Functions
{
	public static AlibreX.ADObjectType GetType(AlibreX.IAD3DSketch s) => s.Type;
	public static string GetName(AlibreX.IAD3DSketch s) => s.Name;
	public static void SetName(AlibreX.IAD3DSketch s, string name) => s.Name = name;
	public static AlibreX.IADRoot GetRoot(AlibreX.IAD3DSketch s) => s.Root;
}
public static class AD_3DSketchBspline_Functions
{
	public static void GetDefinition(AlibreX.IAD3DSketchBspline bs,out int pOrder,out int pNumCtlPoints,out int pNumKnots,out bool pIsRational,out bool pIsClosed,out bool pIsPlanar)
	{
		bs.GetDefinition(out pOrder, out pNumCtlPoints, out pNumKnots,out pIsRational, out pIsClosed, out pIsPlanar);
	}
	public static void GetData(AlibreX.IAD3DSketchBspline bs,ref Array pCtlPoints,ref Array pKnotVector,ref Array pWeights)
	{
		bs.GetData(ref pCtlPoints, ref pKnotVector, ref pWeights);
	}
	public static AlibreX.IADPoint GetStartPoint(AlibreX.IAD3DSketchBspline bs) => bs.StartPoint;
	public static AlibreX.IADPoint GetEndPoint(AlibreX.IAD3DSketchBspline bs) => bs.EndPoint;
}
public static class AD_3DSketchCircle_Functions
{
	public static AlibreX.IAD3DSketchPoint GetCenter(AlibreX.IAD3DSketchCircle c) => c.Center;
	public static AlibreX.IADVector GetNormal(AlibreX.IAD3DSketchCircle c) => c.Normal;
	public static double GetRadius(AlibreX.IAD3DSketchCircle c) => c.Radius;
}
public static class AD_3DSketchCircularArc_Functions
{
	public static AlibreX.IAD3DSketchPoint GetCenter(AlibreX.IAD3DSketchCircularArc arc) => arc.Center;
	public static double GetRadius(AlibreX.IAD3DSketchCircularArc arc) => arc.Radius;
	public static AlibreX.IAD3DSketchPoint GetStart(AlibreX.IAD3DSketchCircularArc arc) => arc.Start;
	public static AlibreX.IAD3DSketchPoint GetEnd(AlibreX.IAD3DSketchCircularArc arc) => arc.End;
	public static double GetIncludedAngle(AlibreX.IAD3DSketchCircularArc arc) => arc.IncludedAngle;
	public static bool GetIsRightHandRule(AlibreX.IAD3DSketchCircularArc arc) => arc.IsRightHandRule;
}
public static class AD_3DSketchEllipse_Functions
{
	public static AlibreX.IAD3DSketchPoint GetCenter(AlibreX.IAD3DSketchEllipse e) => e.Center;
	public static AlibreX.IAD3DSketchPoint GetMajorRadiusPoint(AlibreX.IAD3DSketchEllipse e) => e.MajorRadiusPoint;
	public static AlibreX.IAD3DSketchPoint GetMinorRadiusPoint(AlibreX.IAD3DSketchEllipse e) => e.MinorRadiusPoint;
}
public static class AD_3DSketchEllipticArc_Functions
{
	public static AlibreX.IAD3DSketchPoint GetCenter(AlibreX.IAD3DSketchEllipticArc ea) => ea.Center;
	public static AlibreX.IAD3DSketchPoint GetMajorRadiusPoint(AlibreX.IAD3DSketchEllipticArc ea) => ea.MajorRadiusPoint;
	public static AlibreX.IAD3DSketchPoint GetMinorRadiusPoint(AlibreX.IAD3DSketchEllipticArc ea) => ea.MinorRadiusPoint;
	public static AlibreX.IAD3DSketchPoint GetStart(AlibreX.IAD3DSketchEllipticArc ea) => ea.Start;
	public static AlibreX.IAD3DSketchPoint GetEnd(AlibreX.IAD3DSketchEllipticArc ea) => ea.End;
	public static bool GetIsRightHandRule(AlibreX.IAD3DSketchEllipticArc ea) => ea.IsRightHandRule;
}
public static class AD_3DSketches_Functions
{
	public static IEnumerator GetEnumerator(AlibreX.IAD3DSketches s) => s.GetEnumerator();
	public static AlibreX.IAD3DSketch Item(AlibreX.IAD3DSketches s, object index) => s.Item(index);
	public static int GetCount(AlibreX.IAD3DSketches s) => s.Count;
	public static AlibreX.DIEnum GetEnum(AlibreX.IAD3DSketches s) => s.Enum;
	public static AlibreX.IADDesignSession GetSession(AlibreX.IAD3DSketches s) => s.Session;
	public static AlibreX.IAD3DSketch Add3DSketch(AlibreX.IAD3DSketches s, string name) => s.Add3DSketch(name);
}
public static class AD_3DSketchFigure_Functions
{
	public static AlibreX.ADObjectType GetType(AlibreX.IAD3DSketchFigure f) => f.Type;
	public static AlibreX.ADGeometryType GetFigureType(AlibreX.IAD3DSketchFigure f) => f.FigureType;
	public static AlibreX.IADRoot GetRoot(AlibreX.IAD3DSketchFigure f) => f.Root;
	public static AlibreX.IAD3DSketch GetSketch(AlibreX.IAD3DSketchFigure f) => f.Sketch;
	public static bool GetIsReference(AlibreX.IAD3DSketchFigure f) => f.IsReference;
	public static string GetID(AlibreX.IAD3DSketchFigure f) => f.ID;
}
public static class AD_3DSketchFigures_Functions
{
	public static IEnumerator GetEnumerator(AlibreX.IAD3DSketchFigures figs) => figs.GetEnumerator();
	public static AlibreX.IAD3DSketchFigure Item(AlibreX.IAD3DSketchFigures figs, int index) => figs.Item(index);
	public static int GetCount(AlibreX.IAD3DSketchFigures figs) => figs.Count;
	public static AlibreX.DIEnum GetEnum(AlibreX.IAD3DSketchFigures figs) => figs.Enum;
	public static AlibreX.IAD3DSketch GetSketch(AlibreX.IAD3DSketchFigures figs) => figs.Sketch;
	public static AlibreX.IAD3DSketchPoint AddPoint(AlibreX.IAD3DSketchFigures figs, AlibreX.IADPoint point)=> figs.AddPoint(point);
	public static AlibreX.IAD3DSketchPoint AddPoint(AlibreX.IAD3DSketchFigures figs, double x, double y, double z)=> figs.AddPoint(x, y, z);
	public static AlibreX.IAD3DSketchLine AddLine(AlibreX.IAD3DSketchFigures figs, double x1, double y1, double z1, double x2, double y2, double z2)=> figs.AddLine(x1, y1, z1, x2, y2, z2);
	public static AlibreX.IAD3DSketchLine AddLine(AlibreX.IAD3DSketchFigures figs, AlibreX.IADPoint start, AlibreX.IADPoint end)=> figs.AddLine(start, end);
	public static AlibreX.IAD3DSketchCircularArc AddCircularArcByCenterStartEnd(AlibreX.IAD3DSketchFigures figs,double XCenter, double YCenter, double ZCenter,double XStartPt, double YStartPt, double ZStartPt,double XEndPt, double YEndPt, double ZEndPt)=> figs.AddCircularArcByCenterStartEnd(XCenter, YCenter, ZCenter,XStartPt, YStartPt, ZStartPt, XEndPt, YEndPt, ZEndPt);
	public static AlibreX.IAD3DSketchCircularArc AddCircularArcByCenterStartEnd(AlibreX.IAD3DSketchFigures figs,AlibreX.IADPoint center,AlibreX.IADPoint start,AlibreX.IADPoint end)=> figs.AddCircularArcByCenterStartEnd(center, start, end);
	public static AlibreX.IAD3DSketchBspline AddBsplineByInterpolation(AlibreX.IAD3DSketchFigures figs, ref Array pInterpolationPoints)=> figs.AddBsplineByInterpolation(ref pInterpolationPoints);
	public static AlibreX.IAD3DSketchFigure GetFigureByID(AlibreX.IAD3DSketchFigures figs, string ID)=> figs.GetFigureByID(ID);
	public static AlibreX.IObjectCollector AddPolyline(AlibreX.IAD3DSketchFigures figs, ref Array pPoints)=> figs.AddPolyline(ref pPoints);
	public static AlibreX.IAD3DSketchBspline AddBspline(AlibreX.IAD3DSketchFigures figs,int order,int numCtlPoints,ref Array pCtlPoints,ref Array pKnotVector,ref Array pWeights)=> figs.AddBspline(order, numCtlPoints, ref pCtlPoints, ref pKnotVector, ref pWeights);
}
public static class AD_3DSketchLine_Functions
{
	public static AlibreX.IAD3DSketchPoint GetStart(AlibreX.IAD3DSketchLine l) => l.Start;
	public static AlibreX.IAD3DSketchPoint GetEnd(AlibreX.IAD3DSketchLine l) => l.End;
	public static double GetLength(AlibreX.IAD3DSketchLine l) => l.Length;
}
public static class AD_3DSketchPoint_Functions
{
	public static double GetX(AlibreX.IAD3DSketchPoint p) => p.X;
	public static double GetY(AlibreX.IAD3DSketchPoint p) => p.Y;
	public static double GetZ(AlibreX.IAD3DSketchPoint p) => p.Z;
	public static bool GetIsSketchNode(AlibreX.IAD3DSketchPoint p) => p.IsSketchNode;
}
public static class AD_Sketch_Functions
{
	public static AlibreX.ADObjectType GetType(AlibreX.IADSketch s) => s.Type;
	public static string GetName(AlibreX.IADSketch s) => s.Name;
	public static void SetName(AlibreX.IADSketch s, string name) => s.Name = name;
	public static AlibreX.IADRoot GetRoot(AlibreX.IADSketch s) => s.Root;
	public static AlibreX.IADDesignSession GetSession(AlibreX.IADSketch s) => s.Session;
	public static AlibreX.IADSketchFigures GetFigures(AlibreX.IADSketch s) => s.Figures;
	public static bool GetIsClosed(AlibreX.IADSketch s) => s.IsClosed;
	public static AlibreX.IADVector GetSketchPlaneNormal(AlibreX.IADSketch s) => s.SketchPlaneNormal;
	public static AlibreX.IADTargetProxy GetSketchPlane(AlibreX.IADSketch s) => s.SketchPlane;
	public static bool GetIsConsumed(AlibreX.IADSketch s) => s.IsConsumed;
	public static AlibreX.IADPartFeature GetConsumingFeature(AlibreX.IADSketch s) => s.ConsumingFeature;
	public static void Delete(AlibreX.IADSketch s) => s.Delete();
	public static void BeginChange(AlibreX.IADSketch s) => s.BeginChange();
	public static void BeginChangeEx(AlibreX.IADSketch s, AlibreX.IADPoint pOrigin, AlibreX.IADVector pXAxis, AlibreX.IADVector pYDirection)=> s.BeginChangeEx(pOrigin, pXAxis, pYDirection);
	public static void EndChange(AlibreX.IADSketch s) => s.EndChange();
	public static void MapFromWorldToSketch(AlibreX.IADSketch s, AlibreX.IADPoint xyzPoint, out double uCoord, out double vCoord)=> s.MapFromWorldToSketch(xyzPoint, out uCoord, out vCoord);
	public static AlibreX.IADDimensions GetDimensions(AlibreX.IADSketch s) => s.Dimensions;
	public static void GetExtents(AlibreX.IADSketch s, out AlibreX.IAD2DPoint ppLower, out AlibreX.IAD2DPoint ppUpper)=> s.GetExtents(out ppLower, out ppUpper);
	public static AlibreX.IAnalyzedSketchData Analyze(AlibreX.IADSketch s,bool bDisjointEnds,bool bOpenLoops,bool bOverLaps,bool bSelfIntersections,bool bDegenerateFigures,bool bHealSketch,double dblHealingTolerance)=> s.Analyze(bDisjointEnds, bOpenLoops, bOverLaps, bSelfIntersections, bDegenerateFigures, bHealSketch, dblHealingTolerance);
	public static void MapFromSketchToWorld(AlibreX.IADSketch s, double uCoord, double vCoord, out AlibreX.IADPoint xyzPoint)=> s.MapFromSketchToWorld(uCoord, vCoord, out xyzPoint);
	public static Array GetKey(AlibreX.IADSketch s) => s.Key;
	public static bool GetIsSuppressed(AlibreX.IADSketch s) => s.IsSuppressed;
	public static bool GetIsActive(AlibreX.IADSketch s) => s.IsActive;
	public static AlibreX.IADSketchConstraints GetSketchConstraints(AlibreX.IADSketch s) => s.SketchConstraints;
	public static AlibreX.IADSketchPoint GetOriginPoint(AlibreX.IADSketch s) => s.OriginPoint;
}
public static class AD_SketchBspline_Functions
{
	public static void GetDefinition(AlibreX.IADSketchBspline bs,out int pOrder,out int pNumCtlPoints,out int pNumKnots,out bool pIsRational,out bool pIsClosed,out bool pIsPeriodic)
	{
		bs.GetDefinition(out pOrder, out pNumCtlPoints, out pNumKnots,out pIsRational, out pIsClosed, out pIsPeriodic);
	}
	public static void GetBsplineData(AlibreX.IADSketchBspline bs,ref Array pCtlPoints,ref Array pKnotVector,ref Array pWeights)
	{
		bs.GetBsplineData(ref pCtlPoints, ref pKnotVector, ref pWeights);
	}
	public static AlibreX.IAD2DPoint GetStartPoint(AlibreX.IADSketchBspline bs) => bs.StartPoint;
	public static AlibreX.IAD2DPoint GetEndPoint(AlibreX.IADSketchBspline bs) => bs.EndPoint;
}
public static class AD_SketchCircle_Functions
{
	public static AlibreX.IADSketchPoint GetCenter(AlibreX.IADSketchCircle c) => c.Center;
	public static double GetRadius(AlibreX.IADSketchCircle c) => c.Radius;
}
public static class AD_SketchCircularArc_Functions
{
	public static AlibreX.IADSketchPoint GetCenter(AlibreX.IADSketchCircularArc arc) => arc.Center;
	public static double GetRadius(AlibreX.IADSketchCircularArc arc) => arc.Radius;
	public static AlibreX.IADSketchPoint GetStart(AlibreX.IADSketchCircularArc arc) => arc.Start;
	public static AlibreX.IADSketchPoint GetEnd(AlibreX.IADSketchCircularArc arc) => arc.End;
	public static double GetIncludedAngle(AlibreX.IADSketchCircularArc arc) => arc.IncludedAngle;
	public static bool GetIsRightHandRule(AlibreX.IADSketchCircularArc arc) => arc.IsRightHandRule;
}
public static class AD_SketchConstraint_Functions
{
	public static AlibreX.ADObjectType GetType(AlibreX.IADSketchConstraint c) => c.Type;
	public static AlibreX.ADSketchConstraintType GetSketchConstraintType(AlibreX.IADSketchConstraint c) => c.SketchConstraintType;
	public static AlibreX.IADRoot GetRoot(AlibreX.IADSketchConstraint c) => c.Root;
	public static AlibreX.IADDesignSession GetSession(AlibreX.IADSketchConstraint c) => c.Session;
}
public static class AD_SketchConstraints_Functions
{
	public static IEnumerator GetEnumerator(AlibreX.IADSketchConstraints sc) => sc.GetEnumerator();
	public static AlibreX.IADSketchConstraint Item(AlibreX.IADSketchConstraints sc, int index) => sc.Item(index);
	public static int GetCount(AlibreX.IADSketchConstraints sc) => sc.Count;
	public static AlibreX.DIEnum GetEnum(AlibreX.IADSketchConstraints sc) => sc.Enum;
	public static AlibreX.IADSketch GetSketch(AlibreX.IADSketchConstraints sc) => sc.Sketch;
	public static bool AddConstraint(AlibreX.IADSketchConstraints sc, AlibreX.IObjectCollector targets, AlibreX.ADSketchConstraintType type)=> sc.AddConstraint(targets, type);
}
public static class AD_SketchEllipse_Functions
{
	public static AlibreX.IADSketchPoint GetCenter(AlibreX.IADSketchEllipse e) => e.Center;
	public static double GetMajorAxis(AlibreX.IADSketchEllipse e) => e.MajorAxis;
	public static double GetMinorMajorRatio(AlibreX.IADSketchEllipse e) => e.MinorMajorRatio;
	public static double GetMajorAxisAngle(AlibreX.IADSketchEllipse e) => e.MajorAxisAngle;
}
public static class AD_SketchEllipticArc_Functions
{
	public static AlibreX.IADSketchPoint GetCenter(AlibreX.IADSketchEllipticArc ea) => ea.Center;
	public static double GetMajorAxis(AlibreX.IADSketchEllipticArc ea) => ea.MajorAxis;
	public static double GetMinorMajorRatio(AlibreX.IADSketchEllipticArc ea) => ea.MinorMajorRatio;
	public static AlibreX.IADSketchPoint GetStart(AlibreX.IADSketchEllipticArc ea) => ea.Start;
	public static AlibreX.IADSketchPoint GetEnd(AlibreX.IADSketchEllipticArc ea) => ea.End;
	public static double GetMajorAxisAngle(AlibreX.IADSketchEllipticArc ea) => ea.MajorAxisAngle;
	public static bool GetIsRightHandRule(AlibreX.IADSketchEllipticArc ea) => ea.IsRightHandRule;
}
public static class AD_Sketches_Functions
{
	public static IEnumerator GetEnumerator(AlibreX.IADSketches s) => s.GetEnumerator();
	public static AlibreX.IADSketch Item(AlibreX.IADSketches s, object index) => s.Item(index);
	public static int GetCount(AlibreX.IADSketches s) => s.Count;
	public static AlibreX.DIEnum GetEnum(AlibreX.IADSketches s) => s.Enum;
	public static AlibreX.IADDesignSession GetSession(AlibreX.IADSketches s) => s.Session;
	public static AlibreX.IADSketch AddSketch(AlibreX.IADSketches s,AlibreX.IADOccurrence occurrence,object sketchPlane,string name = "")
	{
		return s.AddSketch(occurrence, sketchPlane, name);
	}
}
public static class AD_SketchFigure_Functions
{
	public static AlibreX.ADObjectType GetType(AlibreX.IADSketchFigure f) => f.Type;
	public static AlibreX.ADGeometryType GetFigureType(AlibreX.IADSketchFigure f) => f.FigureType;
	public static AlibreX.IADRoot GetRoot(AlibreX.IADSketchFigure f) => f.Root;
	public static AlibreX.IADSketch GetSketch(AlibreX.IADSketchFigure f) => f.Sketch;
	public static bool GetIsReference(AlibreX.IADSketchFigure f) => f.IsReference;
	public static void SetIsReference(AlibreX.IADSketchFigure f, bool value) => f.IsReference = value;
	public static bool GetIsAnchored(AlibreX.IADSketchFigure f) => f.IsAnchored;
	public static void SetIsAnchored(AlibreX.IADSketchFigure f, bool value) => f.IsAnchored = value;
	public static void Delete(AlibreX.IADSketchFigure f) => f.Delete();
	public static bool GetIsOwned(AlibreX.IADSketchFigure f) => f.IsOwned;
	public static string GetID(AlibreX.IADSketchFigure f) => f.ID;
}
public static class AD_SketchFigures_Functions
{
	public static IEnumerator GetEnumerator(AlibreX.IADSketchFigures fs) => fs.GetEnumerator();
	public static AlibreX.IADSketchFigure Item(AlibreX.IADSketchFigures fs, object index) => fs.Item(index);
	public static int GetCount(AlibreX.IADSketchFigures fs) => fs.Count;
	public static AlibreX.DIEnum GetEnum(AlibreX.IADSketchFigures fs) => fs.Enum;
	public static AlibreX.IADSketch GetSketch(AlibreX.IADSketchFigures fs) => fs.Sketch;
	public static AlibreX.IADSketchPoint AddSketchPoint(AlibreX.IADSketchFigures fs, double XCoord, double YCoord)=> fs.AddSketchPoint(XCoord, YCoord);
	public static AlibreX.IADSketchLine AddLine(AlibreX.IADSketchFigures fs, double X1, double Y1, double X2, double Y2)=> fs.AddLine(X1, Y1, X2, Y2);
	public static AlibreX.IADSketchCircle AddCircle(AlibreX.IADSketchFigures fs, double XCenter, double YCenter, object Radius)=> fs.AddCircle(XCenter, YCenter, Radius);
	public static AlibreX.IADSketchCircularArc AddCircularArcByCenterStartAngle(AlibreX.IADSketchFigures fs, double XCenter, double YCenter, double XStartPt, double YStartPt, double ArcAngle)=> fs.AddCircularArcByCenterStartAngle(XCenter, YCenter, XStartPt, YStartPt, ArcAngle);
	public static AlibreX.IADSketchCircularArc AddCircularArcByCenterStartEnd(AlibreX.IADSketchFigures fs, double XCenter, double YCenter, double XStartPt, double YStartPt, double XEndPt, double YEndPt)=> fs.AddCircularArcByCenterStartEnd(XCenter, YCenter, XStartPt, YStartPt, XEndPt, YEndPt);
	public static AlibreX.IObjectCollector AddRectangle(AlibreX.IADSketchFigures fs, double Xlow, double Ylow, double Xhigh, double Yhigh)=> fs.AddRectangle(Xlow, Ylow, Xhigh, Yhigh);
	public static AlibreX.IADSketchBspline AddBspline(AlibreX.IADSketchFigures fs,int order,int numCtlPoints,ref Array pCtlPoints,ref Array pKnotVector,ref Array pWeights)=> fs.AddBspline(order, numCtlPoints, ref pCtlPoints, ref pKnotVector, ref pWeights);
	public static AlibreX.IADSketchCircularArc AddCircularArcBy3Points(AlibreX.IADSketchFigures fs, double XCenter, double YCenter, double XStartPt, double YStartPt, double XEndPt, double YEndPt)=> fs.AddCircularArcBy3Points(XCenter, YCenter, XStartPt, YStartPt, XEndPt, YEndPt);
	public static AlibreX.IADSketchCircularArc AddCircularArc(AlibreX.IADSketchFigures fs, double XCenter, double YCenter, double XStartPt, double YStartPt, double ArcAngle)=> fs.AddCircularArc(XCenter, YCenter, XStartPt, YStartPt, ArcAngle);
	public static AlibreX.IADSketchFigure GetFigureByID(AlibreX.IADSketchFigures fs, string ID)=> fs.GetFigureByID(ID);
	public static AlibreX.IADSketchBspline AddBsplineByInterpolation(AlibreX.IADSketchFigures fs, ref Array pInterpolationPoints)=> fs.AddBsplineByInterpolation(ref pInterpolationPoints);
	public static AlibreX.IADSketchEllipse AddEllipse(AlibreX.IADSketchFigures fs, double XCenter, double YCenter, double majorAxis, double minorMajorRatio, double majorAxisAngle)=> fs.AddEllipse(XCenter, YCenter, majorAxis, minorMajorRatio, majorAxisAngle);
	public static AlibreX.IADSketchEllipse AddEllipseBy3Points(AlibreX.IADSketchFigures fs, double XCenter, double YCenter, double XMajor, double YMajor, double XMinor, double YMinor)=> fs.AddEllipseBy3Points(XCenter, YCenter, XMajor, YMajor, XMinor, YMinor);
	public static AlibreX.IADSketchEllipticArc AddEllipticArc(AlibreX.IADSketchFigures fs,double XCenter,double YCenter,double majorAxis,double minorMajorRatio,double XStart,double YStart,double XEnd,double YEnd,double majorAxisAngle)=> fs.AddEllipticArc(XCenter, YCenter, majorAxis, minorMajorRatio, XStart, YStart, XEnd, YEnd, majorAxisAngle);
}
public static class AD_SketchLine_Functions
{
	public static AlibreX.IADSketchPoint GetStart(AlibreX.IADSketchLine line) => line.Start;
	public static AlibreX.IADSketchPoint GetEnd(AlibreX.IADSketchLine line) => line.End;
	public static double GetLength(AlibreX.IADSketchLine line) => line.Length;
}
public static class AD_SketchPoint_Functions
{
	public static double GetX(AlibreX.IADSketchPoint p) => p.X;
	public static double GetY(AlibreX.IADSketchPoint p) => p.Y;
	public static bool GetIsSketchNode(AlibreX.IADSketchPoint p) => p.IsSketchNode;
}
public static class AD_ComplexSketchFigure_Functions
{
	public static AlibreX.IADCompositeFigure GetCompositeFigure(AlibreX.IADComplexSketchFigure cf) => cf.CompositeFigure;
}
public static class AD_SketchShapePattern_Functions
{
	public static AlibreX.IADCompositeFigure GetCompositeFigure(AlibreX.IADSketchShapePattern sp) => sp.CompositeFigure;
}
public static class AD_SketchText_Functions
{
	public static string GetTextString(AlibreX.IADSketchText t) => t.TextString;
	public static void SetTextString(AlibreX.IADSketchText t, string value) => t.TextString = value;
	public static string GetFontName(AlibreX.IADSketchText t) => t.FontName;
	public static void SetFontName(AlibreX.IADSketchText t, string value) => t.FontName = value;
	public static bool GetBold(AlibreX.IADSketchText t) => t.Bold;
	public static void SetBold(AlibreX.IADSketchText t, bool value) => t.Bold = value;
	public static bool GetItalic(AlibreX.IADSketchText t) => t.Italic;
	public static void SetItalic(AlibreX.IADSketchText t, bool value) => t.Italic = value;
}
public static class AnalyzedSketchData_Functions
{
	public static AlibreX.IObjectCollector GetDisjointEnds(AlibreX.IAnalyzedSketchData d) => d.DisjointEnds;
	public static AlibreX.IObjectCollector GetOpenLoops(AlibreX.IAnalyzedSketchData d) => d.OpenLoops;
	public static AlibreX.IObjectCollector GetOverLaps(AlibreX.IAnalyzedSketchData d) => d.OverLaps;
	public static AlibreX.IObjectCollector GetIntersections(AlibreX.IAnalyzedSketchData d) => d.Intersections;
	public static AlibreX.IObjectCollector GetDegenerateFigures(AlibreX.IAnalyzedSketchData d) => d.DegenerateFigures;
}
public static class SketchDegenerateFigure_Functions { /* No members. */ }
public static class SketchFigureDisjointEnd_Functions { /* No members. */ }
public static class SketchFigureIntersection_Functions { /* No members. */ }
public static class SketchFigureOpenLoop_Functions { /* No members. */ }
public static class SketchFigureOverlap_Functions { /* No members. */ }
