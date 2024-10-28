namespace ACCR

{
    public interface IContainer
    {
        public void SetAspect(string key, IAspect aspect);
        public IAspect GetAspect(string key);
        public IAspect[] GetAllAspects();
    }
}
