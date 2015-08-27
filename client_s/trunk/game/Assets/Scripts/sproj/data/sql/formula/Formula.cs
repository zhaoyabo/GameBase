﻿/// <summary>
/// 公式类
/// @author MXL
/// @date 2015-07
/// </summary>
namespace Formula
{

    public sealed class Formula
    {


        // ---------------------------------------- 人物裸体属性计算----------------------------------------------

        /**
         * 裸体物理强度 =  初始物理强度 + 等级 * 物理强度成长 
         * 
         * 裸体法术强度 = 初始法术强度 + 等级 * 法术强度成长
         * 
         * 裸体法术防御 = 初始法术防御 + 等级 * 法术防御成长
         * 
         * 裸体物理防御 = 初始物理防御 + 等级 * 物理防御成长
         * 
         * 裸体法术防御 = 初始法术防御 + 等级 * 法术防御成长
         * 
         * 裸体蓝量     = 初始蓝量 + 等级 * 蓝量成长
         * **/
        public static int getNakedAttribute(int strength, float growth, int level)
        {
            return strength + ((int)(level * growth));
        }


        // ---------------------------------------- 人物裸体属性计算----------------------------------------------

    }

}

