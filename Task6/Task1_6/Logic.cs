using System;
using System.Collections.Generic;

namespace Task1_6
{
    public class Logic
    {
        private readonly IUserInteractor _userInteractor;

        public Logic(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public void Run()
        {
            var displayTypes = new List<DisplayType>();
            _userInteractor.PrintDisplayTypes(displayTypes);

            while (true)
            {
                _userInteractor.PrintOptions();
                var enteredStr = _userInteractor.ReadDisplayType();
                if (!TryReadType(enteredStr, out DisplayType type) || type == DisplayType.None)
                {
                    return;
                }

                if (!displayTypes.Remove(type))
                {
                    displayTypes.Add(type);
                }

                _userInteractor.PrintDisplayTypes(displayTypes);
            }
        }

        public bool TryReadType(string enteredStr, out DisplayType type)
        {
            type = DisplayType.None;


            if (!Enum.TryParse(enteredStr, out type))
            {
                return false;
            }

            if (!Enum.IsDefined(type))
            {
                return false;
            }

            return true;
        }
    }
}
