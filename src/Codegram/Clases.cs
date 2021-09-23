using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Codegram
{
    [Serializable()]
    public enum VisibilityType { Private, Protected, Public }
    [Serializable()]
    public enum RelationshipType { Dependency, Association, Aggregation, Composition, Inheritance }
    [Serializable()]
    public enum MultiplicityType {
        None, NoInstance, 
        NoInstanceOrOneInstance, 
        ExactlyOneInstance, 
        ZeroOrMoreInstance, 
        OneOrMoreInstance };

    [Serializable()]
    public class Atribute
    {
        public VisibilityType visibility { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string initial_value { get; set; }
        public bool get { get; set; }
        public bool set { get; set; }

        public Atribute()
        {
            this.visibility = VisibilityType.Private;
            this.name = "";
            this.type = "";
            this.initial_value = "";
            this.get = false;
            this.set = false;
        }
        public Atribute(Atribute attribute)
        {
            this.visibility = attribute.visibility;
            this.name = attribute.name;
            this.type = attribute.type;
            this.initial_value = attribute.initial_value;
            this.get = attribute.get;
            this.set = attribute.set;
        }
        public override string ToString()
        {
            string ans = " ";

            if (visibility == VisibilityType.Public)
                ans += "+ ";
            else if (visibility == VisibilityType.Private)
                ans += "- ";
            else if (visibility == VisibilityType.Protected)
                ans += "# ";

            ans += name;

            if (type != "")
                ans += " : " + type;

            if (initial_value != "")
                ans += " = " + initial_value;

            ans += " ";
            return ans;
        }
    }
    [Serializable()]
    public class Parameter
    {
        public string type { get; set; }
        public string name { get; set; }
        
        public Parameter()
        {
            type = "";
            name = "";
        }
        public Parameter(Parameter parameter)
        {
            this.type = parameter.type;
            this.name = parameter.name;
        }
        public override string ToString()
        {
            return type + " " + name;
        }
    }
    [Serializable()]
    public class Method
    {
        public VisibilityType visibility { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public bool @virtual { get; set; }
        public List<Parameter> parameters { get; set; }
        public Method()
        {
            parameters = new List<Parameter>();
            type = "";
            name = "";
            code = "";
            @virtual = false;
        }
        public Method(Method method)
        {
            this.visibility = method.visibility;
            this.type = method.type;
            this.name = method.name;
            this.code = method.code;
            this.@virtual = method.@virtual;
            parameters = new List<Parameter>();
            foreach (Parameter p in method.parameters)
                parameters.Add(new Parameter(p));
        }
        public override string ToString()
        {
            string ans = " ";
            if (visibility == VisibilityType.Public)
                ans += "+ ";
            if (visibility == VisibilityType.Private)
                ans += "- ";
            if (visibility == VisibilityType.Protected)
                ans += "# ";

            ans += name + "()";
            ans += " ";
            return ans;
        }
    }

    [Serializable()]
    public class Class
    {
        public string documentation { get; set; }
        public string name { get; set; }
        public List<Atribute> atributes { get; set; }
        public List<Method> methods { get; set; }
        public Class()
        {
            name = "";
            atributes = new List<Atribute>();
            methods = new List<Method>();
            documentation = "";
        }
        public Class(Class @class)
        {
            this.name = @class.name;

            atributes = new List<Atribute>();
            foreach (Atribute a in @class.atributes)
                atributes.Add(new Atribute(a));

            methods = new List<Method>();
            foreach (Method m in @class.methods)
                methods.Add(new Method(m));

            this.documentation = @class.documentation;
        }
        public override string ToString()
        {
            return name;
        }
    }

    [Serializable()]
    public class Object
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Rectangle Area()
        {
            return new Rectangle(x, y, width, height);
        }
        public Object()
        {

        }
        public virtual void Draw(Graphics g, Color workspace_color, Color font_color, Color back_color, int df_x, int df_y)
        {

        }
        public virtual void Shape(Graphics g)
        {

        }
    }
    [Serializable()]
    public class Relationship : Object
    {
        public RelationshipType relationship { get; set; }
        public Instance class1 { get; set; }
        public MultiplicityType class1Multiplicity { get; set; }
        public Instance class2 { get; set; }
        public MultiplicityType class2Multiplicity { get; set; }

        public Relationship()
        {
            class1Multiplicity = class2Multiplicity = MultiplicityType.None;
        }
        public Relationship(RelationshipType relationship)
        {
            this.relationship = relationship;
            class1Multiplicity = class2Multiplicity = MultiplicityType.None;
        }
        public override void Draw(Graphics g, Color workspace_color, Color font_color, Color back_color, int df_x, int df_y)
        {
            int thick = 1;

            Point p1 = new Point(class1.x + class1.width / 2, class1.y + class1.height / 2);
            Point p2 = new Point(class2.x + class2.width / 2, class2.y + class2.height / 2);

            if (p1.X != p2.X || p1.Y != p2.Y)
            {
                Pen pen = new Pen(Color.Black, thick);
                if (relationship != RelationshipType.Dependency)
                    g.DrawLine(pen, p1.X - df_x, p1.Y - df_y, p2.X - df_x, p2.Y - df_y);
                else
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    pen.DashPattern = new float[] { 9, 9 };
                    g.DrawLine(pen, p1.X - df_x, p1.Y - df_y, p2.X - df_x, p2.Y - df_y);
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

                }

                double width = p1.X - p2.X;
                double height = p1.Y - p2.Y;

                double alfa = Math.Atan(width / height);
                int L = 25; double l = 0.50; double a = 0.0174533 * 30;
                Point A = new Point(0, 0);
                Point B = new Point(0, 0);
                Point C = new Point(0, 0);
                Point D = new Point(0, 0);

                A.X = (int)(p2.X - (class2.height / 2) * Math.Tan(alfa));
                A.Y = (int)(p2.Y - (class2.height / 2));

                B.X = (int)(A.X - L * Math.Sin(alfa));
                B.Y = (int)(A.Y - L * Math.Cos(alfa));

                C.X = (int)(A.X - (L * l) * Math.Sin(alfa - a));
                C.Y = (int)(A.Y - (L * l) * Math.Cos(alfa - a));

                D.X = (int)(A.X - (L * l) * Math.Sin(alfa + a));
                D.Y = (int)(A.Y - (L * l) * Math.Cos(alfa + a));

                if (p2.Y < p1.Y)
                {
                    A.X = (int)(p2.X + (class2.height / 2) * Math.Tan(alfa));
                    A.Y = (int)(p2.Y + (class2.height / 2));

                    B.X = (int)(A.X + L * Math.Sin(alfa));
                    B.Y = (int)(A.Y + L * Math.Cos(alfa));

                    C.X = (int)(A.X + (L * l) * Math.Sin(alfa - a));
                    C.Y = (int)(A.Y + (L * l) * Math.Cos(alfa - a));

                    D.X = (int)(A.X + (L * l) * Math.Sin(alfa + a));
                    D.Y = (int)(A.Y + (L * l) * Math.Cos(alfa + a));
                }
                if (!(A.X >= p2.X - class2.width / 2 && A.X <= p2.X + class2.width / 2))
                {
                    alfa = Math.Atan(height / width);

                    A.X = (int)(p2.X - (class2.width / 2));
                    A.Y = (int)(p2.Y - (class2.width / 2) * Math.Tan(alfa));

                    B.X = (int)(A.X - L * Math.Cos(alfa));
                    B.Y = (int)(A.Y - L * Math.Sin(alfa));

                    C.X = (int)(A.X - (L * l) * Math.Cos(alfa - a));
                    C.Y = (int)(A.Y - (L * l) * Math.Sin(alfa - a));

                    D.X = (int)(A.X - (L * l) * Math.Cos(alfa + a));
                    D.Y = (int)(A.Y - (L * l) * Math.Sin(alfa + a));

                    if (p2.X < p1.X)
                    {
                        A.X = (int)(p2.X + (class2.width / 2));
                        A.Y = (int)(p2.Y + (class2.width / 2) * Math.Tan(alfa));

                        B.X = (int)(A.X + L * Math.Cos(alfa));
                        B.Y = (int)(A.Y + L * Math.Sin(alfa));

                        C.X = (int)(A.X + (L * l) * Math.Cos(alfa - a));
                        C.Y = (int)(A.Y + (L * l) * Math.Sin(alfa - a));

                        D.X = (int)(A.X + (L * l) * Math.Cos(alfa + a));
                        D.Y = (int)(A.Y + (L * l) * Math.Sin(alfa + a));
                    }
                }

                A.X -= df_x; B.X -= df_x; C.X -= df_x; D.X -= df_x;
                A.Y -= df_y; B.Y -= df_y; C.Y -= df_y; D.Y -= df_y;


                if (relationship == RelationshipType.Association)
                {

                }
                else if (relationship == RelationshipType.Dependency)
                {
                    g.DrawLine(pen, C, A);
                    g.DrawLine(pen, D, A);
                }
                else if (relationship == RelationshipType.Aggregation)
                {
                    g.FillPolygon(Brushes.White, new Point[] { A, C, B, D });
                    g.DrawPolygon(pen, new Point[] { A, C, B, D });
                }
                else if (relationship == RelationshipType.Composition)
                {
                    g.FillPolygon(Brushes.Black, new Point[] { A, C, B, D });
                }
                else if (relationship == RelationshipType.Inheritance)
                {
                    g.FillPolygon(Brushes.White, new Point[] { A, C, D });
                    g.DrawPolygon(pen, new Point[] { A, C, D });
                }


                string multi = "";
                if (class1Multiplicity == MultiplicityType.NoInstance) multi = "0";
                if (class1Multiplicity == MultiplicityType.NoInstanceOrOneInstance) multi = "0..1";
                if (class1Multiplicity == MultiplicityType.ExactlyOneInstance) multi = "1";
                if (class1Multiplicity == MultiplicityType.ZeroOrMoreInstance) multi = "0..*";
                if (class1Multiplicity == MultiplicityType.OneOrMoreInstance) multi = "1..*";

                Font font = new Font("Consolas", 10);
                g.DrawString(multi, font, Brushes.Black, B);






                p2 = new Point(class1.x + class1.width / 2, class1.y + class1.height / 2);
                p1 = new Point(class2.x + class2.width / 2, class2.y + class2.height / 2);

                width = p1.X - p2.X;
                height = p1.Y - p2.Y;

                alfa = Math.Atan(width / height);
                L = 25; l = 0.50; a = 0.0174533 * 30;
                A = new Point(0, 0);
                B = new Point(0, 0);

                A.X = (int)(p2.X - (class1.height / 2) * Math.Tan(alfa));
                A.Y = (int)(p2.Y - (class1.height / 2));

                B.X = (int)(A.X - L * Math.Sin(alfa));
                B.Y = (int)(A.Y - L * Math.Cos(alfa));

                if (p2.Y < p1.Y)
                {
                    A.X = (int)(p2.X + (class1.height / 2) * Math.Tan(alfa));
                    A.Y = (int)(p2.Y + (class1.height / 2));

                    B.X = (int)(A.X + L * Math.Sin(alfa));
                    B.Y = (int)(A.Y + L * Math.Cos(alfa));
                }
                if (!(A.X >= p2.X - class1.width / 2 && A.X <= p2.X + class1.width / 2))
                {
                    alfa = Math.Atan(height / width);

                    A.X = (int)(p2.X - (class1.width / 2));
                    A.Y = (int)(p2.Y - (class1.width / 2) * Math.Tan(alfa));

                    B.X = (int)(A.X - L * Math.Cos(alfa));
                    B.Y = (int)(A.Y - L * Math.Sin(alfa));

                    if (p2.X < p1.X)
                    {
                        A.X = (int)(p2.X + (class1.width / 2));
                        A.Y = (int)(p2.Y + (class1.width / 2) * Math.Tan(alfa));

                        B.X = (int)(A.X + L * Math.Cos(alfa));
                        B.Y = (int)(A.Y + L * Math.Sin(alfa));
                    }
                }
                multi = "";
                if (class2Multiplicity == MultiplicityType.NoInstance) multi = "0";
                if (class2Multiplicity == MultiplicityType.NoInstanceOrOneInstance) multi = "0..1";
                if (class2Multiplicity == MultiplicityType.ExactlyOneInstance) multi = "1";
                if (class2Multiplicity == MultiplicityType.ZeroOrMoreInstance) multi = "0..*";
                if (class2Multiplicity == MultiplicityType.OneOrMoreInstance) multi = "1..*";

                g.DrawString(multi, font, Brushes.Black, B.X - df_x, B.Y - df_y);
            }
        }
        public override void Shape(Graphics g)
        {
            Point p1 = new Point(class1.x + class1.width / 2, class1.y + class1.height / 2);
            Point p2 = new Point(class2.x + class2.width / 2, class2.y + class2.height / 2);

            Pen pen = new Pen(Color.Gray, 4);
            g.DrawLine(pen, p1, p2);
        }
    }
    [Serializable()]
    public class Instance : Object
    {
        public Class cls { get; set; }
        public Instance()
        {

        }
        public Instance(Class @class)
        {
            cls = @class;
        }
        public override void Draw(Graphics g, Color workspace_color, Color font_color, Color back_color, int df_x, int df_y)
        {
            //Title settings
            Point title_point = new Point(x - df_x, y - df_y);
            Font title_font = new Font("Consolas", 12, FontStyle.Bold);
            SizeF title_size = g.MeasureString("--" + cls.name + "--", title_font);
            Rectangle title_rectangle = new Rectangle(title_point, title_size.ToSize());

            StringFormat title_stringFormat = new StringFormat();
            title_stringFormat.Alignment = StringAlignment.Center;
            title_stringFormat.LineAlignment = StringAlignment.Center;

            //Attributes setting
            string attributes = "";
            foreach (Atribute a in cls.atributes)
                attributes += a.ToString() + "\n";

            string attributes_T = "";
            foreach (Atribute a in cls.atributes)
                attributes_T += a.ToString() + "-\n";
            if (attributes_T.Length != 0)
                attributes_T = attributes_T.Substring(0, attributes_T.Length - 1);
            else
                attributes_T = "-";
            Point attributes_point = new Point(title_point.X, title_point.Y + (int)title_size.Height);
            Font attributes_font = new Font("Consolas", 10);
            SizeF attributes_size = g.MeasureString(attributes_T, attributes_font);
            Rectangle attributes_rectangle = new Rectangle(attributes_point, attributes_size.ToSize());

            //Methods setting
            string methods = "";
            foreach (Method a in this.cls.methods)
                methods += a.ToString() + "\n";

            string methods_T = "";
            foreach (Method a in this.cls.methods)
                methods_T += a.ToString() + "-\n";
            if (methods_T.Length != 0)
                methods_T = methods_T.Substring(0, methods_T.Length - 1);
            else
                methods_T = "-";

            Point methods_point = new Point(attributes_point.X, attributes_point.Y + (int)attributes_size.Height);
            Font methods_font = new Font("Consolas", 10);
            SizeF methods_size = g.MeasureString(methods_T, methods_font);
            Rectangle methods_rectangle = new Rectangle(methods_point, methods_size.ToSize());


            width = Math.Max(title_rectangle.Width, Math.Max(attributes_rectangle.Width, methods_rectangle.Width));

            title_rectangle.Width = width;
            attributes_rectangle.Width = width;
            methods_rectangle.Width = width;

            height = (int)(title_rectangle.Height + attributes_rectangle.Height + methods_rectangle.Height);
            Rectangle area = Area();
            area.X -= df_x;
            area.Y -= df_y;
            g.FillRectangle(new SolidBrush(back_color), area);

            Pen pen = new Pen(Color.Black, 2);

            g.DrawString(cls.name, title_font, new SolidBrush(font_color), title_rectangle, title_stringFormat);
            g.DrawRectangle(pen, title_rectangle);

            g.DrawString(attributes, attributes_font, new SolidBrush(font_color), attributes_point);
            g.DrawRectangle(pen, attributes_rectangle);

            g.DrawString(methods, methods_font, new SolidBrush(font_color), methods_point);
            g.DrawRectangle(pen, methods_rectangle);
        }
        public override void Shape(Graphics g)
        {
            int border = 2;

            Rectangle rectangle = Area();
            rectangle.X -= border;
            rectangle.Y -= border;
            rectangle.Width += 2 * border;
            rectangle.Height += 2 * border;

            g.FillRectangle(Brushes.Gray, rectangle);
        }

    }
    [Serializable()]
    public class Text : Object
    {
        public string text { get; set; }
        public Text()
        {

        }
        public Text(string text)
        {
            this.text = text;
        }
        public override void Draw(Graphics g, Color workspace_color, Color font_color, Color back_color, int df_x, int df_y)
        {
            //Title settings
            Point title_point = new Point(x - df_x, y - df_y);
            Font title_font = new Font("Consolas", 10);
            SizeF title_size = g.MeasureString(text, title_font);
            Rectangle title_rectangle = new Rectangle(title_point, title_size.ToSize());

            width = title_rectangle.Width += 20;
            height = title_rectangle.Height;

            StringFormat title_stringFormat = new StringFormat();
            title_stringFormat.Alignment = StringAlignment.Center;
            title_stringFormat.LineAlignment = StringAlignment.Center;

            g.DrawString(text, title_font, new SolidBrush(font_color), title_rectangle, title_stringFormat);
        }
        public override void Shape(Graphics g)
        {
            int border = 2;

            Rectangle rectangle = Area();
            rectangle.X -= border;
            rectangle.Y -= border;
            rectangle.Width += 2 * border;
            rectangle.Height += 2 * border;

            g.FillRectangle(Brushes.Gray, rectangle);
        }
    }

    [Serializable()]
    public class Diagram
    {

        public Color workspace_color { get; set; }
        public Color font_color { get; set; }
        public Color back_color { get; set; }


        public List<Class> classes { get; set; }
        public List<Object> objects { get; set; }

        public Object selection { get; set; }

        public Diagram()
        {
            classes = new List<Class>();
            objects = new List<Object>();
            selection = null;
            workspace_color = Color.White;
            font_color = Color.Black;
            back_color = Color.FromArgb(255, 255, 204);
        }
        public void Draw(Graphics g, int df_x, int df_y)
        {
            List<Object> relationships = objects.FindAll(x => x is Relationship);

            if (df_x == 0 && df_y == 0)
                foreach (Object I in relationships)
                    if (selection == I)
                        I.Shape(g);

            foreach (Relationship R in relationships.FindAll(x => (x as Relationship).relationship == RelationshipType.Association))
                R.Draw(g, workspace_color, font_color, back_color, df_x, df_y);
            foreach (Relationship R in relationships.FindAll(x => (x as Relationship).relationship == RelationshipType.Dependency))
                R.Draw(g, workspace_color, font_color, back_color, df_x, df_y);
            foreach (Relationship R in relationships.FindAll(x => (x as Relationship).relationship == RelationshipType.Aggregation))
                R.Draw(g, workspace_color, font_color, back_color, df_x, df_y);
            foreach (Relationship R in relationships.FindAll(x => (x as Relationship).relationship == RelationshipType.Composition))
                R.Draw(g, workspace_color, font_color, back_color, df_x, df_y);
            foreach (Relationship R in relationships.FindAll(x => (x as Relationship).relationship == RelationshipType.Inheritance))
                R.Draw(g, workspace_color, font_color, back_color, df_x, df_y);

            foreach (Object I in objects.FindAll(x => !(x is Relationship)))
            {
                if (df_x == 0 && df_y == 0)
                    if (selection == I)
                        I.Shape(g);

                I.Draw(g, workspace_color, font_color, back_color, df_x, df_y);
            }

            int width = 64;
            int height = 64;
            Image img = Properties.Resources.logo_y_nombre;
            g.DrawImage(img, g.VisibleClipBounds.Width - width, g.VisibleClipBounds.Height - height, width, height);

            if (df_x != 0 || df_y != 0)
            {
                StringFormat title_stringFormat = new StringFormat();
                title_stringFormat.Alignment = StringAlignment.Center;
                title_stringFormat.LineAlignment = StringAlignment.Center;
                g.DrawString("Created with 'Codegram'\nby Coding Academy Perú", new Font("Consolas", 10, FontStyle.Bold), new SolidBrush(Color.FromArgb(104, 33, 122)), new Rectangle(0, (int)g.VisibleClipBounds.Height - 64, (int)g.VisibleClipBounds.Width - 64, 64), title_stringFormat);
            }
        }
        public Object Selection(int x, int y)
        {
            Rectangle click = new Rectangle(x - 2, y - 2, 5, 5);

            Object @object = this.objects.FindLast(o => !(o is Relationship) && o.Area().IntersectsWith(click));
            if (@object != null)
                return @object;

            List<Object> objects = this.objects.FindAll(o => o is Relationship);
            foreach(Object R in objects)
            {
                Relationship relationship = R as Relationship;
                Point p1 = new Point(relationship.class1.x + relationship.class1.width / 2, relationship.class1.y + relationship.class1.height / 2);
                Point p2 = new Point(relationship.class2.x + relationship.class2.width / 2, relationship.class2.y + relationship.class2.height / 2);
                if (LineIntersectsRect(p1, p2, click))
                    return R;
            }
            return null;
        }
        public Relationship GetRelationshipSelected(int x, int y, out int num)
        {
            int radius = 25;
            Rectangle click = new Rectangle(x - 2, y - 2, 5, 5);
            List<Object> objects = this.objects.FindAll(O => O is Relationship);
            foreach (Relationship R in objects)
            {
                Point A = RelationshipPoint(R.class1, R.class2);
                Rectangle A1 = new Rectangle(A.X - radius, A.Y - radius, 2 * radius + 1, 2 * radius + 1);
                if (A1.IntersectsWith(click))
                {
                    num = 1;
                    return R;
                }
                    
                Point B = RelationshipPoint(R.class2, R.class1);
                Rectangle B1 = new Rectangle(B.X - radius, B.Y - radius, 2 * radius + 1, 2 * radius + 1);
                if (B1.IntersectsWith(click))
                {
                    num = 2;
                    return R;
                }
            }
            num = 0;
            return null;
        }
        public int Width()
        {
            int max = int.MinValue;
            foreach (Object o in objects.FindAll(x => !(x is Relationship)))
                if (max < o.x + o.width)
                    max = o.x + o.width;
            return max;
        }
        public int Height()
        {
            int max = int.MinValue;
            foreach (Object o in objects.FindAll(x => !(x is Relationship)))
                if (max < o.y + o.height)
                    max = o.y + o.height;
            return max;
        }

        private Point RelationshipPoint(Instance class1, Instance class2)
        {
            Point p1 = new Point(class1.x + class1.width / 2, class1.y + class1.height / 2);
            Point p2 = new Point(class2.x + class2.width / 2, class2.y + class2.height / 2);

            double width = p1.X - p2.X;
            double height = p1.Y - p2.Y;

            double alfa = Math.Atan(width / height);
            Point A = new Point(0, 0);

            A.X = (int)(p2.X - (class2.height / 2) * Math.Tan(alfa));
            A.Y = (int)(p2.Y - (class2.height / 2));

            if (p2.Y < p1.Y)
            {
                A.X = (int)(p2.X + (class2.height / 2) * Math.Tan(alfa));
                A.Y = (int)(p2.Y + (class2.height / 2));
            }
            if (!(A.X >= p2.X - class2.width / 2 && A.X <= p2.X + class2.width / 2))
            {
                alfa = Math.Atan(height / width);

                A.X = (int)(p2.X - (class2.width / 2));
                A.Y = (int)(p2.Y - (class2.width / 2) * Math.Tan(alfa));

                if (p2.X < p1.X)
                {
                    A.X = (int)(p2.X + (class2.width / 2));
                    A.Y = (int)(p2.Y + (class2.width / 2) * Math.Tan(alfa));
                }
            }

            return A;
        }
        private bool LineIntersectsRect(Point p1, Point p2, Rectangle r)
        {
            return LineIntersectsLine(p1, p2, new Point(r.X, r.Y), new Point(r.X + r.Width, r.Y)) ||
                   LineIntersectsLine(p1, p2, new Point(r.X + r.Width, r.Y), new Point(r.X + r.Width, r.Y + r.Height)) ||
                   LineIntersectsLine(p1, p2, new Point(r.X + r.Width, r.Y + r.Height), new Point(r.X, r.Y + r.Height)) ||
                   LineIntersectsLine(p1, p2, new Point(r.X, r.Y + r.Height), new Point(r.X, r.Y)) ||
                   (r.Contains(p1) && r.Contains(p2));
        }
        private bool LineIntersectsLine(Point l1p1, Point l1p2, Point l2p1, Point l2p2)
        {
            float q = (l1p1.Y - l2p1.Y) * (l2p2.X - l2p1.X) - (l1p1.X - l2p1.X) * (l2p2.Y - l2p1.Y);
            float d = (l1p2.X - l1p1.X) * (l2p2.Y - l2p1.Y) - (l1p2.Y - l1p1.Y) * (l2p2.X - l2p1.X);

            if (d == 0)
            {
                return false;
            }

            float r = q / d;

            q = (l1p1.Y - l2p1.Y) * (l1p2.X - l1p1.X) - (l1p1.X - l2p1.X) * (l1p2.Y - l1p1.Y);
            float s = q / d;

            if (r < 0 || r > 1 || s < 0 || s > 1)
            {
                return false;
            }

            return true;
        }
    }
}